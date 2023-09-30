namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorComponents
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    [Serializable]
    public class FloorMeasurements
    {
        [XmlAttribute("area"), Range(0, 0x270f)]
        public decimal Area;
        [XmlAttribute("length"), Range(0, 100)]
        public decimal Length;

        public FloorMeasurements()
        {
        }

        public FloorMeasurements(FloorMeasurements toCopy)
        {
            this.Area = toCopy.Area;
            this.Length = toCopy.Length;
        }
    }
}

