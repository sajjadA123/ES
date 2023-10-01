using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.baseInfo
{
    public class KeyValueDTO:StrongEntityDTO
    {

        public string KEY { get; set; }
        public string VALUE { get; set; }
        public class KeyValueSearch : BaseSearch
        {

        }
    }
}
