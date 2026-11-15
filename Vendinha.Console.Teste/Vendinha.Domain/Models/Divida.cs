using System.ComponentModel.DataAnnotations;

namespace Vendinha.Domain.Models
{
    public class Divida
    {
        public int id { get; set; }

        [Required(ErrorMessage = "O preenchimento do valor da dívida é obrigatório.")]
        [Range(1, double.MaxValue, ErrorMessage = "O valor da dívida deve ser maior que zero.")]
        public double Valor { get; set; }

        private bool pago;
        public bool Pago
        {
            get { return pago; }
            private set
            {
                if (value)
                {
                    DataPagamento = DateTime.UtcNow;
                }

                this.pago = value;
            }
        }

        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        public DateTime? DataPagamento { get; private set; }

        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = "É obrigatório informar um CPF cadastrado para vincular à dívida.")]
        public string ClienteCPF { get; set; }


        public void Pagar()
        {
            if (!Pago)
            {
                Pago = true;
            }
        }
        public void PrintarDetalhes()
        {
            Console.WriteLine($"Valor: {Valor}");
            Console.WriteLine($"Pago: {Pago}");
            Console.WriteLine($"Data de Criação: {DataCriacao}");
            Console.WriteLine($"Data de Pagamento: {DataPagamento}");
            Console.WriteLine($"CPF do Cliente: {Cliente.CPF}");
        }
    }
}
