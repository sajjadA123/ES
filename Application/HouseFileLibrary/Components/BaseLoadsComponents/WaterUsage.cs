namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class WaterUsage
    {
        [XmlAttribute("temperature")]
        public decimal Temperature;
        [XmlAttribute("otherHotWaterUse")]
        public decimal OtherHotWaterUse;
        [XmlAttribute("lowFlushToilets")]
        public ushort LowFlushToilets;
        [XmlElement("BathroomFaucets")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.BathroomFaucets BathroomFaucets;
        [XmlElement("Shower")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.Shower Shower;
        [XmlElement("ClothesWasher")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.ClothesWasher ClothesWasher;
        [XmlElement("DishWasher")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.DishWasher DishWasher;

        public WaterUsage()
        {
            this.BathroomFaucets = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.BathroomFaucets();
            this.Shower = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.Shower();
            this.SetDefaults();
        }

        public WaterUsage(WaterUsage toCopy)
        {
            this.BathroomFaucets = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.BathroomFaucets();
            this.Shower = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.Shower();
            this.Temperature = toCopy.Temperature;
            this.OtherHotWaterUse = toCopy.OtherHotWaterUse;
            this.LowFlushToilets = toCopy.LowFlushToilets;
            this.BathroomFaucets = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.BathroomFaucets(toCopy.BathroomFaucets);
            this.Shower = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.Shower(toCopy.Shower);
            this.ClothesWasher = (toCopy.ClothesWasher == null) ? null : new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.ClothesWasher(toCopy.ClothesWasher);
            this.DishWasher = (toCopy.DishWasher == null) ? null : new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.DishWasher(toCopy.DishWasher);
        }

        public void SetDefaults()
        {
            this.Temperature = 55M;
            this.OtherHotWaterUse = 2.92M;
            this.LowFlushToilets = 0;
            this.BathroomFaucets.SetDefaults();
            this.Shower.SetDefaults();
            this.ClothesWasher = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.ClothesWasher();
            this.DishWasher = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.DishWasher();
        }
    }
}

