using ShowroomManagementSystem.Application.Vehicles.Commands;

namespace ShowroomManagermentSystem.Application.Vehicles.Commands
{
    public class CreateVehicleValidator : AbstractValidator<CreateVehicleCommand>
    {
        public CreateVehicleValidator()
        {
            RuleFor(x => x.ModelNumber).NotEmpty().MaximumLength(64);
            RuleFor(x => x.Name).NotEmpty().MaximumLength(128);
            RuleFor(x => x.Brand).NotEmpty().MaximumLength(64);
            RuleFor(x => x.Price).GreaterThanOrEqualTo(0);
        }

        private object RuleFor(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
