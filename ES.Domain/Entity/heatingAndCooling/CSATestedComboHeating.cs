using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.common;
using ES.Domain.Entity.domesticHotWater;

namespace ES.Domain.Entity.heatingAndCooling
{
    public class CSATestedComboHeating:StrongEntity
    {
		//[Key]
  //      public long? Id { get; set; }
        public CSADataType DataType { get; set; }
		[MaxLength(100)]
		public string Manufacture { get; set; }
		[MaxLength(100)]
		public string Model { get; set; }

		public long? P9SysNum { get; set; }
		public long? CSAP9Id { get; set; }
		public CSAP9TestData CSAP9 { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ThrmalPerFactor { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AnnualElec { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? SpcHeatingCap { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CompositeSHE { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? WaterHeatPerFact { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? NominalBurner { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RecoveryEff { get; set; }
		public long? DWHRId { get; set; }
        public DWHR DWHR { get; set; }
    }
}
