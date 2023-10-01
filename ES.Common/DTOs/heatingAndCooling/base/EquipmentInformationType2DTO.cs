using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.heatingAndCooling
{
    public class EquipmentInformationType2DTO
    {
        public string EquipmentManufact { get; set; }
        public string EquipmentModel { get; set; }
        public string EquipmentAHRI { get; set; }
        public bool? EnergyStar { get; set; }
        public bool? CanCsa { get; set; }
    }
}
