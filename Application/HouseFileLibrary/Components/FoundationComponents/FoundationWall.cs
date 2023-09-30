namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.HouseFileEvents;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class FoundationWall : ISerializationEvents
    {
        [XmlAttribute("hasPonyWall")]
        public bool HasPonyWall;
        [XmlElement("Construction")]
        public FoundationWallConstruction Construction = new FoundationWallConstruction();
        [XmlElement("Measurements")]
        public FoundationWallMeasurements Measurements;

        public void OnDeserialization()
        {
            this.Construction.OnDeserialization();
        }

        public void OnPostSerialization()
        {
        }

        public void OnPreSerialization()
        {
            this.Construction.OnPreSerialization();
        }
    }
}

