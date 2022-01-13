namespace RazorPagesMovies.Pages.Movies;

public class IndexModel : PageModel
{
    private readonly Data.RazorPagesMoviesContext _context;

    public IndexModel(Data.RazorPagesMoviesContext context)
    {
        _context = context;
    }

    public IList<Movie>? Movies { get; set; }
    public Movie Movie { get; set; } = new();

    public async Task OnGetAsync()
    {
        Movies = await _context.Movies.ToListAsync();
    }
}
