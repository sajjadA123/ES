using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ES.Domain.Entity.naturalAir
{
    public class NaturalAirInfiltration:StrongEntity
    {
		[Column(TypeName = "numeric(18,4)")]
		public decimal? HouseVolume { get; set; }

		public long? AirTigthnessTypeId { get; set; }
		public TbDetail AirTigthnessType { get; set; }

		public long? BuildingSiteTerrainId { get; set; }
		public TbDetail BuildingSiteTerrain { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AboveGradeHeigth { get; set; }

		public DepressTestType DepressTestType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? DepressTestResult { get; set; }

		public long? AirLeakageTestId { get; set; }
		public AirLeakage AirLeakageTest { get; set; }

		public bool? Guarded { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AirChangeRate { get; set; }
		public BlowerTestType TestType { get; set; }

		public UserSpecOrCalcType EquvalLeakageAreaType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? EquvalLeakageAreaVal { get; set; }
		public EquvalLeakageAreaAt EquvalLeakageAreaAt { get; set; }

		public long? LocalShadeWallTypeId { get; set; }
		public TbDetail LocalShadeWallType { get; set; }

		public LocalShadeFlueType LocalShadeFlueType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CommonSurFloor { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CommonSurWalls { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CommonSurCeilings { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CommonSurTot { get; set; }

		public long? WeatherStTerrainTypeId { get; set; }
		public TbDetail WeatherStTerrainType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? WeatherStTerrainAnemHeight { get; set; }
		public UserOrDefult LeakageFracType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? LeakageFracCeillings { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? LeakageFracWalls { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? LeakageFracFloors { get; set; }
	}
}
