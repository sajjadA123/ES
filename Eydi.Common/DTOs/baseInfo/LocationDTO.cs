
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.baseInfo
{
    public class LocationDTO:StrongEntityDTO
    {
        public string Name { get; set; }
        public class LocationSearch : BaseSearch
        {

        }
    }
}
