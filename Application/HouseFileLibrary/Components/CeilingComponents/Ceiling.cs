namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.CeilingComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Ceiling : Component
    {
        [XmlElement("Construction")]
        public CeilingConstruction Construction;
        [XmlElement("Measurements")]
        public CeilingMeasurements Measurements;

        public Ceiling()
        {
            this.Construction = new CeilingConstruction();
            this.Measurements = new CeilingMeasurements();
            this.SetDefaults();
        }

        public Ceiling(Ceiling toCopy)
        {
            this.Construction = new CeilingConstruction();
            this.Measurements = new CeilingMeasurements();
            base.Id = toCopy.Id;
            base.Label = toCopy.Label;
            this.Construction = new CeilingConstruction(toCopy.Construction);
            this.Measurements = new CeilingMeasurements(toCopy.Measurements);
        }

        public void SetDefaults()
        {
            base.Label = "Ceiling";
            this.Construction.Type = CeilingTypes.AtticGable;
            this.Construction.CeilingType = new CodeReference("2200000000", "2200000000", 0.22M, 0M);
            this.Measurements.Length = 3.16M;
            this.Measurements.Area = 10M;
            this.Measurements.Slope = CeilingSlopes.Slope4Twelfth;
            this.Measurements.HeelHeight = 0.13M;
        }
    }
}

