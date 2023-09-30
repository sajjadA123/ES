namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class PropaneAppliance : Consummable
    {
        [XmlAttribute("appliance")]
        public decimal Appliance;

        [XmlIgnore]
        public decimal TotalInLitres
        {
            get => 
                (decimal) Conversions.GigaJoulesToLitresOfPropane((double) base.TotalInGigaJoules);
            set => 
                base.TotalInGigaJoules = (decimal) Conversions.LitresToGigaJoulesOfPropane((double) value);
        }
    }
}

