using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.Core.Module;
using ES.Domain.Entity.house.fuel;
using ES.DTOs.house.fuel;
using ES.Service.Contracts.fuel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Service.Modules.fuelCost
{
    public class FuelCostByTypeBiz : BaseBiz<FuelCostByType, FuelCostByTypeDTO>, IFuelCostByTypeBiz
    {
        public FuelCostByTypeBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public PaginatedResult<FuelCostByTypeDTO> Show(FuelCostByTypeSearch search)
        {
            var data = Get();
            return data.ToDTOPaginatedResult<FuelCostByType, FuelCostByTypeDTO>(search);
        }
        public FuelCostByTypeDTO GetFuelCostByTypeDTOByName(string name)
        {
            System.Linq.Expressions.Expression<Func<FuelCostByType, bool>> body = s => s.Label==name;
            return Extensions.ToDTO<FuelCostByTypeDTO>(base.Get(body).FirstOrDefault());
        }
    }
}
