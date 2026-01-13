using System.Linq;
using SystemCraftAPI.Model;
using SystemCraftAPI.Model.Dtos;
using Monitor = SystemCraftAPI.Model.Entities.Monitor;

namespace SystemCraftAPI.Service;

public class MonitorService
{
    private readonly SystemCraftDbContext _context;

    public MonitorService(SystemCraftDbContext context)
    {
        _context = context;
    }

    public MonitorDto AddMonitor(MonitorDto dto)
    {
        var entity = new Monitor
        {
            Name = dto.Name,
            Price = dto.Price,
            Description = dto.Description,
            BrandId = dto.BrandId,
            Model = dto.Model,
            ScreenSize = dto.ScreenSize,
            Resolution = dto.Resolution,
            PanelType = dto.PanelType,
            RefreshRate = dto.RefreshRate,
            ResponseTime = dto.ResponseTime,
            AspectRatio = dto.AspectRatio,
            HasHDR = dto.HasHDR,
            IsCurved = dto.IsCurved,
            Color = dto.Color,
            Brightness = dto.Brightness,
            Connectivity = dto.Connectivity,
            HasSpeakers = dto.HasSpeakers,
            Warranty = dto.Warranty,
            ReleaseDate = dto.ReleaseDate,
            Rating = dto.Rating,
            InStock = dto.InStock,
            StockQuantity = dto.StockQuantity
        };

        _context.Monitors.Add(entity);
        _context.SaveChanges();

        dto.Id = entity.Id;
        return dto;
    }

    public MonitorDto? GetMonitorById(int id)
    {
        var entity = _context.Monitors.FirstOrDefault(m => m.Id == id);
        if (entity is null) return null;

        return new MonitorDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Price = entity.Price,
            Description = entity.Description,
            BrandId = entity.BrandId,
            Model = entity.Model,
            ScreenSize = entity.ScreenSize,
            Resolution = entity.Resolution,
            PanelType = entity.PanelType,
            RefreshRate = entity.RefreshRate,
            ResponseTime = entity.ResponseTime,
            AspectRatio = entity.AspectRatio,
            HasHDR = entity.HasHDR,
            IsCurved = entity.IsCurved,
            Color = entity.Color,
            Brightness = entity.Brightness,
            Connectivity = entity.Connectivity,
            HasSpeakers = entity.HasSpeakers,
            Warranty = entity.Warranty,
            ReleaseDate = entity.ReleaseDate,
            Rating = entity.Rating,
            InStock = entity.InStock,
            StockQuantity = entity.StockQuantity
        };
    }

    public IEnumerable<MonitorDto> GetAllMonitors()
    {
        return _context.Monitors
            .Select(entity => new MonitorDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                Description = entity.Description,
                BrandId = entity.BrandId,
                Model = entity.Model,
                ScreenSize = entity.ScreenSize,
                Resolution = entity.Resolution,
                PanelType = entity.PanelType,
                RefreshRate = entity.RefreshRate,
                ResponseTime = entity.ResponseTime,
                AspectRatio = entity.AspectRatio,
                HasHDR = entity.HasHDR,
                IsCurved = entity.IsCurved,
                Color = entity.Color,
                Brightness = entity.Brightness,
                Connectivity = entity.Connectivity,
                HasSpeakers = entity.HasSpeakers,
                Warranty = entity.Warranty,
                ReleaseDate = entity.ReleaseDate,
                Rating = entity.Rating,
                InStock = entity.InStock,
                StockQuantity = entity.StockQuantity
            })
            .ToList();
    }

    public MonitorDto? UpdateMonitor(MonitorDto dto)
    {
        var entity = _context.Monitors.FirstOrDefault(m => m.Id == dto.Id);
        if (entity is null) return null;

        entity.Name = dto.Name;
        entity.Price = dto.Price;
        entity.Description = dto.Description;
        entity.BrandId = dto.BrandId;
        entity.Model = dto.Model;
        entity.ScreenSize = dto.ScreenSize;
        entity.Resolution = dto.Resolution;
        entity.PanelType = dto.PanelType;
        entity.RefreshRate = dto.RefreshRate;
        entity.ResponseTime = dto.ResponseTime;
        entity.AspectRatio = dto.AspectRatio;
        entity.HasHDR = dto.HasHDR;
        entity.IsCurved = dto.IsCurved;
        entity.Color = dto.Color;
        entity.Brightness = dto.Brightness;
        entity.Connectivity = dto.Connectivity;
        entity.HasSpeakers = dto.HasSpeakers;
        entity.Warranty = dto.Warranty;
        entity.ReleaseDate = dto.ReleaseDate;
        entity.Rating = dto.Rating;
        entity.InStock = dto.InStock;
        entity.StockQuantity = dto.StockQuantity;

        _context.SaveChanges();
        return dto;
    }

    public bool DeleteMonitor(int id)
    {
        var entity = _context.Monitors.FirstOrDefault(m => m.Id == id);
        if (entity is null) return false;

        _context.Monitors.Remove(entity);
        _context.SaveChanges();
        return true;
    }
}
