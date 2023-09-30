namespace ca.nrcan.gc.OEE.HouseFileLibrary.WeatherLibraryHelpers
{
    using System;
    using System.Xml.Linq;

    public class WeatherLocation
    {
        public string English;
        public string French;
        public WeatherRegion region;
        private uint code;

        private WeatherLocation()
        {
            this.English = string.Empty;
            this.French = string.Empty;
        }

        public WeatherLocation(WeatherLocation source)
        {
            this.English = string.Empty;
            this.French = string.Empty;
            this.code = source.code;
            this.English = source.English;
            this.French = source.French;
            this.region = new WeatherRegion(source.region);
        }

        public WeatherLocation(WeatherRegion region, uint code, string englishName)
        {
            this.English = string.Empty;
            this.French = string.Empty;
            this.code = code;
            this.region = region;
            this.English = englishName;
            this.French = englishName;
        }

        public uint Code =>
            this.code;

        public XElement Xml
        {
            get
            {
                object[] content = new object[] { new XAttribute("code", this.code), new XElement("English", new XText(this.English)), new XElement("French", new XText(this.French)) };
                return new XElement("Location", content);
            }
        }
    }
}

