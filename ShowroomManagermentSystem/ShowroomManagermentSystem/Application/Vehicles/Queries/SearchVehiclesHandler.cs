using ShowroomManagementSystem.Application.Vehicles.Dtos;
using ShowroomManagermentSystem.Application.Abstractions.ShowroomManagementSystem.Application.Abstractions;
using ShowroomManagermentSystem.Application.Vehicles.Commands;

namespace ShowroomManagermentSystem.Application.Vehicles.Queries;
public class SearchVehiclesHandler : IRequestHandler<SearchVehiclesQuery, IReadOnlyList<VehicleDto>>
{
    private readonly IVehicleRepository _repo;
    private readonly IMapper _mapper;

    public SearchVehiclesHandler(IVehicleRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<VehicleDto>> Handle(SearchVehiclesQuery request, CancellationToken ct)
    {
        var list = await _repo.SearchAsync(request.Q, request.Page, request.Size, ct);
        return _mapper.Map<IReadOnlyList<VehicleDto>>(list);
    }
}