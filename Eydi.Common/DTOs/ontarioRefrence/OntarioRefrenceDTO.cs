using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.ontarioRefrence
{
	public class OntarioRefrenceDTO:StrongEntityDTO
	{
		public long? ApplyHosueholdOCID { get; set; }
		public HouseHoldOCDTO ApplyHosueholdOC { get; set; }

		public long? AtypicalEnergyLoadID { get; set; }
		public ATypicalEnergyLoadDTO AtypicalEnergyLoad { get; set; }

		public long? WaterConservationId { get; set; }
		public WaterConservationDTO WaterConservation { get; set; }

		public long? ApplyRediOCAndESID { get; set; }
		public RedusedOcDTO ApplyRediOCAndES { get; set; }

		public long? RefHouseID { get; set; }
		public RefrenceHouseDTO RefHouse { get; set; }

		public long? GreenerHomeId { get; set; }
		public GreenerHomeDTO GreenerHome { get; set; }

		public IndicatePresenceVermiculite IndicatePresenceType { get; set; }

		public string AirSeal { get; set; }
		public string MainWalls { get; set; }
		public string Ceillings { get; set; }
		public string CatchedralCeilling { get; set; }
		public string ExposedFloor { get; set; }
		public string Foundation { get; set; }
		public string Windows { get; set; }
		public string Doors { get; set; }
		public string VentilationSys { get; set; }
		public string HotWaterSys { get; set; }
		public string HeatingSys { get; set; }
		public string CoolingSys { get; set; }
		public string Renewable { get; set; }
		public string WaterConser { get; set; }
		public string AdditionalComment { get; set; }
		public class OntarioRefrenceSearch : BaseSearch
		{

		}
	}
}
