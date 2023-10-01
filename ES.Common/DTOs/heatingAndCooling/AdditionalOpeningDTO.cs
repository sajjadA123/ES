using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.heatingAndCooling
{
    public class AdditionalOpeningDTO:StrongEntityDTO

    {
		//[Key]
		//public long? ID { get; set; }
		public TbDetailDTO EquipmentType { get; set; }
		public decimal? FlueDiameter { get; set; }
		public bool? DamperClosed { get; set; }
        public long? HeatingAndCoolingId { get; set; }
        public class AdditionalOpeningSearch : BaseSearch
		{

		}
	}
}
