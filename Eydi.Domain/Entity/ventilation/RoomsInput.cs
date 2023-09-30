using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;

namespace ES.Domain.Entity.ventilation
{
    public class RoomsInput:StrongEntity
    {
		//[Key]
		//      public long Id { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? KitchenLivingDiningRoom { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Bedroom { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? UtilityRoom { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? OtherHabitableRoom { get; set; }
		public long? VentiRateOtherBaseTypeId { get; set; }
		public TbDetail VentiRateOtherBaseType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? MinVentiRate { get; set; }
		public long? VentedComAppLimitTypeId { get; set; }
		public TbDetail VentedComAppLimitType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? VentedComAppLimitVal { get; set; }
	}
}
