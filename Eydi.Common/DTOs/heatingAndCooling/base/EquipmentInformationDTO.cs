using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.heatingAndCooling
{
    public class EquipmentInformationDTO
    {
        public string EquipmentManufact { get; set; }
        public string EquipmentModel { get; set; }
        public string Description { get; set; }
        public bool? EnergyStar { get; set; }
        public bool? EPA_CSA { get; set; }
        public decimal ThermostatsNumber { get; set; }
    }
}
