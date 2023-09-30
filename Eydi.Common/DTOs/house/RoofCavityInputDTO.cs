using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.house
{
    public class RoofCavityInputDTO: StrongEntityDTO
	{
		public decimal? GeTotalArea { get; set; }

		public long? GeSheathingMatTypeId { get; set; }
        public TbDetailDTO GeSheathingMatType { get; set; }
        public decimal? GeSheathingMatValue { get; set; }

		public long? GeExteriorMatTypeId { get; set; }
		public TbDetailDTO GeExteriorMatType { get; set; }
		public decimal? GeExteriorMatValue { get; set; }

		public decimal? SrTotalArea { get; set; }

		public long? SrSheathingMatTypeId { get; set; }
		public TbDetailDTO SrSheathingMatType { get; set; }
		public decimal? SrSheathingMatValue { get; set; }

		public long? SrRoofingMatTypeId { get; set; }
		public TbDetailDTO SrRoofingMatType { get; set; }
		public decimal? SrRoofingMatValue { get; set; }

		public decimal? CavityVol { get; set; }
		public decimal? VentilationRate { get; set; }
		public class RoofCavityInputSearch : BaseSearch
		{

		}
	}
}
