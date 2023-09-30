namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(NaturalGasAppliance))]
    public class Oil : Consummable
    {
        [XmlIgnore]
        public decimal TotalInLitres
        {
            get => 
                (decimal) Conversions.GigaJoulesToLitresOfOil((double) base.TotalInGigaJoules);
            set => 
                base.TotalInGigaJoules = (decimal) Conversions.LitresToGigaJoulesOfOil((double) value);
        }
    }
}

