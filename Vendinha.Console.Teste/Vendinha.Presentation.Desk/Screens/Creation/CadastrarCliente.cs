using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Vendinha.Application.Services;
using Vendinha.Domain.Models;

namespace Vendinha.Presentation.Desk.Screens
{
    public partial class CadastrarCliente : Form
    {
        private readonly ClienteService _service;
        private ListaClientes _parent;


        public CadastrarCliente(ClienteService service)
        {
            InitializeComponent();
            _service = service;
        }
        public CadastrarCliente(ClienteService service, ListaClientes parent)
        {
            InitializeComponent();
            _service = service;
            _parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nomeCompleto = textNome.Text.Trim() + " " + textSobrenome.Text.Trim();

            string? cpf = mdTextCpf.Text.Any(char.IsDigit) ? mdTextCpf.Text : null;

            var cliente = new Cliente()
            {
                Nome = nomeCompleto,
                CPF = cpf,
                DataNascimento = pickerData.Value,
                Email = string.IsNullOrWhiteSpace(textEmail.Text) ? null : textEmail.Text

            };

            if (!_service.CadastrarCliente(cliente, out var erros))
            {
                labelErros.Visible = true;
                labelErros.Text = ConstruirMensagemErros(erros);
            }
            else
            {

                var msg = MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK);

                if(_parent is not null)
                {
                    _parent.CarregarDadosTabela();
                    _parent.AtualizarCadastroClientes();
                }

               
                this.Close();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            labelErros.Visible = false;
            labelErros.Text = "";
        }

        private string ConstruirMensagemErros(IEnumerable<ValidationResult> erros)
        {
            return string.Join(
                Environment.NewLine,
                erros.Select(e => "• " + e.ErrorMessage)
            );
        }
    }
}
