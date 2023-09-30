namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.SupplementaryHeat
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class SupplementaryHeatSpecifications
    {
        [XmlAttribute("efficiency")]
        public decimal Efficiency;
        [XmlAttribute("pilotLight")]
        public decimal PilotLight;
        [XmlAttribute("damperClosed")]
        public bool DamperClosed;
        private ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.YearMade YearMade_ = ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.YearMade.Years1970To79;
        private HeatingUsages Usage_ = HeatingUsages.Never;
        [XmlElement("MonthlyUsage")]
        public MonthlyData MonthlyUsage;
        private HeatingLocations LocationHeated_ = HeatingLocations.MainFloors;
        [XmlElement("Flue")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.SupplementaryHeat.Flue Flue = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.SupplementaryHeat.Flue();
        [XmlElement("OutputCapacity")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.OutputCapacity OutputCapacity = new ca.nrcan.gc.OEE.HouseFileLibrary.OutputCapacity();

        [XmlElement("YearMade")]
        public CodeAndText YearMadeXml
        {
            get => 
                (CodeAndText) this.YearMade;
            set
            {
                if (value == null)
                {
                    this.YearMade = null;
                }
                else
                {
                    this.YearMade = (from dt in ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.YearMade.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.YearMade>();
                }
            }
        }

        [XmlIgnore]
        public ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.YearMade YearMade
        {
            get => 
                this.YearMade_;
            set
            {
                if (value == null)
                {
                    this.YearMade_ = ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.YearMade.Years1970To79;
                }
                else
                {
                    this.YearMade_ = value;
                }
            }
        }

        [XmlElement("Usage")]
        public CodeAndText UsageXml
        {
            get => 
                (CodeAndText) this.Usage;
            set
            {
                if (value == null)
                {
                    this.Usage = null;
                }
                else
                {
                    this.Usage = (from dt in HeatingUsages.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<HeatingUsages>();
                }
            }
        }

        [XmlIgnore]
        public HeatingUsages Usage
        {
            get => 
                this.Usage_;
            set
            {
                if (value == null)
                {
                    this.Usage_ = HeatingUsages.Never;
                }
                else
                {
                    this.Usage_ = value;
                }
            }
        }

        [XmlElement("LocationHeated")]
        public CodeTextAndValue LocationHeatedXml
        {
            get => 
                (CodeTextAndValue) this.LocationHeated;
            set
            {
                if (value == null)
                {
                    this.LocationHeated = null;
                }
                else
                {
                    this.LocationHeated = (from dt in HeatingLocations.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<HeatingLocations>();
                    if (this.LocationHeated.IsUserSpecified)
                    {
                        this.LocationHeated.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public HeatingLocations LocationHeated
        {
            get => 
                this.LocationHeated_;
            set
            {
                if (value == null)
                {
                    this.LocationHeated_ = HeatingLocations.MainFloors;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.LocationHeated_ = value;
                }
                else
                {
                    this.LocationHeated_ = (from us in HeatingLocations.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<HeatingLocations>();
                    this.LocationHeated_.Value = value.Value;
                }
            }
        }
    }
}

