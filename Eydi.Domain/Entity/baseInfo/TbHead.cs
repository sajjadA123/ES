using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ES.Domain.Entity.baseInfo
{
    public class TbHead:StrongEntity
    {
        //[Key]
        //public long Id { get; set; }
        [MaxLength(100)]
        public string HeadCode { get; set; }
        [MaxLength(255)]
        public string HeadDesc { get; set; }
        public bool? Status { get; set; }
        public TimeSpan StatusDate { get; set; }
    }
}
