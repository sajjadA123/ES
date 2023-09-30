using ES.Common.Enums;
using ES.DTOs.baseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.heatingAndCooling
{
    public class EquipmentDTO
    {
        public TbDetailDTO EnergySrcType { get; set; }
        public long? EnergySrcTypeId { get; set; }
        public bool? DualFuelSystem { get; set; }
        public decimal? SwitchoverTemp { get; set; }
        public long? EquipmentTypeId { get; set; }
        public TbDetailDTO EquipmentType { get; set; }
    }
}
