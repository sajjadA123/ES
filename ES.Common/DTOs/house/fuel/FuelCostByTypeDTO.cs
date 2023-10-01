using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.house.fuel
{
    public class FuelCostByTypeDTO:StrongEntityDTO
    {
        public string Label { get; set; }
        public string Comment { get; set; }
        public TbDetailDTO Units { get; set; }
        public decimal? RateBlockMinUnits { get; set; }
        public decimal? RateBlockMinCharge { get; set; }
        public decimal? RateBlock1Unit { get; set; }
        public decimal? RateBlock1costPerUnit { get; set; }
        public decimal? RateBlock2Unit { get; set; }
        public decimal? RateBlock2costPerUnit { get; set; }
        public decimal? RateBlock3Unit { get; set; }
        public decimal? RateBlock3costPerUnit { get; set; }
        public decimal? RateBlock4Unit { get; set; }
        public decimal? RateBlock4costPerUnit { get; set; }
    }
    public class FuelCostByTypeSearch : BaseSearch
    {

    }
}
