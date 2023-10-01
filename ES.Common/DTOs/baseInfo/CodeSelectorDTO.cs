using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.baseInfo
{
    public class CodeSelectorDTO:StrongEntityDTO
    {
		
		public string FloorLable { get; set; }

		public long? StructureTypeId { get; set; }
		public TbDetailDTO StructureType { get; set; }

		public long? ComponentTypeSizeId { get; set; }
		public TbDetailDTO ComponentTypeSize { get; set; }
		public long? SpacingId { get; set; }
		public TbDetailDTO Spacing { get; set; }
		public long? InsulLay1Id { get; set; }
		public TbDetailDTO InsulLay1 { get; set; }
		public long? InsulLay2Id { get; set; }
		public TbDetailDTO InsulLay2 { get; set; }
		public long? InternalCodeId { get; set; }
		public string? InternalCode { get; set; }
		public long? InteriorId { get; set; }
		public TbDetailDTO Interior { get; set; }
		public long? SheathingId { get; set; }
		public TbDetailDTO Sheathing { get; set; }
		public long? ExteriorId { get; set; }
		public TbDetailDTO Exterior { get; set; }
		public long? StudCornrIntersectId { get; set; }
		public TbDetailDTO StudCornrIntersect { get; set; }
	}
	public class CodeSelectorSearch : BaseSearch
	{

	}
}
