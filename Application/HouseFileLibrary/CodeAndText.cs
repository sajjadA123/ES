namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(HeatPumpCoolingType)), XmlInclude(typeof(AdditionalOpening))]
    public class CodeAndText
    {
        [XmlElement("English")]
        public string EnglishText;
        [XmlElement("French")]
        public string FrenchText;
        [XmlText]
        public string Text;
        private string code;

        public CodeAndText()
        {
        }

        public CodeAndText(CodeAndText toCopy)
        {
            this.Text = toCopy.Text;
            this.EnglishText = toCopy.EnglishText;
            this.FrenchText = toCopy.FrenchText;
            this.code = toCopy.Code;
        }

        public CodeAndText(string code, string englishText, string frenchText)
        {
            this.Set(code, englishText, frenchText);
        }

        public string GetLanguage(LanguageOptions desiredLanguage) => 
            (desiredLanguage == LanguageOptions.French) ? this.FrenchText : this.EnglishText;

        public void Set(string code)
        {
            this.Code = code;
        }

        public void Set(string code, string englishText, string frenchText)
        {
            this.Code = code;
            this.EnglishText = englishText;
            this.FrenchText = frenchText;
        }

        [Required, XmlAttribute("code")]
        public string Code
        {
            get => 
                this.code;
            set
            {
                if (this.code != value)
                {
                    this.Text = null;
                    this.EnglishText = null;
                    this.FrenchText = null;
                    this.code = value;
                }
            }
        }
    }
}

