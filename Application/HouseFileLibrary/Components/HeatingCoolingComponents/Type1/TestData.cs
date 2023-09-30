namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class TestData
    {
        [XmlAttribute("controlsPower")]
        public decimal ControlsPower;
        [XmlAttribute("circulationPower")]
        public decimal CirculationPower;
        [XmlAttribute("dailyUse")]
        public decimal DailyUse;
        [XmlAttribute("standbyLossWithFan")]
        public decimal StandbyLossWithFan;
        [XmlAttribute("standbyLossWithoutFan")]
        public decimal StandbyLossWithoutFan;
        [XmlAttribute("oneHourRatingHotWater")]
        public decimal OneHourRatingHotWater;
        [XmlAttribute("oneHourRatingConcurrent")]
        public decimal OneHourRatingConcurrent;
        private P9EnergySources EnergySource_ = P9EnergySources.NaturalGas;
        [XmlElement("NetEfficiency")]
        public P9LoadPerformance NetEfficiency = new P9LoadPerformance();
        [XmlElement("ElectricalUse")]
        public P9LoadPerformance ElectricalUse = new P9LoadPerformance();
        [XmlElement("BlowerPower")]
        public P9LoadPerformance BlowerPower = new P9LoadPerformance();

        [XmlElement("EnergySource")]
        public CodeAndText EnergySourceXml
        {
            get => 
                (CodeAndText) this.EnergySource;
            set
            {
                if (value == null)
                {
                    this.EnergySource = null;
                }
                else
                {
                    this.EnergySource = (from dt in P9EnergySources.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<P9EnergySources>();
                }
            }
        }

        [XmlIgnore]
        public P9EnergySources EnergySource
        {
            get => 
                this.EnergySource_;
            set
            {
                if (value == null)
                {
                    this.EnergySource_ = P9EnergySources.NaturalGas;
                }
                else
                {
                    this.EnergySource_ = value;
                }
            }
        }
    }
}

