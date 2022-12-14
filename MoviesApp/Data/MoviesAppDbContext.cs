using Microsoft.EntityFrameworkCore;
using MoviesApp.Models;

namespace MoviesApp.Data
{
    public class MoviesAppDbContext : DbContext
    {
        public MoviesAppDbContext(DbContextOptions<MoviesAppDbContext> options) : base(options)
        { }
       
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<MoviesApp.Models.Product> Product { get; set; }
        public DbSet<MoviesApp.Models.Photo> Photo { get; set; }
    }
}
    

