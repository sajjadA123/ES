namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Configuration
    {
        [XmlAttribute("type")]
        public string Type;
        [XmlAttribute("subtype")]
        public uint Subtype;
        [XmlAttribute("overlap")]
        public decimal Overlap;

        [XmlText]
        public string Text
        {
            get => 
                $"{this.Type}_{this.Subtype}";
            set
            {
            }
        }
    }
}

