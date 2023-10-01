using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;
using ES.DTOs.codes;

namespace ES.DTOs.components
{
	public class WallsDTO:StrongEntityDTO, IBaseComponent
	{
		public string Lable { get; set; }

		public TbDetailDTO FaceDir { get; set; }
		public long? FaceDirId { get; set; }

		public long? WallTypeId { get; set; }
		public  CodeByTypesDTO WallType { get; set; }

		public long? LintelTypeId { get; set; }
		public CodeByTypesDTO LintelType { get; set; }

		public decimal? Corners { get; set; }
		public decimal? Intersection { get; set; }
		public decimal? Heigth { get; set; }
		public decimal? Primeter { get; set; }
		public decimal? Area { get; set; }
		public bool? AdjustEnclosedUncondSPC { get; set; }
		public decimal? RValue { get; set; }

		public WallLocation WallLocation { get; set; }

	}
	public class WallsSearch : BaseSearch
	{

	}
}
