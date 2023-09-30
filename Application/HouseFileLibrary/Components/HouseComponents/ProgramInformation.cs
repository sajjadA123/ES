namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using Microsoft.Xml.Serialization.GeneratedAssembly;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Serialization;

    [Serializable]
    public class ProgramInformation
    {
        [XmlAttribute("mixed")]
        public bool Mixed;
        [XmlElement("Weather")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.Weather Weather = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.Weather();
        [XmlElement("File")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.File File = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.File();
        [XmlElement("Client")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.Client Client = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.Client();
        [XmlElement("Justifications")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.Justifications Justifications = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.Justifications();
        [XmlArrayItem("Info", typeof(CodeAndText)), XmlArray("Information")]
        public List<CodeAndText> Information;
        private static ProgramInformationSerializer cachedSerializer;

        public ProgramInformation Clone()
        {
            using (MemoryStream stream = new MemoryStream(0x400))
            {
                Serializer.Serialize((Stream) stream, this);
                stream.Position = 0L;
                return (ProgramInformation) Serializer.Deserialize(stream);
            }
        }

        [XmlIgnore]
        public static ProgramInformationSerializer Serializer
        {
            get
            {
                cachedSerializer = new ProgramInformationSerializer();
                return cachedSerializer;
            }
        }
    }
}

