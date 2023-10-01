using ES.Common.DTOs;
using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.DTOs.components;

namespace ES.Service.Contracts
{
    public interface IFloorBiz:IBiz<FloorDTO>
    {
        PaginatedResult<FloorDTO> Show(FloorSearch search);
    }
}
