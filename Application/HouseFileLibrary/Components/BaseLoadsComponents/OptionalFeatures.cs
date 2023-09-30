namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class OptionalFeatures
    {
        [XmlElement("ElectronicThermostats")]
        public SelectedValueAndUnits ElectronicThermostats = new SelectedValueAndUnits();
        [XmlElement("Ventilation")]
        public SelectedValueAndUnits Ventilation = new SelectedValueAndUnits();
    }
}

