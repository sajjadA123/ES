using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using System.Collections.Generic;

namespace ES.DTOs.heatingAndCooling
{
    public class HeatingAndCoolingDTO: StrongEntityDTO
	{
        public type1.Type1 Type1 { get; set; }
        public type2.Type2 Type2 { get; set; }
		public bool? AccountForShading { get; set; }

		public long? RadiantHeatingId { get; set; }
		public RadiantDTO RadiantHeating { get; set; }
        public long? SupHeatSys { get; set; }

		public GeoMonthType SeasonCoolStartMon { get; set; }
		public GeoMonthType SeasonCoolEndMon { get; set; }
		public GeoMonthType SeasonCoolDesignMon { get; set; }
		public long? FanPumpId { get; set; }
		public FansAndPumpsDTO FanPump { get; set; }


		public virtual List<AdditionalOpeningDTO> AditionalOpenings { get; set; }
		public virtual List<SupplHtgDTO> SupplHtgs { get; set; }


	}
	public class HeatingAndCoolingSearch : BaseSearch
	{

	}
}
