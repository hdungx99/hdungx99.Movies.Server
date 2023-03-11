
using hdungx99.Movies.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace hdungx99.Movies.DAL.Context
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
    }
}
