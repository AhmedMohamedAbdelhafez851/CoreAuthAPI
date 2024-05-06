using ApisToFlutter.DTOs;

namespace ApisToFlutter.Services
{
    public interface IAuthenticationService
    {
        Task<string> Register(RegisterRequest request);
        Task<string> Login(LoginRequest request);
    }
}
