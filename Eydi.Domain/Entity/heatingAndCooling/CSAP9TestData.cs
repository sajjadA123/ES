	using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Common.Enums;
using ES.Core.Contracts.Entities;

namespace ES.Domain.Entity.heatingAndCooling
{
    public class CSAP9TestData:StrongEntity
    {
		//[Key]
  //      public long? Id { get; set; }
        public EnergySourceType EnergyType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? NetEff15 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? NetEff40 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? NetEff100 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AvgElecUse15 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AvgElecUse40 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AvgElecUse100 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CirclBmePower15 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CirclBmePower40 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CirclBmePower100 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Pcont { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Pcirc { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? DailyElWaterHeat { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ThemalStandbyOn { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ThemalStandbyOff { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? HDeliverRateDhw { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? HDeliverRateSh { get; set; }
	}
}
