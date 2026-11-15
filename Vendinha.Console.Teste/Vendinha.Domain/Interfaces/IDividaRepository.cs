using Vendinha.Domain.Models;

namespace Vendinha.Domain.Interfaces
{
    public interface IDividaRepository
    {
        bool CadastrarDivida(Divida divida);
        Divida PegarDividaPorId(int id);
        List<Divida> ListarDividas();
        List<Divida> ListarDevedores();
        List<Divida> DividaAbertaPorCPF(string cpf);
        bool ExisteDividaPorId(int id);
        bool AtualizarDivida(Divida divida);
        bool DeletarDivida(Divida divida);
    }
}
