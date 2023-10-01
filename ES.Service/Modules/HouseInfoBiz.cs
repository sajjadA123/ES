using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.Core.Module;
using ES.Domain.Entity;
using ES.DTOs.house;
using ES.Service.Contracts;

namespace ES.Services.Modules
{
    public class HouseInfoBiz : BaseBiz<HouseInfo, HouseInfoDTO>, IHouseInfoBiz
    {
        public HouseInfoBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public PaginatedResult<HouseInfoDTO> Show(HouseInfoSearch search)
        {
            var data = Get();
            return data.ToDTOPaginatedResult<HouseInfo, HouseInfoDTO>(search);
        }
    }
}
