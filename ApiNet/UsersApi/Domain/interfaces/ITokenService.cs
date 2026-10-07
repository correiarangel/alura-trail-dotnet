using UsersApi.Domain.Models;

namespace UsersApi.Domain.interfaces;

public interface ITokenService
{
    string GenerateToken(User user);
}
