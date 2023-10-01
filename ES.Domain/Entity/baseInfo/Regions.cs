using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ES.Domain.Entity.baseInfo
{
    public class Regions:StrongEntity
    {
        [MaxLength(200)]
        public string RegionName { get; set; }
    }
}
