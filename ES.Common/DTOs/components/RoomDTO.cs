using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.components
{
    public class RoomDTO:StrongEntityDTO
    {
		public string Lable { get; set; }
		public decimal? DimensionHeigth { get; set; }
		public RoomShapeType SahpeType { get; set; }
		public decimal? FloorPerimeterOrLength { get; set; }
		public decimal? FloorAreaOrLength { get; set; }

		public RoomType RoomType { get; set; }

		public FloorType FloorType { get; set; }

		public long? FounDationBelowTypeId { get; set; }
		public TbDetailDTO FoundationBelowType { get; set; }

		public decimal? ExtWallsQty { get; set; }
		public decimal? ExtWallsGArea { get; set; }
		public decimal? ExtWallsNetArea { get; set; }
		public decimal? ExtCeillingQty { get; set; }
		public decimal? ExtCeillingGArea { get; set; }
		public decimal? ExtCeillingNetArea { get; set; }
		public decimal? DoorsQty { get; set; }
		public decimal? DoorsGArea { get; set; }
		public decimal? DoorsNetArea { get; set; }
		public decimal? ExtFloorsQty { get; set; }
		public decimal? ExtFloorGArea { get; set; }
		public decimal? FloorHdrsQty { get; set; }
		public decimal? FloorHdrsGArea { get; set; }
		public decimal? RoomArea { get; set; }
		public decimal? RoomPerimeter { get; set; }
		public decimal? RoomVolume { get; set; }
		public class RoomSearch : BaseSearch
		{

		}
	}
}
