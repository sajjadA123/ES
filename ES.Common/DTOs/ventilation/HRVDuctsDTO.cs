using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.ventilation
{
    public class HRVDuctsDTO:StrongEntityDTO
    {
		public long? SupplyLocationTypeId { get; set; }
		public ColdAirLocation SupplyLocationType { get; set; }

		public ColdAirType ColdAirSupplyType { get; set; }
		public decimal? ColdAirSuppDucLength { get; set; }
		public decimal? ColdAirSuppDiameter { get; set; }
		public decimal? ColdAirSuppInsulation { get; set; }
		public SealingCharact ColdAirSuppSealingCharact { get; set; }

		public long? ExhaustLocationTypeId { get; set; }
		public ColdAirLocation ExhaustLocationType { get; set; }

		public ColdAirType ExhaustType { get; set; }
		public decimal? ExhaustSDLength { get; set; }
		public decimal? ExhaustDiameter { get; set; }
		public decimal? ExhaustInsulation { get; set; }
		public SealingCharact ExhaustSealingCharat { get; set; }


		public class HRVDuctsSearch : BaseSearch
		{

		}
	}
}
