namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class LoadAnnual
    {
        [XmlAttribute("basementHeating")]
        public decimal BasementHeating;
        [XmlAttribute("basementCooling")]
        public decimal BasementCooling;
        [XmlAttribute("grossHeating")]
        public decimal GrossHeating;
        [XmlAttribute("auxiliaryEnergy")]
        public decimal AuxiliaryEnergy;
    }
}

