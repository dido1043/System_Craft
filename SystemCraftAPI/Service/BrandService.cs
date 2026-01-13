using System.Linq;
using SystemCraftAPI.Model;
using SystemCraftAPI.Model.Dtos;
using SystemCraftAPI.Model.Entities;

namespace SystemCraftAPI.Service;

public class BrandService
{
    private readonly SystemCraftDbContext _context;

    public BrandService(SystemCraftDbContext context)
    {
        _context = context;
    }

    public BrandDto AddBrand(BrandDto dto)
    {
        var entity = new Brand
        {
            Name = dto.Name,
            Country = dto.Country,
            Website = dto.Website
        };

        _context.Brands.Add(entity);
        _context.SaveChanges();

        dto.Id = entity.Id;
        return dto;
    }

    public BrandDto? GetBrandById(int id)
    {
        var entity = _context.Brands.FirstOrDefault(b => b.Id == id);
        if (entity is null) return null;

        return new BrandDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Country = entity.Country,
            Website = entity.Website
        };
    }

    public IEnumerable<BrandDto> GetAllBrands()
    {
        return _context.Brands
            .Select(entity => new BrandDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Country = entity.Country,
                Website = entity.Website
            })
            .ToList();
    }

    public BrandDto? UpdateBrand(BrandDto dto)
    {
        var entity = _context.Brands.FirstOrDefault(b => b.Id == dto.Id);
        if (entity is null) return null;

        entity.Name = dto.Name;
        entity.Country = dto.Country;
        entity.Website = dto.Website;

        _context.SaveChanges();
        return dto;
    }

    public bool DeleteBrand(int id)
    {
        var entity = _context.Brands.FirstOrDefault(b => b.Id == id);
        if (entity is null) return false;

        _context.Brands.Remove(entity);
        _context.SaveChanges();
        return true;
    }
}
