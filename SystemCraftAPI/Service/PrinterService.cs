using System.Linq;
using SystemCraftAPI.Model;
using SystemCraftAPI.Model.Dtos;
using SystemCraftAPI.Model.Entities;

namespace SystemCraftAPI.Service;

public class PrinterService
{
    private readonly SystemCraftDbContext _context;

    public PrinterService(SystemCraftDbContext context)
    {
        _context = context;
    }

    public PrinterDto AddPrinter(PrinterDto dto)
    {
        var entity = new Printer
        {
            Name = dto.Name,
            Price = dto.Price,
            Description = dto.Description,
            BrandId = dto.BrandId,
            Model = dto.Model,
            Type = dto.Type,
            PrintTechnology = dto.PrintTechnology,
            PrintSpeed = dto.PrintSpeed,
            Resolution = dto.Resolution,
            IsWireless = dto.IsWireless,
            Connectivity = dto.Connectivity,
            HasScanner = dto.HasScanner,
            HasCopier = dto.HasCopier,
            PaperSize = dto.PaperSize,
            DutyCycle = dto.DutyCycle,
            Warranty = dto.Warranty,
            ReleaseDate = dto.ReleaseDate,
            Rating = dto.Rating,
            InStock = dto.InStock,
            StockQuantity = dto.StockQuantity
        };

        _context.Printers.Add(entity);
        _context.SaveChanges();

        dto.Id = entity.Id;
        return dto;
    }

    public PrinterDto? GetPrinterById(int id)
    {
        var entity = _context.Printers.FirstOrDefault(p => p.Id == id);
        if (entity is null) return null;

        return new PrinterDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Price = entity.Price,
            Description = entity.Description,
            BrandId = entity.BrandId,
            Model = entity.Model,
            Type = entity.Type,
            PrintTechnology = entity.PrintTechnology,
            PrintSpeed = entity.PrintSpeed,
            Resolution = entity.Resolution,
            IsWireless = entity.IsWireless,
            Connectivity = entity.Connectivity,
            HasScanner = entity.HasScanner,
            HasCopier = entity.HasCopier,
            PaperSize = entity.PaperSize,
            DutyCycle = entity.DutyCycle,
            Warranty = entity.Warranty,
            ReleaseDate = entity.ReleaseDate,
            Rating = entity.Rating,
            InStock = entity.InStock,
            StockQuantity = entity.StockQuantity
        };
    }

    public IEnumerable<PrinterDto> GetAllPrinters()
    {
        return _context.Printers
            .Select(entity => new PrinterDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                Description = entity.Description,
                BrandId = entity.BrandId,
                Model = entity.Model,
                Type = entity.Type,
                PrintTechnology = entity.PrintTechnology,
                PrintSpeed = entity.PrintSpeed,
                Resolution = entity.Resolution,
                IsWireless = entity.IsWireless,
                Connectivity = entity.Connectivity,
                HasScanner = entity.HasScanner,
                HasCopier = entity.HasCopier,
                PaperSize = entity.PaperSize,
                DutyCycle = entity.DutyCycle,
                Warranty = entity.Warranty,
                ReleaseDate = entity.ReleaseDate,
                Rating = entity.Rating,
                InStock = entity.InStock,
                StockQuantity = entity.StockQuantity
            })
            .ToList();
    }

    public PrinterDto? UpdatePrinter(PrinterDto dto)
    {
        var entity = _context.Printers.FirstOrDefault(p => p.Id == dto.Id);
        if (entity is null) return null;

        entity.Name = dto.Name;
        entity.Price = dto.Price;
        entity.Description = dto.Description;
        entity.BrandId = dto.BrandId;
        entity.Model = dto.Model;
        entity.Type = dto.Type;
        entity.PrintTechnology = dto.PrintTechnology;
        entity.PrintSpeed = dto.PrintSpeed;
        entity.Resolution = dto.Resolution;
        entity.IsWireless = dto.IsWireless;
        entity.Connectivity = dto.Connectivity;
        entity.HasScanner = dto.HasScanner;
        entity.HasCopier = dto.HasCopier;
        entity.PaperSize = dto.PaperSize;
        entity.DutyCycle = dto.DutyCycle;
        entity.Warranty = dto.Warranty;
        entity.ReleaseDate = dto.ReleaseDate;
        entity.Rating = dto.Rating;
        entity.InStock = dto.InStock;
        entity.StockQuantity = dto.StockQuantity;

        _context.SaveChanges();
        return dto;
    }

    public bool DeletePrinter(int id)
    {
        var entity = _context.Printers.FirstOrDefault(p => p.Id == id);
        if (entity is null) return false;

        _context.Printers.Remove(entity);
        _context.SaveChanges();
        return true;
    }
}
