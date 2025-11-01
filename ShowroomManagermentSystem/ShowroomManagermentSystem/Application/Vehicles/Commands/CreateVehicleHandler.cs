using ShowroomManagementSystem.Application.Vehicles.Commands;
using ShowroomManagementSystem.Application.Vehicles.Dtos;
using ShowroomManagermentSystem.Application.Abstractions.ShowroomManagementSystem.Application.Abstractions;
using ShowroomManagermentSystem.Domain.Entities;
using ShowroomManagementSystem.Application.Vehicles.Commands;

namespace ShowroomManagermentSystem.Application.Vehicles.Commands
{
    public class CreateVehicleHandler : IRequestHandler<CreateVehicleCommand, VehicleDto>
    {
        private readonly IVehicleRepository _repo;
        private readonly IMapper _mapper;

        public CreateVehicleHandler(IVehicleRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<VehicleDto> Handle(CreateVehicleCommand request, CancellationToken ct)
        {
            var entity = new Vehicle
            {
                Id = Guid.NewGuid(),
                ModelNumber = request.ModelNumber,
                Name = request.Name,
                Brand = request.Brand,
                Price = request.Price,
                Vin = request.Vin
            };

            var saved = await _repo.AddAsync(entity, ct);
            return _mapper.Map<VehicleDto>(saved);
        }
    }
}
