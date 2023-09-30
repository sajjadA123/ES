namespace Microsoft.Xml.Serialization.GeneratedAssembly
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;

    public sealed class MainFloorsFactorsSerializer : XmlSerializer1
    {
        public override bool CanDeserialize(XmlReader xmlReader) => 
            xmlReader.IsStartElement("MainFloorsFactors", "");

        protected override object Deserialize(XmlSerializationReader reader) => 
            ((XmlSerializationReader1) reader).Read612_MainFloorsFactors();

        protected override void Serialize(object objectToSerialize, XmlSerializationWriter writer)
        {
            ((XmlSerializationWriter1) writer).Write612_MainFloorsFactors(objectToSerialize);
        }
    }
}

