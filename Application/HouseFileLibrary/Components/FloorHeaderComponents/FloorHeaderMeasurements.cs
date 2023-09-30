namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorHeaderComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class FloorHeaderMeasurements
    {
        [XmlAttribute("height")]
        public decimal Height;
        [XmlAttribute("perimeter")]
        public decimal Perimeter;

        [XmlIgnore]
        public decimal Area
        {
            get => 
                this.Perimeter * this.Height;
            set
            {
            }
        }
    }
}

