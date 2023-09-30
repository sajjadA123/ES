using ES.Core.Contracts.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.house.fuel
{
    public class FuelCostsDTO:StrongEntityDTO
    {
        public List<FuelCostByTypeDTO> ElectricityType { get; set; }
        public List<FuelCostByTypeDTO> NaturalGasType { get; set; }
        public List<FuelCostByTypeDTO> OilType { get; set; }
        public List<FuelCostByTypeDTO> PropaneType { get; set; }
        public List<FuelCostByTypeDTO> WoodType { get; set; }
    }
}
