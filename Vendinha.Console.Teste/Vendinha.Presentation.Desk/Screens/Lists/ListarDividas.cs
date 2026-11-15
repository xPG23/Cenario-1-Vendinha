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
    public partial class ListarDividas : Form
    {
        private readonly ClienteService _cService;
        private readonly DividasService _dService;

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

        private ResultadoPaginado<Divida> BuscaAtual = new();

        public ListarDividas(ClienteService cService, DividasService dService)
        {
            InitializeComponent();
            _cService = cService;
            _dService = dService;


            CarregarDadosTabela();
            AtualizarCadastroClientes();
        }

        public void AtualizarCadastroClientes()
        {
            qtdClientes.Text = "Dívidas abertas: " + _dService.QuantidadeClientesDevedores().ToString();
        }

        public int IdDividaSelecionada(out bool check)
        {
            try
            {
                var clienteSelecionado = Convert.ToInt32(ClienteDataGrid.SelectedRows[0].Cells["ID"].Value);

                check = true;
                return clienteSelecionado;
            }
            catch (Exception)
            {
                check = false;
                MessageBox.Show(
                    "Selecione uma dívida em aberto para continuar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            return -1;
        }



        private void SetarListaClientesSource()
        {
            if (string.IsNullOrEmpty(caixaBusca.Text))
            {
                BuscaAtual = _dService.ListarClientesDevedoresPaginada(paginaAtual, QtdPorPagina);
            }
            else
            {
                BuscaAtual = _dService.ListarDividasPorCPF(caixaBusca.Text);
            }

            AtualizarPaginacao();
        }

        private void AtualizarPaginacao()
        {

            labelPagFinal.Text = BuscaAtual.QuantidadePorPagina.ToString();
            labelPagInicial.Text = PaginaAtual.ToString();

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

            labelTotalDividas.Text = "Total em dívidas: R$ " + _dService.TotalEmDividas().ToString("F2");

            ClienteDataGrid.Rows.Clear();

            foreach (var dividas in BuscaAtual.Dados)
            {
                ClienteDataGrid.Rows.Add(
                    dividas.id,
                    dividas.Cliente.Nome,
                    dividas.ClienteCPF,
                    dividas.Valor,
                    dividas.DataCriacao
                );
            }
        }

        private void caixaBusca_TextChanged(object sender, EventArgs e)
        {
            PaginaAtual = 1;
            CarregarDadosTabela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var criarDivida = new CadastrarDivida(_dService, _cService, this);
            criarDivida.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var divida = _dService.PegarDividaPorId(IdDividaSelecionada(out bool check));

            if (!check)
                return;

            var alert1 = MessageBox.Show(
                $"Tem certeza de que deseja excluir a dívida do cliente {divida.Cliente.Nome}?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (alert1 == DialogResult.Yes)
            {
                _dService.ApagarDivida(_dService.PegarDividaPorId(IdDividaSelecionada(out bool c)));

                CarregarDadosTabela();
                AtualizarCadastroClientes();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var divida = _dService.PegarDividaPorId(IdDividaSelecionada(out bool check));

            if (!check)
                return;


            var telaAtualiza = new AtualizarDivida(divida, this, _dService);
            telaAtualiza.ShowDialog(this);
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

        private void button4_Click(object sender, EventArgs e)
        {
            var divida = _dService.PegarDividaPorId(IdDividaSelecionada(out bool check));

            if (!check)
                return;


            divida.Pagar();

            _dService.AtualizarDivida(divida, out var erros);


            MessageBox.Show("A dívida foi marcada como paga com sucesso!", "Operação concluída");
            CarregarDadosTabela();
            AtualizarCadastroClientes();
        }

    
    }
}
