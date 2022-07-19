using CoursatOnline.Data;
using CoursatOnline.helpers;
using CoursatOnline.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CoursatOnline.Services
{
    public class AuthService : IAuthService
    {
        public AuthService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager,
            IOptions<JWT> jwt, CoursatOnlineDbContext coursatOnlineDbContext)
        {
            _userManager = userManager;
            _jwt = jwt.Value;
            _coursatOnlineDbContext = coursatOnlineDbContext;
        }
        CoursatOnlineDbContext _coursatOnlineDbContext; //=new CoursatOnlineDbContext();
        private readonly UserManager<ApplicationUser> _userManager;//
        private readonly JWT _jwt;

        //register student
        public async Task<AuthModel> RegisterAsync(RegisterModel model,Roles role)
        {
            if (await _userManager.FindByEmailAsync(model.Email) is not null)
                return new AuthModel { Message = "Email is already registered!" };

            if (await _userManager.FindByNameAsync(model.Username) is not null)
                return new AuthModel { Message = "Username is already registered!" };

            var user = new ApplicationUser
            {

                UserName = model.Username,
                Email = model.Email,
                First_Name = model.FirstName,
                Last_Name = model.LastName
            };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                var errors = string.Empty;

                foreach (var error in result.Errors)
                    errors += $"{error.Description},";

                return new AuthModel { Message = errors };
            }
            await _userManager.AddToRoleAsync(user, role.ToString());

            var jwtSecurityToken = await CreateJwtToken(user);


            await _userManager.UpdateAsync(user);

            
            //admin 0
            if (role == Roles.Admin)
            {
                _coursatOnlineDbContext.Admin.Add(new Admin
            {

                     Email = model.Email,
                    User_Name = model.Username,
                    Last_Name = model.LastName,
                    First_Name = model.FirstName,
                    Password = model.Password,

                });
                _coursatOnlineDbContext.SaveChanges();

                return new AuthModel
                {
                    Email = user.Email,
                    ExpiresOn = jwtSecurityToken.ValidTo,
                    IsAuthenticated = true,
                    Roles = new List<string> { "Admin" },
                    Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                    Username = user.UserName,

                };

            }
            //instructor 1
            if (role == Roles.Instructor)
            {
                _coursatOnlineDbContext.Instructor.Add(new Instructor
                {

                    Email = model.Email,
                    User_Name = model.Username,
                    Last_Name = model.LastName,
                    First_Name = model.FirstName,
                    Password = model.Password,

                });
                _coursatOnlineDbContext.SaveChanges();

                return new AuthModel
                {
                    Email = user.Email,
                    ExpiresOn = jwtSecurityToken.ValidTo,
                    IsAuthenticated = true,
                    Roles = new List<string> { "Instructor" },
                    Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                    Username = user.UserName,

                };

            }

            //student 2
            if (role == Roles.Student)
            {
                 
                _coursatOnlineDbContext.Student.Add(new Student
                {
                    
                    Email = model.Email,
                    User_Name = model.Username,
                    Last_Name = model.LastName,
                    First_Name = model.FirstName,
                    Password = model.Password,

                });
                int rows = _coursatOnlineDbContext.SaveChanges();
                Student? std = _coursatOnlineDbContext.Student.FirstOrDefault(s => s.Email == model.Email);
                if (rows > 0 && std!=null)
                {
                    int stdId = std.Id;
                    Cart cart = new Cart();
                    cart.StdId = stdId;
                    cart.Discount = 0;
                    cart.TotalPrice = 0;
                    _coursatOnlineDbContext.Cart.Add(cart);
                    _coursatOnlineDbContext.SaveChanges();
                }


                return new AuthModel
                {
                    Email = user.Email,
                    ExpiresOn = jwtSecurityToken.ValidTo,
                    IsAuthenticated = true,
                    Roles = new List<string> { "Student" },
                    Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                    Username = user.UserName,

                };

            }




            //return new AuthModel
            //{
            //    Email = user.Email,
            //    ExpiresOn = jwtSecurityToken.ValidTo,
            //    IsAuthenticated = true,
            //    Roles = new List<string> { "Admin" },//Instructor
            //    Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
            //    Username = user.UserName,

            //};
            return null;

        }
        


           
       
        //login
        public async Task<AuthModel> GetTokenAsync(TokenRequestModel model)
        {
            var authModel = new AuthModel();
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user is null || !await _userManager.CheckPasswordAsync(user, model.Password))
            {
                authModel.Message = "Email or Password is incorrect!";
                return authModel;
            }

            var jwtSecurityToken = await CreateJwtToken(user);//
            var rolesList = await _userManager.GetRolesAsync(user);

            authModel.IsAuthenticated = true;
            authModel.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);//
            authModel.Email = user.Email;
            authModel.Username = user.UserName;
            authModel.ExpiresOn = jwtSecurityToken.ValidTo;
            authModel.Roles = rolesList.ToList();

            return authModel;
        }

        private async Task<JwtSecurityToken> CreateJwtToken(ApplicationUser user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);
            var roleClaims = new List<Claim>();

            foreach (var role in roles)
                roleClaims.Add(new Claim("roles", role));

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id)
                //jwt.claim(name: "role_id").rawValue as? String
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwt.Issuer,
                audience: _jwt.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwt.DurationInMinutes),
                signingCredentials: signingCredentials);

            return jwtSecurityToken;
        }

        public Task<AuthModel> RefreshTokenAsync(string token)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RevokeTokenAsync(string token)
        {
            throw new NotImplementedException();
        }
    }
}

