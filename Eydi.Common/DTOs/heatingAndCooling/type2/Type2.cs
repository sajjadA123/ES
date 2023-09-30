using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.heatingAndCooling.type2
{
    public class Type2
    {
        public AirConditionDTO AirCondition { get; set; }
        public AirHeatPumpDTO AirHeatPump { get; set; }
        public GroundHeatPumpDTO GroundHeatPump { get; set; }
        public WaterHeatPumpDTO WaterHeatPump { get; set; }

    }
}
