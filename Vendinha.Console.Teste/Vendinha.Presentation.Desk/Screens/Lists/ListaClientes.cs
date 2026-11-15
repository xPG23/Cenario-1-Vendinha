using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Vendinha.Application.DTOs;
using Vendinha.Application.Services;
using Vendinha.Domain.Models;

namespace Vendinha.Presentation.Desk.Screens
{
    public partial class ListaClientes : Form
    {
        private readonly ClienteService _service;

        public readonly int QtdPorPagina = 10;
        private int QuantidadePaginas => BuscaAtual.QuantidadePorPagina;

        public int paginaAtual = 1;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int PaginaAtual
        {
            get { return this.paginaAtual; }
            set
            {
                if (value < 1)
                {
                    this.paginaAtual = 1;
                }
                else if (value > QuantidadePaginas)
                {

                }
                else
                {
                    this.paginaAtual = value;
                }
            }
        }

        private ResultadoPaginado<Cliente> BuscaAtual = new();

        public ListaClientes(ClienteService cService)
        {
            InitializeComponent();
            _service = cService;


            CarregarDadosTabela();
            AtualizarCadastroClientes();
        }

        public string CpfClienteSelecionado(out bool check)
        {
            try
            {
                var clienteSelecionado = ClienteDataGrid.SelectedRows[0].Cells["CPF"].Value.ToString();

                check = true;
                return clienteSelecionado;
            }
            catch (Exception)
            {
                check = false;
                MessageBox.Show("Selecione um cliente para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return string.Empty;


        }

        private void SetarListaClientesSource()
        {
            if (string.IsNullOrEmpty(caixaBusca.Text))
            {
                BuscaAtual = _service.ListarClientesPaginados(PaginaAtual, QtdPorPagina);
            }
            else
            {
                BuscaAtual = _service.BuscaClienteNomeCpf(caixaBusca.Text, PaginaAtual, QtdPorPagina);
            }

            AtualizarPaginacao();
        }

        public void AtualizarCadastroClientes()
        {
            qtdClientes.Text = _service.QuantidadeClientesCadastrados().ToString() + " Clientes cadastrados";
        }

        private void AtualizarPaginacao()
        {

            labelPagInicial.Text = PaginaAtual.ToString();
            labelPagFinal.Text = BuscaAtual.QuantidadePorPagina.ToString();

            if (PaginaAtual == 1)
            {
                btn_VoltarPag.Enabled = false;
            }
            else
            {
                btn_VoltarPag.Enabled = true;
            }

            if (PaginaAtual == QuantidadePaginas)
            {
                btn_AvancarPag.Enabled = false;
            }
            else
            {
                btn_AvancarPag.Enabled = true;
            }


            if (QuantidadePaginas <= 1)
            {
                labelPagFinal.Visible = false;
                labelQtdPag.Visible = false;

                btn_AvancarPag.Visible = false;
                btn_VoltarPag.Visible = false;
                return;
            }
            else
            {
                labelPagFinal.Visible = true;
                labelQtdPag.Visible = true;

                btn_AvancarPag.Visible = true;
                btn_VoltarPag.Visible = true;
            }

            if (QuantidadePaginas < 2 || PaginaAtual == (QuantidadePaginas - 1))
            {
                labelQtdPag.Text = "-";
                return;
            }
            else
            {
                if (PaginaAtual == QuantidadePaginas)
                {
                    labelQtdPag.Text = "-";
                    return;
                }
                labelQtdPag.Text = "...";
            }
        }


        public void CarregarDadosTabela()
        {
            SetarListaClientesSource();

            ClienteDataGrid.Rows.Clear();

            foreach (var cliente in BuscaAtual.Dados)
            {
                ClienteDataGrid.Rows.Add(
                    cliente.Nome,
                    cliente.Idade,
                    cliente.CPF,
                    cliente.PossuiDividas() ? "Devendo" : "Em dia"
                );
            }

            for (int i = 0; i < ClienteDataGrid.Rows.Count; i++)
            {
                DataGridViewRow row = ClienteDataGrid.Rows[i];
                if (row.Cells[3].Value.ToString() == "Devendo")
                {
                    row.Cells[3].Style.ForeColor = Color.Red;
                }
                else
                {
                    row.Cells[3].Style.ForeColor = Color.Green;
                }
            }

        }

        private void btn_AvancarPag_Click(object sender, EventArgs e)
        {
            PaginaAtual++;
            CarregarDadosTabela();
        }

        private void btn_VoltarPag_Click(object sender, EventArgs e)
        {
            PaginaAtual--;
            CarregarDadosTabela();
        }

        private void labelPagFinal_Click(object sender, EventArgs e)
        {
            var pagFinal = QuantidadePaginas;

            paginaAtual = pagFinal;
            CarregarDadosTabela();
        }

        private void labelPagFinal_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                control.Cursor = Cursors.Hand;


            }
            labelPagFinal.ForeColor = Color.Blue;
            labelPagFinal.Font = new Font(labelPagFinal.Font, FontStyle.Underline);
        }

        private void labelPagFinal_MouseLeave(object sender, EventArgs e)
        {
            labelPagFinal.ForeColor = Color.Black;
            labelPagFinal.Font = new Font(labelPagFinal.Font, FontStyle.Regular);
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PaginaAtual = 1;
            CarregarDadosTabela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var telaCadastro = new CadastrarCliente(_service, this);
            telaCadastro.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cliente = _service.ConsultarClientePorCpf(CpfClienteSelecionado(out bool check));

            if (!check)
                return;

            var alert1 = MessageBox.Show(
                $"Tem certeza de que deseja excluir o cliente {cliente.Nome}?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (alert1 == DialogResult.Yes)
            {

                if (cliente.PossuiDividas())
                {
                    var alert2 = MessageBox.Show(
                        $"O cliente {cliente.Nome} possui dívidas pendentes. " +
                        "Ao excluí-lo, a dívida também será anulada. Deseja continuar?",
                        "Atenção: existem dívidas pendentes",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (alert2 == DialogResult.No)
                    {
                        return;
                    }
                }

                _service.ExcluirCliente(cliente.CPF);
                CarregarDadosTabela();
                AtualizarCadastroClientes();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cliente = _service.ConsultarClientePorCpf(CpfClienteSelecionado(out bool check));

            if (!check)
                return;

            var infoCliente = new ClienteInfo(cliente);
            infoCliente.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cliente = _service.ConsultarClientePorCpf(CpfClienteSelecionado(out bool check));

            if (!check)
                return;

            var telaAtualiza = new AtualizarCliente(_service, cliente, this);
            telaAtualiza.ShowDialog(this);
        }

        private void ClienteDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cliente = _service.ConsultarClientePorCpf(CpfClienteSelecionado(out bool check));

            if (!check)
                return;

            var infoCliente = new ClienteInfo(cliente);
            infoCliente.ShowDialog(this);
        }
    }
}
