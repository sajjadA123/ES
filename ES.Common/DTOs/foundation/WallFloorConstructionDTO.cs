using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.Common.DTOs.foundation
{
    public class WallFloorConstructionDTO:StrongEntityDTO
    {
		#region general
		public long? InsulationConfigId { get; set; }
		public InsulationConfigDTO InsulationConfig { get; set; }
		public decimal? Overlap { get; set; }
		#endregion
		#region ponyWall

		public int? PonyWallConsTypeId { get; set; }

		public CodeSelectorDTO PonyWallConsType { get; set; }
		public decimal? PonyWallRValue { get; set; }
		public long? PonyWallCompositeId { get; set; }
		public CompositeDTO PonyWallComposite { get; set; }
		#endregion
		#region WallConst
		public long? WallConsInAddedInsId { get; set; }
		public CodeSelectorDTO WallConsInAddedIns { get; set; }

		public decimal? WallConsInAddedInsRVal { get; set; }
		public long? WallConsCompositId { get; set; }
		public CompositeDTO WallConsComposit { get; set; }
		public long? Corners { get; set; }

		public long? LintelsId { get; set; }
		public LintelCodeSelectorDTO Lintels { get; set; }

		public string? CoreWallType { get; set; }
		public decimal? CoreWallRVal { get; set; }

		public long? ExtAddInsTypeId { get; set; }
		public TbDetailDTO ExtAddInsType { get; set; }

		public decimal? ExtAddInsRVal { get; set; }

		public long? ExtAddInsCompositId { get; set; }
		public CompositeDTO ExtAddInsComposit { get; set; }

		public decimal? RValSkirtVal { get; set; }
		public decimal? RValThermalBreakVal { get; set; }
		#endregion
		#region floor Const
		public long? FloorConsInsAddedSlabTypeId { get; set; }
		public TbDetailDTO FloorConsInsAddedSlabType { get; set; }

		public decimal? FloorConsInsAddedSlabRVal { get; set; }

		public long? FloorAbvFoundTypeId { get; set; }
		public CodeSelectorDTO FloorAbvFoundType { get; set; }

		public decimal? FloorAbvFoundRVal { get; set; }
		public bool? FloorAbowFrostline { get; set; }
		public bool? HeatedFloor { get; set; }


		#endregion


		public class WallFloorConstructionSearch : BaseSearch
		{

		}
	}
}
