using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
namespace ES.DTOs.baseInfo
{
    public class CompositeDTO:StrongEntityDTO
    {
		//[Key]
		//public long? ID { get; set; }
		public decimal? Sec1Area { get; set; }
		public decimal? Sec1Rsi { get; set; }
		public decimal? Sec2Area { get; set; }
		public decimal? Sec2Rsi { get; set; }
		public decimal? RemArea { get; set; }
		public decimal? RemRsi { get; set; }
		public decimal? EffRsi { get; set; }
		public class CompositeSearch : BaseSearch
		{

		}
	}
}
