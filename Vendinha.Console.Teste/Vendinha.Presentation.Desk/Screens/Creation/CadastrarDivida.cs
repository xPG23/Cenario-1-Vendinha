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
    public partial class CadastrarDivida : Form
    {
        private readonly ClienteService _cService;
        private readonly DividasService _dService;

        private ListarDividas _parent;
        private Cliente _cliente;


        public CadastrarDivida(DividasService dService, ClienteService cService, ListarDividas parent)
        {
            InitializeComponent();

            _dService = dService;
            _cService = cService;
            _parent = parent;
        }

        public CadastrarDivida(DividasService dService, ClienteService cService)
        {
            InitializeComponent();

            _dService = dService;
            _cService = cService;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            var valor = string.IsNullOrEmpty(textValor.Text) ? 0 : double.Parse(textValor.Text);

            var divida = new Divida()
            {
                Valor = valor,
                ClienteCPF = mdTextCPF.Text
            };

            if (!_dService.CadastrarDivida(divida, out var erros))
            {
                labelErros.Visible = true;
                labelErros.Text = ConstruirMensagemErros(erros);
            }
            else
            {

                var msg = MessageBox.Show("Divida cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK);

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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mdTextCPF_TextChanged(object sender, EventArgs e)
        {
            if (mdTextCPF.MaskCompleted)
            {
                var cliente = _cService.ConsultarClientePorCpf(mdTextCPF.Text);

                if (cliente is not null)
                {
                    _cliente = cliente;
                    ClienteDataGrid.Rows.Add(_cliente.Nome, _cliente.Idade, _cliente.CPF, _cliente.PossuiDividas() ? "Devendo" : "Em dia");
                }
            }
        }

       
    }
}
