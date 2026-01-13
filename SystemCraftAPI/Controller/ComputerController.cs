using Microsoft.AspNetCore.Mvc;
using SystemCraftAPI.Model.Dtos;
using SystemCraftAPI.Service;

namespace SystemCraftAPI.Controller;

[Route("api/computers")]
[ApiController]
public class ComputerController : ControllerBase
{
    private readonly ComputerService _computerService;

    public ComputerController(ComputerService computerService)
    {
        _computerService = computerService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var items = _computerService.GetAllComputers();
        return Ok(items);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var item = _computerService.GetComputerById(id);
        return item is null ? NotFound() : Ok(item);
    }

    [HttpPost]
    public IActionResult Create([FromBody] ComputerDto dto)
    {
        var created = _computerService.AddComputer(dto);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, [FromBody] ComputerDto dto)
    {
        if (dto.Id == 0) dto.Id = id;
        else if (dto.Id != id) return BadRequest("Computer ID mismatch.");

        var updated = _computerService.UpdateComputer(dto);
        return updated is null ? NotFound() : Ok(updated);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var deleted = _computerService.DeleteComputer(id);
        return deleted ? NoContent() : NotFound();
    }
}
