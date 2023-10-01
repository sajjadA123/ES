using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ES.Domain.Entity.house
{
    public class RoofCavityInput:StrongEntity
    {
		//[Key]
		//public long? ID { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? GeTotalArea { get; set; }

		public long? GeSheathingMatTypeId { get; set; }
        public TbDetail GeSheathingMatType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? GeSheathingMatValue { get; set; }

		public long? GeExteriorMatTypeId { get; set; }
		public TbDetail GeExteriorMatType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? GeExteriorMatValue { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? SrTotalArea { get; set; }

		public long? SrSheathingMatTypeId { get; set; }
		public TbDetail SrSheathingMatType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? SrSheathingMatValue { get; set; }

		public long? SrRoofingMatTypeId { get; set; }
		public TbDetail SrRoofingMatType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? SrRoofingMatValue { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CavityVol { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? VentilationRate { get; set; }
	}
}
