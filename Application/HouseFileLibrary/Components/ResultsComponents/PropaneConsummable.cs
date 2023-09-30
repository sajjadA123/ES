namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class PropaneConsummable : Consummable
    {
        [XmlAttribute("appliance")]
        public decimal Appliance;
    }
}

