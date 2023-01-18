#if SQLiteVersion
using GeoProfs_v2.Models;
using Microsoft.EntityFrameworkCore;

namespace GeoProfs.Data
{
#region snippet_SQLite
    public class GeoprofsContext : DbContext
    {
        public GeoprofsContext(DbContextOptions<GeoprofsContext> options) : base(options)
        {
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
#endregion
}
#else
#region snippet_SS
using Geoprofs_v2.Models;
using Microsoft.EntityFrameworkCore;

namespace GeoProfs.Data
{
    public class GeoprofsContext : DbContext
    {
        public GeoprofsContext(DbContextOptions<GeoprofsContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Werknemer> Werknemers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Geoprofs_v2.Models.VerlofAanvraag> VerlofAanvraag { get; set; }
    }
}
#endregion
#endif