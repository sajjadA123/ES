namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class ClothesWasher
    {
        [XmlAttribute("numberPerOccupantPerWeek")]
        public decimal NumberPerOccupantPerWeek;
        [XmlElement("RatedValues")]
        public RatedValue RatedValues;
        private ClothesWasherTemperatures Temperature_;

        public ClothesWasher()
        {
            this.RatedValues = new RatedValue();
            this.Temperature_ = ClothesWasherTemperatures.Hot;
            this.SetDefaults();
        }

        public ClothesWasher(ClothesWasher toCopy)
        {
            this.RatedValues = new RatedValue();
            this.Temperature_ = ClothesWasherTemperatures.Hot;
            this.RatedValues = new RatedValue(toCopy.RatedValues);
            this.Temperature = toCopy.Temperature;
            this.NumberPerOccupantPerWeek = toCopy.NumberPerOccupantPerWeek;
        }

        public void SetDefaults()
        {
            this.RatedValues.SetDefaults();
            this.RatedValues.RatedAnnualEnergyConsumption = 197.0M;
            this.RatedValues.RatedWaterConsumptionPerCycle = 54.0M;
            this.Temperature = ClothesWasherTemperatures.Hot;
            this.NumberPerOccupantPerWeek = 1.9M;
        }

        [XmlElement("Temperature")]
        public CodeAndText TemperatureXml
        {
            get => 
                (CodeAndText) this.Temperature;
            set
            {
                if (value == null)
                {
                    this.Temperature = null;
                }
                else
                {
                    this.Temperature = (from dt in ClothesWasherTemperatures.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<ClothesWasherTemperatures>();
                }
            }
        }

        [XmlIgnore]
        public ClothesWasherTemperatures Temperature
        {
            get => 
                this.Temperature_;
            set
            {
                if (value == null)
                {
                    this.Temperature_ = ClothesWasherTemperatures.Hot;
                }
                else
                {
                    this.Temperature_ = value;
                }
            }
        }
    }
}

