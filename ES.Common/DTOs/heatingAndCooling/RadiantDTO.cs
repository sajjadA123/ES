using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.heatingAndCooling
{
    public class RadiantDTO: StrongEntityDTO
	{
		//[Key]
		//public long? Id { get; set; }
		public decimal? AticCeilingEffTemp { get; set; }
		public decimal? AticCeilingTotArea { get; set; }
		public decimal? FlatRoofEffTemp { get; set; }
		public decimal? FlatRoofTotArea { get; set; }
		public decimal? FloorAbCrawlSpcEffTemp { get; set; }
		public decimal? FloorAbCrawlSpcTotArea { get; set; }
		public decimal? SlabOnGradeEffTemp { get; set; }
		public decimal? SlabOnGradeTotArea { get; set; }
		public decimal? FloorAbBasementEffTemp { get; set; }
		public decimal? FloorAbBasementTotArea { get; set; }
		public decimal? BasementEffTemp { get; set; }
		public decimal? BasementTotArea { get; set; }
		public class RadiantSearch : BaseSearch
		{

		}
	}
}
