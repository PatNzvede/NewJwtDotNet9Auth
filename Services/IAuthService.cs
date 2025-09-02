using NewJwtDotNet9Auth.Entities;
using NewJwtDotNet9Auth.Models;

namespace NewJwtDotNet9Auth.Services
{
    public interface IAuthService
    {
       Task<User?> RegisterAsync(UserDto request);
        Task<TokenResponseDto?> LoginAsync(UserDto request);
//        Task<User?> ValidateRefreshTokenAsync(Guid userId, string refreshToken);
        Task<TokenResponseDto?> RefreshTokenAsync(RefreshTokenRequestDto request); 

    }
}
