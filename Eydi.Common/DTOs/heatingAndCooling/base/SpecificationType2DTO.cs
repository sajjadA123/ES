using ES.Common.Enums;
using ES.DTOs.baseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.heatingAndCooling
{
    public class SpecificationType2DTO
    {
		public decimal? SizingFactor { get; set; }
        public TbDetailDTO OutCapType { get; set; }
        public long? OutCapTypeId { get; set; }
        public decimal? OutCapacityVal { get; set; }
        public CapacityUnit OutCapacityUnit { get; set; }
        public decimal? HeatEfficiencyVal { get; set; }
		public HeatCoolEfficiencyType HeatEfficiencyType { get; set; }
		public decimal? CoolEfficiencyVal { get; set; }
		public HeatCoolEfficiencyType CoolEfficiencyType { get; set; }
        public decimal RatedCapacity { get; set; }
		public CapacityUnit RateCapacityUnit { get; set; }
	}
}
