using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Domain.Entity.house.fuel
{
    public class FuelCost:StrongEntity
    {
		public long? ElectricityTypeId { get; set; }
        public TbDetail ElectricityType { get; set; }

        public long? NaturalGasTypeId { get; set; }
        public TbDetail NaturalGasType { get; set; }

        public long? OilTypeId { get; set; }
        public TbDetail OilType { get; set; }

        public long? PropaneTypeId { get; set; }
        public TbDetail PropaneType { get; set; }

        public long? WoodTypeId { get; set; }
        public TbDetail WoodType { get; set; }

    }
}
