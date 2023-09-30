namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents
{
    using System;
    using System.Xml.Serialization;

    public class RadiantHeating
    {
        [XmlElement("AtticCeiling")]
        public RadiantHeatingComponent AtticCeiling = new RadiantHeatingComponent();
        [XmlElement("FlatRoof")]
        public RadiantHeatingComponent FlatRoof = new RadiantHeatingComponent();
        [XmlElement("AboveCrawlspace")]
        public RadiantHeatingComponent AboveCrawlspace = new RadiantHeatingComponent();
        [XmlElement("SlabOnGrade")]
        public RadiantHeatingComponent SlabOnGrade = new RadiantHeatingComponent();
        [XmlElement("AboveBasement")]
        public RadiantHeatingComponent AboveBasement = new RadiantHeatingComponent();
        [XmlElement("Basement")]
        public RadiantHeatingComponent Basement = new RadiantHeatingComponent();
    }
}

