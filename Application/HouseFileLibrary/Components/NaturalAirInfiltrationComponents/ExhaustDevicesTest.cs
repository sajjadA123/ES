namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class ExhaustDevicesTest
    {
        [XmlAttribute("result")]
        public decimal Result;
        private TestStatuses TestStatus_ = TestStatuses.NotApplicable;

        [XmlElement("TestStatus")]
        public CodeAndText TestStatusXml
        {
            get => 
                (CodeAndText) this.TestStatus;
            set
            {
                if (value == null)
                {
                    this.TestStatus = null;
                }
                else
                {
                    this.TestStatus = (from dt in TestStatuses.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<TestStatuses>();
                }
            }
        }

        [XmlIgnore]
        public TestStatuses TestStatus
        {
            get => 
                this.TestStatus_;
            set
            {
                if (value == null)
                {
                    this.TestStatus_ = TestStatuses.NotApplicable;
                }
                else
                {
                    this.TestStatus_ = value;
                }
            }
        }
    }
}

