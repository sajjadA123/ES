using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.baseLoad
{
    public class ElectricalUsageDTO:StrongEntityDTO
    {
		public bool? ClothsDryerInstalled { get; set; }
		public long? ClothsEnergySourceTypeID { get; set; }
		public TbDetailDTO ClothsEnergySourceType { get; set; }

		public decimal? ClothWashLoadDryPer { get; set; }

		public long? ClthRateValTypeID { get; set; }
		public TbDetailDTO ClthRateValType { get; set; }

		public decimal? ClthAnnualEnergyConsRate { get; set; }
		public long? DryerLocationId { get; set; }
		public TbDetailDTO DryerLocationType { get; set; }
		public long? DryerLocType { get; set; }

		public long? StoveEnergySourceTypeID { get; set; }
		public TbDetailDTO StoveEnergySourceType { get; set; }

		public long? StoveRateValTypeID { get; set; }
		public TbDetailDTO StoveRateValType { get; set; }

		public decimal? StoveAnnualEnConsRateYear { get; set; }

		public long? RefrigRateValTypeID { get; set; }
		public TbDetailDTO RefrigRateValType { get; set; }

		public decimal? RegrigAnnualEnConsRateYear { get; set; }

		public long? LigthDailyElecEnConsTypeID { get; set; }
		public TbDetailDTO LigthDailyElecEnConsType { get; set; }
		public decimal? LigthDailyElecEnConsVal { get; set; }
		public decimal? OtherElecLoad { get; set; }
		public decimal? AvgExtUse { get; set; }
		public class ElectricalUsageSearch : BaseSearch
		{

		}
	}
}
