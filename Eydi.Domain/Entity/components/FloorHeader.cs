using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Entity.components
{
    public class FloorHeader:StrongEntity
    {
		[MaxLength(100)]
		public string Lable { get; set; }
		public bool? AdjuctEnCloseUncondSpc { get; set; }
		public Orientation FacingDirection { get; set; }
		public long? FloorHeaderTypeId { get; set; }
		public CodeSelector FloorHeaderType { get; set; }
		public long Location { get; set; }
		public decimal? Heigth { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Area { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Primeter { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RValue { get; set; }
	}
}
