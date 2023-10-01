using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.ontarioRefrence
{
	public class RefrenceHouseDTO:StrongEntityDTO
	{
		//[Key]
  //      public long? Id { get; set; }
        public bool? ElectGeneration { get; set; }
		public SpaceCondHeadPumpType SpaceCondHeadPumpType { get; set; }
		public bool? WinDoorSkyligthNeut { get; set; }
		public decimal? PartyWallAreaAbG { get; set; }
		public decimal? PartyWallAreaBlG { get; set; }
		public decimal? UserHdd { get; set; }
		public class RefrenceHouseSearch : BaseSearch
		{

		}
	}
}
