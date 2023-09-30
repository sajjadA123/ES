using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ES.Domain.Entity
{

	public class HouseInfo:StrongEntity
	{
        //[Key]
        //public long Id { get; set; }
        public long? KeyVaLueId { get; set; }
        public KeyValue KeyValue { get; set; }
        public long? HouseId { get; set; }
        public HouseFile House { get; set; }
    }
}
