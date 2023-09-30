using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.house
{
    public class HouseWeatherDTO: StrongEntityDTO
    {
		public long? HouseId { get; set; }
        public HouseFileDTO House { get; set; }
        public string WeatherLib { get; set; }

		public long? RegionId { get; set; }
        public TbDetailDTO   Region { get; set; }

        public  long? LocationsId { get; set; }
        public TbDetailDTO Locations { get; set; }

        public decimal? DEPTH_FROST { get; set; }
		public decimal? HEATINGDEGREEDAYS { get; set; }
        public class HouseWeatherSearch : BaseSearch
        {

        }
    }
}
