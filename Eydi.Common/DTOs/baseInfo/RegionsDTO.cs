
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.baseInfo
{
    public class RegionsDTO:StrongEntityDTO
    {
        //public int RegionId { get; set; }
        public string RegionName { get; set; }
        public class RegionsSearch : BaseSearch
        {

        }
    }
}
