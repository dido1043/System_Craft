using Microsoft.AspNetCore.Mvc;
using SystemCraftAPI.Model.Dtos;
using SystemCraftAPI.Service;

namespace SystemCraftAPI.Controller;

[Route("api/mice")]
[ApiController]
public class MouseController : ControllerBase
{
    private readonly MouseService _service;

    public MouseController(MouseService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var items = _service.GetAllMice();
        return Ok(items);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var item = _service.GetMouseById(id);
        return item is null ? NotFound() : Ok(item);
    }

    [HttpPost]
    public IActionResult Create([FromBody] MouseDto dto)
    {
        var created = _service.AddMouse(dto);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, [FromBody] MouseDto dto)
    {
        if (dto.Id == 0) dto.Id = id;
        else if (dto.Id != id) return BadRequest("Mouse ID mismatch.");

        var updated = _service.UpdateMouse(dto);
        return updated is null ? NotFound() : Ok(updated);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var deleted = _service.DeleteMouse(id);
        return deleted ? NoContent() : NotFound();
    }
}
