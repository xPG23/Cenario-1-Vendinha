using System.ComponentModel.DataAnnotations;

namespace Vendinha.Domain.Validators
{
    public class CpfAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is not string cpf)
                return false;


            return ValidarCPF(cpf);
        }

        private bool ValidarCPF(string cpf)
        {

            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            cpf = cpf.Replace(".", "").Replace("-", "").Trim();

            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
                return false;

            if (cpf.Distinct().Count() == 1)
                return false;

            string baseCpf = cpf[..9];

            int primeiroDigito = CalculateDigit(baseCpf, 10);

            string cpfComPrimeiroDigito = baseCpf + primeiroDigito;

            int segundoDigito = CalculateDigit(cpfComPrimeiroDigito, 11);

            return cpf[9] - '0' == primeiroDigito &&
                   cpf[10] - '0' == segundoDigito;

        }

        private int CalculateDigit(string cpf, int peso)
        {
            int sum = 0;

            foreach (char digit in cpf)
            {
                sum += (digit - '0') * peso;
                peso--;
            }

            int remainder = sum % 11;

            return remainder < 2 ? 0 : 11 - remainder;
        }
    }
}
