using System.ComponentModel.DataAnnotations;

namespace JwtToken.Api.Validators
{
    public class StringEqualsAttribute : ValidationAttribute
    {
        private readonly string text;

        public StringEqualsAttribute(string text)
        {
            this.text = text;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var compareValue = value as string;

            if (string.IsNullOrEmpty(compareValue) || compareValue != text)
            {
                return new ValidationResult(GetErrorMessage(validationContext.MemberName, compareValue));
            }

            return ValidationResult.Success;
        }

        private string GetErrorMessage(string propertyName, string value)
        {
            return $"{propertyName} is not {value}.";
        }
    }
}
