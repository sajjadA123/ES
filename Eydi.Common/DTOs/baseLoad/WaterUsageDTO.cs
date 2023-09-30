using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.baseLoad
{
    public class WaterUsageDTO:StrongEntityDTO
    {
		public decimal? HotWaterTemp { get; set; }

		public long? BathFaucetFlowRateTypeId { get; set; }
		public TbDetailDTO BathFaucetFlowRateType { get; set; }

		public decimal? BathFaucetUserPerOcc { get; set; }

		public long? ShowerTempTypeId { get; set; }
		public TbDetailDTO ShowerTempType { get; set; }

		public long? ShwrHeadFlowRateId { get; set; }
		public TbDetailDTO ShwrHeadFlowRate { get; set; }

		public decimal? AvgShwrDur { get; set; }
		public decimal? ShwrNumPerOcc { get; set; }
		public bool? ClothWasherInstalled { get; set; }

		public long? ClthWasherRateValTypeID { get; set; }
		public TbDetailDTO ClthWasherRateValType { get; set; }

		public long? ClthWasherTempTypeId { get; set; }
		public TbDetailDTO ClthWasherTempType { get; set; }

		public decimal? ClthWasherRatePerCycle { get; set; }
		public decimal? ClthWasherRateAnnPerYear { get; set; }
		public decimal? ClthWasherClothNumPerOcc { get; set; }
		public bool? DishwasherInstalled { get; set; }

		public long? DshWasherRateValTypeId { get; set; }
		public TbDetailDTO DshWasherRateValType { get; set; }

		public decimal? DshWasherDishNumPerCycle { get; set; }
		public decimal? DshWasherRateWaterPerCycle { get; set; }
		public decimal? DshWasherAnnualEnergyPerYear { get; set; }
		public decimal? DshWasherCycleNumPerOcc { get; set; }
		public decimal? OtherWaterConsPerDay { get; set; }
		public decimal? LowFlushNum { get; set; }
		public class WaterUsageSearch : BaseSearch
		{

		}
	}
}
