namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents;
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(OutputCapacity)), XmlInclude(typeof(EnergyFactor))]
    public class CodeTextAndValue : CodeAndText
    {
        [XmlAttribute("value")]
        public decimal Value;

        public CodeTextAndValue()
        {
        }

        public CodeTextAndValue(string code, string text, decimal value)
        {
            base.Code = code;
            base.EnglishText = text;
            base.FrenchText = text;
            this.Value = value;
        }

        public CodeTextAndValue(string code, string englishText, string frenchText, decimal value)
        {
            base.Code = code;
            base.EnglishText = englishText;
            base.FrenchText = frenchText;
            this.Value = value;
        }
    }
}

