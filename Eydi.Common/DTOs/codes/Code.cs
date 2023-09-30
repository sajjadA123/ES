using ES.Core.Contracts.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.codes
{
    public class Code:StrongEntityDTO
    {
        public decimal NominalRValue { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
    }
}
