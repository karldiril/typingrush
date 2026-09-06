namespace backend.Services;
using backend.Models;
using backend.DTOs;

public interface IAuthService
{
    Task<User?> RegisterAsync(RegisterDto registerDto);
    Task<string?> LoginAsync(LoginDto loginDto);
}