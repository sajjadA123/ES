using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.heatingAndCooling.type1
{
    public class BaseBoardDTO : StrongEntityDTO, IType1
    {
        public EquipmentInformationDTO EquipmentInformation { get; set; }
        public SpecificationDTO Specification { get; set; }

    }
}
