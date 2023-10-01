using System.Collections.Generic;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.generation
{
    public class GenerationDTO:StrongEntityDTO
    {
		public decimal? PhotovoliSysCount { get; set; }
		public decimal? CapPhotovoliSys { get; set; }
		public bool? BatteryStorage { get; set; }
		public decimal? WindEnergy { get; set; }
		public bool? SolarReady { get; set; }
        public virtual List<PhotovoltaicSystemDTO> PhotovoltaicSystems { get; set; }

	}
	public class GenerationSearch : BaseSearch
	{

	}
}
