using System;
using System.Collections.Generic;
using System.Text;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;

namespace ES.Domain.Entity.baseLoad
{
    public class ElectricalUsage:StrongEntity
    {
		public bool? ClothsDryerInstalled { get; set; }
		public long? ClothsEnergySourceTypeID { get; set; }
		public TbDetail ClothsEnergySourceType { get; set; }

		public decimal? ClothWashLoadDryPer { get; set; }

		public long? ClthRateValTypeID { get; set; }
		public TbDetail ClthRateValType { get; set; }

		public decimal? CLTH_ANNUAL_ENERGY_CONS_RATE { get; set; }
		public long? DryerLocationId { get; set; }
		public long? DryerLocType { get; set; }

		public long? StoveEnergySourceTypeID { get; set; }
		public TbDetail StoveEnergySourceType { get; set; }

		public long? StoveRateValTypeID { get; set; }
		public TbDetail StoveRateValType { get; set; }

		public decimal? StoveAnnualEnConsRateYear { get; set; }

		public long? RefrigRateValTypeID { get; set; }
		public TbDetail RefrigRateValType { get; set; }

		public decimal? RegrigAnnualEnConsRateYear { get; set; }

		public long? LigthDailyElecEnConsTypeID { get; set; }
		public TbDetail LigthDailyElecEnConsType { get; set; }
		public decimal? LigthDailyElecEnConsVal { get; set; }
		public decimal? OtherElecLoad { get; set; }
		public decimal? AvgExtUse { get; set; }
	}
}
