using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Vendinha.Application.Services;
using Vendinha.Domain.Models;

namespace Vendinha.Presentation.Desk.Screens
{
    public partial class ClienteInfo : Form
    {
        private readonly Cliente _dadosCliente;
        public ClienteInfo(Cliente cliente)
        {
            InitializeComponent();
            _dadosCliente = cliente;

            ClienteInfo_Load();
            CarregarDadosTabela();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClienteInfo_Load()
        {
            var dataNascimento = DateTime.Parse(_dadosCliente.DataNascimento.ToString());

            if (_dadosCliente != null)
            {
                textNome.Text = _dadosCliente.Nome;
                mdTextCPF.Text = _dadosCliente.CPF;
                textEmail.Text = string.IsNullOrEmpty(_dadosCliente.Email) ? "[Vazio]" : _dadosCliente.Email;
                textIdade.Text = _dadosCliente.Idade.ToString();
                textStatus.Text = _dadosCliente.PossuiDividas() ? "Devendo" : "Em dia";
                textTempoCliente.Text = _dadosCliente.TempoCliente.ToString();
                mdDataCadastro.Text = _dadosCliente.DataInscricao.ToString("dd/MM/yyyy");
                mdTextDataNasc.Text = dataNascimento.ToString("dd/MM/yyyy");
            }
        }

        public void CarregarDadosTabela()
        {
         
            ClienteDataGrid.Rows.Clear();

            foreach (var divida in _dadosCliente.Dividas)
            {
                ClienteDataGrid.Rows.Add(
                    divida.Valor,
                    divida.Pago ? "Pago" : "Aberto",
                    divida.DataCriacao,
                    divida.DataPagamento.ToString()
                );
            }

            for (int i = 0; i < ClienteDataGrid.Rows.Count; i++)
            {
                DataGridViewRow row = ClienteDataGrid.Rows[i];
                if (row.Cells[1].Value.ToString() == "Aberto")
                {
                    row.Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    row.Cells[1].Style.ForeColor = Color.Green;
                }
            }

        }

    }
}
