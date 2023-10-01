using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Core.Contracts.Entities;

namespace ES.Domain.Entity.heatingAndCooling
{
    public class HeatPumpSourceTempMonthly:StrongEntity
    {
		//[Key]
		//      public long? Id { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? January { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? February { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? March { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? April { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? May { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? June { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? July { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? August { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? September { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? October { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? November { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? December { get; set; }
	}
}
