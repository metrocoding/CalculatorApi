namespace BusinessLogic.Validators;

public class DivideByZeroValidator : IMathValidator
{
    public (bool validated, string message) Validate(float? num1, float? num2)
    {
        if (num2 == 0) return (false, "can not divide a number by zero");
        return (true, "");
    }
}