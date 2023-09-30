namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class SlabWall
    {
        [XmlElement("RValues")]
        public WallRValues RValues = new WallRValues();
    }
}

