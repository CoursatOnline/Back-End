using CoursatOnline.Models;
using CoursatOnline.Data;

namespace CoursatOnline.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model,Roles role);
        

       Task<AuthModel> GetTokenAsync(TokenRequestModel model);//login
     
       
        Task<AuthModel> RefreshTokenAsync(string token);
        Task<bool> RevokeTokenAsync(string token);
    }
}

