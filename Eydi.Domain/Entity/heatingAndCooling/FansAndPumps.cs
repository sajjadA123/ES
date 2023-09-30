using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ES.Domain.Entity.heatingAndCooling
{
    public class FansAndPumps:StrongEntity
    {
		//[Key]
		//public long? Id { get; set; }
		public FansPumpModel HeatSysFanModel { get; set; }
		public FansPumpPower HeatSysFanPower { get; set; }
		public bool? HeatEnergyEfMotor { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? HeatSysFanPowerHspeed { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? HeatSysFanPowerLspeed { get; set; }
		public FansPumpModel CoolFanInModel { get; set; }
		public FansPumpPower CoolFanPower { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CoolFanInFlowRate { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Power { get; set; }
		public bool? CoolEnergyEfMotor { get; set; }
	}
}
