using System.Collections.Generic;
using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.ventilation
{
    public class VentilationDTO:StrongEntityDTO
    {
		public long? RequireUseTypeId { get; set; }
		public TbDetailDTO RequireUseType { get; set; }

		public decimal? RequireACH { get; set; }
		public decimal? RequireSupply { get; set; }
		public decimal? RequireExhaust { get; set; }
		public decimal? RequireDeviceOver75l { get; set; }

		public TbDetailDTO AirDistCircType { get; set; }
		public decimal AirDistCircTypeId { get; set; }

		public TbDetailDTO AirDistCircFanPwrType { get; set; }
		public decimal AirDistCircFanPwrTypeId { get; set; }
		public decimal? AirDistCircFanPwrVal { get; set; }

		public long? OperationScheduleTypeId { get; set; }
		public TbDetailDTO OperationScheduleType { get; set; }

		public decimal? OperationScheduleVal { get; set; }
		public decimal? TempControlVentiLow { get; set; }
		public decimal? TempControlVentiUp { get; set; }

		public long? RoomInputId { get; set; }
		public RoomsInputDTO RoomInput { get; set; }

		//public long? WhComId { get; set; }
		public virtual List<WholeHouseComponentsDTO> WholeHouseComponent { get; set; }

        //public long? SuppComId { get; set; }
		public virtual List<WholeHouseComponentsDTO> SupplementalComponent { get; set; }

	}

	public class VentilationSearch : BaseSearch
	{

	}
}
