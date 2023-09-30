using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.naturalAir
{
    public class AirLeakageDTO:StrongEntityDTO
    {
        public BlowerTestType TEST_CONDITIONS { get; set; }

		public decimal? OutsideTemp { get; set; }
		public decimal? BarometricPressure { get; set; }

		public long? TestTypeId { get; set; }
		public TbDetailDTO TestType { get; set; }

		public decimal? FlowCoEff { get; set; }
		public decimal? FlowExponent { get; set; }
		public decimal? CorrelationCoEff { get; set; }
		public decimal? HeatedVolume { get; set; }
		public decimal? ACH { get; set; }
		public decimal? ELA { get; set; }
		public decimal? RelativeError { get; set; }
		public long? Test1Equip1Id { get; set; }
		public TestEquipDTO Test1Equip1 { get; set; }

		public long? Test1Equip2Id { get; set; }
		public TestEquipDTO Test1Equip2 { get; set; }
		public class AirLeakageSearch : BaseSearch
		{

		}
	}
}
