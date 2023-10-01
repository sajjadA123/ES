using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ES.Domain.Entity.foundation
{
    public class WallFloorConstruction:StrongEntity
    {
		public long? InsulationConfigId { get; set; }
		public InsulationConfig InsulationConfig { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Overlap { get; set; }
		public long? PonyWallConsTypeId { get; set; }

		public TbDetail PonyWallConsType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? PonyWallRValue { get; set; }

		public long? PonyWallCompositeId { get; set; }
		public Composite PonyWallComposite { get; set; }

		public long? WallConsInAddedInsId { get; set; }
		public CodeSelector WallConsInAddedIns{ get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? WallConsInAddedInsRVal { get; set; }
		public long? WallConsCompositId { get; set; }
		public Composite WallConsComposit { get; set; }

		public string? CoreWallType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CoreWallRVal { get; set; }

		public long? ExtAddInsTypeId { get; set; }
		public TbDetail ExtAddInsType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ExtAddInsRVal { get; set; }

		public long? ExtAddInsCompositId { get; set; }
		public Composite ExtAddInsComposit { get; set; }

		public long? Corners { get; set; }

		public long? LintelsId { get; set; }
		public LintelCodeSelector Lintels { get; set; }

		public long? FloorConsInsAddedSlabTypeId { get; set; }
		public TbDetail FloorConsInsAddedSlabType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FloorConsInsAddedSlabRVal { get; set; }

		public long? FloorAbvFoundTypeId { get; set; }
		public CodeSelector FloorAbvFoundType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FloorAbvFoundRVal { get; set; }
		public bool? FloorAbowFrostline { get; set; }
		public bool? HeatedFloor { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RValSkirtVal { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RValThermalBreakVal { get; set; }
	}
}
