using ES.Common.DTOs.Common;
using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;
using ES.DTOs.Common;
using ES.DTOs.components;

namespace ES.DTOs.domesticHotWater
{
    public class DomesticHotWaterDTO:StrongEntityDTO,IBaseComponent
    {
       // public EnergyFactorType EnergyFactorType { get; set; }
		public long? EnergySrcTypeId { get; set; }
		public TbDetailDTO EnergySrcType { get; set; }

		public long? TankTypeId { get; set; }
		public TbDetailDTO TankType { get; set; }

		public long? TankVolumeTypeId { get; set; }
		public TbDetailDTO TankVolumeType { get; set; }
		public decimal? TankVolumeVal { get; set; }

		public long? EnergyFactorTypeId { get; set; }
		public TbDetailDTO EnergyFactorType { get; set; }
		public decimal? EnergyFactorVal { get; set; }

		public long? UniformEnergyFactorId { get; set; }
		public TbDetailDTO UniformEnergyFactor { get; set; }

		public TbDetailDTO TankLocationType { get; set; }
		public long? TankLocationTypeId { get; set; }

		public decimal? standbyHeatLoss { get; set; }
		public StandyHeatLossUnit StandyHeatLossUnit { get; set; }
		public decimal? StandyThermalEfficiency { get; set; }
		public decimal? StandyInputCap { get; set; }
		public string EqupmentManufac { get; set; }
		public string EqupmentModel { get; set; }
		public bool? EqupmentES { get; set; }
		public bool? EqupmentEco { get; set; }
		public decimal? InsulatingBlanket { get; set; }
		public decimal? HPCOP { get; set; }
		public bool? FlueCombined { get; set; }
		public decimal? FlueDiameter { get; set; }

		/// <summary>
		/// Only in Solar
		/// </summary>
		public long? CsaType { get; set; }
		public decimal? CsaVal { get; set; }
		public decimal? Slope { get; set; }
		public decimal? Azimuth { get; set; }


		public decimal? FractionOfTank { get; set; }
		public decimal? PilotEnergy { get; set; }//only in secenfary
		public long? DWHRId { get; set; }
		public DWHRDTO DWHR { get; set; }

		public DHWType DHW_TYPE { get; set; }//Primary or SEcendary
		public class DomesticHotWaterSearch : BaseSearch
		{

		}
	}
}
