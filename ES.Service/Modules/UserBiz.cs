using ES.Core.Biz;
using ES.Core.DataAccess;
using ES.Domain.Entity;
using System.Linq;
using ES.Services.Contracts;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System;
using System.IO;
using ES.Common.Enums;
using ES.DTOs;

namespace ES.Services.Modules
{
    public class UserBiz : BaseBiz<User, UserDTO>, IUserBiz
    {
        public UserBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public UserInfoDTO Login(LoginDTO loginDto, out List<Claim> claims)
        {
            claims = new List<Claim>();
            string pass = Encrypt(loginDto.Password);
            if (loginDto.Username == "admin" && loginDto.Password == "admin")
            {
                var user = new UserInfoDTO
                {
                    Name = "Sajjad",
                    Id = 1,
                    LastName = "Saburi",
                    PersonelCode = "100320",
                    access = RoleType.Admin.ToString(),

                };

                claims = geClaims(user);



                return user;
            }
            return null;
        }

        private string HashIt(string input)
        {
            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2")));
        }

        private string Encrypt(string s)
        {
            byte[] hash;
            UnicodeEncoding u = new UnicodeEncoding();
            byte[] byteproduct = u.GetBytes(s);
            MD5CryptoServiceProvider md = new MD5CryptoServiceProvider();
            hash = md.ComputeHash(byteproduct);
            return Convert.ToBase64String(hash);
        }
       

        private List<Claim> geClaims(UserInfoDTO user)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
            claims.Add(new Claim(ClaimTypes.Role, RoleType.Admin.ToString()));
            claims.Add(new Claim(ClaimTypes.GivenName, user.Name + " " + user.LastName));
            return claims;
        }
    }
}
