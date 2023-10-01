using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.house.fuel;

namespace ES.DTOs.house
{
	public class HouseFuelDTO : StrongEntityDTO
    {
		public string FuelCostLib { get; set; }
		public bool? IncludeCostCalc { get; set; }

		public long? MonthlyCostId { get; set; }
        public FuelMonthlyCostDataDTO FuelMonthlyCost { get; set; }
        public long? YearlyCostId { get; set; }
        public FuelCostDTO YearlyFuelCost { get; set; }
        public long? HouseId { get; set; }
        public HouseFileDTO House { get; set; }
    }
    public class HouseFuelSearch : BaseSearch
    {

    }
}
