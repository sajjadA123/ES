using ES.Core.Contracts.Entities;
using ES.Domain.Entity.house.fuel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ES.Domain.Entity
{
	public class HouseFuel : StrongEntity
	{
		[MaxLength(100)]
		public string FuelCostLib { get; set; }
		public bool? IncludeCostCalc { get; set; }

		public long? MonthlyCostId { get; set; }
        public FuelMonthlyCostData FuelMonthlyCost { get; set; }
        public long? YearlyCostId { get; set; }
        public FuelCost YearlyFuelCost { get; set; }
        public long? HouseId { get; set; }
        public HouseFile House { get; set; }
    }
}
