using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.heatingAndCooling.type2
{
    public class GroundHeatPumpDTO : StrongEntityDTO, IType2
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



		public UserSpecOrCalcType GroundTempUseType { get; set; }
		public long? WaterTempMonId { get; set; }
		public HeatPumpSourceTempMonthlyDTO WaterTempMon { get; set; }

		public decimal? AvgDepth { get; set; }



	}
	public class GroundHeatPumpSearch : BaseSearch
	{

	}
}
