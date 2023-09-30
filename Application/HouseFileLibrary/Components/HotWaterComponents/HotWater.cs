namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class HotWater : Component
    {
        [XmlElement("Primary")]
        public HotWaterComponent Primary;
        [XmlElement("Secondary")]
        public HotWaterComponent Secondary;
        [XmlElement("NumberOfDwhrSystems")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents.NumberOfDwhrSystems NumberOfDwhrSystems;
        [XmlElement("NumberOfHotWaterSystems")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents.NumberOfHotWaterSystems NumberOfHotWaterSystems;

        public HotWater()
        {
            this.SetDefaults();
        }

        public void SetDefaults()
        {
            base.Label = "Domestic Hot Water";
        }

        public void SetFractionOfPrimary(decimal fractionOfPrimary)
        {
            if ((this.Secondary == null) && (this.Primary != null))
            {
                this.Primary.Fraction = 1.0M;
            }
            else if (this.Primary != null)
            {
                decimal num = (fractionOfPrimary > 1.0M) ? 1.0M : fractionOfPrimary;
                if (num < 0.0M)
                {
                    num = new decimal(0, 0, 0, false, 1);
                }
                this.Primary.Fraction = num;
                this.Secondary.Fraction = 1.0M - num;
            }
        }
    }
}

