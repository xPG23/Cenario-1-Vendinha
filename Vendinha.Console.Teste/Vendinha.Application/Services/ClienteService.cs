using System.ComponentModel.DataAnnotations;
using Vendinha.Application.DTOs;
using Vendinha.Domain.Models;
using Vendinha.Domain.Validators;
using Vendinha.Infrastructure.Repository.PostgreSQL;

namespace Vendinha.Application.Services
{
    public class ClienteService
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteService(ClienteRepository clienteRepo)
        {

            _clienteRepository = clienteRepo;
        }

        public bool CadastrarCliente(Cliente cliente, out List<ValidationResult> errosValidados)
        {
            var valid = DataAObjectValidator.Validar(cliente, out List<ValidationResult> erros);

            if (valid == false)
            {
                errosValidados = erros;
                return false;
            }

            errosValidados = new List<ValidationResult>();
            return _clienteRepository.CadastrarCliente(cliente);
        }

        public Cliente ConsultarClientePorCpf(string cpf)
        {
            if (_clienteRepository.ClientePorCpf(cpf, out var cliente))
                return cliente;
            return null;
        }

        public ResultadoPaginado<Cliente> BuscaClienteNomeCpf(string busca, int pagina, int quantidade)
        {

            if (_clienteRepository.ClientePorCpf(busca, out var cliente))
            {
                var lista = new List<Cliente>() { cliente };


                return new ResultadoPaginado<Cliente>()
                {
                    Dados = lista,
                    QuantidadePorPagina = QuantidadePaginasPorTamanho(1, quantidade)
                };
            }

            var clientes = _clienteRepository.ClientePorNome(busca);

            var clientesPaginados = clientes.Skip((pagina - 1) * quantidade).Take(quantidade).ToList();

            return new ResultadoPaginado<Cliente>()
            {
                Dados = clientesPaginados,
                QuantidadePorPagina = QuantidadePaginasPorTamanho(clientes.Count, quantidade)
            };
        }

        public ResultadoPaginado<Cliente> ListarClientesPaginados(int pagina, int quantidade)
        {

            var listaClientes =
                _clienteRepository.ListarClientes()
                .OrderBy(c => c.Nome)
                .ToList();

            var listaPaginada =
                listaClientes.Skip((pagina - 1) * quantidade)
                .Take(quantidade)
                .ToList();


            return new ResultadoPaginado<Cliente>()
            {
                Dados = listaPaginada,
                QuantidadePorPagina = QuantidadePaginasPorTamanho(listaClientes.Count, quantidade)
            };

        }

        public bool AtualizarCliente(Cliente cliente, out List<ValidationResult> errosValidados)
        {
            var valid = DataAObjectValidator.Validar(cliente, out List<ValidationResult> erros);

            if (valid == false)
            {
                errosValidados = erros;
                return false;
            }

            errosValidados = new List<ValidationResult>();
            return _clienteRepository.AtualizarCliente(cliente);
        }

        public bool ExcluirCliente(string cpf)
        {
            return _clienteRepository.DeletarCliente(cpf);
        }

        //------------------------------------------------------------------

        private int QuantidadePaginasPorTamanho(int tamanho, int qtdPorLista)
        {

            if (qtdPorLista == 0)
            {
                return 0;
            }

            var qtd = (int)Math.Ceiling((double)tamanho / qtdPorLista);

            return qtd;
        }

        public int QuantidadeClientesCadastrados()
        {
            var clientes = _clienteRepository.ListarClientes();

            return clientes.Count;
        }
    }
}
