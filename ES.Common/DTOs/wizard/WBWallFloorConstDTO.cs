using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Common.DTOs.wizard
{
    public class WBWallFloorConstDTO
    {
        public int ponyWallConstType { get; set; }
        public int interiorInsulationConstType { get; set; }
        public int insulationRVal { get; set; }
        public int corner { get; set; }
        public int exteriorInsulationConstType { get; set; }
        public int insulationToSlap { get; set; }
        public int floorAboveFoundation { get; set; }
        public bool heatedFloor { get; set; }
        public int WallConstType { get; set; }
    }
}
