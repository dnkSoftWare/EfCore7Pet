using System.ComponentModel.DataAnnotations;

namespace WebApplication.DTOs;

public class ActorCreationDTO
{
    [StringLength(maximumLength:150)]
    public string Name { get; set; } = null!;
    public decimal Fortune { get; set; }
    public DateTime DayOfBirthday { get; set; }
}