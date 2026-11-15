using Microsoft.EntityFrameworkCore;
using Vendinha.Domain.Interfaces;
using Vendinha.Domain.Models;
using Vendinha.Infrastructure.Context;

namespace Vendinha.Infrastructure.Repository.PostgreSQL
{
    public class DividaRepository : IDividaRepository
    {
        private readonly VendinhaDbContext context;

        public DividaRepository(VendinhaDbContext context)
        {
            this.context = context;
        }

        public bool CadastrarDivida(Divida divida)
        {
            context.Dividas.Add(divida);
            context.SaveChanges();

            return true;
        }

        public Divida PegarDividaPorId(int id)
        {
            return context.Dividas.Find(id);
        }

        public bool ExisteDividaPorId(int id)
        {
            var divida = context.Dividas.Find(id);

            if (divida != null)
            {
                return true;
            }
            return false;
        }

        public List<Divida> ListarDividas()
        {
            var dividas = context.Dividas.Include(d => d.Cliente).ToList();
            return dividas;
        }

        public List<Divida> DividaAbertaPorCPF(string cpf)
        {
            var dividas = context.Clientes
                .Where(c => c.CPF.StartsWith(cpf))
                .SelectMany(c => c.Dividas)
                .Where(d => d.Pago == false)
                .ToList();

            return dividas;
        }

        public List<Divida> ListarDevedores()
        {
            var devedores = context.Dividas.Include(d => d.Cliente)
                .Where(d => d.Pago == false)
                .OrderByDescending(d => d.Valor)
                .ToList();

            return devedores;
        }

        public bool AtualizarDivida(Divida divida)
        {
            if (ExisteDividaPorId(divida.id))
            {
                context.Dividas.Update(divida);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeletarDivida(Divida divida)
        {
            if (ExisteDividaPorId(divida.id))
            {
                context.Dividas.Remove(divida);
                context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
