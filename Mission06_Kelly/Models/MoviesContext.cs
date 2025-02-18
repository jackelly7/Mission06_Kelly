using Microsoft.EntityFrameworkCore;

namespace Mission06_Kelly.Models;

public class MoviesContext : DbContext
{
    public MoviesContext(DbContextOptions<MoviesContext> options) : base(options) // constructor
    {
    }
    
    public DbSet<Movie> Movies { get; set; }
}