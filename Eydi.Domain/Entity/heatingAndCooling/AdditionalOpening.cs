using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ES.Domain.Entity.heatingAndCooling
{
    public class AdditionalOpening:StrongEntity
    {
		//[Key]
		//public long? ID { get; set; }
		public EquipmentType EquipmentType1 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FlueDiameter1 { get; set; }
		public bool? DamperClosed1 { get; set; }
		public EquipmentType EquipmentType2 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FlueDiameter2 { get; set; }
		public bool? DamperClosed2 { get; set; }
		public EquipmentType EquipmentType3 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FlueDiameter3 { get; set; }
		public bool? DamperClosed3 { get; set; }
	}
}
