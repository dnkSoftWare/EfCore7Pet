using System.ComponentModel.DataAnnotations;

namespace WebApplication.Entities;

public class Genre
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public HashSet<Movie> Movies { get; set; } = new HashSet<Movie>();
}