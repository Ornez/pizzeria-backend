using Pizzeria.Modules.Users.Models;

namespace Pizzeria.Modules.Token.Services;

public interface ITokenService
{
    Task<string> CreateToken(AppUser user);
}
