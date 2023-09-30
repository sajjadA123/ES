using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.ontarioRefrence
{
	public class GreenerHomeDTO:StrongEntityDTO
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
		public TbDetailDTO RemoteComTyp { get; set; }

		public bool? BackWaterValv { get; set; }
		public bool? SumpPump { get; set; }
		public bool? Programmable { get; set; }
		public decimal? EvalCost { get; set; }
		public class GreenerHomeSearch : BaseSearch
		{

		}
	}
}
