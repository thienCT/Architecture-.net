using ShowroomManagermentSystem.Domain.Entities;

namespace ShowroomManagementSystem.Infrastructure.Persistence
{
    public class DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>(static b =>
            {
                b.HasKey(x => x.Id);
                b.Property(x => x.ModelNumber).HasMaxLength(64).IsRequired();
                b.Property(x => x.Name).HasMaxLength(128).IsRequired();
                b.Property(x => x.Brand).HasMaxLength(64).IsRequired();
                b.Property(x => x.Price).HasColumnType("decimal(18,2)");
            });
        }
    }
}