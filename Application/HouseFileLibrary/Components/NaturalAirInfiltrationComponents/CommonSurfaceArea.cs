namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class CommonSurfaceArea
    {
        [XmlAttribute("surfacearea")]
        public decimal SurfaceArea;
    }
}

