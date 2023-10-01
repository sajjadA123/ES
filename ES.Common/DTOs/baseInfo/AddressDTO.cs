using ES.Core.Contracts.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Common.DTOs.baseInfo
{
    public class AddressDTO:StrongEntityDTO
    {
        public string Street { set; get; }
        public string UnitNumber { set; get; }
        public string City { set; get; }
        public string ProvinceOrTerritory { set; get; }
        public string PostalCode { set; get; }
        public string Name { get; set; }

    }
}
