using System.ComponentModel.DataAnnotations;

namespace JobBoardApp.Models.Validation;

public class LegalEntityAttribute: ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        string[] PossibleValues = new string[] {"EOOD", "OOD", "ET", "AD"};
        if (PossibleValues.Contains(value))
        {
            return ValidationResult.Success;
        }
        else 
        {
            return new ValidationResult("Please enter a valid legal entity type.");
        }
    }
}