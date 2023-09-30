namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class ElectricalAnnual
    {
        [XmlAttribute("baseload")]
        public decimal Baseload;
        [XmlAttribute("airConditioning")]
        public decimal AirConditioning;
        [XmlAttribute("appliance")]
        public decimal Appliance;
        [XmlAttribute("lighting")]
        public decimal Lighting;
        [XmlAttribute("heatPump")]
        public decimal HeatPump;
        [XmlAttribute("spaceHeating")]
        public decimal SpaceHeating;
        [XmlAttribute("spaceCooling")]
        public decimal SpaceCooling;
        [XmlAttribute("ventilation")]
        public decimal Ventilation;
        [XmlAttribute("total")]
        public decimal TotalInGigaJoules;
        [XmlElement("HotWater")]
        public HotWaterElectrical HotWater = new HotWaterElectrical();

        [XmlIgnore]
        public decimal TotalInKiloWattHours
        {
            get => 
                (decimal) Conversions.GigaJoulesToKiloWattHours((double) this.TotalInGigaJoules);
            set => 
                this.TotalInGigaJoules = (decimal) Conversions.KiloWattHoursToGigaJoules((double) value);
        }
    }
}

