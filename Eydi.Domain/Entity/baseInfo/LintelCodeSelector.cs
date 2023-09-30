using ES.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ES.Domain.Entity.baseInfo
{
    public class LintelCodeSelector
    {
		public long? ID { get; set; }
		[MaxLength(100)]
		public string LABLE { get; set; }
		public long? LintelTypeid { get; set; }
		public TbDetail LintelType { get; set; }
		public LintelMaterial Material { get; set; }
		public long? InsulationId { get; set; }
		public TbDetail Insulation { get; set; }
		[MaxLength(20)]
		public string InternalCode { get; set; }
	}
}
