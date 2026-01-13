using System.Linq;
using SystemCraftAPI.Model;
using SystemCraftAPI.Model.Dtos;
using SystemCraftAPI.Model.Entities;

namespace SystemCraftAPI.Service;

public class GraphicsCardService
{
    private readonly SystemCraftDbContext _context;

    public GraphicsCardService(SystemCraftDbContext context)
    {
        _context = context;
    }

    public GraphicsCardDto AddGraphicsCard(GraphicsCardDto dto)
    {
        var entity = new GraphicsCard
        {
            Name = dto.Name,
            Price = dto.Price,
            Description = dto.Description,
            BrandId = dto.BrandId,
            Model = dto.Model,
            Chipset = dto.Chipset,
            VRAM = dto.VRAM,
            MemoryType = dto.MemoryType,
            MemoryBus = dto.MemoryBus,
            CoreClock = dto.CoreClock,
            BoostClock = dto.BoostClock,
            Interface = dto.Interface,
            PowerConsumption = dto.PowerConsumption,
            CoolingType = dto.CoolingType,
            Length = dto.Length,
            SupportsRayTracing = dto.SupportsRayTracing,
            SupportsDLSS = dto.SupportsDLSS,
            Ports = dto.Ports,
            Warranty = dto.Warranty,
            ReleaseDate = dto.ReleaseDate,
            Rating = dto.Rating,
            InStock = dto.InStock,
            StockQuantity = dto.StockQuantity
        };

        _context.GraphicsCards.Add(entity);
        _context.SaveChanges();

        dto.Id = entity.Id;
        return dto;
    }

    public GraphicsCardDto? GetGraphicsCardById(int id)
    {
        var entity = _context.GraphicsCards.FirstOrDefault(g => g.Id == id);
        if (entity is null) return null;

        return new GraphicsCardDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Price = entity.Price,
            Description = entity.Description,
            BrandId = entity.BrandId,
            Model = entity.Model,
            Chipset = entity.Chipset,
            VRAM = entity.VRAM,
            MemoryType = entity.MemoryType,
            MemoryBus = entity.MemoryBus,
            CoreClock = entity.CoreClock,
            BoostClock = entity.BoostClock,
            Interface = entity.Interface,
            PowerConsumption = entity.PowerConsumption,
            CoolingType = entity.CoolingType,
            Length = entity.Length,
            SupportsRayTracing = entity.SupportsRayTracing,
            SupportsDLSS = entity.SupportsDLSS,
            Ports = entity.Ports,
            Warranty = entity.Warranty,
            ReleaseDate = entity.ReleaseDate,
            Rating = entity.Rating,
            InStock = entity.InStock,
            StockQuantity = entity.StockQuantity
        };
    }

    public IEnumerable<GraphicsCardDto> GetAllGraphicsCards()
    {
        return _context.GraphicsCards
            .Select(entity => new GraphicsCardDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                Description = entity.Description,
                BrandId = entity.BrandId,
                Model = entity.Model,
                Chipset = entity.Chipset,
                VRAM = entity.VRAM,
                MemoryType = entity.MemoryType,
                MemoryBus = entity.MemoryBus,
                CoreClock = entity.CoreClock,
                BoostClock = entity.BoostClock,
                Interface = entity.Interface,
                PowerConsumption = entity.PowerConsumption,
                CoolingType = entity.CoolingType,
                Length = entity.Length,
                SupportsRayTracing = entity.SupportsRayTracing,
                SupportsDLSS = entity.SupportsDLSS,
                Ports = entity.Ports,
                Warranty = entity.Warranty,
                ReleaseDate = entity.ReleaseDate,
                Rating = entity.Rating,
                InStock = entity.InStock,
                StockQuantity = entity.StockQuantity
            })
            .ToList();
    }

    public GraphicsCardDto? UpdateGraphicsCard(GraphicsCardDto dto)
    {
        var entity = _context.GraphicsCards.FirstOrDefault(g => g.Id == dto.Id);
        if (entity is null) return null;

        entity.Name = dto.Name;
        entity.Price = dto.Price;
        entity.Description = dto.Description;
        entity.BrandId = dto.BrandId;
        entity.Model = dto.Model;
        entity.Chipset = dto.Chipset;
        entity.VRAM = dto.VRAM;
        entity.MemoryType = dto.MemoryType;
        entity.MemoryBus = dto.MemoryBus;
        entity.CoreClock = dto.CoreClock;
        entity.BoostClock = dto.BoostClock;
        entity.Interface = dto.Interface;
        entity.PowerConsumption = dto.PowerConsumption;
        entity.CoolingType = dto.CoolingType;
        entity.Length = dto.Length;
        entity.SupportsRayTracing = dto.SupportsRayTracing;
        entity.SupportsDLSS = dto.SupportsDLSS;
        entity.Ports = dto.Ports;
        entity.Warranty = dto.Warranty;
        entity.ReleaseDate = dto.ReleaseDate;
        entity.Rating = dto.Rating;
        entity.InStock = dto.InStock;
        entity.StockQuantity = dto.StockQuantity;

        _context.SaveChanges();
        return dto;
    }

    public bool DeleteGraphicsCard(int id)
    {
        var entity = _context.GraphicsCards.FirstOrDefault(g => g.Id == id);
        if (entity is null) return false;

        _context.GraphicsCards.Remove(entity);
        _context.SaveChanges();
        return true;
    }
}
