using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ES.Core.Contracts.Entities;

namespace ES.Domain.Entity.generation
{
    public class Generation:StrongEntity
    {
		[Column(TypeName = "numeric(18,4)")]
		public decimal? PhotovoliSysCount { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? CapPhotovoliSys { get; set; }
		public bool? BatteryStorage { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? WindEnergy { get; set; }
		public bool? SolarReady { get; set; }
        public virtual List<PhotovoltaicSystem> PhotovoltaicSystems { get; set; }
    }
}
