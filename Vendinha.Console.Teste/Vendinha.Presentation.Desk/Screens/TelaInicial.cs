using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Vendinha.Application.Services;

namespace Vendinha.Presentation.Desk.Screens
{
    public partial class TelaInicial : Form
    {

        private readonly ClienteService _cService;
        private readonly DividasService _dService;

        public TelaInicial(ClienteService cService, DividasService dService)
        {
            InitializeComponent();

            _cService = cService;
            _dService = dService;
        }

        private void ListaClientBtn_Click(object sender, EventArgs e)
        {
            var telaListaClientes = new ListaClientes(_cService);
            telaListaClientes.Show();
        }

        private void ListaDevedoresBtn_Click(object sender, EventArgs e)
        {
            var telaListaDividas = new ListarDividas(_cService, _dService);
            telaListaDividas.Show();
        }

        private void addClienteBtn_Click(object sender, EventArgs e)
        {
            var telaCadastro = new CadastrarCliente(_cService);
            telaCadastro.ShowDialog(this);
        }

        private void cadastrarDividaBtn_Click(object sender, EventArgs e)
        {
            var criarDivida = new CadastrarDivida(_dService, _cService);
            criarDivida.ShowDialog(this);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "VENDINHA CONTROL\n\n" +
               "Sistema de gerenciamento de clientes e dívidas.\n\n" +
               "Projeto desenvolvido como parte do cenário 1 proposto " +
               "para a avaliação P2.\n\n" +
               "INFORMAÇÕES DO ALUNO\n" +
               "Nome: Pedro Gabriel Aiello\n" +
               "RA: 2039564",
               "Sobre o sistema",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
            );
        }
    }
}
