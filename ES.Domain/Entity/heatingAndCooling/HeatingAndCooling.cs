using System;
using System.Collections.Generic;
using System.Text;
using ES.Common.Enums;
using ES.Core.Contracts.Entities;

namespace ES.Domain.Entity.heatingAndCooling
{
    public class HeatingAndCooling:StrongEntity
    {
		//public int? Type1Type { get; set; }
		public long? Type1Id { get; set; }
        public Type1 Type1 { get; set; }
        //public int? Type2Type { get; set; }
        public long? Type2Id { get; set; }
        public Type2 Type2 { get; set; }
        public bool? AccountForShading { get; set; }

		public long? RadiantHeatingId { get; set; }
		public Radiant RadiantHeating { get; set; }

		public long? AditionalOpeningId { get; set; }
        public AdditionalOpening AditionalOpening { get; set; }
        public long? SupHeatSys { get; set; }

		public GeoMonthType SeasonCoolStartMon { get; set; }
		public GeoMonthType SeasonCoolEndMon { get; set; }
		public GeoMonthType SeasonCoolDesignMon { get; set; }
		public long? FanPumpId { get; set; }
		public FansAndPumps FanPump { get; set; }
		//public decimal? AC_ID { get; set; }
		//public decimal? BASEBOARD_ID { get; set; }
		//public decimal? FURNACE_ID { get; set; }
		//public decimal? BOILER_ID { get; set; }
		public long? CsaComHeatId { get; set; }
		public CSATestedComboHeating CsaComHeat { get; set; }

	}
}
