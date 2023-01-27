using Biniverso.Business.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Biniverso.Data
{
    public class BiniContext : DbContext
    {
        public BiniContext(DbContextOptions<BiniContext> options)
            :base(options) { }

        public DbSet<Bini> Binies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

    }
}
