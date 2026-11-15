using System.ComponentModel.DataAnnotations;
using Vendinha.Domain.Validators;

namespace Vendinha.Domain.Models
{
    public class Cliente
    {
        [Required(ErrorMessage = "O preenchimento do nome e sobrenome é obrigatório.")]
        [RegularExpression(@"^[\p{L}]+(?:[ '-][\p{L}]+)+$", ErrorMessage = "Informe um nome completo válido.")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O preenchimento do CPF é obrigatório.")]
        [Cpf(ErrorMessage = "O CPF informado é inválido.")]
        public string CPF { get; set; }


        private string? email;
        [EmailAddress(ErrorMessage = "Informe um endereço de e-mail válido.")]
        public string? Email
        {
            get { return email; }
            set
            {
                this.email = value?.ToLower().Trim();
            }
        }

        [Required]
        public DateTime? DataNascimento { get; set; }

        [Range(5, 110, ErrorMessage = "A idade deve estar entre 5 e 110 anos.")]
        public int Idade
        {
            get
            {
                var dataNascimento = DataNascimento ?? DateTime.MinValue;

                var hoje = DateTime.Today;
                var idade = hoje.Year - dataNascimento.Year;
                var hojeAnoNascimento = hoje.AddYears(-idade);
                if (DataNascimento > hojeAnoNascimento)
                {
                    idade--;
                }

                return idade;

            }
        }
        public DateTime DataInscricao { get; set; } = DateTime.UtcNow;
        public int TempoCliente
        {
            get
            {

                var hoje = DateTime.Today;
                var tempoCliente = hoje.Year - DataInscricao.Year;
                var diferenca = hoje.AddYears(-tempoCliente);
                if (DataInscricao > diferenca)
                {
                    tempoCliente--;
                }
                if (tempoCliente < 0)
                    tempoCliente = 0;

                return tempoCliente;

            }
        }
        public ICollection<Divida> Dividas { get; private set; } = new List<Divida>();


        public bool PossuiDividas()
        {
            var dividasPendentes = Dividas.Where(d => !d.Pago).ToList();

            if (dividasPendentes.Any())
                return true;

            return false;
        }

        public void PrintDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Data de Nascimento: {DataNascimento?.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Idade: {Idade}");
        }
    }
}
