using global::ShowroomManagementSystem.Application.Vehicles.Commands;
using global::ShowroomManagementSystem.Application.Vehicles.Dtos;
using ShowroomManagermentSystem.Application.Vehicles.Queries;
namespace ShowroomManagermentSystem.Application.Vehicles.Queries
{
    public record SearchVehiclesQuery(string? Q, int Page = 1, int Size = 20) : IRequest<IReadOnlyList<VehicleDto>>;

}
