using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Core.Contracts.Entities.calculate
{
    public class CalculateResponse
    {
        public double InnerArea { get; set; }
        public double InnerPrimeter { get; set; }
        public double OutArea { get; set; }
        public double OutPrimeter { get; set; }
    }
}
