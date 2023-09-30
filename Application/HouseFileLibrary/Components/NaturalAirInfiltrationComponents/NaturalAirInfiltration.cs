namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.AirLeakageReportComponents;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class NaturalAirInfiltration : Component
    {
        [XmlElement("Specifications")]
        public NaturalAirSpecifications Specifications = new NaturalAirSpecifications();
        [XmlElement("OtherFactors")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.OtherFactors OtherFactors = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.OtherFactors();
        [XmlElement("AirLeakageTestData")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.AirLeakageReportComponents.AirLeakageTestData AirLeakageTestData;

        public NaturalAirInfiltration()
        {
            base.Label = "NaturalAirInfiltration";
        }

        public void SetDefaults()
        {
            this.Specifications.BlowerTest.AirLeakageTestData = this.AirLeakageTestData != null;
        }
    }
}

