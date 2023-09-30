using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ES.Domain.Entity.foundation
{
    public class BasementConfig:StrongEntity
    {
        [MaxLength(100)]
        public string ConfingLable { get; set; }
        public byte[] ConfigImage { get; set; }
        public string ConfigDecriprion { get; set; }
        public long? IsulationId { get; set; }
        public InsulationConfig Isulation { get; set; }

    }
}
