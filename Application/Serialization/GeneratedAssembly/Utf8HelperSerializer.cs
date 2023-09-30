namespace Microsoft.Xml.Serialization.GeneratedAssembly
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;

    public sealed class Utf8HelperSerializer : XmlSerializer1
    {
        public override bool CanDeserialize(XmlReader xmlReader) => 
            xmlReader.IsStartElement("Utf8Helper", "");

        protected override object Deserialize(XmlSerializationReader reader) => 
            ((XmlSerializationReader1) reader).Read421_Utf8Helper();

        protected override void Serialize(object objectToSerialize, XmlSerializationWriter writer)
        {
            ((XmlSerializationWriter1) writer).Write421_Utf8Helper(objectToSerialize);
        }
    }
}

