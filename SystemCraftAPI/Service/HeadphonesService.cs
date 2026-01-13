using System.Linq;
using SystemCraftAPI.Model;
using SystemCraftAPI.Model.Dtos;
using SystemCraftAPI.Model.Entities;

namespace SystemCraftAPI.Service;

public class HeadphonesService
{
    private readonly SystemCraftDbContext _context;

    public HeadphonesService(SystemCraftDbContext context)
    {
        _context = context;
    }

    public HeadphonesDto AddHeadphones(HeadphonesDto dto)
    {
        var entity = new Headphones
        {
            Name = dto.Name,
            Price = dto.Price,
            Description = dto.Description,
            BrandId = dto.BrandId,
            Model = dto.Model,
            Type = dto.Type,
            IsWireless = dto.IsWireless,
            Connectivity = dto.Connectivity,
            HasMicrophone = dto.HasMicrophone,
            BatteryLife = dto.BatteryLife,
            DriverSize = dto.DriverSize,
            FrequencyResponse = dto.FrequencyResponse,
            IsNoiseCancelling = dto.IsNoiseCancelling,
            Color = dto.Color,
            Weight = dto.Weight,
            IsFoldable = dto.IsFoldable,
            Warranty = dto.Warranty,
            ReleaseDate = dto.ReleaseDate,
            Rating = dto.Rating,
            InStock = dto.InStock,
            StockQuantity = dto.StockQuantity
        };

        _context.Headphones.Add(entity);
        _context.SaveChanges();

        dto.Id = entity.Id;
        return dto;
    }

    public HeadphonesDto? GetHeadphonesById(int id)
    {
        var entity = _context.Headphones.FirstOrDefault(h => h.Id == id);
        if (entity is null) return null;

        return new HeadphonesDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Price = entity.Price,
            Description = entity.Description,
            BrandId = entity.BrandId,
            Model = entity.Model,
            Type = entity.Type,
            IsWireless = entity.IsWireless,
            Connectivity = entity.Connectivity,
            HasMicrophone = entity.HasMicrophone,
            BatteryLife = entity.BatteryLife,
            DriverSize = entity.DriverSize,
            FrequencyResponse = entity.FrequencyResponse,
            IsNoiseCancelling = entity.IsNoiseCancelling,
            Color = entity.Color,
            Weight = entity.Weight,
            IsFoldable = entity.IsFoldable,
            Warranty = entity.Warranty,
            ReleaseDate = entity.ReleaseDate,
            Rating = entity.Rating,
            InStock = entity.InStock,
            StockQuantity = entity.StockQuantity
        };
    }

    public IEnumerable<HeadphonesDto> GetAllHeadphones()
    {
        return _context.Headphones
            .Select(entity => new HeadphonesDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                Description = entity.Description,
                BrandId = entity.BrandId,
                Model = entity.Model,
                Type = entity.Type,
                IsWireless = entity.IsWireless,
                Connectivity = entity.Connectivity,
                HasMicrophone = entity.HasMicrophone,
                BatteryLife = entity.BatteryLife,
                DriverSize = entity.DriverSize,
                FrequencyResponse = entity.FrequencyResponse,
                IsNoiseCancelling = entity.IsNoiseCancelling,
                Color = entity.Color,
                Weight = entity.Weight,
                IsFoldable = entity.IsFoldable,
                Warranty = entity.Warranty,
                ReleaseDate = entity.ReleaseDate,
                Rating = entity.Rating,
                InStock = entity.InStock,
                StockQuantity = entity.StockQuantity
            })
            .ToList();
    }

    public HeadphonesDto? UpdateHeadphones(HeadphonesDto dto)
    {
        var entity = _context.Headphones.FirstOrDefault(h => h.Id == dto.Id);
        if (entity is null) return null;

        entity.Name = dto.Name;
        entity.Price = dto.Price;
        entity.Description = dto.Description;
        entity.BrandId = dto.BrandId;
        entity.Model = dto.Model;
        entity.Type = dto.Type;
        entity.IsWireless = dto.IsWireless;
        entity.Connectivity = dto.Connectivity;
        entity.HasMicrophone = dto.HasMicrophone;
        entity.BatteryLife = dto.BatteryLife;
        entity.DriverSize = dto.DriverSize;
        entity.FrequencyResponse = dto.FrequencyResponse;
        entity.IsNoiseCancelling = dto.IsNoiseCancelling;
        entity.Color = dto.Color;
        entity.Weight = dto.Weight;
        entity.IsFoldable = dto.IsFoldable;
        entity.Warranty = dto.Warranty;
        entity.ReleaseDate = dto.ReleaseDate;
        entity.Rating = dto.Rating;
        entity.InStock = dto.InStock;
        entity.StockQuantity = dto.StockQuantity;

        _context.SaveChanges();
        return dto;
    }

    public bool DeleteHeadphones(int id)
    {
        var entity = _context.Headphones.FirstOrDefault(h => h.Id == id);
        if (entity is null) return false;

        _context.Headphones.Remove(entity);
        _context.SaveChanges();
        return true;
    }
}
