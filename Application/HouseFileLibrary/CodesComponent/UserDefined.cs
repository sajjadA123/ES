namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [Serializable]
    public class UserDefined : Code
    {
        [XmlArray("Layers"), XmlArrayItem("ContinuousInsulation", typeof(ContinuousInsulation)), XmlArrayItem("ContinuousMedium", typeof(ContinuousMedium)), XmlArrayItem("Lintel", typeof(LintelUserDefined)), XmlArrayItem("SteelFraming", typeof(SteelFramingLayer)), XmlArrayItem("Strapping", typeof(StrappingLayer)), XmlArrayItem("Window", typeof(WindowUserDefined)), XmlArrayItem("WindowLegacy", typeof(WindowLegacy)), XmlArrayItem("WoodFraming", typeof(WoodFramingLayer))]
        public List<UserDefinedLayer> Layers = new List<UserDefinedLayer>();
    }
}

