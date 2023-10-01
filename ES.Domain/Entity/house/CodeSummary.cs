using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ES.Domain.Entity.house
{
    public class CodeSummary:StrongEntity
    {
        [MaxLength(100)]
        public string Code { get; set; }
        [MaxLength(100)]
        public string Type { get; set; }
        public string Description { get; set; }
        public bool? Liberary { get; set; }
    }
}
