namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class VentilationResults
    {
        [XmlAttribute("roomCountCapacity")]
        public decimal RoomCountCapacity;
        [XmlAttribute("noLimitCapacity")]
        public decimal NoLimitCapacity;
        [XmlAttribute("minimumAirChangeRate")]
        public decimal MinimumAirChangeRate;
        [XmlAttribute("equivalentLeakageArea")]
        public decimal EquivalentLeakageArea;
    }
}

