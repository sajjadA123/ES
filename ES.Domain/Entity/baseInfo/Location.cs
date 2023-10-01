using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ES.Domain.Entity.baseInfo
{
    public class Location:StrongEntity
    {
        [MaxLength(200)]
        public string Name { get; set; }
    }
}
