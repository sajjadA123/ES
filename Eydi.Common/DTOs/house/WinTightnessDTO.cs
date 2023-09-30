using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.house
{
	public class WinTightnessDTO: StrongEntityDTO
    {
		public long? HouseId { get; set; }
        public HouseFileDTO House { get; set; }

        public long? WinAirTigthnessTypeId { get; set; }
        public TbDetailDTO WinAirTigthnessType { get; set; }

        public decimal? WinAirTigthnessValue { get; set; }
        public class WinTightnessSearch : BaseSearch
        {

        }
    }
}
