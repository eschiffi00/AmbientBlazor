using BusinessLogicLibrary.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLibrary.Validations
{
    public class Ratio_EnsurePriceIsGreaterThanInventoriesCost : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var ratio = validationContext.ObjectInstance as Ratio;
            if (ratio != null)
            {
            }

            return ValidationResult.Success;
        }



    }
}
