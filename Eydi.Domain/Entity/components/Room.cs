using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;

namespace ES.Domain.Entity.components
{
    public class Room:StrongEntity
    {
		[MaxLength(100)]
		public string Lable { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? DimensionHeigth { get; set; }
		public RoomShapeType SahpeType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FloorPerimeterOrLength { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FloorAreaOrLength { get; set; }

		public long? RoomTypeId { get; set; }
		public TbDetail RoomType { get; set; }

		public long? FloorTypeId { get; set; }
		public TbDetail FloorType { get; set; }

		public long? FounDationBelowTypeId { get; set; }
		public TbDetail FounDationBelowType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ExtWallsQty { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ExtWallsGArea { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ExtWallsNetArea { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ExtCeillingQty { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ExtCeillingGArea { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ExtCeillingNetArea { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? DoorsQty { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? DoorsGArea { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? DoorsNetArea { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ExtFloorsQty { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ExtFloorGArea { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FloorHdrsQty { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FloorHdrsGArea { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RoomArea { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RoomPerimeter { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RoomVolume { get; set; }
	}
}
