using Vendinha.Domain.Interfaces;
using Vendinha.Domain.Models;
using Vendinha.Infrastructure.Context.Mock;

namespace Vendinha.Infrastructure.Repository.Mockup
{
    public class DividaRepositoryMock : IDividaRepository
    {
        private readonly List<Divida> context;

        public DividaRepositoryMock()
        {
            context = MockDividas.Dividas;
        }
        public bool CadastrarDivida(Divida divida)
        {
            if (ExisteDividaPorId(divida.id))
            {
                return false;
            }

            context.Add(divida);

            return true;
        }

        public List<Divida> ListarDividas()
        {
            var dividas = context.ToList();
            return dividas;
        }
        public bool ExisteDividaPorId(int id)
        {
            var divida = context.FirstOrDefault(d => d.id == id);

            if (divida != null)
            {
                return true;
            }
            return false;
        }

        public bool AtualizarDivida(Divida divida)
        {
            if (DeletarDivida(divida))
            {
                context.Add(divida);
                return true;
            }
            return false;
        }

        public bool DeletarDivida(Divida divida)
        {
            if (ExisteDividaPorId(divida.id))
            {
                context.Remove(divida);
                return true;
            }

            return false;
        }

        public Divida DividaPorId(int id)
        {
            var divida = context.FirstOrDefault(d => d.id == id);
            return divida;
        }

        public List<Divida> ListarDevedores()
        {
            throw new NotImplementedException();
        }

        public List<Divida> DividaAbertaPorCPF(string cpf)
        {
            throw new NotImplementedException();
        }

        public Divida PegarDividaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
