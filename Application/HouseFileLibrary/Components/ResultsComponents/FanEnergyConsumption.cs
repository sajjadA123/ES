namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class FanEnergyConsumption
    {
        [XmlElement("Hrv")]
        public FanConsumption Hrv = new FanConsumption();
        [XmlElement("Heating")]
        public FanConsumption Heating = new FanConsumption();
        [XmlElement("AirConditioning")]
        public FanConsumption AirConditioning = new FanConsumption();
        [XmlElement("HrvOrExhaust")]
        public FanConsumption HrvOrExhaust = new FanConsumption();
        [XmlElement("SpaceHeating")]
        public FanConsumption SpaceHeating = new FanConsumption();
        [XmlElement("SpaceCooling")]
        public FanConsumption SpaceCooling = new FanConsumption();
    }
}

