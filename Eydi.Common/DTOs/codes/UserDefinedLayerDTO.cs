using ES.Core.Contracts.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.codes
{
    public class UserDefinedLayerDTO:StrongEntityDTO
    {
        public int Rank { get; set; }
        public virtual UserDefinedDTO UserDefined { get; set; }
    }
}
