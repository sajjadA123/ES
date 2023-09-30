using ES.Common.DTOs.foundation;
using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.Core.Module;
using ES.Domain.Entity;
using ES.Service.Contracts;
using static ES.Common.DTOs.foundation.BasementDTO;

namespace ES.Services.Modules
{
    public class BasementBiz : BaseBiz<Basement, BasementDTO>, IBasementBiz
    {
        public BasementBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public PaginatedResult<BasementDTO> Show(BasementSearch search)
        {
            var data = Get();
            return data.ToDTOPaginatedResult<Basement, BasementDTO>(search);
        }
    }
}
