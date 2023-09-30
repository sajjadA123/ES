namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components
{
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
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(BaseLoads)), XmlInclude(typeof(Ceiling)), XmlInclude(typeof(Door)), XmlInclude(typeof(Floor)), XmlInclude(typeof(FloorHeader)), XmlInclude(typeof(HeatingCooling)), XmlInclude(typeof(Basement)), XmlInclude(typeof(Crawlspace)), XmlInclude(typeof(Foundation)), XmlInclude(typeof(Slab)), XmlInclude(typeof(Walkout)), XmlInclude(typeof(Generation)), XmlInclude(typeof(HotWater)), XmlInclude(typeof(NaturalAirInfiltration)), XmlInclude(typeof(Room)), XmlInclude(typeof(Temperatures)), XmlInclude(typeof(Ventilation)), XmlInclude(typeof(Wall)), XmlInclude(typeof(Window))]
    public abstract class Component : BaseComponent
    {
        [XmlElement("Label")]
        public string Label;

        protected Component()
        {
        }
    }
}

