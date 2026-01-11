using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SystemCraftAPI.Service;
using SystemCraftAPI.Model.Dtos;

namespace SystemCraftAPI.Controller
{
    [Route("api/laptops")]
    [ApiController]
    public class LaptopController : ControllerBase
    {
        private readonly LaptopService _laptopService;

        public LaptopController(LaptopService laptopService)
        {
            _laptopService = laptopService;
        }

        [HttpGet("/all-laptops")]
        public IActionResult GetLaptops()
        {
            var laptops = _laptopService.GetAllLaptops();
            return Ok(laptops);
        }

        [HttpGet("/laptop/{id:int}")]
        public IActionResult GetLaptopById(int id)
        {
            var laptop = _laptopService.GetLaptopById(id);
            if (laptop == null) return NotFound();

            return Ok(laptop);
        }

        [HttpPost("/add-laptop")]
        public IActionResult AddLaptop([FromBody] LaptopDto laptopDto)
        {
            var addedLaptop = _laptopService.AddLaptop(laptopDto);
            return CreatedAtAction(nameof(GetLaptops), new { id = addedLaptop.Id }, addedLaptop);
        }

        [HttpPut("/update-laptop/{id:int}")]
        public IActionResult UpdateLaptop(int id, [FromBody] LaptopDto laptopDto)
        {
            if (laptopDto.Id == 0)
            {
                laptopDto.Id = id;
            }
            else if (laptopDto.Id != id)
            {
                return BadRequest("Laptop ID mismatch.");
            }

            var updatedLaptop = _laptopService.UpdateLaptop(laptopDto);
            if (updatedLaptop == null) return NotFound();

            return Ok(updatedLaptop);
        }

        [HttpDelete("/delete-laptop/{id:int}")]
        public IActionResult DeleteLaptop(int id)
        {
            var deleted = _laptopService.DeleteLaptop(id);
            if (!deleted) return NotFound();

            return NoContent();
        }

    }
}
