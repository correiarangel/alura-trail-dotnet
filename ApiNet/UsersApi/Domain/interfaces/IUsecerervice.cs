using UsersApi.Data.Dtos;
using UsersApi.Domain.Models;

namespace UsersApi.Domain.interfaces;

public interface IUserService
{
    Task CreateUserAsync(CreateUserDto createUserDto);
    Task<UserResponse?> GetUserByIdAsync(string userId);
    Task<string> Login(LoginDto loginDto);
    //Task<bool> UpdateUserAsync(string userId, UpdateUserDto updateUserDto);
    Task<bool> DeleteUserAsync(string userId);
}
