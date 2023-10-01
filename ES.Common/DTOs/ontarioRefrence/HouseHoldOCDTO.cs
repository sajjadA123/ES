
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.ontarioRefrence
{
	public class HouseHoldOCDTO:StrongEntityDTO
	{
		//[Key]
  //      public long? Id { get; set; }
        public decimal? AccupantsNum { get; set; }
		public decimal? ThemostatHSeasonDay { get; set; }
		public decimal? ThemostatHSeasonNight { get; set; }
		public decimal? ThemostatColling { get; set; }
		public bool? CoolingSeasonMonthNum { get; set; }
		public bool? ClothWasher { get; set; }
		public	bool? MorThn50CflLed { get; set; }
		public bool? LessThn5Year { get; set; }
		public class HouseHoldOCSearch : BaseSearch
		{

		}
	}
}
