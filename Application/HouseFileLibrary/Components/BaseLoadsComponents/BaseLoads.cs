namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class BaseLoads : Component
    {
        [XmlAttribute("basementFractionOfInternalGains")]
        public decimal BasementFractionOfInternalGains;
        [XmlAttribute("commonSpaceElectricalConsumption")]
        public decimal CommonSpaceElectricalConsumption;
        [XmlElement("Occupancy")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.Occupancy Occupancy;
        [XmlElement("Summary")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.Summary Summary;
        [XmlElement("WaterUsage")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.WaterUsage WaterUsage;
        [XmlElement("ElectricalUsage")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.ElectricalUsage ElectricalUsage;
        [XmlElement("AdvancedUserSpecified")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.AdvancedUserSpecified AdvancedUserSpecified;

        public BaseLoads()
        {
            this.Occupancy = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.Occupancy();
            this.Summary = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.Summary();
            base.Label = "BaseLoads";
            this.SetDefaults();
        }

        public BaseLoads(BaseLoads toCopy)
        {
            this.Occupancy = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.Occupancy();
            this.Summary = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.Summary();
            base.Id = toCopy.Id;
            base.Label = toCopy.Label;
            this.BasementFractionOfInternalGains = toCopy.BasementFractionOfInternalGains;
            this.CommonSpaceElectricalConsumption = toCopy.CommonSpaceElectricalConsumption;
            this.Occupancy = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.Occupancy(toCopy.Occupancy);
            this.Summary = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.Summary(toCopy.Summary);
            this.WaterUsage = (toCopy.WaterUsage == null) ? null : new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.WaterUsage(toCopy.WaterUsage);
            this.ElectricalUsage = (toCopy.ElectricalUsage == null) ? null : new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.ElectricalUsage(toCopy.ElectricalUsage);
            this.AdvancedUserSpecified = (toCopy.AdvancedUserSpecified == null) ? null : new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.AdvancedUserSpecified(toCopy.AdvancedUserSpecified);
        }

        public void SetDefaults()
        {
            this.BasementFractionOfInternalGains = 0.15M;
            this.Occupancy.SetDefaults();
            this.Summary.SetDefaults();
            this.WaterUsage = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.WaterUsage();
            this.ElectricalUsage = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.ElectricalUsage();
            this.AdvancedUserSpecified = null;
        }
    }
}

