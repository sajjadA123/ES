using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ES.Domain.Entity.components
{
	public class Ceiling:StrongEntity
	{
		[MaxLength(100)]
		public string CeilLable { get; set; }

		public long? ConstractTypeID { get; set; }
		public TbDetail ConstractType { get; set; }

		public long? CeilTypeID { get; set; }
		public CodeSelector CeilType { get; set; }

		public decimal? Length { get; set; }
		public decimal? Area { get; set; }

		public long? RoofSlopeTypeId { get; set; }
		public TbDetail RoofSlopeType { get; set; }

		public decimal? RoofSlopeValue { get; set; }
		public decimal? RValue { get; set; }
		public decimal? HeelHeigth { get; set; }
	}
}
