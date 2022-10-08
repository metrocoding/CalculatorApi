using System.Collections.Generic;
using ApiModels;
using BusinessLogic.Validators;
using BusinessLogicInterface;

namespace BusinessLogic;

public class SafeMathManager : ISafeMathManager
{
    public ServiceResult<float> GetAddition(CalculateDto calculateDto)
    {
        // validate
        var validators = new List<IMathValidator> { new NullValidator() };
        foreach (var validator in validators)
        {
            var (validated, message) = validator.Validate(calculateDto);
            if (!validated) return new ServiceResult<float> { Success = false, Message = message };
        }

        // result
        var addition = (float)(calculateDto.Number1 + calculateDto.Number2)!;
        return new ServiceResult<float> { Success = true, Result = addition };
    }

    public ServiceResult<float> GetSubtraction(CalculateDto calculateDto)
    {
        // validate
        var validators = new List<IMathValidator> { new NullValidator() };
        foreach (var validator in validators)
        {
            var (validated, message) = validator.Validate(calculateDto);
            if (!validated) return new ServiceResult<float> { Success = false, Message = message };
        }

        // result
        var subtraction = (float)(calculateDto.Number1 - calculateDto.Number2)!;
        return new ServiceResult<float> { Success = true, Result = subtraction };
    }

    public ServiceResult<float> GetMultiplication(CalculateDto calculateDto)
    {
        // validate
        var validators = new List<IMathValidator> { new NullValidator() };
        foreach (var validator in validators)
        {
            var (validated, message) = validator.Validate(calculateDto);
            if (!validated) return new ServiceResult<float> { Success = false, Message = message };
        }

        // result
        var multiplication = (float)(calculateDto.Number1 * calculateDto.Number2)!;
        return new ServiceResult<float> { Success = true, Result = multiplication };
    }

    public ServiceResult<float> GetDivision(CalculateDto calculateDto)
    {
        // validate
        var validators = new List<IMathValidator> { new NullValidator() };
        foreach (var validator in validators)
        {
            var (validated, message) = validator.Validate(calculateDto);
            if (!validated) return new ServiceResult<float> { Success = false, Message = message };
        }

        // result
        var division = (float)(calculateDto.Number1 / calculateDto.Number2)!;
        return new ServiceResult<float> { Success = true, Result = division };
    }
}