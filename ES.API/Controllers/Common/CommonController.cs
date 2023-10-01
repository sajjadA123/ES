using Microsoft.AspNetCore.Mvc;
using ES.Common.DTOs.Common;
using ES.Common.Helpers;
using System.Linq;

namespace ES.API.Controllers.Common
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CommonController : BaseApiController
    {
        public CommonController()
        {
        }


        [HttpPost]
        public IActionResult GetEnumSelectData(DropdownEnumSelect select)
        {
            var data = EnumHelper.GetByName(select.EnumType).Select(x => new DropdownDTO { Id = x.Key, Desc = x.Value }).OrderBy(x => x.Id);
            return Okk(data);
        }
    }
}