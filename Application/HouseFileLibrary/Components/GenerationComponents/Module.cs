namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class Module
    {
        [XmlAttribute("efficiency")]
        public decimal Efficiency;
        [XmlAttribute("cellTemperature")]
        public decimal CellTemperature;
        [XmlAttribute("coefficientOfEfficiency")]
        public decimal CoefficientOfEfficiency;
        private PhotovoltaicModules Type_ = PhotovoltaicModules.UserSpecified;

        public Module()
        {
            this.SetDefaults();
        }

        public void SetDefaults()
        {
            this.Type = PhotovoltaicModules.UserSpecified;
            this.UpdateValuesFromType();
        }

        public void UpdateValuesFromType()
        {
            if (this.Type_ != null)
            {
                if (this.Type_ == PhotovoltaicModules.MonoSi)
                {
                    this.Efficiency = 13M;
                    this.CellTemperature = 45M;
                    this.CoefficientOfEfficiency = 0.40M;
                }
                else if (this.Type_ == PhotovoltaicModules.PolySi)
                {
                    this.Efficiency = 11M;
                    this.CellTemperature = 45M;
                    this.CoefficientOfEfficiency = 0.40M;
                }
                else if (this.Type_ == PhotovoltaicModules.ASi)
                {
                    this.Efficiency = 5M;
                    this.CellTemperature = 50M;
                    this.CoefficientOfEfficiency = 0.11M;
                }
                else if (this.Type_ == PhotovoltaicModules.Cdte)
                {
                    this.Efficiency = 7M;
                    this.CellTemperature = 46M;
                    this.CoefficientOfEfficiency = 0.24M;
                }
                else if (this.Type_ == PhotovoltaicModules.Cls)
                {
                    this.Efficiency = 7.5M;
                    this.CellTemperature = 47M;
                    this.CoefficientOfEfficiency = 0.46M;
                }
                else if (this.Type_ == PhotovoltaicModules.UserSpecified)
                {
                    this.Efficiency = 14.2M;
                    this.CellTemperature = 45M;
                    this.CoefficientOfEfficiency = 0.72M;
                }
            }
        }

        [XmlElement("Type")]
        public CodeAndText TypeXml
        {
            get => 
                (CodeAndText) this.Type;
            set
            {
                if (value == null)
                {
                    this.Type = null;
                }
                else
                {
                    this.Type = (from dt in PhotovoltaicModules.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<PhotovoltaicModules>();
                }
            }
        }

        [XmlIgnore]
        public PhotovoltaicModules Type
        {
            get => 
                this.Type_;
            set
            {
                if (value == null)
                {
                    this.Type_ = PhotovoltaicModules.UserSpecified;
                }
                else if (this.Type_ != value)
                {
                    this.Type_ = value;
                }
            }
        }
    }
}

