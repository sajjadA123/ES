namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(NaturalGasAppliance))]
    public class Wood : Consummable
    {
        [XmlIgnore]
        public decimal TotalInTonnes
        {
            get => 
                (decimal) Conversions.GigaJoulesToTonneOfWood((double) base.TotalInGigaJoules, 5, true);
            set => 
                base.TotalInGigaJoules = (decimal) Conversions.TonneToGigaJoulesOfWood((double) value, 5, true);
        }
    }
}

