using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ES.Domain.Entity
{
	public class WinTightness:StrongEntity
	{
		public long? HouseId { get; set; }
        public HouseFile House { get; set; }

        public long? WinAirTigthnessTypeId { get; set; }
        public TbDetail WinAirTigthnessType { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? WinAirTigthnessValue { get; set; }
	}
}
