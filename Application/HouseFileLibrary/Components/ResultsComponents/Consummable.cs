namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(NaturalGasAppliance)), XmlInclude(typeof(PropaneAppliance))]
    public class Consummable
    {
        [XmlAttribute("baseload")]
        public decimal Baseload;
        [XmlAttribute("hotWater")]
        public decimal HotWater;
        [XmlAttribute("spaceHeating")]
        public decimal SpaceHeating;
        [XmlAttribute("total")]
        public decimal TotalInGigaJoules;
    }
}

