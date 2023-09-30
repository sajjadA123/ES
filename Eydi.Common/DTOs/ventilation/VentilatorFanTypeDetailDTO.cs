using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.ventilation
{
    public class VentilatorFanTypeDetailDTO:StrongEntityDTO
    {
		public VentilatorFanType DetailType { get; set; }
		public string EquipmentManufact { get; set; }
		public string EquipmentModel { get; set; }

		public long? SchaduleOpTypeID { get; set; }//Supp
		public TbDetailDTO SchaduleOpType { get; set; }//Supp

		public decimal? SCHADULE_OP_VAL { get; set; }//Sup

		public bool? EnergyStar { get; set; }
		public bool? HVI { get; set; }
		public decimal? AirflowSupply { get; set; }
		public decimal? AirflowExhaust { get; set; }
		public bool? UseDefFanPwr { get; set; }
		public decimal? RatingCondPwr1 { get; set; }
		public decimal? RatingCondTemp1 { get; set; }
		public decimal? RatingCondEff1 { get; set; }
		public decimal? RatingCondPwr2 { get; set; }
		public decimal? RatingCondTemp2 { get; set; }
		public decimal? RatingCondEff2 { get; set; }
		public decimal? PreheaterCap { get; set; }
		public decimal? LowTempVentReduct { get; set; }
		public decimal? CoolingEff { get; set; }
		public decimal? HrvDuctsId { get; set; }

		public DryerExhaustDestination DryerExDestType { get; set; }
		public class VentilatorFanTypeDetailSearch : BaseSearch
		{

		}
	}
}
