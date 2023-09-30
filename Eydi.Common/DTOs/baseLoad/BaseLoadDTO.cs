using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.house;

namespace ES.DTOs.baseLoad
{
    public class BaseLoadDTO:StrongEntityDTO
    {
		public long? HouseId { get; set; }
		public HouseFileDTO House { get; set; }

		public bool? UserSpecElWaterUsage { get; set; }

		public decimal? OccupantsAdults { get; set; }
		public decimal? AtHomeAdults { get; set; }
		public decimal? OccupantsChildren { get; set; }
		public decimal? AtHomeChildren { get; set; }
		public decimal? OccupantsInfants { get; set; }
		public decimal? AtHomeInfants { get; set; }
		public decimal? FractionOfIntGain { get; set; }

		public decimal? ElecApp { get; set; }
		public decimal? LightingApp { get; set; }
		public decimal? OtherElec { get; set; }
		public decimal? AvgExUse { get; set; }
		public decimal? EstimatHotWater { get; set; }

		public decimal? AdvHotWaterTemp { get; set; }

		public GasStoveType AdvGasStoveType { get; set; }

		public decimal? AdvGasStoveVal { get; set; }
		public GasStoveType AdvGasDryerType { get; set; }

		public decimal? AdvGasDryerVal { get; set; }
		public long? AdvDryerLocationType { get; set; }
		public long? AdvDryerLocationId { get; set; }
		//use in defaultMod
		public long? WaterUsageId { get; set; }
        public WaterUsageDTO WaterUsage { get; set; }
        public long? ElecUsageId { get; set; }
        public ElectricalUsageDTO ElecUsage { get; set; }
	}
	public class BaseLoadSearch : BaseSearch
	{

	}
}
