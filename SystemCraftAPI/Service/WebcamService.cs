using System.Linq;
using SystemCraftAPI.Model;
using SystemCraftAPI.Model.Dtos;
using SystemCraftAPI.Model.Entities;

namespace SystemCraftAPI.Service;

public class WebcamService
{
    private readonly SystemCraftDbContext _context;

    public WebcamService(SystemCraftDbContext context)
    {
        _context = context;
    }

    public WebcamDto AddWebcam(WebcamDto dto)
    {
        var entity = new Webcam
        {
            Name = dto.Name,
            Price = dto.Price,
            Description = dto.Description,
            BrandId = dto.BrandId,
            Model = dto.Model,
            Resolution = dto.Resolution,
            FrameRate = dto.FrameRate,
            LensType = dto.LensType,
            FieldOfView = dto.FieldOfView,
            HasMicrophone = dto.HasMicrophone,
            IsWireless = dto.IsWireless,
            Connectivity = dto.Connectivity,
            HasAutofocus = dto.HasAutofocus,
            HasLED = dto.HasLED,
            Color = dto.Color,
            Weight = dto.Weight,
            Warranty = dto.Warranty,
            ReleaseDate = dto.ReleaseDate,
            Rating = dto.Rating,
            InStock = dto.InStock,
            StockQuantity = dto.StockQuantity
        };

        _context.Webcams.Add(entity);
        _context.SaveChanges();

        dto.Id = entity.Id;
        return dto;
    }

    public WebcamDto? GetWebcamById(int id)
    {
        var entity = _context.Webcams.FirstOrDefault(w => w.Id == id);
        if (entity is null) return null;

        return new WebcamDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Price = entity.Price,
            Description = entity.Description,
            BrandId = entity.BrandId,
            Model = entity.Model,
            Resolution = entity.Resolution,
            FrameRate = entity.FrameRate,
            LensType = entity.LensType,
            FieldOfView = entity.FieldOfView,
            HasMicrophone = entity.HasMicrophone,
            IsWireless = entity.IsWireless,
            Connectivity = entity.Connectivity,
            HasAutofocus = entity.HasAutofocus,
            HasLED = entity.HasLED,
            Color = entity.Color,
            Weight = entity.Weight,
            Warranty = entity.Warranty,
            ReleaseDate = entity.ReleaseDate,
            Rating = entity.Rating,
            InStock = entity.InStock,
            StockQuantity = entity.StockQuantity
        };
    }

    public IEnumerable<WebcamDto> GetAllWebcams()
    {
        return _context.Webcams
            .Select(entity => new WebcamDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                Description = entity.Description,
                BrandId = entity.BrandId,
                Model = entity.Model,
                Resolution = entity.Resolution,
                FrameRate = entity.FrameRate,
                LensType = entity.LensType,
                FieldOfView = entity.FieldOfView,
                HasMicrophone = entity.HasMicrophone,
                IsWireless = entity.IsWireless,
                Connectivity = entity.Connectivity,
                HasAutofocus = entity.HasAutofocus,
                HasLED = entity.HasLED,
                Color = entity.Color,
                Weight = entity.Weight,
                Warranty = entity.Warranty,
                ReleaseDate = entity.ReleaseDate,
                Rating = entity.Rating,
                InStock = entity.InStock,
                StockQuantity = entity.StockQuantity
            })
            .ToList();
    }

    public WebcamDto? UpdateWebcam(WebcamDto dto)
    {
        var entity = _context.Webcams.FirstOrDefault(w => w.Id == dto.Id);
        if (entity is null) return null;

        entity.Name = dto.Name;
        entity.Price = dto.Price;
        entity.Description = dto.Description;
        entity.BrandId = dto.BrandId;
        entity.Model = dto.Model;
        entity.Resolution = dto.Resolution;
        entity.FrameRate = dto.FrameRate;
        entity.LensType = dto.LensType;
        entity.FieldOfView = dto.FieldOfView;
        entity.HasMicrophone = dto.HasMicrophone;
        entity.IsWireless = dto.IsWireless;
        entity.Connectivity = dto.Connectivity;
        entity.HasAutofocus = dto.HasAutofocus;
        entity.HasLED = dto.HasLED;
        entity.Color = dto.Color;
        entity.Weight = dto.Weight;
        entity.Warranty = dto.Warranty;
        entity.ReleaseDate = dto.ReleaseDate;
        entity.Rating = dto.Rating;
        entity.InStock = dto.InStock;
        entity.StockQuantity = dto.StockQuantity;

        _context.SaveChanges();
        return dto;
    }

    public bool DeleteWebcam(int id)
    {
        var entity = _context.Webcams.FirstOrDefault(w => w.Id == id);
        if (entity is null) return false;

        _context.Webcams.Remove(entity);
        _context.SaveChanges();
        return true;
    }
}
