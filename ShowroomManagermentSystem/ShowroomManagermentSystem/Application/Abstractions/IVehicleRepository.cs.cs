namespace ShowroomManagermentSystem.Application.Abstractions
{
    using ShowroomManagementSystem.Domain.Entities;
    using ShowroomManagermentSystem.Domain.Entities;

    namespace ShowroomManagementSystem.Application.Abstractions;

    public interface IVehicleRepository
    {
        Task<Vehicle?> GetAsync(Guid id, CancellationToken ct);
        Task<IReadOnlyList<Vehicle>> SearchAsync(string? q, int page, int size, CancellationToken ct);
        Task<Vehicle> AddAsync(Vehicle entity, CancellationToken ct);
        Task UpdateAsync(Vehicle entity, CancellationToken ct);
        Task DeleteAsync(Guid id, CancellationToken ct);
    }
}
