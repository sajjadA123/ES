namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.SupplementaryHeat;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2;
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [Serializable]
    public class HeatingCooling : Component
    {
        [XmlElement("CoolingSeason")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.CoolingSeason CoolingSeason = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.CoolingSeason();
        [XmlElement("Type1")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.Type1 Type1 = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.Type1();
        [XmlElement("Type2")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2.Type2 Type2 = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2.Type2();
        [XmlElement("MultipleSystems")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.MultipleSystems MultipleSystems;
        [XmlElement("RadiantHeating")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.RadiantHeating RadiantHeating;
        [XmlArray("AdditionalOpenings"), XmlArrayItem("Opening", typeof(AdditionalOpening))]
        public List<AdditionalOpening> AdditionalOpenings;
        [XmlArray("SupplementaryHeatingSystems"), XmlArrayItem("System", typeof(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.SupplementaryHeat.SupplementaryHeat))]
        public List<ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.SupplementaryHeat.SupplementaryHeat> SupplementaryHeating;

        public HeatingCooling()
        {
            base.Label = "HeatingCooling";
        }
    }
}

