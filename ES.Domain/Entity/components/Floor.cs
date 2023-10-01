using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ES.Domain.Entity.components
{
	public class Floor:StrongEntity
	{
		[MaxLength(100)]
		public string FloorLable { get; set; }
		public bool? AdjuctEnCloseUncondSpc { get; set; }
		public long? FloorTypeId { get; set; }
		public CodeSelector FloorType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Heigth { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Area { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RValue { get; set; }
	}
}
