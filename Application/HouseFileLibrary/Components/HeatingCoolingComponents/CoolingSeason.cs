namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class CoolingSeason
    {
        private Months Start_ = Months.January;
        private Months End_ = Months.December;
        private Months Design_ = Months.July;

        [XmlElement("Start")]
        public CodeAndText StartXml
        {
            get => 
                (CodeAndText) this.Start;
            set
            {
                if (value == null)
                {
                    this.Start = null;
                }
                else
                {
                    this.Start = (from dt in Months.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<Months>();
                }
            }
        }

        [XmlIgnore]
        public Months Start
        {
            get => 
                this.Start_;
            set => 
                this.Start_ = value;
        }

        [XmlElement("End")]
        public CodeAndText EndXml
        {
            get => 
                (CodeAndText) this.End;
            set
            {
                if (value == null)
                {
                    this.End = null;
                }
                else
                {
                    this.End = (from dt in Months.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<Months>();
                }
            }
        }

        [XmlIgnore]
        public Months End
        {
            get => 
                this.End_;
            set => 
                this.End_ = value;
        }

        [XmlElement("Design")]
        public CodeAndText DesignXml
        {
            get => 
                (CodeAndText) this.Design;
            set
            {
                if (value == null)
                {
                    this.Design = null;
                }
                else
                {
                    this.Design = (from dt in Months.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<Months>();
                }
            }
        }

        [XmlIgnore]
        public Months Design
        {
            get => 
                this.Design_;
            set => 
                this.Design_ = value;
        }
    }
}

