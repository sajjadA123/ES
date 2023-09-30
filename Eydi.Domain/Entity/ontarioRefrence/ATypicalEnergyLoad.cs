using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ES.Domain.Entity.ontarioRefrence
{
    public class ATypicalEnergyLoad:StrongEntity
    {
		//[Key]
  //      public long Id { get; set; }
        public bool? DeIcingCable { get; set; }
		public bool? ElecVehicleShargSt { get; set; }
		public bool? ExExtLight { get; set; }
		public bool? HeatedGarag { get; set; }
		public bool? HotTub { get; set; }
		public bool? MixedUse { get; set; }
		public bool? OutGas { get; set; }
		public bool? SwimmPool { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? UnitCount { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? EnStarCout { get; set; }
	}
}
