namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class BathroomFaucets : CodeTextAndValue
    {
        [XmlAttribute("numberPerOccupantPerDay")]
        public decimal NumberPerOccupantPerDay;

        public BathroomFaucets()
        {
            this.SetDefaults();
        }

        public BathroomFaucets(BathroomFaucets toCopy)
        {
            base.Code = toCopy.Code;
            base.EnglishText = toCopy.EnglishText;
            base.FrenchText = toCopy.FrenchText;
            base.Value = toCopy.Value;
            this.NumberPerOccupantPerDay = toCopy.NumberPerOccupantPerDay;
        }

        public BathroomFaucets(string code, string englishText, string frenchText, decimal value, decimal numberPerOccupantPerWeek)
        {
            base.Code = code;
            base.EnglishText = englishText;
            base.FrenchText = frenchText;
            base.Value = value;
            this.NumberPerOccupantPerDay = numberPerOccupantPerWeek;
        }

        public void SetDefaults()
        {
            base.Code = "2";
            base.EnglishText = "Standard 8.3 L/min (2.2 US gpm)";
            base.FrenchText = "D\x00e9bit standard 8.3 L/min (2,2 gal/min)";
            base.Value = 8.3M;
            this.NumberPerOccupantPerDay = 1.33M;
        }
    }
}

