using System.ComponentModel.DataAnnotations;

namespace MuvieApi.Models;

public class Movie
{
    [Key]
    [Required]
    public int Id { get; set; }
  
    [Required(ErrorMessage = "Title is not null oe empty")]
    [MaxLength(50, ErrorMessage = "Title must be at most 50 characters")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "Gender is not null oe empty")]
    [MaxLength(50, ErrorMessage = "Gender must be at most 50 characters")]
    public string? Gender { get; set; }

    [Required(ErrorMessage = "Director is not null oe empty")]
    [MaxLength(50, ErrorMessage = "Director must be at most 50 characters")]
    public string? Director { get; set; } 

    [Required]
    [Range(20, 600, ErrorMessage = "Duration Range 20..40 min")]
    public int Duration { get; set; }
}