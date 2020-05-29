using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreJwt.Framework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace AspNetCoreJwt.Restful.Controllers
{
    /// <summary>
    /// 授权控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private readonly IMemoryCache _cache;
        public IConfiguration Configuration { get; }
        public AuthorizationController(IConfiguration configuration, IMemoryCache cache)
        {
            Configuration = configuration;
            _cache = cache;
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpGet]
        public CodeResult<string> Login(string userName, string password)
        {
            if (userName == "admin" && password == "123456")
            {
                var jti = Guid.NewGuid().ToString();    // 唯一标识
                var expires = TimeSpan.FromHours(2);    // 有效期，这里时2小时
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Jti, jti),
                    new Claim(ClaimTypes.Name, userName)
                };
                SigningCredentials credentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:SecurityKey"])), SecurityAlgorithms.HmacSha256);
                JwtSecurityToken token = new JwtSecurityToken(Configuration["Jwt:Issuer"], Configuration["Jwt:Audience"], claims, DateTime.Now, DateTime.Now.Add(expires), credentials);

                string tokenString = new JwtSecurityTokenHandler().WriteToken(token);

                return tokenString.Success();
            }

            return null;
        }

        /// <summary>
        /// 注销
        /// </summary>
        /// <returns></returns>
        [HttpGet, Authorize]
        public CodeResult LogOut()
        {
            var jtiClaims = User.Claims.FirstOrDefault(item => item.Type == JwtRegisteredClaimNames.Jti);
            _cache.Set(jtiClaims.Value, jtiClaims.Value, TimeSpan.FromHours(2));  // 将token唯一标识存入缓存中， 用于判断当前Token已注销，即使token在有效期内

            return CodeResult.Success();
        }
    }
}