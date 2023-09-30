using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Domain.Entity.baseLoad
{
    public class WaterUsage:StrongEntity
    {
		public decimal? HotWaterTemp { get; set; }

		public long? BathFaucetFlowRateTypeId { get; set; }
		public TbDetail BathFaucetFlowRateType { get; set; }

		public decimal? BathFaucetUserPerOcc { get; set; }

		public long? ShowerTempTypeId { get; set; }
		public TbDetail ShowerTempType { get; set; }

		public long? ShwrHeadFlowRateId { get; set; }
		public TbDetail ShwrHeadFlowRate { get; set; }

		public decimal? AvgShwrDur { get; set; }
		public decimal? ShwrNumPerOcc { get; set; }
		public bool? ClothWasherInstalled { get; set; }

		public long? ClthWasherRateValTypeID { get; set; }
		public TbDetail ClthWasherRateValType { get; set; }

		public long? ClthWasherTempTypeId { get; set; }
		public TbDetail ClthWasherTempType { get; set; }

		public decimal? ClthWasherRatePerCycle { get; set; }
		public decimal? ClthWasherRateAnnPerYear { get; set; }
		public decimal? ClthWasherClothNumPerOcc { get; set; }
		public bool? DishwasherInstalled { get; set; }

		public long? DshWasherRateValTypeId { get; set; }
		public TbDetail DshWasherRateValType { get; set; }

		public decimal? DshWasherDishNumPerCycle { get; set; }
		public decimal? DshWasherRateWaterPerCycle { get; set; }
		public decimal? DshWasherAnnualEnergyPerYear { get; set; }
		public decimal? DshWasherCycleNumPerOcc { get; set; }
		public decimal? OtherWaterConsPerDay { get; set; }
		public decimal? LowFlushNum { get; set; }
	}
}
