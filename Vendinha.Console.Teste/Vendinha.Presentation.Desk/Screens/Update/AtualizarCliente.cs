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
    public partial class AtualizarCliente : Form
    {
        private readonly ClienteService _service;
        private ListaClientes _parent;
        private Cliente _cliente;
        public AtualizarCliente(ClienteService service, Cliente cliente, ListaClientes parent)
        {
            InitializeComponent();
            _service = service;
            _parent = parent;
            _cliente = cliente;

            ClienteInfo_Load();
        }

        private void ClienteInfo_Load()
        {
            var dataNascimento = DateTime.Parse(_cliente.DataNascimento.ToString());

            string[] partes = _cliente.Nome.Split(' ', 2);

            string nome = partes[0];
            string sobrenome = partes.Length > 1 ? partes[1] : "";

            if (_cliente != null)
            {
                textNome.Text = nome;
                textSobrenome.Text = sobrenome;
                mdTextCPF.Text = _cliente.CPF;
                textEmail.Text = string.IsNullOrEmpty(_cliente.Email) ? "[Vazio]" : _cliente.Email;
                pickerDataNascimento.Value = dataNascimento;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            var nomeCompleto = textNome.Text.Trim() + " " + textSobrenome.Text.Trim();


            _cliente.Nome = nomeCompleto;
            _cliente.DataNascimento = pickerDataNascimento.Value;
            _cliente.Email = string.IsNullOrWhiteSpace(textEmail.Text) || textEmail.Text == "[Vazio]" ? null : textEmail.Text;

      
            if (!_service.AtualizarCliente(_cliente, out var erros))
            {
                labelErros.Visible = true;
                labelErros.Text = ConstruirMensagemErros(erros);
            }
            else
            {

                var msg = MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK);

                _parent.CarregarDadosTabela();
                _parent.AtualizarCadastroClientes();



                this.Close();
            }
        }
    }
}
