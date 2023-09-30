using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Core.Contracts.Entities;

namespace ES.Domain.Entity.ontarioRefrence
{
    public class WaterConservation:StrongEntity
    {
        //[Key]
        //public long? Id { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Observed { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Recommnded { get; set; }
    }
}
