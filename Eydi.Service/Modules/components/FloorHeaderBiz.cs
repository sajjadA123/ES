using ES.Common.DTOs.components;
using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.Domain.Entity.components;
using ES.Service.Contracts;
using ES.Service.Contracts.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Service.Modules.components
{
    public class FloorHeaderBiz : BaseBiz<FloorHeader, FloorHeaderDTO>, IFloorHeaderBiz
    {
        public FloorHeaderBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public PaginatedResult<FloorHeaderDTO> Show(FloorHeaderSearch search)
        {
            throw new NotImplementedException();
        }
    }
}
