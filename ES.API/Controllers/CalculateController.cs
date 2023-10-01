using ES.API.Controllers.Common;
using ES.Core.Biz;
using ES.Core.Contracts.Entities.calculate;
using ES.Service.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ES.API.Controllers
{


    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculateController :  ESBaseApiController<CalculateInput>
    {
        private ICalculateBiz _calculateBiz;

        public CalculateController(ICalculateBiz calculateBiz) : base(calculateBiz)
        {
            _calculateBiz = calculateBiz;
        }
        [HttpPost]
        public IActionResult CalcPolygon(List<CalculateInput> calc)
        {
             Service.Modules.Calculate.Calculate calculate= new Service.Modules.Calculate.Calculate(calc);
            CalculateResponse response=calculate.CalcPolygon();
            var out_ = Okk(response);
            return out_;
        }

    }
}
