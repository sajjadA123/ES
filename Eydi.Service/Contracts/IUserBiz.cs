using ES.Core.Biz;
using ES.DTOs;
using System.Collections.Generic;
using System.Security.Claims;

namespace ES.Services.Contracts
{
    public interface IUserBiz : IBiz<UserDTO>
    {
      
        UserInfoDTO Login(LoginDTO loginDto, out List<Claim> claims);

    }
}
