using Vendinha.Domain.Interfaces;
using Vendinha.Domain.Models;
using Vendinha.Infrastructure.Context.Mock;

namespace Vendinha.Infrastructure.Repository.Mockup
{
    public class ClienteRepositoryMock : IClienteRepository
    {
        private readonly List<Cliente> context;

        public ClienteRepositoryMock()
        {
            context = MockClientes.Clientes;
        }
        public bool AtualizarCliente(Cliente cliente)
        {

            if (DeletarCliente(cliente.CPF))
            {
                context.Add(cliente);
                return true;
            }

            return true;
        }

        public bool CadastrarCliente(Cliente cliente)
        {


            if (ClienteExiste(cliente.CPF))
            {
                return false;
            }

            context.Add(cliente);

            return true;
        }

        public bool DeletarCliente(string cpf)
        {
            if (ClientePorCpf(cpf, out Cliente cliente))
            {
                context.Remove(cliente);
                return true;
            }

            return false;
        }

        public List<Cliente> ListarClientes()
        {
            var clientes = context.ToList();
            //var clientes = context.Clientes.Include(c => c.Dividas).ToList();

            return clientes;
        }
        public bool ClientePorCpf(string cpf, out Cliente cliente)
        {

            cliente = context.FirstOrDefault(c => c.CPF == cpf);


            if (cliente == null)
            {
                return false;
            }

            return true;
        }

        public bool ClienteExiste(string cpf)
        {

            var clienteExistente = context.FirstOrDefault(c => c.CPF == cpf);

            if (clienteExistente != null)
                return true;

            return false;

        }

        public List<Cliente> ClientePorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}