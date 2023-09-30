using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.DTOs.components;

namespace ES.Service.Contracts
{
    public interface IDoorBiz:IBiz<DoorDTO>
    {
        PaginatedResult<DoorDTO> Show(DoorSearch search);
    }
}
