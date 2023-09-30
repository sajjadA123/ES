
using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.DTOs.components;

namespace ES.Service.Contracts
{
    public interface ICeilingBiz:IBiz<CeilingDTO>
    {
        PaginatedResult<CeilingDTO> Show(CeilingSearch search);
    }
}
