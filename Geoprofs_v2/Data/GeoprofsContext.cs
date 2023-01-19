using Geoprofs_v2.Models;
using Microsoft.EntityFrameworkCore;

namespace GeoProfs.Data
{
    public class GeoprofsContext : DbContext
    {
        public GeoprofsContext(DbContextOptions<GeoprofsContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Werknemer> Werknemers { get; set; }
        public DbSet<VerlofAanvraag> VerlofAanvraag { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Werknemer>().ToTable("Werknemers");
            modelBuilder.Entity<VerlofAanvraag>().ToTable("VerlofAanvraag");
        }

    }
}
