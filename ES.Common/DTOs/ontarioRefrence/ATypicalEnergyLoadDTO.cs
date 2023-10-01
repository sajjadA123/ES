using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
namespace ES.DTOs.ontarioRefrence
{
    public class ATypicalEnergyLoadDTO:StrongEntityDTO
    {
        public bool? DeIcingCable { get; set; }
		public bool? ElecVehicleShargSt { get; set; }
		public bool? ExExtLight { get; set; }
		public bool? HeatedGarag { get; set; }
		public bool? HotTub { get; set; }
		public bool? MixedUse { get; set; }
		public bool? OutGas { get; set; }
		public bool? SwimmPool { get; set; }
		public decimal? UnitCount { get; set; }
		public decimal? EnStarCout { get; set; }
		public class ATypicalEnergyLoadSearch : BaseSearch
		{

		}
	}
}
