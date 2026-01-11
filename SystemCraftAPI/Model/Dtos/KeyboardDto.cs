using System;

namespace SystemCraftAPI.Model.Dtos;

public class KeyboardDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public int BrandId { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Layout { get; set; } = string.Empty;
    public bool IsWireless { get; set; }
    public bool HasBacklight { get; set; }
    public string SwitchType { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public double Weight { get; set; }
    public string Connectivity { get; set; } = string.Empty;
    public bool HasNumericKeypad { get; set; }
    public bool IsErgonomic { get; set; }
    public string KeyCount { get; set; } = string.Empty;
    public string Warranty { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public int Rating { get; set; }
    public bool InStock { get; set; }
    public int StockQuantity { get; set; }
}
