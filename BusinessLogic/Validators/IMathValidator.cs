using ApiModels;

namespace BusinessLogic.Validators;

public interface IMathValidator
{
    (bool validated, string message) Validate(float? num1, float? num2);
}