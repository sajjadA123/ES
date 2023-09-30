namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
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
    using ca.nrcan.gc.OEE.HouseFileLibrary.HouseFileEvents;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(Component)), XmlInclude(typeof(BaseLoads)), XmlInclude(typeof(Ceiling)), XmlInclude(typeof(Door)), XmlInclude(typeof(Floor)), XmlInclude(typeof(FloorHeader)), XmlInclude(typeof(HeatingCooling)), XmlInclude(typeof(House)), XmlInclude(typeof(Basement)), XmlInclude(typeof(Crawlspace)), XmlInclude(typeof(Foundation)), XmlInclude(typeof(Slab)), XmlInclude(typeof(Walkout)), XmlInclude(typeof(HotWater)), XmlInclude(typeof(Room)), XmlInclude(typeof(Wall)), XmlInclude(typeof(Window))]
    public class BaseComponent: ISerializationEvents
    {
        [Required, XmlAttribute("id")]
        public uint Id;
        [XmlArray("Components"), XmlArrayItem(typeof(BaseLoads)), XmlArrayItem(typeof(Ceiling)), XmlArrayItem(typeof(Door)), XmlArrayItem(typeof(Floor)), XmlArrayItem(typeof(FloorHeader)), XmlArrayItem(typeof(Basement)), XmlArrayItem(typeof(Crawlspace)), XmlArrayItem(typeof(Foundation)), XmlArrayItem(typeof(Slab)), XmlArrayItem(typeof(Walkout)), XmlArrayItem(typeof(HeatingCooling)), XmlArrayItem(typeof(Generation)), XmlArrayItem(typeof(HotWater)), XmlArrayItem(typeof(NaturalAirInfiltration)), XmlArrayItem(typeof(Room)), XmlArrayItem(typeof(Temperatures)), XmlArrayItem(typeof(Ventilation)), XmlArrayItem(typeof(Wall)), XmlArrayItem(typeof(Window))]
        public List<BaseComponent> Components;
        [XmlIgnore]
        public ca.nrcan.gc.OEE.HouseFileLibrary.HouseFile HouseFile;
        [XmlIgnore]
        public BaseComponent Parent;

        public bool IsSame(BaseComponent other) => 
            this.Id == other.Id;

        public void OnDeserialization()
        {
         
        }

        public void OnPostSerialization()
        {
            
        }

        public void OnPreSerialization()
        {
            
        }
    }
}

