using ES.API.Controllers.Common;
using ES.Common.DTOs;
using ES.Service.Contracts;
using ES.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ES.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ComponentsController : ESBaseApiController<ComponentsDTO>
    {
        private IComponentsBiz _components;

        public ComponentsController(IComponentsBiz components) : base(components)
        {
            _components = components;
        }
    }
}
