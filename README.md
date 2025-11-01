Clean Architecture gồm các tầng:
- **Domain**: Entities, Enums, Domain rules.
- **Application**: UseCases (MediatR), DTOs, Validators, Interfaces (Repositories).
- **Infrastructure**: EF Core DbContext, Repositories implementation, Migrations.
- **API**: ASP.NET Core Web API, Controllers, Swagger.

Request → Response Flow

Controller → MediatR → UseCase → Repository → DbContext → SQL → DTO → Controller → Client.
Flow request → response (Clean Architecture)

Client gọi POST /api/vehicles với payload.

API Controller → IMediator.Send(CreateVehicleCommand).

Application (Handler) xử lý nghiệp vụ, validate, mapping.

Application.Abstractions gọi IVehicleRepository.

Infrastructure (EF Repository) thao tác DbContext → SQL Server.

Kết quả map sang DTO → trả về API → JSON cho Client.
