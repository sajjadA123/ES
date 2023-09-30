using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.heatingAndCooling.type2
{
    public class AirHeatPumpDTO : StrongEntityDTO,IType2
	{

        public EquipmentType2DTO EquipmentType { get; set; }

        public SpecificationType2DTO Specification { get; set; }
        public EquipmentInformationType2DTO EquipmentInformation { get; set; }

        public TbDetailDTO TempCutoffType { get; set; }
        public long? TempCutoffTypeId { get; set; }

		public decimal? CutoffTemp { get; set; }
		public TbDetailDTO TempRatingType { get; set; }
		public long? TempRatingTypeId { get; set; }
		public decimal? RatingTemp { get; set; }


        public decimal? CrankcaseHeat { get; set; }
		public decimal? SensibleHeatRate { get; set; }
		public decimal? OpenableWinArea { get; set; }

		public bool? ColdClimateHeatPumo { set; get; }

        public decimal? HeatEff { get; set; }
        public decimal? CoolEf { get; set; }
        public decimal? Capacity { get; set; }
        public CapacityUnit CapacityUnit { get; set; }
        public decimal? CopAt { get; set; }
        public decimal? CapMain { get; set; }


    }
	public class AirHeatPumpSearch : BaseSearch
	{

	}
}
