using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.heatingAndCooling.type1
{
    public class CSAP9TestDataDTO:StrongEntityDTO, IType1
	{
		//[Key]
  //      public long? Id { get; set; }
        public TbDetailDTO EnergyType { get; set; }
        public long? EnergyTypeId { get; set; }
		public decimal? NetEff15 { get; set; }
		public decimal? NetEff40 { get; set; }
		public decimal? NetEff100 { get; set; }
		public decimal? AvgElecUse15 { get; set; }
		public decimal? AvgElecUse40 { get; set; }
		public decimal? AvgElecUse100 { get; set; }
		public decimal? CirclBmePower15 { get; set; }
		public decimal? CirclBmePower40 { get; set; }
		public decimal? CirclBmePower100 { get; set; }
		public decimal? Pcont { get; set; }
		public decimal? Pcirc { get; set; }
		public decimal? DailyElWaterHeat { get; set; }
		public decimal? ThemalStandbyOn { get; set; }
		public decimal? ThemalStandbyOff { get; set; }
		public decimal? HDeliverRateDhw { get; set; }
		public decimal? HDeliverRateSh { get; set; }
		public class CSAP9TestDataSearch : BaseSearch
		{

		}
	}
}
