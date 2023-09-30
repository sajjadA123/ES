using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Domain.Entity.house.fuel
{
    public class FuelMonthlyCostData:StrongEntity
    {
		public long? JanuaryCostId { get; set; }
        public FuelCost JunuaryCost { get; set; }

        public long? FebruaryCostId { get; set; }
		public FuelCost FebruaryCost { get; set; }

		public long? MarchCostId { get; set; }
		public FuelCost MarchCost { get; set; }

		public long? AprilCostId { get; set; }
		public FuelCost AprilCost { get; set; }

		public long? MayCostId { get; set; }
		public FuelCost MayCost { get; set; }

		public long? JuneCostId { get; set; }
		public FuelCost JuneCost { get; set; }

		public long? JulyCostId { get; set; }
		public FuelCost JulyCost { get; set; }

		public long? AugustCostId { get; set; }
		public FuelCost AugustCost { get; set; }

		public long? SeptemberCostId { get; set; }
		public FuelCost SeptemberCost { get; set; }

		public long? OctoberCostId { get; set; }
		public FuelCost OctoberCost { get; set; }

		public long? NovemberCostId { get; set; }
		public FuelCost NovemberCost { get; set; }

		public long? DecemberCostId { get; set; }
		public FuelCost DecemberCost { get; set; }

	}
}
