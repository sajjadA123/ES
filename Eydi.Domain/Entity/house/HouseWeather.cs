using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ES.Domain.Entity.house
{
    public class HouseWeather:StrongEntity
    {
		public long? HouseId { get; set; }
        public HouseFile House { get; set; }
		[MaxLength(250)]
        public string WeatherLib { get; set; }

		public long? RegionId { get; set; }
        public Regions   Region { get; set; }

        public  long? LocationsId { get; set; }
        public Location Locations { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? DEPTH_FROST { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? HEATINGDEGREEDAYS { get; set; }
	}
}
