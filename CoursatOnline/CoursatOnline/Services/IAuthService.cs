using CoursatOnline.Models;

namespace CoursatOnline.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
       Task<AuthModel> GetTokenAsync(TokenRequestModel model);
       
        Task<AuthModel> RefreshTokenAsync(string token);
        Task<bool> RevokeTokenAsync(string token);
    }
}

