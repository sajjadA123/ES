using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ES.Domain.Entity.house
{
    public class Justification:StrongEntity
    {

		public bool? EfficFromNameplate { get; set; }
		public bool EfficFromComTest { get; set; }
		public bool? HeatSysCorrect { get; set; }
		[MaxLength(11)]
		public string PossesionDate { get; set; }
		[MaxLength(250)]
		public string HeatVolumeDec { get; set; }
		[MaxLength(250)]
		public string InsCorrectValCeiling { get; set; }
		[MaxLength(250)]
		public string InsCorrectValWall { get; set; }
		[MaxLength(250)]
		public string InsCorrectValBasement { get; set; }
		public bool? AchCorrect { get; set; }
		public bool? TwoBlowerDoor { get; set; }
		[MaxLength(250)]
		public string Other { get; set; }
		public bool? Up18Mon { get; set; }
		public long? EnergyStarTypeId { get; set; }
        public TbDetail EnergyStarType { get; set; }
    }
}
