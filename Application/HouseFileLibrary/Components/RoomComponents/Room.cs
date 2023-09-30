namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.RoomComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Room : Component
    {
        [XmlElement("Construction")]
        public RoomConstruction Construction = new RoomConstruction();
        [XmlElement("Measurements")]
        public RoomMeasurements Measurements = new RoomMeasurements();
    }
}

