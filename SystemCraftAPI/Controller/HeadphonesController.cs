using Microsoft.AspNetCore.Mvc;
using SystemCraftAPI.Model.Dtos;
using SystemCraftAPI.Service;

namespace SystemCraftAPI.Controller;

[Route("api/headphones")]
[ApiController]
public class HeadphonesController : ControllerBase
{
    private readonly HeadphonesService _service;

    public HeadphonesController(HeadphonesService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var items = _service.GetAllHeadphones();
        return Ok(items);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var item = _service.GetHeadphonesById(id);
        return item is null ? NotFound() : Ok(item);
    }

    [HttpPost]
    public IActionResult Create([FromBody] HeadphonesDto dto)
    {
        var created = _service.AddHeadphones(dto);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, [FromBody] HeadphonesDto dto)
    {
        if (dto.Id == 0) dto.Id = id;
        else if (dto.Id != id) return BadRequest("Headphones ID mismatch.");

        var updated = _service.UpdateHeadphones(dto);
        return updated is null ? NotFound() : Ok(updated);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var deleted = _service.DeleteHeadphones(id);
        return deleted ? NoContent() : NotFound();
    }
}
