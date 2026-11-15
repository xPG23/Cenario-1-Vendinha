using System.ComponentModel.DataAnnotations;
using Vendinha.Application.DTOs;
using Vendinha.Domain.Models;
using Vendinha.Domain.Validators;
using Vendinha.Infrastructure.Repository.PostgreSQL;

namespace Vendinha.Application.Services
{
    public class DividasService
    {

        private readonly ClienteRepository _clienteRepository;
        private readonly DividaRepository _dividaRepository;

        public DividasService(ClienteRepository clienteRepo, DividaRepository dividaRepo)
        {
            _clienteRepository = clienteRepo;
            _dividaRepository = dividaRepo;
        }

        public bool CadastrarDivida(Divida divida, out List<ValidationResult> errosValidados)
        {
            var valid = DataAObjectValidator.Validar(divida, out List<ValidationResult> erros);

            if (valid == false)
            {
                errosValidados = erros;
                return false;
            }

            _clienteRepository.ClientePorCpf(divida.ClienteCPF, out var cliente);

            if (cliente.PossuiDividas())
            {
                errosValidados = new List<ValidationResult>()
                {
                    new ValidationResult("O cliente informado já possui uma dívida em aberto.")
                };
                return false;
            }

            errosValidados = new List<ValidationResult>();
            return _dividaRepository.CadastrarDivida(divida);
        }

        public Divida PegarDividaPorId(int id)
        {
            var divida = _dividaRepository.PegarDividaPorId(id);
            return divida;
        }

        public ResultadoPaginado<Divida> ListarClientesDevedoresPaginada(int pagina, int quantidade)
        {
            var listaDividas = _dividaRepository.ListarDevedores();

            var listaPaginada = listaDividas
                .Skip((pagina - 1) * quantidade)
                .Take(quantidade)
                .ToList();

            return new ResultadoPaginado<Divida>()
            {
                Dados = listaPaginada,
                QuantidadePorPagina = QuantidadePaginasPorTamanho(listaDividas.Count, quantidade)
            };

        }

        public ResultadoPaginado<Divida> ListarDividasPorCPF(string cpf)
        {

            var dividas = _dividaRepository.DividaAbertaPorCPF(cpf);

            return new ResultadoPaginado<Divida>()
            {
                Dados = dividas,
                QuantidadePorPagina = QuantidadePaginasPorTamanho(dividas.Count, 10)
            };

        }

        public bool AtualizarDivida(Divida divida, out List<ValidationResult> errosValidados)
        {
            var valid = DataAObjectValidator.Validar(divida, out List<ValidationResult> erros);

            if (valid == false)
            {
                errosValidados = erros;
                return false;
            }

            errosValidados = new List<ValidationResult>();
            _dividaRepository.AtualizarDivida(divida);

            return true;
        }

        public bool ApagarDivida(Divida divida)
        {
            return _dividaRepository.DeletarDivida(divida);
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

        public int QuantidadeClientesDevedores()
        {
            var devedores = _dividaRepository.ListarDevedores();

            return devedores.Count;
        }

        public double TotalEmDividas()
        {
            var devedores = _dividaRepository.ListarDevedores();

            return devedores.Select(d => d.Valor)
                .DefaultIfEmpty(0)
                .Sum();
        }
    }
}
