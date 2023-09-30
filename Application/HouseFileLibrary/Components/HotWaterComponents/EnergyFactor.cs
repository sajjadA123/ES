namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class EnergyFactor : CodeTextAndValue
    {
        [XmlAttribute("inputCapacity")]
        public decimal InputCapacity;
        [XmlAttribute("thermalEfficiency")]
        public decimal ThermalEfficiency;
        [XmlAttribute("standbyHeatLoss")]
        public decimal StandbyHeatLoss;
        [XmlAttribute("standbyHeatLossMode")]
        public ushort StandbyHeatLossMode;
        [XmlAttribute("isUniform")]
        public bool isUniform;
    }
}

