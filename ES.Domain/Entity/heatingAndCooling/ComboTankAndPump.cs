using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;

namespace ES.Domain.Entity.heatingAndCooling
{
    public class ComboTankAndPump:StrongEntity
    {
		//[Key]
  //      public long Id { get; set; }
        public long? TankVolumeTypeId { get; set; }
		public TbDetail TankVolumeType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? TankVolumeVal { get; set; }
		public DefaultOrUserSpecType EnergyFactorType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? EnergyFactorVal { get; set; }
		public TankLocation TankLocation { get; set; }
		public UserSpecOrCalcType CirculationPompType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CirculationPompVal { get; set; }
		public bool? EnergyEffMotor { get; set; }
	}
}
