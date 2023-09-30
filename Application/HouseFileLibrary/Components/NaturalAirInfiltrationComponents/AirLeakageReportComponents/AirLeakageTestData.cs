namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.AirLeakageReportComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class AirLeakageTestData
    {
        [XmlAttribute("hasCgsbConditions")]
        public bool HasCgsbConditions;
        [XmlAttribute("outsideTemperature")]
        public decimal OutsideTemperature;
        [XmlAttribute("barometricPressure")]
        public decimal BarometricPressure;
        private AirLeakageTestTypes TestType_ = AirLeakageTestTypes.OneBlowerWholeHouse;
        [XmlArray("TestData"), XmlArrayItem("Test", typeof(Test))]
        public List<Test> TestData = new List<Test>();

        [XmlElement("TestType")]
        public CodeAndText TestTypeXml
        {
            get => 
                (CodeAndText) this.TestType;
            set
            {
                if (value == null)
                {
                    this.TestType = null;
                }
                else
                {
                    this.TestType = (from dt in AirLeakageTestTypes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<AirLeakageTestTypes>();
                }
            }
        }

        [XmlIgnore]
        public AirLeakageTestTypes TestType
        {
            get => 
                this.TestType_;
            set
            {
                if (value == null)
                {
                    this.TestType_ = AirLeakageTestTypes.OneBlowerWholeHouse;
                }
                else
                {
                    this.TestType_ = value;
                }
            }
        }
    }
}

