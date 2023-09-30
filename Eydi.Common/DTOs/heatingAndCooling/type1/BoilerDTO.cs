using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.DTOs.baseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.heatingAndCooling.type1
{
    public class BoilerDTO : StrongEntityDTO, IType1
    {
        public EquipmentDTO Equipment { get; set; }
        public EquipmentInformationDTO EquipmentInformation { get; set; }
        public SpecificationDTO Specification { get; set; }
    }
}
