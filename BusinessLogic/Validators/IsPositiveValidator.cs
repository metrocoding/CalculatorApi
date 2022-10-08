using System;
using ApiModels;

namespace BusinessLogic.Validators;

public class IsPositiveValidator : IMathValidator
{
    public (bool validated, string message) Validate(CalculateDto calculateDto)
    {
        if (calculateDto.Number1<0)
            return (false, "number 1 is not positive");
        if (calculateDto.Number2<0)
            return (false, "number 2 is not positive");
        return (true, "");
    }
}