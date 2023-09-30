namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class AnnualConsumption
    {
        [XmlAttribute("total")]
        public decimal Total;
        [XmlElement("Electrical")]
        public ElectricalAnnual Electrical = new ElectricalAnnual();
        [XmlElement("NaturalGas")]
        public NaturalGasAppliance NaturalGas = new NaturalGasAppliance();
        [XmlElement("Oil")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.Oil Oil = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.Oil();
        [XmlElement("Propane")]
        public PropaneAppliance Propane = new PropaneAppliance();
        [XmlElement("Wood")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.Wood Wood = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.Wood();
        [XmlElement("SpaceHeating")]
        public PrimarySecondaryEnergy SpaceHeating = new PrimarySecondaryEnergy();
        [XmlElement("HotWater")]
        public PrimarySecondaryEnergy HotWater = new PrimarySecondaryEnergy();
        [XmlElement("SupplementalHeating")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.SupplementalHeating SupplementalHeating = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.SupplementalHeating();
    }
}

