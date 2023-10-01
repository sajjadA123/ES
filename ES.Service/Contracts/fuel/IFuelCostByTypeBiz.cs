using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.DTOs.house.fuel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Service.Contracts.fuel
{
    public interface IFuelCostByTypeBiz : IBiz<FuelCostByTypeDTO>
    {
        PaginatedResult<FuelCostByTypeDTO> Show(FuelCostByTypeSearch search);
        FuelCostByTypeDTO GetFuelCostByTypeDTOByName(string name);
    }
}
