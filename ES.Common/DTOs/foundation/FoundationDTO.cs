using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.DTOs.baseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Common.DTOs.foundation
{
    public class FoundationDTO: StrongEntityDTO
	{
		#region general
		public string Lable { get; set; }
		public int? OpeningToUpstairTypeId { get; set; }
		public TbDetailDTO OpeningToUpstairType { get; set; }
		public decimal? OpeningToUpstairValue { get; set; }

		public RoomType FoundationRoomType { get; set; }

		public CrawlSpaceType CrawlSpaceType { get; set; }
		#endregion
		#region Floor Demision
		public FloorDimension FloorDimensionType { get; set; }
		public decimal? FloorLengthOrPerimeter { get; set; }
		public decimal? FloorWidthOrTotalArea { get; set; }

		#endregion
		#region Wall Demison
		public bool? PonyWall { get; set; }
		public decimal? PonyWallHeigth { get; set; }
		#endregion
		#region Measurment
		public decimal? WallDimTotalHeigth { get; set; }
		public decimal? WallDepthBGrade { get; set; }

		#endregion
		public decimal? ExAreaAG { get; set; }
		public decimal? ExAreaBG { get; set; }
		public decimal? InAreaAG { get; set; }
		public decimal? InAreaBG { get; set; }
		public decimal? ExSurPerimeter { get; set; }


	}
}
