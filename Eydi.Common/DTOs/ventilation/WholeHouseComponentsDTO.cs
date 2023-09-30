using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.ventilation
{
    public class WholeHouseComponentsDTO : StrongEntityDTO
    {
        public long? VentilationSysId { get; set; }
        public VentilationDTO Ventilation { get; set; }

        public long? VentilatorFanTypeId { get; set; }
		public TbDetailDTO VentilatorFanType { get; set; }

		public long? VentilatorDetailId { get; set; }
        public VentilatorFanTypeDetailDTO VentilatorDetail { get; set; }
        public decimal? SupplyFlowRate { get; set; }
		public decimal? ExhaustFlowRate { get; set; }
		public VentilationComponentType ComponentType { get; set; }//WholeHouse or Supplemental
        public class HouseComponentsSearch : BaseSearch
        {

        }
    }
}
