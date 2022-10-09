using ApiModels;

namespace BusinessLogic.Validators;

public class NullValidator : IMathValidator
{
    public (bool validated, string message) Validate(float? num1, float? num2)
    {
        if (num1 == null)
            return (false, "first number is null");
        if (num2 == null)
            return (false, "second number is null");

        return (true, "");
    }
}