using Microsoft.AspNetCore.Mvc;
using SystemCraftAPI.Model.Dtos;
using SystemCraftAPI.Service;

namespace SystemCraftAPI.Controller;

[Route("api/brands")]
[ApiController]
public class BrandController : ControllerBase
{
    private readonly BrandService _service;

    public BrandController(BrandService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var items = _service.GetAllBrands();
        return Ok(items);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var item = _service.GetBrandById(id);
        return item is null ? NotFound() : Ok(item);
    }

    [HttpPost]
    public IActionResult Create([FromBody] BrandDto dto)
    {
        var created = _service.AddBrand(dto);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, [FromBody] BrandDto dto)
    {
        if (dto.Id == 0) dto.Id = id;
        else if (dto.Id != id) return BadRequest("Brand ID mismatch.");

        var updated = _service.UpdateBrand(dto);
        return updated is null ? NotFound() : Ok(updated);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var deleted = _service.DeleteBrand(id);
        return deleted ? NoContent() : NotFound();
    }
}
