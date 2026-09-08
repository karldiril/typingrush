namespace backend.Controllers;

using Microsoft.AspNetCore.Mvc;
using backend.Services;
using backend.DTOs;
using backend.Models;

[ApiController]
[Route("api/[controller]")]

public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }


    [HttpPost("login")]

    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        string? token = await _authService.LoginAsync(loginDto);

        if (token == null)
        {
            return Unauthorized("Identifiants invalides");
        }
        return Ok(new
        {
            Token = token,
            Message = "connexion réussie"
        });
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto registerDto)
    {
        User? user = await _authService.RegisterAsync(registerDto);

        if (user == null)
        {
            return BadRequest(new { Message = "Données invalides ou email déjà utilisé."});
        }

        return Ok(new { Message = "Inscription réussie. "});
    }
}