namespace RazorPagesMovies.Data;

public class RazorPagesMoviesContext : DbContext
{
    public RazorPagesMoviesContext(DbContextOptions<RazorPagesMoviesContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movies => Set<Movie>();
}
