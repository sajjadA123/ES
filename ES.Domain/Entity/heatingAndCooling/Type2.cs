using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Common.Enums;
using ES.Core.Contracts.Entities;

namespace ES.Domain.Entity.heatingAndCooling
{
    public class Type2:StrongEntity
    {
		//[Key]
  //      public long Id { get; set; }
        public UnitFuncType UnitFuncType { get; set; }
		public CentralEquipmentTpe CentralEquipmentTpe { get; set; }

		public OutputCapacityType OutCapacityType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? OutCapacityVal { get; set; }
		public CapacityUnit OutCapacityUnit { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? HeatEfficiencyVal { get; set; }
		public HeatCoolEfficiencyType HeatEfficiencyType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CoolEfficiencyVal { get; set; }
		public HeatCoolEfficiencyType CoolEfficiencyType { get; set; }

		public TempCutoffType TempCutoffType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CutoffTemp { get; set; }
		public TempRatingType TempRatingType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RatingTemp { get; set; }

		[MaxLength(100)]
		public string EquipmentManufact { get; set; }
		[MaxLength(100)]
		public string EquipmentModel { get; set; }
		[MaxLength(11)]
		public string EquipmentAHRI { get; set; }
        public bool? EnergyStar { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CrankcaseHeat { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? SensibleHeatRate { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? OpenableWinArea { get; set; }

		public bool? ColdClimateHeatPumo { set; get; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CLHHeatEff { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CLHCoolEff { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CLHCapVal { get; set; }
		public CapacityUnit CLHCapUnit { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CLHCopAt { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ClhCapMaintnc { get; set; }

		public UserSpecOrCalcType WaterOrGroundTempUseType { get; set; }
		public long? WaterTempMonId { get; set; }
		public HeatPumpSourceTempMonthly WaterTempMon { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AvgDepth { get; set; }

		public bool? CAN_CSA { get; set; }

	}
}
