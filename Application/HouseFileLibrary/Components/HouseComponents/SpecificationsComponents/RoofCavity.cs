namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class RoofCavity
    {
        [XmlAttribute("volume")]
        public decimal Volume;
        [XmlAttribute("ventilationRate")]
        public decimal VentilationRate;
        [XmlElement("GableEnds")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.GableEnds GableEnds;
        [XmlElement("SlopedRoof")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.SlopedRoof SlopedRoof;

        public RoofCavity()
        {
            this.GableEnds = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.GableEnds();
            this.SlopedRoof = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.SlopedRoof();
        }

        public RoofCavity(RoofCavity toCopy)
        {
            this.GableEnds = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.GableEnds();
            this.SlopedRoof = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.SlopedRoof();
            this.Volume = toCopy.Volume;
            this.VentilationRate = toCopy.VentilationRate;
            this.GableEnds = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.GableEnds(toCopy.GableEnds);
            this.SlopedRoof = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.SlopedRoof(toCopy.SlopedRoof);
        }
    }
}

