namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Justifications
    {
        [XmlAttribute("nameplateEfficiency")]
        public bool NameplateEfficiency;
        [XmlAttribute("combustionTestEfficiency")]
        public bool CombustionTestEfficiency;
        [XmlAttribute("heatingCorrection")]
        public bool HeatingCorrection;
        [XmlAttribute("achCorrection")]
        public bool AchCorrection;
        [XmlAttribute("twoBlowerDoors")]
        public bool TwoBlowerDoors;
        [XmlAttribute("over18Months")]
        public bool Over18Months;
        [XmlElement("PossessionDate")]
        public SelectedAndDate PossessionDate = new SelectedAndDate();
        [XmlElement("HeatingVolumeDecrease")]
        public SelectedAndText HeatingVolumeDecrease = new SelectedAndText();
        [XmlElement("CorrectedInsulation")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.CorrectedInsulation CorrectedInsulation = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.CorrectedInsulation();
        [XmlElement("Other")]
        public SelectedAndText Other = new SelectedAndText();
        [XmlElement("EnergyStar")]
        public CodeAndText EnergyStar = new CodeAndText();
    }
}

