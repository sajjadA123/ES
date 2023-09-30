using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using ES.Domain.Entity.foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ES.Domain.Entity
{
	public class Basement:StrongEntity
	{
		[MaxLength(100)]
		public string Lable { get; set; }

		public int? OpeningToUpstairTypeId { get; set; }
		public TbDetail OpeningToUpstairType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? OpeningToUpstairValue { get; set; }

		public int? FoundationRoomTypeId { get; set; }
		public TbDetail FoundationRoomType { get; set; }

		public FloorDimension FloorDimensionType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FloorLengthOrPerimeter { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FloorWidthOrTotalArea { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? WallDimTotalHeigth { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? WallDepthBGrade { get; set; }
		
		public bool? PonyWall { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? PonyWallHeigth { get; set; }
		//public string? AttachDataMethod { get; set; }


		[Column(TypeName = "numeric(18,4)")]
		public decimal? ExSurPerimeter { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ExAreaAG { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ExAreaBG { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? InAreaAG { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? InAreaBG { get; set; }
		public BasementType BasementType { get; set; }//CrwlSpace or Basement or slab or WalkOut
		public long? WallFloorConstId { get; set; }
		public WallFloorConstruction WallFloorConst { get; set; }
		public virtual List<BasementAttach> BasementAttachList { get; set; } 
	}
}
