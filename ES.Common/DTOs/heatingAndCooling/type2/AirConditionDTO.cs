using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.heatingAndCooling.type2
{
    public class AirConditionDTO : StrongEntityDTO,IType2
	{

        public EquipmentType2DTO EquipmentType { get; set; }

        public SpecificationType2DTO Specification { get; set; }
        public EquipmentInformationType2DTO EquipmentInformation { get; set; }



        public decimal? CrankcaseHeat { get; set; }
		public decimal? SensibleHeatRate { get; set; }
		public decimal? OpenableWinArea { get; set; }
	


	}
	public class AirConditionSearch : BaseSearch
	{

	}
}
