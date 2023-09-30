using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.components
{
	public class DoorDTO:StrongEntityDTO
	{
		public string DoorLable { get; set; }
		public long? DoorTypeId { get; set; }
		public TbDetailDTO DoorType { get; set; }
		public bool? EnergyStar { get; set; }
		public bool? AdjustEnclose { get; set; }
		public decimal? Width { get; set; }
		public decimal? Heigth { get; set; }
		public decimal? GArea { get; set; }
		public decimal? RValue { get; set; }
	}
	public class DoorSearch : BaseSearch
	{

	}
}
