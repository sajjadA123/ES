using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.DTOs.components;

namespace ES.Services.Contracts
{
    public interface IWindowsBiz : IBiz<WindowsDTO>
    {
        PaginatedResult<WindowsDTO> Show(WindowsSearch search);
    }
}
