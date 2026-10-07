using System.Globalization;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsersApi.Data.Dtos;
using UsersApi.Domain.interfaces;
using UsersApi.Domain.Models;

namespace UsersApi.Services;

public class UserService(UserManager<User> userManager, IMapper mapper, SignInManager<User> signInManager, ITokenService tokenService) : IUserService
{
    private readonly UserManager<User> _userManager = userManager;
    private readonly IMapper _mapper = mapper;
    private readonly SignInManager<User> _signInManager = signInManager;
    private readonly ITokenService _tokenService = tokenService;

    public Task<bool> DeleteUserAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public async Task<UserResponse?> GetUserByIdAsync(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user is null)
        {
            return null;
        }

        return _mapper.Map<UserResponse>(user);
    }

    public async Task CreateUserAsync(CreateUserDto createUserDto)
    {
        var user = _mapper.Map<User>(createUserDto);
        user.DateOfBirth = DateTime.Parse(createUserDto.DateOfBirth);

        if (!TryParseDateOfBirth(createUserDto.DateOfBirth, out var dateOfBirthUtc))
        {
            throw new ArgumentException("Formato de dateOfBirth inválido. Use yyyy-MM-dd, dd-MM-yyyy ou MM-yyyy-dd");
        }
        user.DateOfBirth = dateOfBirthUtc;

        user.DateOfBirth = dateOfBirthUtc;
        var result = await _userManager.CreateAsync(user, createUserDto.Password);

        if (!result.Succeeded)
        {
            var errors = result.Errors.Select(e => e.Description).ToList();
            throw new ApplicationException($"Erro ao criar usuário: {string.Join(", ", errors)}");
        }
    }

    private static bool TryParseDateOfBirth(string value, out DateTime utcDate)
    {
        utcDate = default;
        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        var formats = new[]
        {
                "yyyy-MM-dd",
                "yyyy-MM-ddTHH:mm:ssZ",
                "dd-MM-yyyy",
                "MM-yyyy-dd",
                "MM-dd-yyyy"
            };

        if (DateTime.TryParseExact(value, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsed))
        {
            utcDate = DateTime.SpecifyKind(parsed, DateTimeKind.Utc);
            return true;
        }

        if (DateTime.TryParse(value, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal, out parsed))
        {
            utcDate = DateTime.SpecifyKind(parsed, DateTimeKind.Utc);
            return true;
        }

        return false;
    }

    public async Task<string> Login(LoginDto loginDto)
    {
        var result = await _signInManager.PasswordSignInAsync(loginDto.Username, loginDto.Password, false, false);

        if (!result.Succeeded)
            throw new ApplicationException("Falha no login. Verifique as credenciais.");

      /*  var user = _signInManager
                    .UserManager      isso da erro errado mané
                    .Users
                    .FirstOrDefault(user => user.UserName.Normalize() == loginDto.Username.ToUpper());*/
       
        var user = await _signInManager.UserManager.FindByNameAsync(loginDto.Username);
        if (user is null)
        {
            throw new ApplicationException("Usuário não encontrado após a autenticação.");
        }

        var token = _tokenService.GenerateToken(user);
        return token;

    }
}