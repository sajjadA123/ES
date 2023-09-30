namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class VentilationBasement
    {
        [XmlAttribute("heated")]
        public bool Heated;
        [XmlAttribute("cooled")]
        public bool Cooled;
        [XmlAttribute("separateThermostat")]
        public bool SeparateThermostat;
        [XmlAttribute("heatingSetPoint")]
        public decimal HeatingSetPoint;
        [XmlAttribute("basementUnit")]
        public bool BasementUnit;
    }
}

