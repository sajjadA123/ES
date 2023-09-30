using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.Core.Module;
using ES.Service.Contracts;
using ES.Domain.Entity.components;
using ES.DTOs.components;

namespace ES.Services.Modules
{
    public class CeilingBiz : BaseBiz<Ceiling, CeilingDTO>, ICeilingBiz
    {
        public CeilingBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public PaginatedResult<CeilingDTO> Show(CeilingSearch search)
        {
            var data = Get();
            return data.ToDTOPaginatedResult<Ceiling, CeilingDTO>(search);
        }
    }
}
