using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs
{
	public class TemperaturesDTO:StrongEntityDTO
	{
		public decimal? DaytimeHeatPoint { get; set; }
		public decimal? DaytimeCoolPoint { get; set; }
		public decimal? NigthtimeHeatPoint { get; set; }
		public decimal? NigthtimeCoolPoint { get; set; }
		public TbDetailDTO AllowableRiseType { get; set; }
		public TbDetailDTO AllowableRiseId { get; set; }
		public bool? BasementHeated { get; set; }
		public bool? BasementCooled { get; set; }
		public decimal? BasementHeatDegr { get; set; }
		public bool? BasementSepThermostat { get; set; }
		public decimal? EquipmentHeadSetPoint { get; set; }
		public decimal? EquipmentCoolSetPoint { get; set; }
		public bool? CrawlSpcHeated { get; set; }
		public decimal? CrawlSpcHeatSetPoint { get; set; }
	}
	public class TemperaturesSearch : BaseSearch
	{

	}
}
