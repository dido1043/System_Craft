using Microsoft.AspNetCore.Mvc;
using SystemCraftAPI.Model.Dtos;
using SystemCraftAPI.Service;

namespace SystemCraftAPI.Controller;

[Route("api/graphics-cards")]
[ApiController]
public class GraphicsCardController : ControllerBase
{
    private readonly GraphicsCardService _service;

    public GraphicsCardController(GraphicsCardService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var items = _service.GetAllGraphicsCards();
        return Ok(items);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var item = _service.GetGraphicsCardById(id);
        return item is null ? NotFound() : Ok(item);
    }

    [HttpPost]
    public IActionResult Create([FromBody] GraphicsCardDto dto)
    {
        var created = _service.AddGraphicsCard(dto);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, [FromBody] GraphicsCardDto dto)
    {
        if (dto.Id == 0) dto.Id = id;
        else if (dto.Id != id) return BadRequest("Graphics card ID mismatch.");

        var updated = _service.UpdateGraphicsCard(dto);
        return updated is null ? NotFound() : Ok(updated);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var deleted = _service.DeleteGraphicsCard(id);
        return deleted ? NoContent() : NotFound();
    }
}
