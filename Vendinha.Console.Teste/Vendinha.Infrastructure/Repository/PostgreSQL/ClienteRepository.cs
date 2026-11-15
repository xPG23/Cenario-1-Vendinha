using Microsoft.EntityFrameworkCore;
using Vendinha.Domain.Interfaces;
using Vendinha.Domain.Models;
using Vendinha.Infrastructure.Context;

namespace Vendinha.Infrastructure.Repository.PostgreSQL
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly VendinhaDbContext context;

        public ClienteRepository(VendinhaDbContext context)
        {
            this.context = context;
        }

        public bool CadastrarCliente(Cliente cliente)
        {
            if (ClienteExiste(cliente.CPF))
            {
                return false;
            }

            context.Clientes.Add(cliente);
            context.SaveChanges();

            return true;
        }
        public bool ClienteExiste(string cpf)
        {
            var clienteExistente = context.Clientes.Find(cpf);

            if (clienteExistente != null)
                return true;

            return false;

        }

        public bool ClientePorCpf(string cpf, out Cliente cliente)
        {

            cliente = context.Clientes.Include(c => c.Dividas).FirstOrDefault(c => c.CPF == cpf);

            if (cliente == null)
            {
                return false;
            }

            return true;
        }

        public List<Cliente> ListarClientes()
        {
            var clientes = context.Clientes.Include(c => c.Dividas).ToList();

            return clientes;
        }

        public List<Cliente> ClientePorNome(string nome)
        {
            var clientes = context.Clientes
                .Where(c => c.Nome.ToLower().StartsWith(nome.ToLower()))
                .OrderBy(c => c.Nome)
                .Include(c => c.Dividas)
                .ToList();

            return clientes;
        }

        public bool AtualizarCliente(Cliente cliente)
        {
            if (!ClienteExiste(cliente.CPF))
            {
                return false;
            }

            context.Clientes.Update(cliente);
            context.SaveChanges();

            return true;
        }

        public bool DeletarCliente(string cpf)
        {
            if (ClientePorCpf(cpf, out Cliente cliente))
            {
                context.Clientes.Remove(cliente);
                context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
