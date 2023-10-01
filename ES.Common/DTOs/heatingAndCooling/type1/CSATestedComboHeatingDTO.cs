using ES.Common.DTOs.Common;
using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.heatingAndCooling.type1
{
    public class CSATestedComboHeatingDTO: StrongEntityDTO, IType1
	{
        public CSADataType DataType { get; set; }
		public string Manufacture { get; set; }
		public string Model { get; set; }

		public long? P9SysNum { get; set; }
		public long? CSAP9Id { get; set; }
		public CSAP9TestDataDTO CSAP9 { get; set; }

		public decimal? ThrmalPerFactor { get; set; }
		public decimal? AnnualElec { get; set; }
		public decimal? SpcHeatingCap { get; set; }
		public decimal? CompositeSHE { get; set; }
		public decimal? WaterHeatPerFact { get; set; }
		public decimal? NominalBurner { get; set; }
		public decimal? RecoveryEff { get; set; }
		public long? DWHRId { get; set; }
        public DWHRDTO DWHR { get; set; }
	}
	public class CSATestedComboHeatingSearch : BaseSearch
	{

	}
}
