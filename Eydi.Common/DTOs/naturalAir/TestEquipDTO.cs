using System.Collections.Generic;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.naturalAir
{
    public class TestEquipDTO:StrongEntityDTO
    {
        public long? FanTypeId { get; set; }
        public TbDetailDTO FanType { get; set; }
		public string Manometer { get; set; }
		public decimal? PressureInit { get; set; }
		public decimal? PerssureFinal { get; set; }
		public decimal? InsideTemp { get; set; }
		public decimal? ZoneHeatedVol { get; set; }
        public virtual List<TestEquipDataDTO> TestData { get; set; }
        public class TestEquipSearch : BaseSearch
        {

        }
    }
}
