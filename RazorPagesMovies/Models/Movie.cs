using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovies.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = String.Empty;
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string Genre { get; set; } = String.Empty;
    public decimal Price { get; set; }
}
