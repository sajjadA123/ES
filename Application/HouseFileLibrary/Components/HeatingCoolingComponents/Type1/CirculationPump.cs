namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class CirculationPump
    {
        [XmlAttribute("isCalculated")]
        public bool IsCalculated;
        [XmlAttribute("value")]
        public decimal Value;
        [XmlAttribute("hasEnergyEfficientMotor")]
        public bool HasEnergyEfficientMotor;
    }
}

