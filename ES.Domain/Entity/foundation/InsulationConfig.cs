using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ES.Domain.Entity.foundation
{
    public class InsulationConfig:StrongEntity
    {
        [MaxLength(100)]
        public string IsName { get; set; }
        public InsulationType IsType { get; set; }
        public virtual List<BasementConfig> BasementConfigList { get; set; }
    }
}
