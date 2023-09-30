namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.WindowComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class EnergyStar
    {
        [XmlAttribute("energyRating")]
        public string ERText;
        [XmlAttribute("uValueMin")]
        public string UValueMinText;
        [XmlAttribute("uValueMax")]
        public string UValueMaxText;

        [XmlIgnore]
        public int? EnergyRating
        {
            get
            {
                int result = 0;
                if (int.TryParse(this.ERText, out result))
                {
                    return new int?(result);
                }
                return null;
            }
            set
            {
                if (value == null)
                {
                    this.ERText = null;
                }
                else
                {
                    this.ERText = value.ToString();
                    decimal? nullable = null;
                    this.UValueMin = nullable;
                    nullable = null;
                    this.UValueMax = nullable;
                }
            }
        }

        [XmlIgnore]
        public decimal? UValueMin
        {
            get
            {
                decimal result = 0M;
                if (decimal.TryParse(this.UValueMinText, out result))
                {
                    return new decimal?(result);
                }
                return null;
            }
            set
            {
                if (value == null)
                {
                    this.UValueMinText = null;
                }
                else
                {
                    this.EnergyRating = null;
                    this.UValueMinText = value.ToString();
                }
            }
        }

        [XmlIgnore]
        public decimal? UValueMax
        {
            get
            {
                decimal result = 0M;
                if (decimal.TryParse(this.UValueMaxText, out result))
                {
                    return new decimal?(result);
                }
                return null;
            }
            set
            {
                if (value == null)
                {
                    this.UValueMaxText = null;
                }
                else
                {
                    this.EnergyRating = null;
                    this.UValueMaxText = value.ToString();
                }
            }
        }

        [XmlIgnore]
        public short UValueRange
        {
            get =>
                (short)(((this.UValueMin != null) || (this.UValueMax == null)) ? (((this.UValueMin == null) || (this.UValueMax == null)) ? 2 : 1) : 0);
            set
            {
                decimal? nullable2;
                this.EnergyRating = null;
                if (value == 0)
                {
                    nullable2 = null;
                    this.UValueMin = nullable2;
                    this.UValueMax = 1.05M;
                }
                else if (value == 1)
                {
                    this.UValueMin = 1.05M;
                    this.UValueMax = 1.22M;
                }
                else
                {
                    this.UValueMin = 1.22M;
                    nullable2 = null;
                    this.UValueMax = nullable2;
                }
            }
        }
    }
}

