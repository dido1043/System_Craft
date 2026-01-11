using System;

namespace SystemCraftAPI.Model.Dtos;

public class PrinterDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public int BrandId { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string PrintTechnology { get; set; } = string.Empty;
    public int PrintSpeed { get; set; }
    public string Resolution { get; set; } = string.Empty;
    public bool IsWireless { get; set; }
    public string Connectivity { get; set; } = string.Empty;
    public bool HasScanner { get; set; }
    public bool HasCopier { get; set; }
    public string PaperSize { get; set; } = string.Empty;
    public int DutyCycle { get; set; }
    public string Warranty { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public int Rating { get; set; }
    public bool InStock { get; set; }
    public int StockQuantity { get; set; }
}
