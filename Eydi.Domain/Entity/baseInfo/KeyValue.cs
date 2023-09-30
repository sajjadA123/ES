using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ES.Domain.Entity.baseInfo
{
    public class KeyValue:StrongEntity
    {
        //[Key]
        //public long ID { get; set; }
        [MaxLength(200)]
        public string KEY { get; set; }
        [MaxLength(200)]
        public string VALUE { get; set; }
    }
}
