namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class SimulationSettings
    {
        [XmlAttribute("simulateBaseHouse")]
        public bool SimulateBaseHouse;
        [XmlAttribute("simulateUpgradedHouse")]
        public bool SimulateUpgradedHouse;
        [XmlAttribute("simulateByCategory")]
        public bool SimulateByCategory;

        public SimulationSettings()
        {
            this.SimulateBaseHouse = true;
            this.SimulateUpgradedHouse = true;
        }

        public SimulationSettings(SimulationSettings toCopy)
        {
            this.SimulateBaseHouse = true;
            this.SimulateUpgradedHouse = true;
            this.SimulateBaseHouse = toCopy.SimulateBaseHouse;
            this.SimulateUpgradedHouse = toCopy.SimulateByCategory;
            this.SimulateByCategory = toCopy.SimulateByCategory;
        }

        public SimulationSettings(bool baseHouse, bool upgradedHouse, bool byCategory)
        {
            this.SimulateBaseHouse = true;
            this.SimulateUpgradedHouse = true;
            this.SimulateBaseHouse = baseHouse;
            this.SimulateUpgradedHouse = upgradedHouse;
            this.SimulateByCategory = byCategory;
        }
    }
}

