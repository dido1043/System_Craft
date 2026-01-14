using Microsoft.AspNetCore.Mvc;
using SystemCraftAPI.Model.Dtos;
using SystemCraftAPI.Service;

namespace SystemCraftAPI.Controller;

[Route("api/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public IActionResult Register([FromBody] UserRegisterDto dto)
    {
        var result = _authService.Register(dto);
        if (result == null) return Conflict("Email already registered.");
        return Ok(result);
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] UserLoginDto dto)
    {
        var result = _authService.Login(dto);
        if (result == null) return Unauthorized();
        return Ok(result);
    }

    [HttpGet("current-user")]
    public IActionResult GetCurrentUser([FromQuery] int userId)
    {
        var user = _authService.GetUserById(userId);
        return user == null ? NotFound() : Ok(user);
    }

    [HttpGet("find-by-email")]
    public IActionResult GetUserByEmail([FromQuery] string email)
    {
        var user = _authService.GetUserByEmail(email);
        return user == null ? NotFound() : Ok(user);
    }
}
