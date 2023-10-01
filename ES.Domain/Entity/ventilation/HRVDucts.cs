using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;

namespace ES.Domain.Entity.ventilation
{
    public class HRVDucts:StrongEntity
    {
		public long? SupplyLocationTypeId { get; set; }
		public TbDetail SupplyLocationType { get; set; }

		public ColdAirType ColdAirSupplyType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ColdAirSuppDucLength { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ColdAirSuppDiameter { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ColdAirSuppInsulation { get; set; }
		public SealingCharact ColdAirSuppSealingCharact { get; set; }

		public long? ExhaustLocationTypeId { get; set; }
		public TbDetail ExhaustLocationType { get; set; }

		public ColdAirType ExhaustType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ExhaustSDLength { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ExhaustDiameter { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ExhaustInsulation { get; set; }
		public SealingCharact ExhaustSealingCharat { get; set; }
		//public decimal? SUP_LOC_TYPE { get; set; }
		//public decimal? COLD_LOC_TYPE { get; set; }
	}
}
