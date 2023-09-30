namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class NaturalAirSpecifications
    {
        [XmlElement("House")]
        public SpecificationsHouse House = new SpecificationsHouse();
        [XmlElement("BlowerTest")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.BlowerTest BlowerTest = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.BlowerTest();
        [XmlElement("BuildingSite")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.BuildingSite BuildingSite = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.BuildingSite();
        [XmlElement("LocalShielding")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.LocalShielding LocalShielding = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.LocalShielding();
        [XmlElement("ExhaustDevicesTest")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.ExhaustDevicesTest ExhaustDevicesTest = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.ExhaustDevicesTest();
        [XmlElement("CommonSurfaceArea")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.CommonSurfaceArea CommonSurfaceArea = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.CommonSurfaceArea();
    }
}

