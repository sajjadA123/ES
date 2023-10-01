using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Domain.Entity.house
{
    public class UnitsMode:StrongEntity
    {
        public long? HouseId { get; set; }
        public HouseFile House { get; set; }

        public DisplayUnitType DisplayUnitType{ get; set; }

        public long? ProgramsTypeId{ get; set; }
        public TbDetail ProgramsType { get; set; }
    }
}
