namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class WalkoutFloor
    {
        [XmlElement("Construction")]
        public FoundationFloorConstruction Construction = new FoundationFloorConstruction();
    }
}

