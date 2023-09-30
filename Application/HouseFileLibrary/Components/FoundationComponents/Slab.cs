namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Slab : Foundation
    {
        [XmlElement("Floor")]
        public FoundationFloor Floor = new FoundationFloor();
        [XmlElement("Wall")]
        public SlabWall Wall = new SlabWall();

        public Slab()
        {
            this.SetDefaults();
        }

        public void SetDefaults()
        {
            base.Label = "Slab-on-grade";
        }
    }
}

