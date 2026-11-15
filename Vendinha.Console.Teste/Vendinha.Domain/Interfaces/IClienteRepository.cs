using Vendinha.Domain.Models;

namespace Vendinha.Domain.Interfaces
{
    public interface IClienteRepository
    {
        bool CadastrarCliente(Cliente cliente);
        List<Cliente> ListarClientes();
        List<Cliente> ClientePorNome(string nome);
        bool ClientePorCpf(string cpf, out Cliente cliente);
        bool ClienteExiste(string cpf);
        bool AtualizarCliente(Cliente cliente);
        bool DeletarCliente(string cpf);
    }
}
