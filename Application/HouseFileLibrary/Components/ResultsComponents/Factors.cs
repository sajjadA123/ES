namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Factors
    {
        [XmlElement("MainFloors")]
        public MainFloorsFactors MainFloors = new MainFloorsFactors();
        [XmlElement("Basement")]
        public BasementFactors Basement = new BasementFactors();
    }
}

