namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.WallComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class WallConstruction : Construction
    {
        [XmlAttribute("corners")]
        public decimal Corners;
        [XmlAttribute("intersections")]
        public decimal Intersections;
        [XmlElement("LintelType")]
        public CodeReference LintelType;

        public WallConstruction()
        {
        }

        public WallConstruction(WallConstruction toCopy) : base(toCopy)
        {
            this.Corners = toCopy.Corners;
            this.Intersections = toCopy.Intersections;
            this.LintelType = new CodeReference(toCopy.LintelType);
        }
    }
}

