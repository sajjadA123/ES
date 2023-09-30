using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;
using ES.DTOs.baseLoad;
using ES.DTOs.components;
using ES.DTOs.house.fuel;
using System;
using System.Collections.Generic;

namespace ES.DTOs.house
{
	public class HouseFileDTO: StrongEntityDTO
	{
		
        public string	FileId { get; set; }
		
		public string PrevFileId { get; set; }
		
		public string HouseId { get; set; }
		
		public string HomeOwnerId { get; set; }
		public long? OwnershipId { get; set; }
		public TbDetailDTO OwnerShip { get; set; }
		 
		public string TaxRollNum { get; set; }
		
		public string BuilderName { get; set; }
		public TimeSpan EvalDate { get; set; }
		
		public string EnteredBy { get; set; }
		public string Telephone { get; set; }
		
		public string Extention { get; set; }
		
		public string CompanyExtention { get; set; }
		
		public string CompanyUser { get; set; }
		public string CompanyTelephone { get; set; }
		public bool? MixedUse { get; set; }

		public long? ClientId { get; set; }
        public HouseClientDTO HouseClient { get; set; }
		public long? JustificationId { get; set; }
        public JustificationDTO Justification { get; set; }
		/// <summary>
		/// virtual
		/// </summary>
		public virtual List<HouseInfoDTO> HouseInfo { get; set; }
		public virtual HouseSpecificationDTO HouseSpecification { get; set; }
		public virtual HouseWeatherDTO HouseWeather { get; set; }
		public virtual HouseFuelDTO FuelCost { get; set; }
		public virtual UnitsModeDTO UnitsMode { get; set; }	
		public virtual WinTightnessDTO WinTightness { get; set; }
		public virtual CodeSummaryDTO CodeSummary { get; set; }
		public virtual ventilation.VentilationDTO Ventilation { get; set; }
		public virtual TemperaturesDTO Temperatures { get; set; }
		public virtual baseLoad.BaseLoadDTO BaseLoad { get; set; }
		public virtual generation.GenerationDTO Generation { get; set; }
		public virtual naturalAir.NaturalAirInfiltrationDTO NaturalAirInfiltration { get; set; }
		public virtual heatingAndCooling.HeatingAndCoolingDTO HeatingAndCooling { get; set; }
        public virtual List<IBaseComponent> Components { get; set; }
        public virtual codes.CodesDTO Codes { get; set; }

    }
	public class HouseFileSearch : BaseSearch
	{

	}
}
