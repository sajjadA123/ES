namespace ca.nrcan.gc.OEE.HouseFileLibrary.EnergyUpgradesComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.CeilingComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.DoorComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorHeaderComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.RoomComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.WallComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.WindowComponents;
    using Microsoft.Xml.Serialization.GeneratedAssembly;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Serialization;

    [Serializable]
    public class EnergyUpgrades
    {
        [XmlElement("Settings")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.EnergyUpgradesComponents.Settings Settings = new ca.nrcan.gc.OEE.HouseFileLibrary.EnergyUpgradesComponents.Settings();
        [XmlArray("Components"), XmlArrayItem(typeof(BaseLoads)), XmlArrayItem(typeof(Ceiling)), XmlArrayItem(typeof(Door)), XmlArrayItem(typeof(Floor)), XmlArrayItem(typeof(FloorHeader)), XmlArrayItem(typeof(Basement)), XmlArrayItem(typeof(Crawlspace)), XmlArrayItem(typeof(Foundation)), XmlArrayItem(typeof(Slab)), XmlArrayItem(typeof(Walkout)), XmlArrayItem(typeof(HeatingCooling)), XmlArrayItem(typeof(HotWater)), XmlArrayItem(typeof(Generation)), XmlArrayItem(typeof(NaturalAirInfiltration)), XmlArrayItem(typeof(Room)), XmlArrayItem(typeof(Temperatures)), XmlArrayItem(typeof(Ventilation)), XmlArrayItem(typeof(Wall)), XmlArrayItem(typeof(Window))]
        public List<Component> Components = new List<Component>();
        [XmlElement("GreenerHomes")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.EnergyUpgradesComponents.GreenerHomes GreenerHomes = new ca.nrcan.gc.OEE.HouseFileLibrary.EnergyUpgradesComponents.GreenerHomes();
        private static EnergyUpgradesSerializer cachedSerializer;

        public EnergyUpgrades Clone()
        {
            using (MemoryStream stream = new MemoryStream(0x400))
            {
                Serializer.Serialize((Stream) stream, this);
                stream.Position = 0L;
                return (EnergyUpgrades) Serializer.Deserialize(stream);
            }
        }

        [XmlIgnore]
        public static EnergyUpgradesSerializer Serializer
        {
            get
            {
                cachedSerializer = new EnergyUpgradesSerializer();
                return cachedSerializer;
            }
        }
    }
}

