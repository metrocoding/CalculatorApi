using ApiModels;

namespace BusinessLogicInterface;

public interface ISafeMathManager
{
    ServiceResult<float> GetAddition(CalculateDto calculateDto);
    ServiceResult<float> GetSubtraction(CalculateDto calculateDto);
    ServiceResult<float> GetMultiplication(CalculateDto calculateDto);
    ServiceResult<float> GetDivision(CalculateDto calculateDto);
}