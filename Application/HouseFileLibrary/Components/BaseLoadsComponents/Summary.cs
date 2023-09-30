namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Summary
    {
        [XmlAttribute("isSpecified")]
        public bool IsSpecified;
        [XmlAttribute("electricalAppliances")]
        public decimal ElectricalAppliances;
        [XmlAttribute("lighting")]
        public decimal Lighting;
        [XmlAttribute("otherElectric")]
        public decimal OtherElectric;
        [XmlAttribute("exteriorUse")]
        public decimal ExteriorUse;
        [XmlAttribute("hotWaterLoad")]
        public decimal HotWaterLoad;

        public Summary()
        {
            this.SetDefaults();
        }

        public Summary(Summary toCopy)
        {
            this.IsSpecified = toCopy.IsSpecified;
            this.ElectricalAppliances = toCopy.ElectricalAppliances;
            this.Lighting = toCopy.Lighting;
            this.OtherElectric = toCopy.OtherElectric;
            this.ExteriorUse = toCopy.ExteriorUse;
            this.HotWaterLoad = toCopy.HotWaterLoad;
        }

        public void SetDefaults()
        {
            this.IsSpecified = false;
            this.ElectricalAppliances = 6.3M;
            this.Lighting = 2.6M;
            this.OtherElectric = 9.7M;
            this.ExteriorUse = 0.9M;
            this.HotWaterLoad = 187.63M;
        }
    }
}

