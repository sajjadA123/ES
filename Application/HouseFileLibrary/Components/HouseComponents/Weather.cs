namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.WeatherLibraryHelpers;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Weather
    {
        [XmlAttribute("depthOfFrost")]
        public decimal DepthOfFrost;
        [XmlAttribute("heatingDegreeDay")]
        public decimal HeatingDegreeDay;
        [XmlIgnore]
        public WeatherRegion Region;
        [XmlIgnore]
        public WeatherLocation Location;
        private WeatherLibrary library;
        private string fileCached;
        private CodeAndText regionCached;
        private CodeAndText locationCached;

        [XmlAttribute("library")]
        public string Library
        {
            get => 
                (this.library == null) ? this.fileCached : this.library.FileName;
            set
            {
                this.fileCached = value;
                WeatherLibrary library = WeatherLibrary.Load(value);
                if (library != null)
                {
                    this.library = library;
                }
            }
        }

        [XmlElement("Region")]
        public CodeAndText RegionXml
        {
            get => 
                (this.Region == null) ? this.regionCached : new CodeAndText(this.Region.Code.ToString(), this.Region.English, this.Region.French);
            set
            {
                this.regionCached = value;
                this.Region = null;
                uint result = 0;
                if ((value != null) && ((this.library != null) && uint.TryParse(value.Code, out result)))
                {
                    this.Region = this.library.GetRegion(result);
                }
            }
        }

        [XmlElement("Location")]
        public CodeAndText LocationXml
        {
            get => 
                (this.Location == null) ? this.locationCached : new CodeAndText(this.Location.Code.ToString(), this.Location.English, this.Location.French);
            set
            {
                this.locationCached = value;
                this.Location = null;
                uint result = 0;
                if ((value != null) && ((this.library != null) && uint.TryParse(value.Code, out result)))
                {
                    this.Location = this.library.GetLocation(result);
                }
            }
        }
    }
}

