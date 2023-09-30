using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.components
{
	public class CeilingDTO:StrongEntityDTO
	{
		public string CeilLable { get; set; }

		public CeilingConstType ConstractType { get; set; }

		public long? CeilTypeID { get; set; }
		public CodeSelectorDTO CeilType { get; set; }

		public decimal? Length { get; set; }
		public decimal? Area { get; set; }

		public TbDetailDTO RoofSlopeType { get; set; }

		public decimal? RoofSlopeId { get; set; }
		public decimal? RValue { get; set; }
		public decimal? HeelHeigth { get; set; }
	}
	public class CeilingSearch : BaseSearch
	{

	}
}
