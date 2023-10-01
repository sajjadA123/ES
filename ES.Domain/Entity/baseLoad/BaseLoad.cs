using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using ES.Domain.Entity.baseLoad;

namespace ES.Domain.Entity
{
    public class BaseLoad:StrongEntity
    {
		public bool? UserSpecElWaterUsage { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? OccupantsAdults { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AtHomeAdults { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? OccupantsChildren { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AtHomeChildren { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? OccupantsInfants { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AtHomeInfants { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FractionOfIntGain { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ElecApp { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? LightingApp { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? OtherElec { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AvgExUse { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? EstimatHotWater { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AdvHotWaterTemp { get; set; }

		public long? AdvGasStoveTypeID { get; set; }
		public TbDetail AdvGasStoveType { get; set; }

		public decimal? AdvGasStoveVal { get; set; }
		public long? AdvGasDryerTypeID { get; set; }
		public TbDetail AdvGasDryerType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AdvGasDryerVal { get; set; }
		public long? AdvDryerLocationType { get; set; }
		public long? AdvDryerLocationId { get; set; }
		//use in defaultMod
		public long? WaterUsageId { get; set; }
        public WaterUsage WaterUsage { get; set; }
        public long? ElecUsageId { get; set; }
        public ElectricalUsage ElecUsage { get; set; }
	}
}
