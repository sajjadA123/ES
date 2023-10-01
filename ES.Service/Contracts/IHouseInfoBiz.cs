using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.DTOs.house;

namespace ES.Service.Contracts
{
    public interface IHouseInfoBiz:IBiz<HouseInfoDTO>
    {
        PaginatedResult<HouseInfoDTO> Show(HouseInfoSearch search);
    }
}
