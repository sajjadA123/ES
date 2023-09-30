using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.Core.Module;
using ES.Services.Contracts;
using ES.Domain.Entity.components;
using ES.DTOs.components;

namespace ES.Services.Modules
{
    public class WindowsBiz : BaseBiz<Windows, WindowsDTO>, IWindowsBiz
    {
        public WindowsBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public PaginatedResult<WindowsDTO> Show(WindowsSearch search)
        {
            var data = Get();
            return data.ToDTOPaginatedResult<Windows, WindowsDTO>(search);
        }
    }
}
