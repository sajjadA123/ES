using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.Core.Module;
using ES.Service.Contracts;
using ES.Domain.Entity.components;
using ES.DTOs.components;

namespace ES.Services.Modules
{
    public class FloorBiz : BaseBiz<Floor, FloorDTO>, IFloorBiz
    {
        public FloorBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public PaginatedResult<FloorDTO> Show(FloorSearch search)
        {
            var data = Get();
            return data.ToDTOPaginatedResult<Floor, FloorDTO>(search);
        }
    }
}
