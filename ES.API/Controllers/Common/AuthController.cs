using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ES.Common.DTOs.Common;
using ES.Services.Contracts;
using ES.DTOs;

namespace ES.API.Controllers.Common
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : BaseApiController
    {
        private IUserBiz _userBiz;
        private readonly IConfiguration _config;

        public AuthController(IUserBiz userBiz, IConfiguration config)
        {
            _userBiz = userBiz;
            _config = config;
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(LoginDTO loginDTO)
        {
            var userFromRepo = _userBiz.Login(loginDTO, out var claims);
            if (userFromRepo == null) //User login failed
                return Ok(new BaseResponse("UserName Or Password is Wrong!"));

            //generate token
            return GetToken(userFromRepo, claims);
        }


        private IActionResult GetToken(UserInfoDTO user, List<Claim> claims)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_config.GetSection("AppSettings:Secret").Value);
            var expires = DateTime.Now.AddDays(1);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = expires,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return Ok(new BaseResponse()
            {
                Succeed = true,
                Data = new
                {
                    User = user,
                    Token = tokenString,
                    ExpireDate = expires
                }
            });
        }
    }
}