using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ES.Domain.Entity.baseInfo
{
    public class Composite:StrongEntity
    {
		//[Key]
		//public long? ID { get; set; }
		public decimal? Sec1Area { get; set; }
		public decimal? Sec1Rsi { get; set; }
		public decimal? Sec2Area { get; set; }
		public decimal? Sec2Rsi { get; set; }
		public decimal? RemArea { get; set; }
		public decimal? RemRsi { get; set; }
		public decimal? EffRsi { get; set; }
	}
}
