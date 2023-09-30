using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.house.fuel
{
    public class FuelCostDTO: StrongEntityDTO
    {
        public long? ElectricityTypeId { get; set; }
        public FuelCostByTypeDTO ElectricityType { get; set; }

        public long? NaturalGasTypeId { get; set; }
        public FuelCostByTypeDTO NaturalGasType { get; set; }

        public long? OilTypeId { get; set; }
        public FuelCostByTypeDTO OilType { get; set; }

        public long? PropaneTypeId { get; set; }
        public FuelCostByTypeDTO PropaneType { get; set; }

        public long? WoodTypeId { get; set; }
        public FuelCostByTypeDTO WoodType { get; set; }
        public class FuelCostSearch : BaseSearch
        {

        }

    }
}
