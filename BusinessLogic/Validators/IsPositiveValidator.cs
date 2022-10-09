namespace BusinessLogic.Validators;

public class IsPositiveValidator : IMathValidator
{
    public (bool validated, string message) Validate(float? num1, float? num2)
    {
        if (num1 < 0) return (false, "number 1 is not positive");
        if (num2 < 0) return (false, "number 2 is not positive");
        return (true, "");
    }
}