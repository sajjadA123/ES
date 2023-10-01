using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ES.Common.DTOs.Common;

namespace ES.API.Controllers.Common
{
    //[Authorize]
    public class BaseApiController : ControllerBase
    {
        protected OkObjectResult Okk()
        {
            return Ok(new BaseResponse(true));
        }
        protected OkObjectResult Okk(bool succeed,string errorMessage)
        {
            return Ok(new BaseResponse(succeed, errorMessage));
        }
        protected OkObjectResult Okk(string errorMessage)
        {
            return Ok(new BaseResponse(errorMessage));
        }
        protected OkObjectResult Okk(ModelStateDictionary modelState)
        {
            string errorMessage = string.Join("; ", ModelState.Values
                .SelectMany(x => x.Errors)
                .Select(x => x.ErrorMessage));
            return Ok(new BaseResponse { Succeed = false, ErrorMessage = errorMessage });
        }
        protected OkObjectResult Okk(object data)
        {
            return Ok(new BaseResponse(data));
        }
    }
}