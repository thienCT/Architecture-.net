using ShowroomManagermentSystem.Application.Vehicles.Queries;

namespace ShowroomManagementSystem.API.Controllers
{
    internal record DeleteVehicleCommand(string? Q, int Page, int Size) : SearchVehiclesQuery(Q, Page, Size)
    {
        private Guid id;

        public DeleteVehicleCommand(Guid id) : this(null, default, default) => this.id = id;
    }
}