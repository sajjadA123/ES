using Microsoft.AspNetCore.Mvc;
using ES.Common.DTOs.Common;
using ES.Core.Biz;

namespace ES.API.Controllers.Common
{
    public class ESBaseApiController<TDTO> : BaseApiController
    {
        private IBiz<TDTO> _biz;
        public ESBaseApiController(IBiz<TDTO> biz)
        {
            this._biz = biz;
        }

        [HttpPost]
        public IActionResult Get(IdRequest req)
        {
            var data = true; //_biz.GetByPK(req.Id);
            return Okk(data);
        }

        [HttpPost]
        public IActionResult Create(TDTO dto)
        {
            //_biz.Insert(dto);
            return Okk();
        }

        [HttpPost]
        public IActionResult Update(TDTO dto)
        {
            //_biz.Update(dto);
            return Okk();
        }

        [HttpPost]
        public IActionResult Delete(IdRequest req)
        {
            //_biz.DeleteByPk(req.Id);
            return Okk();
        }

        [HttpPost]
        public IActionResult HardDelete(IdRequest req)
        {
           // _biz.HardDeleteByPk(req.Id);
            return Okk();
        }
    }
}