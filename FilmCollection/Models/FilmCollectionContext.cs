using FilmCollection.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmCollection_Allen.Models
{
    public class FilmCollectionContext : DbContext
    {
        public FilmCollectionContext(DbContextOptions<FilmCollectionContext> options) : base (options) 
        {
        }

        public DbSet<Application> Movies { get; set; }
    }
}
