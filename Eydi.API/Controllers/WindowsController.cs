using Microsoft.AspNetCore.Mvc;
using ES.API.Controllers.Common;
using ES.Services.Contracts;
using ES.DTOs.components;

namespace ES.API.Controllers
{


    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WindowsController : ESBaseApiController<WindowsDTO>
    {
        private IWindowsBiz _windows;

        public WindowsController(IWindowsBiz windows) : base(windows)
        {
            _windows = windows;
        }
        [HttpPost]
        public IActionResult Show(WindowsSearch search)
        {
            var out_ = Okk(_windows.Show(search));
            return Okk( out_);
        }
    }
}