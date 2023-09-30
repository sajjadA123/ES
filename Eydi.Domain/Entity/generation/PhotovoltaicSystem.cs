using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;

namespace ES.Domain.Entity.generation
{
    public class PhotovoltaicSystem:StrongEntity
    {
        public long? GenerationId { get; set; }
        public Generation Generation { get; set; }
		[MaxLength(200)]
		public string Manufacture { get; set; }
		[MaxLength(200)] 
		public string Model { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ArayArea { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? SlopDeg { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AzimuthDeg { get; set; }
		public long? ModuleTypeId { get; set; }
		public TbDetail ModuleType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? ModuleEfficiency { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? NormOperationCellTemp { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? TempCoefficientOfEff { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? MissArrayLoss { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? InverterEff { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? OtherPow { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? GridObsorRate { get; set; }
	}
}
