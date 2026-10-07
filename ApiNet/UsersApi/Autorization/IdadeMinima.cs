using Microsoft.AspNetCore.Authorization;

namespace UsersApi.Autorization;

public class IdadeMinima(int idade) : IAuthorizationRequirement
{
    public int Idade { get; set; } = idade;
}
