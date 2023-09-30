using System.ComponentModel.DataAnnotations.Schema;
using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;

namespace ES.Domain.Entity.ventilation
{
    public class HouseComponents:StrongEntity
    {

		public long? VentilationSysId { get; set; }
		[ForeignKey("VentilationSysId")]
		public virtual Ventilation Ventilation { get; set; }

		public long? VentilatorFanTypeId { get; set; }
		public virtual TbDetail VentilatorFanType { get; set; }

		public long? VentilatorDetailId { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? SupplyFlowRate { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ExhaustFlowRate { get; set; }
		public VentilationComponentType ComponentType { get; set; }//WholeHouse or Supplemental
	}
}
