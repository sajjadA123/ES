using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.baseInfo
{
    public class LintelCodeSelectorDTO:StrongEntityDTO
    {
		public string LABLE { get; set; }
		public long? LintelTypeid { get; set; }
		public TbDetailDTO LintelType { get; set; }
		public LintelMaterial Material { get; set; }
		public decimal? InsulationId { get; set; }
		public TbDetailDTO Insulation { get; set; }
		public string InternalCode { get; set; }
		public class LintelCodeSelectorSearch : BaseSearch
		{

		}
	}
}
