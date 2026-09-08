namespace backend.Services;

using backend.Models;

public interface ITokenService
{
    string CreateToken(User user);
}