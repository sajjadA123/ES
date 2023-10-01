using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;

namespace ES.Domain.Entity.ontarioRefrence
{
	public class GreenerHome:StrongEntity
	{
		//[Key]
  //      public long Id { get; set; }
        public bool? BaseSlabIns { get; set; }
		public bool? MoisProofCrwSpc { get; set; }
		public bool? WaterProof { get; set; }
		public bool? AdhesiveWaterproof { get; set; }
		public bool? MinR10Contin { get; set; }
		public bool? RemoteCom { get; set; }

		public long? RemoteComTypId { get; set; }
		public TbDetail RemoteComTyp { get; set; }

		public bool? BackWaterValv { get; set; }
		public bool? SumpPump { get; set; }
		public bool? Programmable { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? EvalCost { get; set; }
	}
}
