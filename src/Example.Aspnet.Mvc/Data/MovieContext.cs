using Example.Aspnet.Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Example.Aspnet.Mvc.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
