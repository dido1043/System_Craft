using System.Linq;
using SystemCraftAPI.Model;
using SystemCraftAPI.Model.Dtos;
using SystemCraftAPI.Model.Entities;

namespace SystemCraftAPI.Service;

public class MouseService
{
    private readonly SystemCraftDbContext _context;

    public MouseService(SystemCraftDbContext context)
    {
        _context = context;
    }

    public MouseDto AddMouse(MouseDto dto)
    {
        var entity = new Mouse
        {
            Name = dto.Name,
            Price = dto.Price,
            Description = dto.Description,
            BrandId = dto.BrandId,
            Model = dto.Model,
            Type = dto.Type,
            IsWireless = dto.IsWireless,
            DPI = dto.DPI,
            Buttons = dto.Buttons,
            Color = dto.Color,
            Weight = dto.Weight,
            Connectivity = dto.Connectivity,
            HasScrollWheel = dto.HasScrollWheel,
            IsErgonomic = dto.IsErgonomic,
            BatteryLife = dto.BatteryLife,
            Warranty = dto.Warranty,
            ReleaseDate = dto.ReleaseDate,
            Rating = dto.Rating,
            InStock = dto.InStock,
            StockQuantity = dto.StockQuantity
        };

        _context.Mice.Add(entity);
        _context.SaveChanges();

        dto.Id = entity.Id;
        return dto;
    }

    public MouseDto? GetMouseById(int id)
    {
        var entity = _context.Mice.FirstOrDefault(m => m.Id == id);
        if (entity is null) return null;

        return new MouseDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Price = entity.Price,
            Description = entity.Description,
            BrandId = entity.BrandId,
            Model = entity.Model,
            Type = entity.Type,
            IsWireless = entity.IsWireless,
            DPI = entity.DPI,
            Buttons = entity.Buttons,
            Color = entity.Color,
            Weight = entity.Weight,
            Connectivity = entity.Connectivity,
            HasScrollWheel = entity.HasScrollWheel,
            IsErgonomic = entity.IsErgonomic,
            BatteryLife = entity.BatteryLife,
            Warranty = entity.Warranty,
            ReleaseDate = entity.ReleaseDate,
            Rating = entity.Rating,
            InStock = entity.InStock,
            StockQuantity = entity.StockQuantity
        };
    }

    public IEnumerable<MouseDto> GetAllMice()
    {
        return _context.Mice
            .Select(entity => new MouseDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                Description = entity.Description,
                BrandId = entity.BrandId,
                Model = entity.Model,
                Type = entity.Type,
                IsWireless = entity.IsWireless,
                DPI = entity.DPI,
                Buttons = entity.Buttons,
                Color = entity.Color,
                Weight = entity.Weight,
                Connectivity = entity.Connectivity,
                HasScrollWheel = entity.HasScrollWheel,
                IsErgonomic = entity.IsErgonomic,
                BatteryLife = entity.BatteryLife,
                Warranty = entity.Warranty,
                ReleaseDate = entity.ReleaseDate,
                Rating = entity.Rating,
                InStock = entity.InStock,
                StockQuantity = entity.StockQuantity
            })
            .ToList();
    }

    public MouseDto? UpdateMouse(MouseDto dto)
    {
        var entity = _context.Mice.FirstOrDefault(m => m.Id == dto.Id);
        if (entity is null) return null;

        entity.Name = dto.Name;
        entity.Price = dto.Price;
        entity.Description = dto.Description;
        entity.BrandId = dto.BrandId;
        entity.Model = dto.Model;
        entity.Type = dto.Type;
        entity.IsWireless = dto.IsWireless;
        entity.DPI = dto.DPI;
        entity.Buttons = dto.Buttons;
        entity.Color = dto.Color;
        entity.Weight = dto.Weight;
        entity.Connectivity = dto.Connectivity;
        entity.HasScrollWheel = dto.HasScrollWheel;
        entity.IsErgonomic = dto.IsErgonomic;
        entity.BatteryLife = dto.BatteryLife;
        entity.Warranty = dto.Warranty;
        entity.ReleaseDate = dto.ReleaseDate;
        entity.Rating = dto.Rating;
        entity.InStock = dto.InStock;
        entity.StockQuantity = dto.StockQuantity;

        _context.SaveChanges();
        return dto;
    }

    public bool DeleteMouse(int id)
    {
        var entity = _context.Mice.FirstOrDefault(m => m.Id == id);
        if (entity is null) return false;

        _context.Mice.Remove(entity);
        _context.SaveChanges();
        return true;
    }
}
