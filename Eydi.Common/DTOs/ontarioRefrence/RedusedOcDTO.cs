using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.ontarioRefrence
{
	public class RedusedOcDTO:StrongEntityDTO
	{
		//[Key]
  //      public long? Id { get; set; }
        public bool? EnStarNewHome { get; set; }
		public LightingType LightingType { get; set; }
		public decimal? ClothesDryerVal { get; set; }
		public bool? ClothesDryerEn { get; set; }
		public decimal? ClothesWasherVal { get; set; }
		public bool? ClothesWasherEn { get; set; }
		public decimal? DishwasherVal { get; set; }
		public bool? DishwasherEn { get; set; }
		public decimal? RefrigeratorVal { get; set; }
		public	bool? RefrigeratorEn { get; set; }
		public decimal? Range { get; set; }
		public bool? HotwaterBathroomRate { get; set; }
		public bool? HotwaterShowerRate { get; set; }
		public class RedusedOcSearch : BaseSearch
		{

		}
	}
}
