using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BCrypt.Net;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SystemCraftAPI.Model;
using SystemCraftAPI.Model.Dtos;
using SystemCraftAPI.Model.Entities;

namespace SystemCraftAPI.Service;

public class AuthService
{
    private readonly SystemCraftDbContext _context;
    private readonly IConfiguration _configuration;

    public AuthService(SystemCraftDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    public AuthResponseDto? Register(UserRegisterDto dto)
    {
        var existing = _context.Users.FirstOrDefault(u => u.Email == dto.Email);
        if (existing != null) return null;

        var user = new User
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email,
            Password = BCrypt.Net.BCrypt.HashPassword(dto.Password)
        };

        _context.Users.Add(user);
        _context.SaveChanges();

        var token = GenerateJwt(user);
        return new AuthResponseDto
        {
            UserId = user.Id,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Token = token
        };
    }

    public AuthResponseDto? Login(UserLoginDto dto)
    {
        var user = _context.Users.FirstOrDefault(u => u.Email == dto.Email);
        if (user == null) return null;

        var valid = BCrypt.Net.BCrypt.Verify(dto.Password, user.Password);
        if (!valid) return null;

        var token = GenerateJwt(user);
        return new AuthResponseDto
        {
            UserId = user.Id,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Token = token
        };
    }
 

    private string GenerateJwt(User user)
    {
        var key = _configuration["Jwt:Key"] ?? string.Empty;
        var issuer = _configuration["Jwt:Issuer"];
        var audience = _configuration["Jwt:Audience"];
        var expireMinutes = int.TryParse(_configuration["Jwt:ExpireMinutes"], out var minutes) ? minutes : 120;

        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.Email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.Email),
            new Claim("firstName", user.FirstName),
            new Claim("lastName", user.LastName)
        };

        var token = new JwtSecurityToken(
            issuer: issuer,
            audience: audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(expireMinutes),
            signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
