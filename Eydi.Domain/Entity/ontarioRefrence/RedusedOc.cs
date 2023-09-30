using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Common.Enums;
using ES.Core.Contracts.Entities;

namespace ES.Domain.Entity.ontarioRefrence
{
	public class RedusedOc:StrongEntity
	{
		//[Key]
  //      public long? Id { get; set; }
        public bool? EnStarNewHome { get; set; }
		public LightingType LightingType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ClothesDryerVal { get; set; }
		public bool? ClothesDryerEn { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ClothesWasherVal { get; set; }
		public bool? ClothesWasherEn { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? DishwasherVal { get; set; }
		public bool? DishwasherEn { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RefrigeratorVal { get; set; }
		public	bool? RefrigeratorEn { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Range { get; set; }
		public bool? HotwaterBathroomRate { get; set; }
		public bool? HotwaterShowerRate { get; set; }
	}
}
