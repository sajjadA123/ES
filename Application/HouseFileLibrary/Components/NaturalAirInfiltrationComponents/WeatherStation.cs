namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class WeatherStation
    {
        [XmlAttribute("anemometerHeight")]
        public decimal AnemometerHeight;
        private Terrains Terrain_ = Terrains.OpenFlatTerrainGrass;

        [XmlElement("Terrain")]
        public CodeAndText TerrainXml
        {
            get => 
                (CodeAndText) this.Terrain;
            set
            {
                if (value == null)
                {
                    this.Terrain = null;
                }
                else
                {
                    this.Terrain = (from dt in Terrains.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<Terrains>();
                }
            }
        }

        [XmlIgnore]
        public Terrains Terrain
        {
            get => 
                this.Terrain_;
            set
            {
                if (value == null)
                {
                    this.Terrain_ = Terrains.OpenFlatTerrainGrass;
                }
                else
                {
                    this.Terrain_ = value;
                }
            }
        }
    }
}

