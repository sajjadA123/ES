using ES.Common.DTOs.foundation;
using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using static ES.Common.DTOs.foundation.BasementDTO;

namespace ES.Service.Contracts
{
    public interface IBasementBiz:IBiz<BasementDTO>
    {
        PaginatedResult<BasementDTO> Show(BasementSearch search);
    }
}
