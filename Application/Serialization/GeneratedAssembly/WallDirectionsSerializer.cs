namespace Microsoft.Xml.Serialization.GeneratedAssembly
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;

    public sealed class WallDirectionsSerializer : XmlSerializer1
    {
        public override bool CanDeserialize(XmlReader xmlReader) => 
            xmlReader.IsStartElement("WallDirections", "");

        protected override object Deserialize(XmlSerializationReader reader) => 
            ((XmlSerializationReader1) reader).Read443_WallDirections();

        protected override void Serialize(object objectToSerialize, XmlSerializationWriter writer)
        {
            ((XmlSerializationWriter1) writer).Write443_WallDirections(objectToSerialize);
        }
    }
}

