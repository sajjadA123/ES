using ES.Core.Contracts.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.domesticHotWater
{
    public class HotWater:StrongEntityDTO
    {
        public DomesticHotWaterDTO Primary { get; set; }
        public DomesticHotWaterDTO Secondary { get; set; }
    }
}
