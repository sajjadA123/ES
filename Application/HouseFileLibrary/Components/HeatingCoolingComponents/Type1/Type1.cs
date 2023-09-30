namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Type1
    {
        [XmlElement("FansAndPump")]
        public FansAndPumpsHeating FansAndPump;
        [XmlElement("Baseboards")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.Baseboards Baseboards;
        [XmlElement("Boiler")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.Boiler Boiler;
        [XmlElement("ComboHeatDhw")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.ComboHeatDhw ComboHeatDhw;
        [XmlElement("Furnace")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.Furnace Furnace;
        [XmlElement("P9")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.P9 P9;
    }
}

