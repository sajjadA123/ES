using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;

namespace ES.Domain.Entity.naturalAir
{
    public class AirLeakage:StrongEntity
    {
		//[Key]
  //      public long? Id { get; set; }
        public BlowerTestType TEST_CONDITIONS { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? OutsideTemp { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? BarometricPressure { get; set; }

		public long? TestTypeId { get; set; }
		public TbDetail TestType { get; set; }

		[Column(TypeName = "numeric(18,4)")]
		public decimal? FlowCoEff { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FlowExponent { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CorrelationCoEff { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? HeatedVolume { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ACH { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ELA { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RelativeError { get; set; }

		public long? Test1Equip1Id { get; set; }
		public TestEquip Test1Equip1 { get; set; }

		public long? Test1Equip2Id { get; set; }
		public TestEquip Test1Equip2 { get; set; }
	}
}
