namespace Microsoft.Xml.Serialization.GeneratedAssembly
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;

    public sealed class CoolingFansAndPumpsSerializer : XmlSerializer1
    {
        public override bool CanDeserialize(XmlReader xmlReader) => 
            xmlReader.IsStartElement("CoolingFansAndPumps", "");

        protected override object Deserialize(XmlSerializationReader reader) => 
            ((XmlSerializationReader1) reader).Read679_CoolingFansAndPumps();

        protected override void Serialize(object objectToSerialize, XmlSerializationWriter writer)
        {
            ((XmlSerializationWriter1) writer).Write679_CoolingFansAndPumps(objectToSerialize);
        }
    }
}

