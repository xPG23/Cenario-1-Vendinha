using System.ComponentModel.DataAnnotations;

namespace Vendinha.Domain.Validators
{
    public static class DataAObjectValidator
    {
        public static bool Validar(object obj,
            out List<ValidationResult> erros)
        {
            var context = new ValidationContext(obj);
            erros = new List<ValidationResult>();
            return Validator.TryValidateObject(obj, context, erros, true);
        }
    }
}
