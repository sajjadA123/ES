namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class BlowerTest
    {
        [XmlIgnore]
        public bool AirLeakageTestData;
        [XmlAttribute("airChangeRate")]
        public decimal AirChangeRate;
        [XmlAttribute("isCgsbTest")]
        public bool IsCgsbTest = true;
        [XmlAttribute("isCalculated")]
        public bool isCalculated;
        [XmlAttribute("leakageArea")]
        public decimal LeakageArea;
        [XmlAttribute("guarded")]
        public bool Guarded;
        private BlowerTestPressures Pressure_ = BlowerTestPressures.FourPascals;

        [XmlElement("Pressure")]
        public CodeAndText PressureXml
        {
            get => 
                (CodeAndText) this.Pressure;
            set
            {
                if (value == null)
                {
                    this.Pressure = null;
                }
                else
                {
                    this.Pressure = (from dt in BlowerTestPressures.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<BlowerTestPressures>();
                }
            }
        }

        [XmlIgnore]
        public BlowerTestPressures Pressure
        {
            get => 
                this.Pressure_;
            set
            {
                if (value == null)
                {
                    this.Pressure_ = BlowerTestPressures.FourPascals;
                }
                else
                {
                    this.Pressure_ = value;
                }
            }
        }
    }
}

