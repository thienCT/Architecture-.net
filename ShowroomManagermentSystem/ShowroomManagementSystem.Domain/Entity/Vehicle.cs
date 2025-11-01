using Microsoft.AspNetCore.Mvc;

public enum VehicleStatus { InStock, Reserved, Sold }

public class Vehicle
{
    public Guid Id { get; set; }
    public string ModelNumber { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Brand { get; set; } = default!;
    public decimal Price { get; set; }
    public string? Vin { get; set; }
    public VehicleStatus Status { get; set; } = VehicleStatus.InStock;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}