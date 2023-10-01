using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.naturalAir
{
    public class TestEquipDataDTO:StrongEntityDTO
    {
		public TestEquipDTO Test { get; set; }

		public decimal? HsePressurePa { get; set; }
		public decimal? FanPressurePa { get; set; }
		public decimal? MeasuredFlowCfm { get; set; }
		public TestFlowRange FlowRanged { get; set; }
		public decimal? MeasuredFlowCfmRes { get; set; }
		public decimal? CorrectPressurePa { get; set; }
		public decimal? CorrectFlowCfm { get; set; }
		public class TestEquipDataSearch : BaseSearch
		{

		}
	}
}
