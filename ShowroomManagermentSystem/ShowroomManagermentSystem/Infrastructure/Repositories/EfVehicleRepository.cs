
using ShowroomManagementSystem.Infrastructure.Persistence;
using ShowroomManagermentSystem.Application.Abstractions.ShowroomManagementSystem.Application.Abstractions;
using ShowroomManagermentSystem.Domain.Entities;

namespace ShowroomManagementSystem.Infrastructure.Repositories;

public class EfVehicleRepository : IVehicleRepository
{
    private readonly AppDbContext _db;
    public EfVehicleRepository(AppDbContext db) => _db = db;

    public async Task<Vehicle?> GetAsync(Guid id, CancellationToken ct)
    {
        return await _db.Vehicles.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, ct);
    }

    public async Task<IReadOnlyList<Vehicle>> SearchAsync(string? q, int page, int size, CancellationToken ct)
    {
        var query = _db.Vehicles.AsQueryable();
        if (!string.IsNullOrWhiteSpace(q))
            query = query.Where(x => x.Name.Contains(q) || x.ModelNumber.Contains(q) || x.Brand.Contains(q));

        return await query.OrderByDescending(x => x.CreatedAt)
                          .Skip((page - 1) * size).Take(size)
                          .AsNoTracking().ToListAsync(ct);
    }

    public async Task<Vehicle> AddAsync(Vehicle entity, CancellationToken ct)
    {
        _db.Vehicles.Add(entity);
        await _db.SaveChangesAsync(ct);
        return entity;
    }

    public async Task UpdateAsync(Vehicle entity, CancellationToken ct)
    {
        _db.Vehicles.Update(entity);
        await _db.SaveChangesAsync(ct);
    }

    public async Task DeleteAsync(Guid id, CancellationToken ct)
    {
        var e = await _db.Vehicles.FindAsync([id], ct);
        if (e is null) return;
        _db.Vehicles.Remove(e);
        await _db.SaveChangesAsync(ct);
    }
}