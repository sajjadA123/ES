using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.house.fuel
{
    public class FuelMonthlyCostDataDTO: StrongEntityDTO
	{
		public long? JanuaryCostId { get; set; }
        public FuelCostDTO JanuaryCost { get; set; }

        public long? FebruaryCostId { get; set; }
		public FuelCostDTO FebruaryCost { get; set; }

		public long? MarchCostId { get; set; }
		public FuelCostDTO MarchCost { get; set; }

		public long? AprilCostId { get; set; }
		public FuelCostDTO AprilCost { get; set; }

		public long? MayCostId { get; set; }
		public FuelCostDTO MayCost { get; set; }

		public long? JuneCostId { get; set; }
		public FuelCostDTO JuneCost { get; set; }

		public long? JulyCostId { get; set; }
		public FuelCostDTO JulyCost { get; set; }

		public long? AugustCostId { get; set; }
		public FuelCostDTO AugustCost { get; set; }

		public long? SeptemberCostId { get; set; }
		public FuelCostDTO SeptemberCost { get; set; }

		public long? OctoberCostId { get; set; }
		public FuelCostDTO OctoberCost { get; set; }

		public long? NovemberCostId { get; set; }
		public FuelCostDTO NovemberCost { get; set; }

		public long? DecemberCostId { get; set; }
		public FuelCostDTO DecemberCost { get; set; }
		public class FuelMonthlyCostDataSearch : BaseSearch
		{

		}

	}
}
