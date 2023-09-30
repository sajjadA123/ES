using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;

namespace ES.Domain.Entity.common
{
    public class DWHR:StrongEntity
    {
		//[Key]
  //      public long? Id { get; set; }
        public long? ShowerTemperatureId { get; set; }
        public TbDetail ShowerTemperature { get; set; }

		public decimal? ShowerLength { get; set; }
		public decimal? ShowerPerDayNum { get; set; }
		public long? ShowerHeadRateId { get; set; }
		public TbDetail ShowerHeadRate { get; set; }

		public DWHRConfig Configuration { get; set; }
		public long? ManufactureId { get; set; }
		public TbDetail Manufacture { get; set; }

		public long? ModelId { get; set; }
		public TbDetail Model { get; set; }

		public decimal? Efficiency { get; set; }
	}
}
