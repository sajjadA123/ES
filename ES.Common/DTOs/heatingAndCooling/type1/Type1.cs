using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.heatingAndCooling.type1
{
    public class Type1
    {
        public BaseBoardDTO BaseBoard { get; set; }
        public BoilerDTO Boiler { get; set; }
        public ComboTankAndPumpDTO ComboTankAndPump { get; set; }
        public CSATestedComboHeatingDTO cSAP9Test { get; set; }
        public FurnaceDTO Furnace { get; set; }
    }
}
