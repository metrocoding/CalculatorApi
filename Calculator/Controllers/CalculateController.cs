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
        var response = _safeMath.GetAddition(calculateDto);
        if (!response.Success) BadRequest(response);
        return Ok(response);
    }

    [HttpPost("subtraction")]
    public IActionResult Subtraction(CalculateDto calculateDto)
    {
        var response = _safeMath.GetSubtraction(calculateDto);
        if (!response.Success) BadRequest(response);
        return Ok(response);
    }

    [HttpPost("multiplication")]
    public IActionResult Multiplication(CalculateDto calculateDto)
    {
        var response = _safeMath.GetMultiplication(calculateDto);
        if (!response.Success) BadRequest(response);
        return Ok(response);
    }

    [HttpPost("division")]
    public IActionResult Division(CalculateDto calculateDto)
    {
        var response = _safeMath.GetDivision(calculateDto);
        if (!response.Success) BadRequest(response);
        return Ok(response);
    }
}