using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.heatingAndCooling
{
    public class FansAndPumpsDTO: StrongEntityDTO
	{
		public FansPumpModel HeatSysFanModel { get; set; }
		public FansPumpPower HeatSysFanPower { get; set; }
		public bool? HeatEnergyEfMotor { get; set; }
		public decimal? HeatSysFanPowerHspeed { get; set; }
		public decimal? HeatSysFanPowerLspeed { get; set; }
		public FansPumpModel CoolFanInModel { get; set; }
		public FansPumpPower CoolFanPower { get; set; }
		public decimal? CoolFanInFlowRate { get; set; }
		public decimal? Power { get; set; }
		public bool? CoolEnergyEfMotor { get; set; }
		public class FansAndPumpsSearch : BaseSearch
		{

		}
	}
}
