using ApiModels;

namespace BusinessLogic.Validators;

public class NullValidator : IMathValidator
{
    public (bool validated, string message) Validate(CalculateDto calculateDto)
    {
        if (calculateDto == null)
            return (false, "numbers are not provided");
        if (calculateDto.Number1 == null)
            return (false, "first number is null");
        if (calculateDto.Number2 == null)
            return (false, "second number is null");

        return (true, "");
    }
}