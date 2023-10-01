using ES.API.Controllers.Common;
using ES.Common.DTOs.wizard;
using ES.Core.Biz;
using ES.Service.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ES.API.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WizardController : BaseApiController
    {
        //public WizardController(IBiz<WizardDTO> biz) : base(biz)
        //{
        //}

        private IWizardBiz _wizardBiz;

        //public WizardController(IWizardBiz wizardBiz) : base(wizardBiz)
        //{
        //    _wizardBiz = wizardBiz;
        //}
        [HttpPost]
        public IActionResult CalcPolygon(WizardDTO calc)
        {

            var out_ = Okk(true,"salam");
            return out_;
        }

    }
}