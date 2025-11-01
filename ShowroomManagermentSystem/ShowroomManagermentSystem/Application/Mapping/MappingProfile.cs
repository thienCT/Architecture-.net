using ShowroomManagementSystem.Application.Vehicles.Dtos;
using ShowroomManagermentSystem.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ShowroomManagermentSystem.Application.Mapping
{
    namespace ShowroomManagementSystem.Application.Mapping
    {
        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<Vehicle, VehicleDto>()
                    .ForMember(d => d.Status, opt => opt.MapFrom(s => s.Status.ToString()));
            }

            private object CreateMap<T1, T2>()
            {
                throw new NotImplementedException();
            }
        }
    }
}
