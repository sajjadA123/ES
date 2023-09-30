namespace Microsoft.Xml.Serialization.GeneratedAssembly
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;

    public sealed class VentilationTypesSerializer : XmlSerializer1
    {
        public override bool CanDeserialize(XmlReader xmlReader) => 
            xmlReader.IsStartElement("VentilationTypes", "");

        protected override object Deserialize(XmlSerializationReader reader) => 
            ((XmlSerializationReader1) reader).Read483_VentilationTypes();

        protected override void Serialize(object objectToSerialize, XmlSerializationWriter writer)
        {
            ((XmlSerializationWriter1) writer).Write483_VentilationTypes(objectToSerialize);
        }
    }
}

