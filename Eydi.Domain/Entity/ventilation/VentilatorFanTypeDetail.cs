using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;

namespace ES.Domain.Entity.ventilation
{
    public class VentilatorFanTypeDetail:StrongEntity
    {
		public VentilatorFanType DetailType { get; set; }
		[MaxLength(100)]
		public string EquipmentManufact { get; set; }
		[MaxLength(100)]
		public string EquipmentModel { get; set; }

		public long? SchaduleOpTypeID { get; set; }//Supp
		public TbDetail SchaduleOpType { get; set; }//Supp
		[Column(TypeName = "numeric(18,4)")]

		public decimal? SCHADULE_OP_VAL { get; set; }//Sup

		public bool? EnergyStar { get; set; }
		public bool? HVI { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AirflowSupply { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AirflowExhaust { get; set; }
		public bool? UseDefFanPwr { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RatingCondPwr1 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RatingCondTemp1 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RatingCondEff1 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RatingCondPwr2 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RatingCondTemp2 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RatingCondEff2 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? PreheaterCap { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? LowTempVentReduct { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CoolingEff { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? HrvDuctsId { get; set; }

		public DryerExhaustDestination DryerExDestType { get; set; }
	}
}
