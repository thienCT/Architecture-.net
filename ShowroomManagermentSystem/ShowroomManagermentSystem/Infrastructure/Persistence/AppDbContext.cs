using ShowroomManagermentSystem.Domain.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ShowroomManagementSystem.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public DbSet<Vehicle> Vehicles => Set<Vehicle>();

   

    private DbSet<T> Set<T>()
    {
        throw new NotImplementedException();
    }

    public override bool Equals(object? obj)
    {
        return obj is AppDbContext context &&
               EqualityComparer<DbSet<Vehicle>>.Default.Equals(Vehicles, context.Vehicles);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Vehicles);
    }
}