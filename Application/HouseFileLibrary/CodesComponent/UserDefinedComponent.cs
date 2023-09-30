namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(ContinuousInsulation)), XmlInclude(typeof(ContinuousMedium)), XmlInclude(typeof(FramingComponent))]
    public class UserDefinedComponent : UserDefinedBaseComponent
    {
        [XmlAttribute("thickness")]
        public decimal Thickness;
    }
}

