using System;
using SystemCraftAPI.Model;
using SystemCraftAPI.Model.Dtos;
using SystemCraftAPI.Model.Entities;

namespace SystemCraftAPI.Service;


public class LaptopService
{
    private readonly SystemCraftDbContext _context;
    public LaptopService(SystemCraftDbContext context)
    {
        _context = context;
    }

    public LaptopDto AddLaptop(LaptopDto laptopDto)
    {
        var laptop = new Laptop
        {
            Name = laptopDto.Name,
            Price = laptopDto.Price,
            Description = laptopDto.Description,
            BrandId = laptopDto.BrandId,
            Model = laptopDto.Model,
            Processor = laptopDto.Processor,
            RAM = laptopDto.RAM,
            Storage = laptopDto.Storage,
            StorageType = laptopDto.StorageType,
            ScreenSize = laptopDto.ScreenSize,
            Resolution = laptopDto.Resolution,
            OperatingSystem = laptopDto.OperatingSystem,
            BatteryLife = laptopDto.BatteryLife,
            Weight = laptopDto.Weight,
            Color = laptopDto.Color,
            HasTouchscreen = laptopDto.HasTouchscreen,
            HasBacklitKeyboard = laptopDto.HasBacklitKeyboard,
            GraphicsCard = laptopDto.GraphicsCard,
            USBPorts = laptopDto.USBPorts,
            HasHDMI = laptopDto.HasHDMI,
            HasEthernet = laptopDto.HasEthernet,
            Warranty = laptopDto.Warranty,
            ReleaseDate = laptopDto.ReleaseDate,
            Rating = laptopDto.Rating,
            InStock = laptopDto.InStock,
            StockQuantity = laptopDto.StockQuantity
        };

        _context.Laptops.Add(laptop);
        _context.SaveChanges();

        laptopDto.Id = laptop.Id;
        return laptopDto;


    }
    public LaptopDto? GetLaptopById(int id)
    {
        var laptop = _context.Laptops.FirstOrDefault(l => l.Id == id);
        if (laptop == null) return null;

        return new LaptopDto
        {
            Id = laptop.Id,
            Name = laptop.Name,
            Price = laptop.Price,
            Description = laptop.Description,
            BrandId = laptop.BrandId,
            Model = laptop.Model,
            Processor = laptop.Processor,
            RAM = laptop.RAM,
            Storage = laptop.Storage,
            StorageType = laptop.StorageType,
            ScreenSize = laptop.ScreenSize,
            Resolution = laptop.Resolution,
            OperatingSystem = laptop.OperatingSystem,
            BatteryLife = laptop.BatteryLife,
            Weight = laptop.Weight,
            Color = laptop.Color,
            HasTouchscreen = laptop.HasTouchscreen,
            HasBacklitKeyboard = laptop.HasBacklitKeyboard,
            GraphicsCard = laptop.GraphicsCard,
            USBPorts = laptop.USBPorts,
            HasHDMI = laptop.HasHDMI,
            HasEthernet = laptop.HasEthernet,
            Warranty = laptop.Warranty,
            ReleaseDate = laptop.ReleaseDate,
            Rating = laptop.Rating,
            InStock = laptop.InStock,
            StockQuantity = laptop.StockQuantity
        };
    }

    public IEnumerable<LaptopDto> GetAllLaptops()
    {
        return _context.Laptops
            .Select(l => new LaptopDto
            {
                Id = l.Id,
                Name = l.Name,
                Price = l.Price,
                Description = l.Description,
                BrandId = l.BrandId,
                Model = l.Model,
                Processor = l.Processor,
                RAM = l.RAM,
                Storage = l.Storage,
                StorageType = l.StorageType,
                ScreenSize = l.ScreenSize,
                Resolution = l.Resolution,
                OperatingSystem = l.OperatingSystem,
                BatteryLife = l.BatteryLife,
                Weight = l.Weight,
                Color = l.Color,
                HasTouchscreen = l.HasTouchscreen,
                HasBacklitKeyboard = l.HasBacklitKeyboard,
                GraphicsCard = l.GraphicsCard,
                USBPorts = l.USBPorts,
                HasHDMI = l.HasHDMI,
                HasEthernet = l.HasEthernet,
                Warranty = l.Warranty,
                ReleaseDate = l.ReleaseDate,
                Rating = l.Rating,
                InStock = l.InStock,
                StockQuantity = l.StockQuantity
            })
            .ToList();
    }

    public LaptopDto? UpdateLaptop(LaptopDto laptopDto)
    {
        var laptop = _context.Laptops.FirstOrDefault(l => l.Id == laptopDto.Id);
        if (laptop == null) return null;

        laptop.Name = laptopDto.Name;
        laptop.Price = laptopDto.Price;
        laptop.Description = laptopDto.Description;
        laptop.BrandId = laptopDto.BrandId;
        laptop.Model = laptopDto.Model;
        laptop.Processor = laptopDto.Processor;
        laptop.RAM = laptopDto.RAM;
        laptop.Storage = laptopDto.Storage;
        laptop.StorageType = laptopDto.StorageType;
        laptop.ScreenSize = laptopDto.ScreenSize;
        laptop.Resolution = laptopDto.Resolution;
        laptop.OperatingSystem = laptopDto.OperatingSystem;
        laptop.BatteryLife = laptopDto.BatteryLife;
        laptop.Weight = laptopDto.Weight;
        laptop.Color = laptopDto.Color;
        laptop.HasTouchscreen = laptopDto.HasTouchscreen;
        laptop.HasBacklitKeyboard = laptopDto.HasBacklitKeyboard;
        laptop.GraphicsCard = laptopDto.GraphicsCard;
        laptop.USBPorts = laptopDto.USBPorts;
        laptop.HasHDMI = laptopDto.HasHDMI;
        laptop.HasEthernet = laptopDto.HasEthernet;
        laptop.Warranty = laptopDto.Warranty;
        laptop.ReleaseDate = laptopDto.ReleaseDate;
        laptop.Rating = laptopDto.Rating;
        laptop.InStock = laptopDto.InStock;
        laptop.StockQuantity = laptopDto.StockQuantity;

        _context.SaveChanges();
        return laptopDto;
    }

    public bool DeleteLaptop(int id)
    {
        var laptop = _context.Laptops.FirstOrDefault(l => l.Id == id);
        if (laptop == null) return false;

        _context.Laptops.Remove(laptop);
        _context.SaveChanges();
        return true;
    }
}
