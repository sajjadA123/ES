namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Globalization;
    using System.Runtime.InteropServices;
    using System.Xml.Linq;

    [StructLayout(LayoutKind.Sequential)]
    public struct LanguageOptions
    {
        public static readonly LanguageOptions English;
        public static readonly LanguageOptions French;
        private string englishName;
        private string frenchName;
        private System.Globalization.CultureInfo cultureInfo;
        public static implicit operator string(LanguageOptions language) => 
            language.cultureInfo.TwoLetterISOLanguageName;

        public static implicit operator System.Globalization.CultureInfo(LanguageOptions language) => 
            language.cultureInfo;

        public static bool operator ==(LanguageOptions x, LanguageOptions y) => 
            x.cultureInfo.TwoLetterISOLanguageName == y.cultureInfo.TwoLetterISOLanguageName;

        public static bool operator !=(LanguageOptions x, LanguageOptions y) => 
            x.cultureInfo.TwoLetterISOLanguageName != y.cultureInfo.TwoLetterISOLanguageName;

        public override bool Equals(object o)
        {
            try
            {
                return (this == ((LanguageOptions) o));
            }
            catch
            {
                return false;
            }
        }

        public override int GetHashCode() => 
            (this == French) ? 1 : 0;

        public static LanguageOptions Clone(LanguageOptions source) => 
            (source == French) ? French : English;

        public static LanguageOptions FromLanguageCode(string languageCode) => 
            (languageCode.Trim().ToLowerInvariant() == "fr") ? French : English;

        public static LanguageOptions FromCultureInfo(System.Globalization.CultureInfo desiredCulture) => 
            (desiredCulture != null) ? ((desiredCulture.TwoLetterISOLanguageName == "fr") ? French : English) : English;

        public System.Globalization.CultureInfo CultureInfo =>
            this.cultureInfo;
        public XAttribute XmlLang() => 
            new XAttribute("xml:lang", this.cultureInfo.TwoLetterISOLanguageName);

        private LanguageOptions(string englishName, string frenchName, System.Globalization.CultureInfo cultureInfo)
        {
            this.englishName = englishName;
            this.frenchName = frenchName;
            this.cultureInfo = cultureInfo;
        }

        static LanguageOptions()
        {
            English = new LanguageOptions("English", "Anglais", new System.Globalization.CultureInfo("en-CA"));
            French = new LanguageOptions("French", "Fran\x00e7ais", new System.Globalization.CultureInfo("fr-CA"));
        }
    }
}

