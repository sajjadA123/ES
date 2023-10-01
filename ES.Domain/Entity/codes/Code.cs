using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Entity.codes
{
    public class Code:StrongEntity
    {
        public decimal NominalRValue { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
    }
}
