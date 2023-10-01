using ES.Core.Contracts.Entities;

using System.ComponentModel.DataAnnotations;


namespace ES.Domain.Entity.baseInfo
{
    public class CodeSelector:StrongEntity
    {
		public long ID { get; set; }
		[MaxLength(100)]
		public string FloorLable { get; set; }

		public long? StructureTypeId { get; set; }
		public TbDetail StructureType { get; set; }

		public long? ComponentTypeSizeId { get; set; }
		public TbDetail ComponentTypeSize { get; set; }
		public long? SpacingId { get; set; }
		public TbDetail Spacing { get; set; }
		public long? InsulLay1Id { get; set; }
		public TbDetail InsulLay1 { get; set; }
		public long? InsulLay2Id { get; set; }
		public TbDetail InsulLay2 { get; set; }
		public long? InternalCodeId { get; set; }
		public string? InternalCode { get; set; }
		public long? InteriorId { get; set; }
		public TbDetail Interior { get; set; }
		public long? SheathingId { get; set; }
		public TbDetail Sheathing { get; set; }
		public long? ExteriorId { get; set; }
		public TbDetail Exterior { get; set; }
		public long? StudCornrIntersectId { get; set; }
		public TbDetail StudCornrIntersect { get; set; }
	}
}
