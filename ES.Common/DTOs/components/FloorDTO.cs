using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.components
{
	public class FloorDTO:StrongEntityDTO
	{
		public string FloorLable { get; set; }
		public bool? AdjuctEnCloseUncondSpc { get; set; }
		public long? FloorTypeId { get; set; }
		public CodeSelectorDTO FloorType { get; set; }
		public decimal? Heigth { get; set; }
		public decimal? Area { get; set; }
		public decimal? RValue { get; set; }
	}
	public class FloorSearch : BaseSearch
	{

	}
}
