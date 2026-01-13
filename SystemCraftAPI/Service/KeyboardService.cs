using System.Linq;
using SystemCraftAPI.Model;
using SystemCraftAPI.Model.Dtos;
using SystemCraftAPI.Model.Entities;

namespace SystemCraftAPI.Service;

public class KeyboardService
{
    private readonly SystemCraftDbContext _context;

    public KeyboardService(SystemCraftDbContext context)
    {
        _context = context;
    }

    public KeyboardDto AddKeyboard(KeyboardDto dto)
    {
        var entity = new Keyboard
        {
            Name = dto.Name,
            Price = dto.Price,
            Description = dto.Description,
            BrandId = dto.BrandId,
            Model = dto.Model,
            Type = dto.Type,
            Layout = dto.Layout,
            IsWireless = dto.IsWireless,
            HasBacklight = dto.HasBacklight,
            SwitchType = dto.SwitchType,
            Color = dto.Color,
            Weight = dto.Weight,
            Connectivity = dto.Connectivity,
            HasNumericKeypad = dto.HasNumericKeypad,
            IsErgonomic = dto.IsErgonomic,
            KeyCount = dto.KeyCount,
            Warranty = dto.Warranty,
            ReleaseDate = dto.ReleaseDate,
            Rating = dto.Rating,
            InStock = dto.InStock,
            StockQuantity = dto.StockQuantity
        };

        _context.Keyboards.Add(entity);
        _context.SaveChanges();

        dto.Id = entity.Id;
        return dto;
    }

    public KeyboardDto? GetKeyboardById(int id)
    {
        var entity = _context.Keyboards.FirstOrDefault(k => k.Id == id);
        if (entity is null) return null;

        return new KeyboardDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Price = entity.Price,
            Description = entity.Description,
            BrandId = entity.BrandId,
            Model = entity.Model,
            Type = entity.Type,
            Layout = entity.Layout,
            IsWireless = entity.IsWireless,
            HasBacklight = entity.HasBacklight,
            SwitchType = entity.SwitchType,
            Color = entity.Color,
            Weight = entity.Weight,
            Connectivity = entity.Connectivity,
            HasNumericKeypad = entity.HasNumericKeypad,
            IsErgonomic = entity.IsErgonomic,
            KeyCount = entity.KeyCount,
            Warranty = entity.Warranty,
            ReleaseDate = entity.ReleaseDate,
            Rating = entity.Rating,
            InStock = entity.InStock,
            StockQuantity = entity.StockQuantity
        };
    }

    public IEnumerable<KeyboardDto> GetAllKeyboards()
    {
        return _context.Keyboards
            .Select(entity => new KeyboardDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                Description = entity.Description,
                BrandId = entity.BrandId,
                Model = entity.Model,
                Type = entity.Type,
                Layout = entity.Layout,
                IsWireless = entity.IsWireless,
                HasBacklight = entity.HasBacklight,
                SwitchType = entity.SwitchType,
                Color = entity.Color,
                Weight = entity.Weight,
                Connectivity = entity.Connectivity,
                HasNumericKeypad = entity.HasNumericKeypad,
                IsErgonomic = entity.IsErgonomic,
                KeyCount = entity.KeyCount,
                Warranty = entity.Warranty,
                ReleaseDate = entity.ReleaseDate,
                Rating = entity.Rating,
                InStock = entity.InStock,
                StockQuantity = entity.StockQuantity
            })
            .ToList();
    }

    public KeyboardDto? UpdateKeyboard(KeyboardDto dto)
    {
        var entity = _context.Keyboards.FirstOrDefault(k => k.Id == dto.Id);
        if (entity is null) return null;

        entity.Name = dto.Name;
        entity.Price = dto.Price;
        entity.Description = dto.Description;
        entity.BrandId = dto.BrandId;
        entity.Model = dto.Model;
        entity.Type = dto.Type;
        entity.Layout = dto.Layout;
        entity.IsWireless = dto.IsWireless;
        entity.HasBacklight = dto.HasBacklight;
        entity.SwitchType = dto.SwitchType;
        entity.Color = dto.Color;
        entity.Weight = dto.Weight;
        entity.Connectivity = dto.Connectivity;
        entity.HasNumericKeypad = dto.HasNumericKeypad;
        entity.IsErgonomic = dto.IsErgonomic;
        entity.KeyCount = dto.KeyCount;
        entity.Warranty = dto.Warranty;
        entity.ReleaseDate = dto.ReleaseDate;
        entity.Rating = dto.Rating;
        entity.InStock = dto.InStock;
        entity.StockQuantity = dto.StockQuantity;

        _context.SaveChanges();
        return dto;
    }

    public bool DeleteKeyboard(int id)
    {
        var entity = _context.Keyboards.FirstOrDefault(k => k.Id == id);
        if (entity is null) return false;

        _context.Keyboards.Remove(entity);
        _context.SaveChanges();
        return true;
    }
}
