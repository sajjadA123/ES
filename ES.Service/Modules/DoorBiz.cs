using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.Core.Module;
using ES.Service.Contracts;
using ES.Domain.Entity.components;
using ES.DTOs.components;

namespace ES.Services.Modules
{
    public class DoorBiz : BaseBiz<Door, DoorDTO>, IDoorBiz
    {
        public DoorBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public PaginatedResult<DoorDTO> Show(DoorSearch search)
        {
            var data = Get();
            return data.ToDTOPaginatedResult<Door, DoorDTO>(search);
        }
    }
}
