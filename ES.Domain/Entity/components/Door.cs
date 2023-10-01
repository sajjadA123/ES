using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ES.Domain.Entity.components
{
	public class Door:StrongEntity
	{
		[MaxLength(100)]
		public string DoorLable { get; set; }
		public long? DoorTypeId { get; set; }
		public TbDetail DoorType { get; set; }
		public bool? EnergyStar { get; set; }
		public bool? AdjustEnclose { get; set; }
		public decimal? Width { get; set; }
		public decimal? Heigth { get; set; }
		public decimal? GArea { get; set; }
		public decimal? RValue { get; set; }
	}
}
