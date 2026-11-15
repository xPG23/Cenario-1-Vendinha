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
    public partial class AtualizarDivida : Form
    {
        private readonly ClienteService _cService;
        private readonly DividasService _dService;
        private readonly Divida _divida;
        private ListarDividas _parent;

        public AtualizarDivida(Divida divida, ListarDividas parent, DividasService service)
        {
            InitializeComponent();
            _divida = divida;
            _parent = parent;
            _dService = service;

            ClienteInfo_Load();
        }

        private void ClienteInfo_Load()
        {



            if (_divida != null)
            {
                textNome.Text = _divida.Cliente.Nome;
                mdTextCPF.Text = _divida.ClienteCPF;
                textValorAntigo.Text = _divida.Valor.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var valor = string.IsNullOrEmpty(textValorNovo.Text) ? 0 : double.Parse(textValorNovo.Text);

            _divida.Valor = valor;

            if (!_dService.AtualizarDivida(_divida, out var erros))
            {
                labelErros.Visible = true;
                labelErros.Text = ConstruirMensagemErros(erros);
            }
            else
            {

                var msg = MessageBox.Show("Dívida atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK);

                _parent.CarregarDadosTabela();
                _parent.AtualizarCadastroClientes();

                this.Close();
            }
        }


        private string ConstruirMensagemErros(IEnumerable<ValidationResult> erros)
        {
            return string.Join(
                Environment.NewLine,
                erros.Select(e => "• " + e.ErrorMessage)
            );
        }

        private void textValorNovo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
