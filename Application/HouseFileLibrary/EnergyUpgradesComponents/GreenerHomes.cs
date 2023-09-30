namespace ca.nrcan.gc.OEE.HouseFileLibrary.EnergyUpgradesComponents
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Xml.Serialization;

    [Serializable]
    public class GreenerHomes
    {
        public GreenerHomes()
        {
        }

        public GreenerHomes(GreenerHomes toCopy)
        {
            this.BasementSlabInsulated = toCopy.BasementSlabInsulated;
            this.MoistureProofCrawlSpace = toCopy.MoistureProofCrawlSpace;
            this.Waterproofing = toCopy.Waterproofing;
            this.RoofingMembrane = toCopy.RoofingMembrane;
            this.MinR10ContinuousExposedFloors = toCopy.MinR10ContinuousExposedFloors;
            this.BackwaterValve = toCopy.BackwaterValve;
            this.SumpPump = toCopy.SumpPump;
            this.SmartThermostats = toCopy.SmartThermostats;
        }

        public void Clear()
        {
            this.BasementSlabInsulated = false;
            this.MoistureProofCrawlSpace = false;
            this.Waterproofing = false;
            this.RoofingMembrane = false;
            this.MinR10ContinuousExposedFloors = false;
            this.BackwaterValve = false;
            this.SumpPump = false;
            this.SmartThermostats = false;
        }

        [XmlAttribute("basementSlabInsulated")]
        public bool BasementSlabInsulated { get; set; }

        [XmlAttribute("moistureProofCrawlSpace")]
        public bool MoistureProofCrawlSpace { get; set; }

        [XmlAttribute("waterproofing")]
        public bool Waterproofing { get; set; }

        [XmlAttribute("roofingMembrane")]
        public bool RoofingMembrane { get; set; }

        [XmlAttribute("minR10ContinuousExposedFloors")]
        public bool MinR10ContinuousExposedFloors { get; set; }

        [XmlAttribute("backwaterValve")]
        public bool BackwaterValve { get; set; }

        [XmlAttribute("sumpPump")]
        public bool SumpPump { get; set; }

        [XmlAttribute("smartThermostats")]
        public bool SmartThermostats { get; set; }
    }
}

