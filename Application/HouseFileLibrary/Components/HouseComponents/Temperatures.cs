namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Temperatures : Component
    {
        [XmlElement("MainFloors")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.MainFloors MainFloors = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.MainFloors();
        [XmlElement("Basement")]
        public VentilationBasement Basement = new VentilationBasement();
        [XmlElement("Equipment")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.Equipment Equipment = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.Equipment();
        [XmlElement("Crawlspace")]
        public TemperatureCrawlspace Crawlspace = new TemperatureCrawlspace();

        public Temperatures()
        {
            base.Label = "Temperatures";
        }
    }
}

