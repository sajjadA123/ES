using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;
using System.Collections.Generic;

namespace ES.Common.DTOs.foundation
{
	public class BasementDTO : StrongEntityDTO
	{
		public BasementDTO(BasementType basementType) { BasementType = basementType; }
		public BasementType BasementType { get; set; }//CrwlSpace or Basement or slab or WalkOut
		public long? Foundation { get; set; }
		public FoundationDTO FoundationConst { get; set; }
		public long? WallFloorConstId { get; set; }
		public WallFloorConstructionDTO WallFloorConst { get; set; }
		public virtual List<BasementAttachDTO> BasementAttachList { get; set; }
	}
	public class BasementSearch : BaseSearch
	{

	}
}
