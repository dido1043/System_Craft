using System;

namespace SystemCraftAPI.Model.Dtos;

public class GraphicsCardDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public int BrandId { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Chipset { get; set; } = string.Empty;
    public int VRAM { get; set; }
    public string MemoryType { get; set; } = string.Empty;
    public int MemoryBus { get; set; }
    public int CoreClock { get; set; }
    public int BoostClock { get; set; }
    public string Interface { get; set; } = string.Empty;
    public int PowerConsumption { get; set; }
    public string CoolingType { get; set; } = string.Empty;
    public int Length { get; set; }
    public bool SupportsRayTracing { get; set; }
    public bool SupportsDLSS { get; set; }
    public string Ports { get; set; } = string.Empty;
    public string Warranty { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public int Rating { get; set; }
    public bool InStock { get; set; }
    public int StockQuantity { get; set; }
}
