using System;

namespace SystemCraftAPI.Model.Dtos;

public class LaptopDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public int BrandId { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Processor { get; set; } = string.Empty;
    public int RAM { get; set; }
    public int Storage { get; set; }
    public string StorageType { get; set; } = string.Empty;
    public double ScreenSize { get; set; }
    public string Resolution { get; set; } = string.Empty;
    public string OperatingSystem { get; set; } = string.Empty;
    public int BatteryLife { get; set; }
    public double Weight { get; set; }
    public string Color { get; set; } = string.Empty;
    public bool HasTouchscreen { get; set; }
    public bool HasBacklitKeyboard { get; set; }
    public string GraphicsCard { get; set; } = string.Empty;
    public int USBPorts { get; set; }
    public bool HasHDMI { get; set; }
    public bool HasEthernet { get; set; }
    public string Warranty { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public int Rating { get; set; }
    public bool InStock { get; set; }
    public int StockQuantity { get; set; }
}
