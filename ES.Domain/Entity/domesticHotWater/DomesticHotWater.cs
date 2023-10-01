using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using ES.Domain.Entity.common;
using ES.Domain.Entity.domesticHotWater;

namespace ES.Domain.Entity.domesticHotWater
{
    public class DomesticHotWater:StrongEntity
    {
       // public EnergyFactorType EnergyFactorType { get; set; }
		public long? EnergySrcTypeId { get; set; }
		public TbDetail EnergySrcType { get; set; }

		public long? TankTypeId { get; set; }
		public TbDetail TankType { get; set; }

		public long? TankVolumeTypeId { get; set; }
		public TbDetail TankVolumeType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? TankVolumeVal { get; set; }

		public long? EnergyFactorTypeId { get; set; }
		public TbDetail EnergyFactorType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? EnergyFactorVal { get; set; }

		public long? UniformEnergyFactorId { get; set; }
		public TbDetail UniformEnergyFactor { get; set; }

		public long? TankLocationType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? standbyHeatLoss { get; set; }
		public StandyHeatLossUnit StandyHeatLossUnit { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? StandyThermalEfficiency { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? StandyInputCap { get; set; }
		[MaxLength(100)]
		public string EqupmentManufac { get; set; }
		[MaxLength(100)]
		public string EqupmentModel { get; set; }
		public bool? EqupmentES { get; set; }
		public bool? EqupmentEco { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? InsulatingBlanket { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal? HPCOP { get; set; }
		public bool? FlueCombined { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FlueDiameter { get; set; }

		/// <summary>
		/// Only in Solar
		/// </summary>
		public long? CsaType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CsaVal { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Slope { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Azimuth { get; set; }

		[Column(TypeName = "numeric(18,4)")]
		public decimal? FractionOfTank { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? PilotEnergy { get; set; }//only in secenfary

		public long? DWHRId { get; set; }
		public DWHR DWHR { get; set; }

		public DHWType DHW_TYPE { get; set; }//Primary or SEcendary
	}
}
