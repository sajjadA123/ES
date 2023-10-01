using ES.Common.Enums;
using ES.DTOs.baseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.heatingAndCooling
{
    public class EquipmentType2DTO
    {
        public TbDetailDTO UnitFuncType { get; set; }
        public long? UnitFuncTypeId { get; set; }
        public TbDetailDTO CentralEquipmentTpe { get; set; }
        public long? CentralEquipmentTpeId { get; set; }
    }
}
