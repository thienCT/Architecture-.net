namespace ShowroomManagementSystem.Application.Vehicles.Dtos;

public record VehicleDto(Guid Id, string ModelNumber, string Name, string Brand, decimal Price, string? Vin, string Status);
