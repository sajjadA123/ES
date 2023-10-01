using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.Common
{
    public class DWHRDTO:StrongEntityDTO
    {
        public long? ShowerTemperatureId { get; set; }
        public TbDetailDTO ShowerTemperature { get; set; }

		public decimal? ShowerLength { get; set; }
		public decimal? ShowerPerDayNum { get; set; }
		public long? ShowerHeadRateId { get; set; }
		public TbDetailDTO ShowerHeadRate { get; set; }

		public DWHRConfig Configuration { get; set; }

		public string Manufacture { get; set; }


		public string Model { get; set; }

		public decimal? Efficiency { get; set; }
		public class DWHRSearch : BaseSearch
		{

		}
	}
}
