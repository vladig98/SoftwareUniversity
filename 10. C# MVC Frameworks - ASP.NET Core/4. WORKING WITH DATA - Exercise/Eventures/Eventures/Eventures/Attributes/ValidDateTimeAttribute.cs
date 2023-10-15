using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Eventures.Attributes
{
    public class ValidDateTimeAttribute : ValidationAttribute
    {
        public string GetErrorMessage() => "You need to provide a valid date in format \"dd-MMM-yyyy HH:mm\"";

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            bool isValid = DateTime.TryParseExact(value!.ToString(), "dd-MMM-yyyy HH:mm",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDate);

            if (!isValid)
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }
    }
}
