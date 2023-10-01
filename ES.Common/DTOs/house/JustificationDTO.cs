using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.house
{
    public class JustificationDTO: StrongEntityDTO
	{

		public bool? EfficFromNameplate { get; set; }
		public bool EfficFromComTest { get; set; }
		public bool? HeatSysCorrect { get; set; }
		public string PossesionDate { get; set; }
		public string HeatVolumeDec { get; set; }
		public string InsCorrectValCeiling { get; set; }
		public string InsCorrectValWall { get; set; }
		public string InsCorrectValBasement { get; set; }
		public bool? AchCorrect { get; set; }
		public bool? TwoBlowerDoor { get; set; }
		public string Other { get; set; }
		public bool? Up18Mon { get; set; }
		public long? EnergyStarTypeId { get; set; }
        public TbDetailDTO EnergyStarType { get; set; }
		public class JustificationSearch : BaseSearch
		{

		}
	}
}
