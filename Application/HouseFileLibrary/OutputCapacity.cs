namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class OutputCapacity : CodeTextAndValue
    {
        [XmlAttribute("uiUnits")]
        public string UiUnits;

        public OutputCapacity()
        {
            this.UiUnits = string.Empty;
        }

        public OutputCapacity(string code, string englishText, string frenchText, decimal value, string uiUnits)
        {
            this.UiUnits = string.Empty;
            this.Set(code, englishText, frenchText, value, uiUnits);
        }

        public void OnHouseFileLoaded()
        {
            if (this.UiUnits.ToLowerInvariant() == "btu/hr")
            {
                base.Value = Conversions.ConvertUnits(eConversionType.UNIT_KW_2_BTUHR, eUnitType.M_2_I, base.Value);
            }
        }

        public void Set(string code, string englishText, string frenchText, decimal value, string uiUnits)
        {
            base.Code = code;
            base.EnglishText = englishText;
            base.FrenchText = frenchText;
            base.Value = value;
            this.UiUnits = uiUnits;
        }

        [XmlIgnore]
        public decimal ValueInUiUnits
        {
            get => 
                (this.UiUnits.ToLowerInvariant() != "btu/hr") ? base.Value : Conversions.ConvertUnits(eConversionType.UNIT_KW_2_BTUHR, eUnitType.M_2_I, base.Value);
            set
            {
                if (this.UiUnits.ToLowerInvariant() == "btu/hr")
                {
                    base.Value = Conversions.ConvertUnits(eConversionType.UNIT_KW_2_BTUHR, eUnitType.I_2_M, value);
                }
                else
                {
                    base.Value = value;
                }
            }
        }
    }
}

