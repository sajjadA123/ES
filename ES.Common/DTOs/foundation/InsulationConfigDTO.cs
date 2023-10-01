using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using System.Collections.Generic;

namespace ES.Common.DTOs.foundation
{
    public class InsulationConfigDTO:StrongEntityDTO
    {
        public string IsName { get; set; }
        public InsulationType IsType { get; set; }
        public virtual List<BasementConfigDTO> BasementConfigList { get; set; }
        public class InsulationConfigSearch : BaseSearch
        {

        }
    }
}
