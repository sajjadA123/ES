using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Common.Enums;
using ES.Core.Contracts.Entities;

namespace ES.Domain.Entity.naturalAir
{
    public class TestEquipData:StrongEntity
    {
		public long? TestId { get; set; }
		public TestEquip Test { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? HsePressurePa { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FanPressurePa { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? MeasuredFlowCfm { get; set; }
		public TestFlowRange FlowRanged { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? MeasuredFlowCfmRes { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CorrectPressurePa { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CorrectFlowCfm { get; set; }
	}
}
