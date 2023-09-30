using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.Core.Module;
using ES.Domain.Entity;
using ES.Services.Contracts;
using ES.DTOs;
using ES.Common.DTOs;
using ES.Service.Contracts;

namespace ES.Services.Modules
{
    public class WinTightnessBiz : BaseBiz<WinTightness, Common.DTOs.WinTightnessDTO>, IWinTightnessBiz
    {
        public WinTightnessBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public PaginatedResult<Common.DTOs.WinTightnessDTO> Show(WinTightnessSearch search)
        {
            var data = Get();
            return data.ToDTOPaginatedResult<WinTightness, Common.DTOs.WinTightnessDTO>(search);
        }
    }
}
