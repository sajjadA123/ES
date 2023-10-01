using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Entity.house.fuel
{
    public class FuelCostByType : StrongEntity
    {
        public string Label { get; set; }
        public string Comment { get; set; }
        public TbDetail Units { get; set; }
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
}
