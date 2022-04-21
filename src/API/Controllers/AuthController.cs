using Core.DTOs;
using Core.Entities;
using Core.Interface.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {
        private IConfiguration _config;
        IAuthService svc;
        private readonly IAppLogger logger;
        public AuthController(IConfiguration config, IAuthService _svc, IAppLogger _logger)
        {
            _config = config;
            //svc = new AppUserService(oContext);
            svc = _svc;
            logger = _logger;
        }

        [AllowAnonymous]
        [HttpPost(nameof(Login))]
        public async Task<IActionResult> Login(AuthenicationParam req)
        {
            try
            {
                var a = await svc.Login(req, GenerateToken);
                return Ok(a);
            }
            catch (Exception ee)
            {
                return Ok(ee.ToString() + "\n" + ee.Message);
            }
        
            var response = svc.Login(req, GenerateToken);
            return Ok(response);

        }

        [HttpPost(nameof(test))]
        public async Task<IActionResult> test()
        {
            
            return Ok();

        }
        private string GenerateToken(USERSETUP userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            string issuer = _config.GetValue<string>("Jwt:Issuer");
            //Claims 
            var premClaims = new List<Claim>();
            premClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            premClaims.Add(new Claim("userid", userInfo.USER_ID));
            premClaims.Add(new Claim("name", userInfo.USER_NAME));

            var token = new JwtSecurityToken(issuer, _config["Jwt:Issuer"], premClaims,
              expires: DateTime.Now.AddMinutes(3),
              signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
