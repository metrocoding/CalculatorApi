using ApiModels;
using BusinessLogicInterface;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculateController : ControllerBase
{
    private readonly ISafeMathManager _safeMath;

    public CalculateController(ISafeMathManager safeMath)
    {
        _safeMath = safeMath;
    }

    [HttpPost("addition")]
    public IActionResult Addition(CalculateDto calculateDto)
    {
        var result = _safeMath.GetAddition(calculateDto);
        if (!result.Success) BadRequest(result);
        return Ok(result);
    }

    [HttpPost("subtraction")]
    public IActionResult Subtraction(CalculateDto calculateDto)
    {
        var result = _safeMath.GetSubtraction(calculateDto);
        if (!result.Success) BadRequest(result);
        return Ok(result);
    }

    [HttpPost("multiplication")]
    public IActionResult Multiplication(CalculateDto calculateDto)
    {
        var result = _safeMath.GetMultiplication(calculateDto);
        if (!result.Success) BadRequest(result);
        return Ok(result);
    }

    [HttpPost("division")]
    public IActionResult Division(CalculateDto calculateDto)
    {
        var result = _safeMath.GetDivision(calculateDto);
        if (!result.Success) BadRequest(result);
        return Ok(result);
    }
}