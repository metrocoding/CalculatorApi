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

    [HttpGet("addition")]
    public IActionResult Addition(CalculateDto calculateDto)
    {
        var response = _safeMath.GetAddition(calculateDto);
        if (!response.Success) BadRequest(response);
        return Ok(response.Result);
    }

    [HttpGet("subtraction")]
    public IActionResult Subtraction(CalculateDto calculateDto)
    {
        var response = _safeMath.GetSubtraction(calculateDto);
        if (!response.Success) BadRequest(response);
        return Ok(response.Result);
    }

    [HttpGet("multiplication")]
    public IActionResult Multiplication(CalculateDto calculateDto)
    {
        var response = _safeMath.GetMultiplication(calculateDto);
        if (!response.Success) BadRequest(response);
        return Ok(response.Result);
    }

    [HttpGet("division")]
    public IActionResult Division(CalculateDto calculateDto)
    {
        var response = _safeMath.GetDivision(calculateDto);
        if (!response.Success) BadRequest(response);
        return Ok(response.Result);
    }
}