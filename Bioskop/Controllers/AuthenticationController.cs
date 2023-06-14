using Bioskop.Models.Login;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Bioskop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        public AuthenticationController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }
        
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(RegistrationDTO model)
        {
            var user = new ApplicationUser
            {
                UserName = model.Username,
                Email = model.Email,
                RegistrationDate = DateTime.Now // Set registration date according to your logic
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "customer");

                return Ok();
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginDTO model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var roles = await _userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var role in roles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, role));
                }

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["Jwt:Issuer"],
                    audience: _configuration["Jwt:Audience"],
                    expires: DateTime.Now.AddDays(7), // Set token expiration according to your needs
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

                return Ok(new
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Expiration = token.ValidTo
                });
            }
            else
            {
                return Unauthorized();
            }
        }
        //private readonly UserManager<ApplicationUser> userManager;
        //private readonly IConfiguration _configuration;

        //public AuthenticationController(UserManager<ApplicationUser> userManager, IConfiguration configuration)
        //{
        //    this.userManager = userManager;
        //    _configuration = configuration;
        //}

        //[HttpPost]
        //[Route("login")]
        //public IActionResult Login([FromBody] LoginDTO model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest("Login parameters invalid.");
        //    }
        //    var user = userManager.FindByNameAsync(model.Username).GetAwaiter().GetResult();
        //    if (user != null && userManager.CheckPasswordAsync(user, model.Password).GetAwaiter().GetResult())
        //    {

        //        var authClaims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name, user.UserName),
        //            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //        };

        //        var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

        //        var token = new JwtSecurityToken(
        //            issuer: _configuration["Jwt:Issuer"],
        //            audience: _configuration["Jwt:Audience"],
        //            expires: DateTime.Now.AddHours(2),      // token valid for 2 hours
        //            claims: authClaims,
        //            signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
        //        );

        //        return Ok(new TokenDTO()
        //        {
        //            Username = user.UserName,
        //            Token = new JwtSecurityTokenHandler().WriteToken(token),
        //            Expiration = token.ValidTo
        //        });
        //    }
        //    return Unauthorized();
        //}

        ////[HttpPost]
        ////[Route("register")]
        ////public IActionResult Register([FromBody] RegistrationDTO model)
        ////{
        ////    if (!ModelState.IsValid)
        ////    {
        ////        return BadRequest("Registration parameters invalid.");
        ////    }

        ////    var userExists = userManager.FindByNameAsync(model.Username).GetAwaiter().GetResult();
        ////    if (userExists != null)
        ////    {
        ////        return BadRequest("User already exists");
        ////    }

        ////    ApplicationUser user;
        ////    if (/* Check if the user is an administrator based on your app's logic */)
        ////    {
        ////        user = new ApplicationUser
        ////        {
        ////            //Email = model.Email,
        ////            SecurityStamp = Guid.NewGuid().ToString(),
        ////            UserName = model.Username
        ////        };

        ////        var result = userManager.CreateAsync(user, model.Password).GetAwaiter().GetResult();
        ////        if (!result.Succeeded)
        ////        {
        ////            return BadRequest("Validation failed! Please check user details and try again.");
        ////        }

        ////        userManager.AddToRoleAsync(user, "Administrator").GetAwaiter().GetResult();
        ////    }
        ////    else
        ////    {
        ////        user = new ApplicationUser
        ////        {
        ////            //Email = model.Email,
        ////            SecurityStamp = Guid.NewGuid().ToString(),
        ////            UserName = model.Username,
        ////            DatumRegistracije = DateTime.Now // Set the registration date here
        ////        };

        ////        var result = userManager.CreateAsync(user, model.Password).GetAwaiter().GetResult();
        ////        if (!result.Succeeded)
        ////        {
        ////            return BadRequest("Validation failed! Please check user details and try again.");
        ////        }

        ////        userManager.AddToRoleAsync(user, "RegularUser").GetAwaiter().GetResult();
        ////    }

        ////    return Ok();
        ////}

        //[HttpPost]
        //[Route("register")]
        //public IActionResult Register([FromBody] RegistrationDTO model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest("Registration parameters invalid.");
        //    }

        //    var userExists = userManager.FindByNameAsync(model.Username).GetAwaiter().GetResult();
        //    if (userExists != null)
        //    {
        //        return BadRequest("User already exists");
        //    }

        //    ApplicationUser user = new ApplicationUser()
        //    {
        //        SecurityStamp = Guid.NewGuid().ToString(),
        //        UserName = model.Username,
        //        DatumRegistracije = model.RegistrationDate
        //    };
        //    var result = userManager.CreateAsync(user, model.Password).GetAwaiter().GetResult();
        //    if (!result.Succeeded)
        //    {
        //        return BadRequest("Validation failed! Please check user details and try again.");
        //    }

        //    return Ok();
        //}
    }
}
