using System.ComponentModel.DataAnnotations;

namespace ApiModels;

public class CalculateDto
{
    [Required]
    public float? Number1 { get; set; }
    [Required]
    public float? Number2 { get; set; }
}