using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.naturalAir
{
    public class NaturalAirInfiltrationDTO:StrongEntityDTO
    {
		public decimal? HouseVolume { get; set; }
        public bool IncludeCrwlSpcVol { get; set; }
        public long? AirTigthnessTypeId { get; set; }
		public TbDetailDTO AirTigthnessType { get; set; }

		public long? BuildingSiteTerrainId { get; set; }
		public TbDetailDTO BuildingSiteTerrain { get; set; }

		public decimal? AboveGradeHeigth { get; set; }

		public TbDetailDTO DepressTestType { get; set; }
		public decimal? DepressTestTypeId { get; set; }

		public decimal? DepressTestResult { get; set; }

		public long? AirLeakageTestId { get; set; }
		public AirLeakageDTO AirLeakageTest { get; set; }

		public bool? Guarded { get; set; }
		public decimal? AirChangeRate { get; set; }
		public BlowerTestType TestType { get; set; }

		public UserSpecOrCalcType EquvalLeakageAreaType { get; set; }
		public decimal? EquvalLeakageAreaVal { get; set; }
		public TbDetailDTO EquvalLeakageAreaAt { get; set; }
		public decimal EquvalLeakageAreaAtId { get; set; }

		public long? LocalShadeWallTypeId { get; set; }
		public TbDetailDTO LocalShadeWallType { get; set; }

		public TbDetailDTO LocalShadeFlueType { get; set; }
		public decimal LocalShadeFlueTypeId { get; set; }
		public decimal? CommonSurFloor { get; set; }
		public decimal? CommonSurWalls { get; set; }
		public decimal? CommonSurCeilings { get; set; }
		public decimal? CommonSurTot { get; set; }

		public long? WeatherStTerrainTypeId { get; set; }
		public TbDetailDTO WeatherStTerrainType { get; set; }

		public decimal? WeatherStTerrainAnemHeight { get; set; }
		public DefaultOrUserSpecType LeakageFracType { get; set; }

		public decimal? LeakageFracCeillings { get; set; }
		public decimal? LeakageFracWalls { get; set; }
		public decimal? LeakageFracFloors { get; set; }
		public class NaturalAirInfiltrationSearch : BaseSearch
		{

		}
	}
}
