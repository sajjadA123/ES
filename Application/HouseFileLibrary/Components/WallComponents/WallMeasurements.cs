namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.WallComponents
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    [Serializable]
    public class WallMeasurements
    {
        [XmlAttribute("height"), Range((double) 0.1, (double) 50.0)]
        public decimal Height;
        [XmlAttribute("perimeter"), Range((double) 0.1, (double) 100.0)]
        public decimal Perimeter;

        public WallMeasurements()
        {
        }

        public WallMeasurements(WallMeasurements toCopy)
        {
            this.Height = toCopy.Height;
            this.Perimeter = toCopy.Perimeter;
        }

        [XmlIgnore]
        public decimal Area =>
            this.Height * this.Perimeter;
    }
}

