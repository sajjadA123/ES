namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class HeatPumpTemperature
    {
        private HeatPumpCutoffTypes CutoffType_ = HeatPumpCutoffTypes.Unrestricted;
        private HeatPumpRatingTypes RatingType_ = HeatPumpRatingTypes.EightDegreesCelcius;

        [XmlElement("CutoffType")]
        public CodeTextAndValue CutoffTypeXml
        {
            get => 
                (CodeTextAndValue) this.CutoffType;
            set
            {
                if (value == null)
                {
                    this.CutoffType = null;
                }
                else
                {
                    this.CutoffType = (from dt in HeatPumpCutoffTypes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<HeatPumpCutoffTypes>();
                    if (this.CutoffType.IsUserSpecified)
                    {
                        this.CutoffType.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public HeatPumpCutoffTypes CutoffType
        {
            get => 
                this.CutoffType_;
            set
            {
                if (value == null)
                {
                    this.CutoffType_ = HeatPumpCutoffTypes.Unrestricted;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.CutoffType_ = value;
                }
                else
                {
                    this.CutoffType_ = (from us in HeatPumpCutoffTypes.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<HeatPumpCutoffTypes>();
                    this.CutoffType_.Value = value.Value;
                }
            }
        }

        [XmlElement("RatingType")]
        public CodeTextAndValue RatingTypeXml
        {
            get => 
                (CodeTextAndValue) this.RatingType;
            set
            {
                if (value == null)
                {
                    this.RatingType = null;
                }
                else
                {
                    this.RatingType = (from dt in HeatPumpRatingTypes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<HeatPumpRatingTypes>();
                    if (this.RatingType.IsUserSpecified)
                    {
                        this.RatingType.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public HeatPumpRatingTypes RatingType
        {
            get => 
                this.RatingType_;
            set
            {
                if (value == null)
                {
                    this.RatingType_ = HeatPumpRatingTypes.EightDegreesCelcius;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.RatingType_ = value;
                }
                else
                {
                    this.RatingType_ = (from us in HeatPumpRatingTypes.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<HeatPumpRatingTypes>();
                    this.RatingType_.Value = value.Value;
                }
            }
        }
    }
}

