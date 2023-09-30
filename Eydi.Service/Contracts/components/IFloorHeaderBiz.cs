using ES.Common.DTOs.components;
using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Service.Contracts.components
{
    public interface IFloorHeaderBiz:IBiz<FloorHeaderDTO>
    {
        PaginatedResult<FloorHeaderDTO> Show(FloorHeaderSearch search);
    }
}
