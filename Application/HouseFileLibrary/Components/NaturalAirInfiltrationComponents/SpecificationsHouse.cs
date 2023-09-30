namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class SpecificationsHouse
    {
        [XmlAttribute("volume")]
        public decimal Volume;
        [XmlAttribute("includeCrawlspaceVolume")]
        public bool includeCrawlspaceVolume;
        private AirTightnessTypes AirTightnessTest_ = AirTightnessTypes.EnergyTight;

        [XmlElement("AirTightnessTest")]
        public CodeTextAndValue AirTightnessTestXml
        {
            get => 
                (CodeTextAndValue) this.AirTightnessTest;
            set
            {
                if (value == null)
                {
                    this.AirTightnessTest = null;
                }
                else
                {
                    this.AirTightnessTest = (from dt in AirTightnessTypes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<AirTightnessTypes>();
                    if (this.AirTightnessTest.IsUserSpecified)
                    {
                        this.AirTightnessTest.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public AirTightnessTypes AirTightnessTest
        {
            get => 
                this.AirTightnessTest_;
            set
            {
                if (value == null)
                {
                    this.AirTightnessTest_ = AirTightnessTypes.EnergyTight;
                }
                else
                {
                    this.AirTightnessTest_ = value;
                }
            }
        }
    }
}

