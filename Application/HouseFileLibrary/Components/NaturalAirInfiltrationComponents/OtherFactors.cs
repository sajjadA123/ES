namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class OtherFactors
    {
        [XmlElement("WeatherStation")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.WeatherStation WeatherStation = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.WeatherStation();
        [XmlElement("LeakageFractions")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.LeakageFractions LeakageFractions = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.LeakageFractions();
    }
}

