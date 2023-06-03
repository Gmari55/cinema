using dataacces.Entities;
using Microsoft.EntityFrameworkCore;

namespace dataacces.Data
{
    public class cinemadbcontext : DbContext
    {
        public cinemadbcontext(DbContextOptions options) : base(options) { }
        
        public DbSet<Seans> seans { get; set; }
        public DbSet<Film> films { get; set; }
        public DbSet<Actor> actors { get; set; }
    }
}