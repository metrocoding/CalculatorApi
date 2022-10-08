using ApiModels;

namespace BusinessLogic.Validators;

public interface IMathValidator
{
    (bool validated, string message) Validate(CalculateDto calculateDto);
}