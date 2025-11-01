using ShowroomManagermentSystem.Application.Vehicles.Queries;

namespace ShowroomManagementSystem.API.Controllers
{
    internal class GetVehicleByIdQuery : SearchVehiclesQuery
    {
        private Guid id;

        public GetVehicleByIdQuery(Guid id)
        {
            this.id = id;
        }
    }
}