using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;

namespace ES.Domain.Entity.ventilation
{
    public class Ventilation:StrongEntity
    {
  //      public Ventilation()
  //      {
  //          WholeHouseComponent = new HashSet<HouseComponents>();
  //          SupplementalComponent = new HashSet<HouseComponents>();
		//}

        public long? RequireUseTypeId { get; set; }
		public TbDetail RequireUseType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RequireACH { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RequireSupply { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RequireExhaust { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RequireDeviceOver75l { get; set; }

		public AirDistrubtionORCirculation AirDistCircType { get; set; }
		public UserOrDefult AirDistCircFanPwrType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AirDistCircFanPwrVal { get; set; }

		public long? OperationScheduleTypeId { get; set; }
		public TbDetail OperationScheduleType { get; set; }

		[Column(TypeName = "numeric(18,4)")]
		public decimal? OperationScheduleVal { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? TempControlVentiLow { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? TempControlVentiUp { get; set; }

		public long? RoomInputId { get; set; }
		public RoomsInput RoomInput { get; set; }

		//public long? WhComId { get; set; }
	//	public virtual ICollection<HouseComponents> WholeHouseComponent { get; set; }

        //public long? SuppComId { get; set; }
		public virtual ICollection<HouseComponents> SupplementalComponent { get; set; }

    }
}
