using System.Linq;
using SystemCraftAPI.Model;
using SystemCraftAPI.Model.Dtos;
using SystemCraftAPI.Model.Entities;

namespace SystemCraftAPI.Service;

public class ComputerService
{
    private readonly SystemCraftDbContext _context;

    public ComputerService(SystemCraftDbContext context)
    {
        _context = context;
    }

    public ComputerDto AddComputer(ComputerDto dto)
    {
        var entity = new Computer
        {
            Name = dto.Name,
            Price = dto.Price,
            Description = dto.Description,
            BrandId = dto.BrandId,
            Model = dto.Model,
            Processor = dto.Processor,
            RAM = dto.RAM,
            Storage = dto.Storage,
            StorageType = dto.StorageType,
            OperatingSystem = dto.OperatingSystem,
            CaseType = dto.CaseType,
            GraphicsCard = dto.GraphicsCard,
            USBPorts = dto.USBPorts,
            HasHDMI = dto.HasHDMI,
            HasEthernet = dto.HasEthernet,
            HasWiFi = dto.HasWiFi,
            PowerSupply = dto.PowerSupply,
            Warranty = dto.Warranty,
            ReleaseDate = dto.ReleaseDate,
            Rating = dto.Rating,
            InStock = dto.InStock,
            StockQuantity = dto.StockQuantity
        };

        _context.Computers.Add(entity);
        _context.SaveChanges();

        dto.Id = entity.Id;
        return dto;
    }

    public ComputerDto? GetComputerById(int id)
    {
        var entity = _context.Computers.FirstOrDefault(c => c.Id == id);
        if (entity is null) return null;

        return new ComputerDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Price = entity.Price,
            Description = entity.Description,
            BrandId = entity.BrandId,
            Model = entity.Model,
            Processor = entity.Processor,
            RAM = entity.RAM,
            Storage = entity.Storage,
            StorageType = entity.StorageType,
            OperatingSystem = entity.OperatingSystem,
            CaseType = entity.CaseType,
            GraphicsCard = entity.GraphicsCard,
            USBPorts = entity.USBPorts,
            HasHDMI = entity.HasHDMI,
            HasEthernet = entity.HasEthernet,
            HasWiFi = entity.HasWiFi,
            PowerSupply = entity.PowerSupply,
            Warranty = entity.Warranty,
            ReleaseDate = entity.ReleaseDate,
            Rating = entity.Rating,
            InStock = entity.InStock,
            StockQuantity = entity.StockQuantity
        };
    }

    public IEnumerable<ComputerDto> GetAllComputers()
    {
        return _context.Computers
            .Select(entity => new ComputerDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                Description = entity.Description,
                BrandId = entity.BrandId,
                Model = entity.Model,
                Processor = entity.Processor,
                RAM = entity.RAM,
                Storage = entity.Storage,
                StorageType = entity.StorageType,
                OperatingSystem = entity.OperatingSystem,
                CaseType = entity.CaseType,
                GraphicsCard = entity.GraphicsCard,
                USBPorts = entity.USBPorts,
                HasHDMI = entity.HasHDMI,
                HasEthernet = entity.HasEthernet,
                HasWiFi = entity.HasWiFi,
                PowerSupply = entity.PowerSupply,
                Warranty = entity.Warranty,
                ReleaseDate = entity.ReleaseDate,
                Rating = entity.Rating,
                InStock = entity.InStock,
                StockQuantity = entity.StockQuantity
            })
            .ToList();
    }

    public ComputerDto? UpdateComputer(ComputerDto dto)
    {
        var entity = _context.Computers.FirstOrDefault(c => c.Id == dto.Id);
        if (entity is null) return null;

        entity.Name = dto.Name;
        entity.Price = dto.Price;
        entity.Description = dto.Description;
        entity.BrandId = dto.BrandId;
        entity.Model = dto.Model;
        entity.Processor = dto.Processor;
        entity.RAM = dto.RAM;
        entity.Storage = dto.Storage;
        entity.StorageType = dto.StorageType;
        entity.OperatingSystem = dto.OperatingSystem;
        entity.CaseType = dto.CaseType;
        entity.GraphicsCard = dto.GraphicsCard;
        entity.USBPorts = dto.USBPorts;
        entity.HasHDMI = dto.HasHDMI;
        entity.HasEthernet = dto.HasEthernet;
        entity.HasWiFi = dto.HasWiFi;
        entity.PowerSupply = dto.PowerSupply;
        entity.Warranty = dto.Warranty;
        entity.ReleaseDate = dto.ReleaseDate;
        entity.Rating = dto.Rating;
        entity.InStock = dto.InStock;
        entity.StockQuantity = dto.StockQuantity;

        _context.SaveChanges();
        return dto;
    }

    public bool DeleteComputer(int id)
    {
        var entity = _context.Computers.FirstOrDefault(c => c.Id == id);
        if (entity is null) return false;

        _context.Computers.Remove(entity);
        _context.SaveChanges();
        return true;
    }
}
