using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ES.Domain.Entity.baseInfo
{
    public class TbDetail:StrongEntity
    {
		//[Key]
		//public long Id { get; set; }

		public long? HEAD_ID { get; set; }
		public TbHead Head { get; set; }

		[MaxLength(50)]
		public string DETAIL_CODE { get; set; }
		[MaxLength(250)]
		public string DETAIL_DESC { get; set; }
		[MaxLength(250)]
		public string DETAIL_DESC2 { get; set; }
		public bool? STATUS { get; set; }
		public TimeSpan STATUS_DATE { get; set; }
	}
}
