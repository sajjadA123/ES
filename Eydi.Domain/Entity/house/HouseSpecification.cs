using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using ES.Domain.Entity.house;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ES.Domain.Entity
{
	public class HouseSpecification:StrongEntity
	{
		public long? HouseId { get; set; }
        public HouseFile House { get; set; }

        public long? BulidingTypeID { get; set; }
        public TbDetail BulidingType { get; set; }

        public long? PlanShapeTypeId { get; set; }
		public TbDetail PlanShapeType { get; set; }

		public long? StoreysId { get; set; }
		public TbDetail Storeys { get; set; }

		public long? FrontOrientationId { get; set; }
		public TbDetail FrontOrientation { get; set; }

		public long? ThermalMassTypeId { get; set; }
		public TbDetail ThermalMassType { get; set; }

		public long? YearBuiltTypeId { get; set; }
		public TbDetail YearBuiltType { get; set; }

		public long? CustomYearBuilt { get; set; }
		public decimal? EffectiveMassFract { get; set; }

		public long? WallColourTypeId { get; set; }
		public TbDetail WallColourType { get; set; }

		[Column(TypeName = "numeric(18,4)")]
		public decimal? WallCoLourValue { get; set; }

		public long? FoundSoilCondTypeId { get; set; }
		public TbDetail FoundSoilCondType { get; set; }

		public long? RoofCoLourTypeId { get; set; }
		public TbDetail RoofCoLourType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RoofColourValue { get; set; }

		public long? WaterTabLevelTypeId { get; set; }
		public TbDetail WaterTabLevelType { get; set; }

		public long? RoofCavityId { get; set; }
		public RoofCavityInput RoofCavityInput { get; set; }

		public bool? IS_NBC_COMP { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? HeatFloorAreaAbove { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? HeatFloorAreaBelow { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? StroreysInBldg { get; set; }//in Multi unit One Unit

		#region In Multi Unit Whole Building
		[Column(TypeName = "numeric(18,4)")]
		public decimal? HeatFloorAreaNonRes { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? HeatFloorAreaCommonSpc { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? DwellingUnitNum { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? NonResNum { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? UnitVisitedNum { get; set; }
        #endregion


    }
}
