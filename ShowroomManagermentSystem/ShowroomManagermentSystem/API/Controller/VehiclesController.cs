using Microsoft.AspNetCore.Mvc;
using ShowroomManagementSystem.Application.Vehicles.Commands;
using ShowroomManagementSystem.Application.Vehicles.Dtos;
using ShowroomManagermentSystem.Application.Vehicles.Queries;

namespace ShowroomManagermentSystem.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<VehicleDto>> Create(CreateVehicleCommand cmd, CancellationToken ct)
            => Ok(await mediator.Send(cmd, ct));

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<VehicleDto>>> Search([FromQuery] string? q, [FromQuery] int page = 1, [FromQuery] int size = 20, CancellationToken ct = default)
            => Ok(await mediator.Send(new SearchVehiclesQuery(q, page, size), ct));
    }
}
