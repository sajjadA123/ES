namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Floor : Component
    {
        [XmlAttribute("adjacentEnclosedSpace")]
        public bool AdjacentEnclosedSpace;
        [XmlElement("Construction")]
        public FloorConstruction Construction;
        [XmlElement("Measurements")]
        public FloorMeasurements Measurements;

        public Floor()
        {
            this.Construction = new FloorConstruction();
            this.Measurements = new FloorMeasurements();
            this.SetDefaults();
        }

        public Floor(Floor toCopy)
        {
            this.Construction = new FloorConstruction();
            this.Measurements = new FloorMeasurements();
            base.Id = toCopy.Id;
            base.Label = toCopy.Label;
            this.AdjacentEnclosedSpace = toCopy.AdjacentEnclosedSpace;
            this.Construction = new FloorConstruction(toCopy.Construction);
            this.Measurements = new FloorMeasurements(toCopy.Measurements);
        }

        public void SetDefaults()
        {
            base.Label = "Floor";
            this.AdjacentEnclosedSpace = false;
            this.Construction.Type.Code = "3200000000";
            this.Construction.Type.Text = this.Construction.Type.Code;
            this.Construction.Type.RValue = 0.39M;
            this.Measurements.Length = 3.16228M;
            this.Measurements.Area = 10M;
        }
    }
}

