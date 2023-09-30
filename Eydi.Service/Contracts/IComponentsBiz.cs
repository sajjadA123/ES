using ES.Common.DTOs;
using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Service.Contracts
{
    public  interface IComponentsBiz :IBiz<ComponentsDTO>
    {
        PaginatedResult<ComponentsDTO> Show(ComponentsSearch search);
    }
}
