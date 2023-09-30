namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class NaturalGasAppliance : Consummable
    {
        [XmlAttribute("appliance")]
        public decimal Appliance;

        [XmlIgnore]
        public decimal TotalInCubicMetres
        {
            get => 
                (decimal) Conversions.GigaJoulesToCubicMetersOfNaturalGas((double) base.TotalInGigaJoules);
            set => 
                base.TotalInGigaJoules = (decimal) Conversions.CubicMetersToGigaJoulesOfNaturalGas((double) value);
        }
    }
}

