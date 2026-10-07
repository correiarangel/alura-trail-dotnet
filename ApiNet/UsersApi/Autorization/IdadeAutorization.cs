using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace UsersApi.Autorization;

public class IdadeAutorization : AuthorizationHandler<IdadeMinima>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IdadeMinima requirement)
    {
        var dateOfBirthClaim = context.User.FindFirst(claim => claim.Type == ClaimTypes.DateOfBirth);
        if (dateOfBirthClaim is null)
        {
            context.Fail();
            return Task.CompletedTask;
        }
        var dateOfBirth = Convert.ToDateTime(dateOfBirthClaim.Value);

        var idade = DateTime.Today.Year - dateOfBirth.Year;

        if (dateOfBirth > dateOfBirth.AddYears(-idade))
            idade--;

        if (idade >= requirement.Idade)
        {
            context.Succeed(requirement);
        }
        else
        {
            context.Fail();
        }

        return Task.CompletedTask;
    }
}