using ES.Common.DTOs;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.house
{

	public class HouseInfoDTO: StrongEntityDTO
    {
        public long? KeyVaLueId { get; set; }
        public KeyValueDTO KeyValue { get; set; }
        public long? HouseId { get; set; }
        public HouseFileDTO House { get; set; }
    }
    public class HouseInfoSearch : BaseSearch
    {

    }
}
