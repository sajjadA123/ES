namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.DoorComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Door : Component
    {
        [XmlAttribute("adjacentEnclosedSpace")]
        public bool AdjacentEnclosedSpace;
        [XmlElement("Construction")]
        public DoorConstruction Construction;
        [XmlElement("Measurements")]
        public DoorMeasurements Measurements;

        public Door()
        {
            this.Construction = new DoorConstruction();
            this.Measurements = new DoorMeasurements();
            this.SetDefaults();
        }

        public Door(Door toCopy)
        {
            this.Construction = new DoorConstruction();
            this.Measurements = new DoorMeasurements();
            base.Id = toCopy.Id;
            base.Label = toCopy.Label;
            this.AdjacentEnclosedSpace = toCopy.AdjacentEnclosedSpace;
            this.Construction = new DoorConstruction(toCopy.Construction);
            this.Measurements = new DoorMeasurements(toCopy.Measurements);
        }

        public void SetDefaults()
        {
            base.Label = "Door";
            this.AdjacentEnclosedSpace = false;
            this.Construction.Type = DoorTypes.WoodHollowCore;
            this.Measurements.Width = 810M;
            this.Measurements.Height = 2070M;
        }

        [XmlAttribute("rValue")]
        public decimal RValue
        {
            get => 
                this.Construction.Type.Value;
            set
            {
            }
        }
    }
}

