namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents
{
    using System;
    using System.Xml.Serialization;

    public class Efficiency
    {
        [XmlAttribute("miscellaneousLosses")]
        public decimal MiscellaneousLosses;
        [XmlAttribute("otherPowerLosses")]
        public decimal OtherPowerLosses;
        [XmlAttribute("inverterEfficiency")]
        public decimal InverterEfficiency;
        [XmlAttribute("gridAbsorptionRate")]
        public decimal GridAbsorptionRate;

        public Efficiency()
        {
            this.SetDefaults();
        }

        public void SetDefaults()
        {
            this.MiscellaneousLosses = 3M;
            this.OtherPowerLosses = 1M;
            this.InverterEfficiency = 90M;
            this.GridAbsorptionRate = 90M;
        }
    }
}

