namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    public class RatedValue : CodeAndText
    {
        [XmlAttribute("ratedWaterConsumptionPerCycle")]
        public decimal RatedWaterConsumptionPerCycle;
        [XmlAttribute("ratedAnnualEnergyConsumption")]
        public decimal RatedAnnualEnergyConsumption;

        public RatedValue()
        {
            this.SetDefaults();
        }

        public RatedValue(RatedValue toCopy)
        {
            base.Text = toCopy.Text;
            base.EnglishText = toCopy.EnglishText;
            base.FrenchText = toCopy.FrenchText;
            base.Code = toCopy.Code;
            this.RatedWaterConsumptionPerCycle = toCopy.RatedWaterConsumptionPerCycle;
            this.RatedAnnualEnergyConsumption = toCopy.RatedAnnualEnergyConsumption;
        }

        public void SetDefaults()
        {
            base.Text = null;
            base.EnglishText = "Default";
            base.FrenchText = "Par d\x00e9faut";
            base.Code = "1";
            this.RatedWaterConsumptionPerCycle = 19M;
            this.RatedAnnualEnergyConsumption = 260M;
        }
    }
}

