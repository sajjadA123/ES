using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Common.DTOs.components
{
	public class FloorHeaderDTO : StrongEntityDTO
	{
		public string Lable { get; set; }
		public bool? AdjuctEnCloseUncondSpc { get; set; }
		public Orientation  FacingDirection { get; set; }
		public long? FloorHeaderTypeId { get; set; }
		public CodeSelectorDTO FloorHeaderType { get; set; }
		public  long Location { get; set; }
		public decimal? Heigth { get; set; }
		public decimal? Area { get; set; }
		public decimal? Primeter { get; set; }

		public decimal? RValue { get; set; }
	}
	public class FloorHeaderSearch : BaseSearch
	{

	}
}

