namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Type2
    {
        [XmlAttribute("shadingInF280Cooling")]
        public string ShadingInF280Cooling;
        [XmlElement("AirHeatPump")]
        public HeatPump AirHeatPump;
        [XmlElement("WaterHeatPump")]
        public HeatPump WaterHeatPump;
        [XmlElement("GroundHeatPump")]
        public HeatPump GroundHeatPump;
        [XmlElement("AirConditioning")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2.AirConditioning AirConditioning;

        public Type2()
        {
            this.ShadingInF280CoolingIsAccountedFor = true;
        }

        [XmlIgnore]
        public bool ShadingInF280CoolingIsAccountedFor
        {
            get => 
                this.ShadingInF280Cooling == "AccountedFor";
            set => 
                this.ShadingInF280Cooling = value ? "AccountedFor" : "Ignored";
        }
    }
}

