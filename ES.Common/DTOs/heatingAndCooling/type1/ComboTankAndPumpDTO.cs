
using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.heatingAndCooling.type1
{
    public class ComboTankAndPumpDTO:StrongEntityDTO, IType1
	{
		public EquipmentDTO Equipment { get; set; }
		public EquipmentInformationDTO EquipmentInformation { get; set; }
		public SpecificationDTO Specification { get; set; }

		public long? TankVolumeTypeId { get; set; }
		public TbDetailDTO TankVolumeType { get; set; }

		public decimal? TankVolumeVal { get; set; }
		public DefaultOrUserSpecType EnergyFactorType { get; set; }
		public decimal? EnergyFactorVal { get; set; }
		public TbDetailDTO TankLocation { get; set; }
		public long? TankLocationId { get; set; }
		public UserSpecOrCalcType CirculationPompType { get; set; }
		public decimal? CirculationPompVal { get; set; }
		public bool? EnergyEffMotor { get; set; }
		public class ComboTankAndPumpSearch : BaseSearch
		{

		}
	}
}
