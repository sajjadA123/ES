using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Common.Enums;
using ES.Core.Contracts.Entities;

namespace ES.Domain.Entity
{
	public class Temperatures:StrongEntity
	{
		[Column(TypeName = "numeric(18,4)")]
		public decimal? DaytimeHeatPoint { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? DaytimeCoolPoint { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? NigthtimeHeatPoint { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? NigthtimeCoolPoint { get; set; }
		public AllowableRize AllowableRiseType { get; set; }
		public bool? BasementHeated { get; set; }
		public bool? BasementCooled { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? BasementHeatDegr { get; set; }
		public bool? BasementSepThermostat { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? EquipmentHeadSetPoint { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? EquipmentCoolSetPoint { get; set; }
		public bool? CrawlSpc { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CrawlSpcHeat { get; set; }
	}
}
