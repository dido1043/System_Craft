using System;

namespace SystemCraftAPI.Model.Dtos;

public class MonitorDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public int BrandId { get; set; }
    public string Model { get; set; } = string.Empty;
    public double ScreenSize { get; set; }
    public string Resolution { get; set; } = string.Empty;
    public string PanelType { get; set; } = string.Empty;
    public int RefreshRate { get; set; }
    public int ResponseTime { get; set; }
    public string AspectRatio { get; set; } = string.Empty;
    public bool HasHDR { get; set; }
    public bool IsCurved { get; set; }
    public string Color { get; set; } = string.Empty;
    public int Brightness { get; set; }
    public string Connectivity { get; set; } = string.Empty;
    public bool HasSpeakers { get; set; }
    public string Warranty { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public int Rating { get; set; }
    public bool InStock { get; set; }
    public int StockQuantity { get; set; }
}
