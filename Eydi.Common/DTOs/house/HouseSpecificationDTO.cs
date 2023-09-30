using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.house
{
	public class HouseSpecificationDTO: StrongEntityDTO
	{
		public long? HouseId { get; set; }
        public HouseFileDTO House { get; set; }

        public long? BulidingTypeID { get; set; }
        public TbDetailDTO BulidingType { get; set; }

		public long? HouseTypeID { get; set; }
		public TbDetailDTO HouseType { get; set; }

		public long? PlanShapeTypeId { get; set; }
		public TbDetailDTO PlanShapeType { get; set; }

		public long? StoreysId { get; set; }
		public TbDetailDTO Storeys { get; set; }

		public long? FrontOrientationId { get; set; }
		public TbDetailDTO FrontOrientation { get; set; }

		public long? ThermalMassTypeId { get; set; }
		public TbDetailDTO ThermalMassType { get; set; }

		public long? YearBuiltTypeId { get; set; }
		public TbDetailDTO YearBuiltType { get; set; }

		public long? CustomYearBuilt { get; set; }
		public decimal? EffectiveMassFract { get; set; }

		public long? WallColourTypeId { get; set; }
		public TbDetailDTO WallColourType { get; set; }


		public decimal? WallCoLourValue { get; set; }

		public long? FoundSoilCondTypeId { get; set; }
		public TbDetailDTO FoundSoilCondType { get; set; }

		public long? RoofCoLourTypeId { get; set; }
		public TbDetailDTO RoofCoLourType { get; set; }
		public decimal? RoofColourValue { get; set; }

		public long? WaterTabLevelTypeId { get; set; }
		public TbDetailDTO WaterTabLevelType { get; set; }

        public bool? DefaultCavity { get; set; }

        public long? RoofCavityId { get; set; }
		public RoofCavityInputDTO RoofCavityInput { get; set; }

		public bool? IS_NBC_COMP { get; set; }
		public decimal? HeatFloorAreaAbove { get; set; }
		public decimal? HeatFloorAreaBelow { get; set; }

		public decimal? StroreysInBldg { get; set; }//in Multi unit One Unit

		#region In Multi Unit Whole Building
		public decimal? HeatFloorAreaNonRes { get; set; }
		public decimal? HeatFloorAreaCommonSpc { get; set; }

		public decimal? DwellingUnitNum { get; set; }
		public decimal? NonResNum { get; set; }
		public decimal? UnitVisitedNum { get; set; }
		#endregion

	}
	public class HouseSpecificationSearch : BaseSearch
	{

	}
}
