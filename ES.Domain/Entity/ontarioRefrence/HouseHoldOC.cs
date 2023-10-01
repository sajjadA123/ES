using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Core.Contracts.Entities;

namespace ES.Domain.Entity.ontarioRefrence
{
	public class HouseHoldOC:StrongEntity
	{
		//[Key]
		//      public long? Id { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AccupantsNum { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ThemostatHSeasonDay { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ThemostatHSeasonNight { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ThemostatColling { get; set; }
		public bool? CoolingSeasonMonthNum { get; set; }
		public bool? ClothWasher { get; set; }
		public	bool? MorThn50CflLed { get; set; }
		public bool? LessThn5Year { get; set; }
	}
}
