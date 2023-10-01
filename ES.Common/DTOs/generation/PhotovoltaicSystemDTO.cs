
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.generation
{
    public class PhotovoltaicSystemDTO:StrongEntityDTO
    {
        public long? GenerationId { get; set; }
        public GenerationDTO Generation { get; set; }
		public string Manufacture { get; set; }
		public string Model { get; set; }
		public decimal? ArayArea { get; set; }
		public decimal? SlopDeg { get; set; }
		public decimal? AzimuthDeg { get; set; }
		public long? ModuleTypeId { get; set; }
		public TbDetailDTO ModuleType { get; set; }

		public decimal? ModuleEfficiency { get; set; }
		public decimal? NormOperationCellTemp { get; set; }
		public decimal? TempCoefficientOfEff { get; set; }
		public decimal? MissArrayLoss { get; set; }
		public decimal? InverterEff { get; set; }
		public decimal? OtherPow { get; set; }
		public decimal? GridObsorRate { get; set; }
		public class PhotovoltaicSystemSearch : BaseSearch
		{

		}
	}
}
