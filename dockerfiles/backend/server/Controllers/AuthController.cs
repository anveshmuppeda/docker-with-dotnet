// AuthController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Models;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _context;

    public AuthController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("signup")]
    public async Task<IActionResult> SignUp(UserCredentials credentials)
    {
        if (await _context.Users.AnyAsync(u => u.Username == credentials.Username))
            return Conflict("User already exists");

        var newUser = new User { Username = credentials.Username, PasswordHash = HashPassword(credentials.Password) };
        _context.Users.Add(newUser);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(UserCredentials credentials)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == credentials.Username);
        if (user == null || !VerifyPassword(credentials.Password, user.PasswordHash))
            return Unauthorized();

        //  JWT token 
        return Ok();
    }

    private string HashPassword(string password)
    {
        
        return password;
    }

    private bool VerifyPassword(string password, string passwordHash)
    {
        
        return password == passwordHash; 
    }
}
