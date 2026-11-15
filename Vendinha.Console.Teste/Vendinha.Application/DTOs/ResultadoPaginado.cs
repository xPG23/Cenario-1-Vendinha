namespace Vendinha.Application.DTOs
{
    public class ResultadoPaginado<T>
    {
        public List<T> Dados { get; set; }
        public int QuantidadePorPagina { get; set; }
    }
}
