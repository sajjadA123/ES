using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;

namespace ES.Domain.Entity.naturalAir
{
    public class TestEquip:StrongEntity
    {
		//[Key]
  //      public long Id { get; set; }
        public long? FanTypeId { get; set; }
        public TbDetail FanType { get; set; }
		[MaxLength(100)]
		public string Manometer { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? PressureInit { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? PerssureFinal { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? InsideTemp { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ZoneHeatedVol { get; set; }
        public virtual List<TestEquipData> TestData { get; set; }
    }
}
