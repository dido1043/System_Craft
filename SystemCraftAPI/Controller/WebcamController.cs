using Microsoft.AspNetCore.Mvc;
using SystemCraftAPI.Model.Dtos;
using SystemCraftAPI.Service;

namespace SystemCraftAPI.Controller;

[Route("api/webcams")]
[ApiController]
public class WebcamController : ControllerBase
{
    private readonly WebcamService _service;

    public WebcamController(WebcamService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var items = _service.GetAllWebcams();
        return Ok(items);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var item = _service.GetWebcamById(id);
        return item is null ? NotFound() : Ok(item);
    }

    [HttpPost]
    public IActionResult Create([FromBody] WebcamDto dto)
    {
        var created = _service.AddWebcam(dto);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, [FromBody] WebcamDto dto)
    {
        if (dto.Id == 0) dto.Id = id;
        else if (dto.Id != id) return BadRequest("Webcam ID mismatch.");

        var updated = _service.UpdateWebcam(dto);
        return updated is null ? NotFound() : Ok(updated);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var deleted = _service.DeleteWebcam(id);
        return deleted ? NoContent() : NotFound();
    }
}
