using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Common.Enums;
using ES.Core.Contracts.Entities;

namespace ES.Domain.Entity.ontarioRefrence
{
	public class RefrenceHouse:StrongEntity
	{
		//[Key]
  //      public long? Id { get; set; }
        public bool? ElectGeneration { get; set; }
		public SpaceCondHeadPumpType SpaceCondHeadPumpType { get; set; }
		public bool? WinDoorSkyligthNeut { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? PartyWallAreaAbG { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? PartyWallAreaBlG { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? UserHdd { get; set; }
	}
}
