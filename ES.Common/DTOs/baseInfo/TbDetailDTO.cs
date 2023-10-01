using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using System;

namespace ES.DTOs.baseInfo
{
    public class TbDetailDTO:StrongEntityDTO
    {
		public long? HEAD_ID { get; set; }
		public TbHeadDTO Head { get; set; }

		public string DETAIL_CODE { get; set; }

		public string DETAIL_DESC { get; set; }

		public string DETAIL_DESC2 { get; set; }
		public bool? STATUS { get; set; }
		public TimeSpan STATUS_DATE { get; set; }
		public class TbDetailSearch : BaseSearch
		{

		}
	}
}
