using ES.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.heatingAndCooling
{
    public class SpecificationDTO
    {
        public UserSpecOrCalcType OutCapacityType { get; set; }
        public decimal? OutCapacityVal { get; set; }
        public CapacityUnit OutCapacityUnit { get; set; }
        public decimal? SizingFactor { get; set; }
        public decimal? Efficiency { get; set; }
        public EfficiencyType EfficiencyType { get; set; }
        public decimal? PilotLigth { get; set; }
        public decimal? FlueDiameter { get; set; }
    }
}
