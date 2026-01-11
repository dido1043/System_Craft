using System;

namespace SystemCraftAPI.Model.Dtos;

public class HeadphonesDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public int BrandId { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public bool IsWireless { get; set; }
    public string Connectivity { get; set; } = string.Empty;
    public bool HasMicrophone { get; set; }
    public int BatteryLife { get; set; }
    public string DriverSize { get; set; } = string.Empty;
    public string FrequencyResponse { get; set; } = string.Empty;
    public bool IsNoiseCancelling { get; set; }
    public string Color { get; set; } = string.Empty;
    public double Weight { get; set; }
    public bool IsFoldable { get; set; }
    public string Warranty { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public int Rating { get; set; }
    public bool InStock { get; set; }
    public int StockQuantity { get; set; }
}
