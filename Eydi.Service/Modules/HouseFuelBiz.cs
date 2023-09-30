using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.Core.Module;
using ES.Domain.Entity;
using ES.DTOs.house;
using ES.Service.Contracts;

namespace ES.Services.Modules
{
    public class HouseFuelBiz : BaseBiz<HouseFuel, HouseFuelDTO>, IHouseFuelBiz
    {
        public HouseFuelBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public PaginatedResult<HouseFuelDTO> Show(HouseFuelSearch search)
        {
            var data = Get();
            return data.ToDTOPaginatedResult<HouseFuel,HouseFuelDTO>(search);
        }
    }
}
