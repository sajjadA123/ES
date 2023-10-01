using ES.Common.DTOs;
using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Service.Contracts
{
    public interface IWinTightnessBiz:IBiz<WinTightnessDTO>
    {
        PaginatedResult<WinTightnessDTO> Show(WinTightnessSearch search);
    }
}
