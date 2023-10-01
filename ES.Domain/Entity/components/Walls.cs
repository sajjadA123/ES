using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ES.Domain.Entity.components
{
	public class Walls:StrongEntity
	{
		[MaxLength(100)]
		public string Lable { get; set; }

		public long? FaceDirId { get; set; }
		public TbDetail FaceDir { get; set; }

		public long? WallTypeId { get; set; }
		public  CodeSelector WallType { get; set; }

		public long? LintelTypeId { get; set; }
		public LintelCodeSelector LintelType { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Corners { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Intersection { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Heigth { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Primeter { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? Area { get; set; }
		public bool? AdjustEnclosedUncondSPC { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? RValue { get; set; }
	}
}
