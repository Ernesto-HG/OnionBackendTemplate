using Microsoft.EntityFrameworkCore;
using andon_ng.Core.Entities;

namespace andon_ng.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<TestEntity> Entities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TestEntity>(entity =>
            {
                entity.HasKey(c => c.Id_entity);

            });
        }
    }
}
