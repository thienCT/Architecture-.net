using ShowroomManagermentSystem.Domain.Entities;

namespace ShowroomManagermentSystem.Application.Vehicles.Commands
{
    public interface IMapper
    {
        T Map<T>(Vehicle saved);
        T Map<T>(IReadOnlyList<Vehicle> list);
    }
}