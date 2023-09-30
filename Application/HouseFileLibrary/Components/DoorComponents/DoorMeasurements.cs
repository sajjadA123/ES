namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.DoorComponents
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    [Serializable]
    public class DoorMeasurements
    {
        [XmlAttribute("height"), Range(0, 0xc350)]
        public decimal Height;
        [XmlAttribute("width"), Range(0, 0xc350)]
        public decimal Width;

        public DoorMeasurements()
        {
        }

        public DoorMeasurements(DoorMeasurements toCopy)
        {
            this.Height = toCopy.Height;
            this.Width = toCopy.Width;
        }

        [XmlIgnore]
        public decimal Area =>
            this.Height * this.Width;
    }
}

