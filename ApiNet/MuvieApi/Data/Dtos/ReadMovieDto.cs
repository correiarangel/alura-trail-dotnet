
namespace MuvieApi.Data.Dtos;

public class ReadMovieDto
{
    public string? Title { get; set; }
    public string? Gender { get; set; }
    public string? Director { get; set; }
    public int Duration { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}