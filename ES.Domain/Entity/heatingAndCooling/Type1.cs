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

namespace ES.Domain.Entity.heatingAndCooling
{
	public class Type1:StrongEntity
	{
		//[Key]
  //      public long Id { get; set; }
        public EnergySourceType EnergySrcType { get; set; }
		public bool? DualFuelSystem { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? SwitchoverTemp { get; set; }
		public long? EquipmentTypeId { get; set; }
		public TbDetail EquipmentType { get; set; }

		public UserSpecOrCalcType OutCapacityType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? OutCapacityVal { get; set; }
		public CapacityUnit OutCapacityUnit { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? SizingFactor { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Efficiency { get; set; }
		public EfficiencyType EfficiencyType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? PilotLigth { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FlueDiameter { get; set; }
		[MaxLength(100)]
		public string EquipmentManufact { get; set; }
		[MaxLength(100)]
		public string EquipmentModel { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ElectThemostatNum { get; set; }
		public bool? EnergyStar { get; set; }
		public bool? EPA_CSA { get; set; }
        public Type1Type Type1Type { get; set; }
        public long?  ComboTankPumpId { get; set; }
        public ComboTankAndPump  ComboTankPump { get; set; }
		public long? DWHRId { get; set; }
		public DWHR  DWHR { get; set; }
	}
}
