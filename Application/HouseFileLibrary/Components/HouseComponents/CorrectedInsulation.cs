namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class CorrectedInsulation
    {
        [XmlElement("Ceilings")]
        public SelectedAndText Ceilings = new SelectedAndText();
        [XmlElement("Walls")]
        public SelectedAndText Walls = new SelectedAndText();
        [XmlElement("Basement")]
        public SelectedAndText Basement = new SelectedAndText();
    }
}

