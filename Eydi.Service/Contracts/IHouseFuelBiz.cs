using ES.Common.DTOs;
using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.DTOs.house;


namespace ES.Service.Contracts
{
    public interface IHouseFuelBiz:IBiz<HouseFuelDTO>
    {
        PaginatedResult<HouseFuelDTO> Show(HouseFuelSearch search);
    }
}
