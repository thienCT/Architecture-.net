using ShowroomManagermentSystem.Application.Vehicles.Commands;

var builder = WebApplication.CreateBuilder(args);

// MVC + FluentValidation (tự động validate Model)
builder.Services.AddControllers()
                .AddFluentValidationAutoValidation();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Lấy assembly của Application (dựa vào 1 handler/ bất kỳ type trong Application)
var applicationAssembly = typeof(CreateVehicleHandler).Assembly;

// MediatR + Handlers trong Application
builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssemblies(applicationAssembly));

// Đăng ký FluentValidation validators trong Application
builder.Services.AddValidatorsFromAssembly(applicationAssembly);

// Pipeline: chạy FluentValidation trước mỗi Handler
builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

// AutoMapper profile trong Application
builder.Services.AddAutoMapper(applicationAssembly);

// Infrastructure (EF Core, Repositories…)
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
