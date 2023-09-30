namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using Microsoft.Xml.Serialization.GeneratedAssembly;
    using System;
    using System.IO;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(ContinuousInsulation)), XmlInclude(typeof(ContinuousMedium)), XmlInclude(typeof(UserDefinedComponent)), XmlInclude(typeof(LintelUserDefined)), XmlInclude(typeof(SteelFramingLayer)), XmlInclude(typeof(StrappingLayer)), XmlInclude(typeof(UserDefinedBaseComponent)), XmlInclude(typeof(WindowUserDefined)), XmlInclude(typeof(WindowLegacy)), XmlInclude(typeof(WoodFramingLayer))]
    public class UserDefinedLayer
    {
        [XmlAttribute("rank")]
        public uint Rank;
        private static UserDefinedLayerSerializer cachedSerializer;

        public UserDefinedLayer Clone()
        {
            using (MemoryStream stream = new MemoryStream(0x400))
            {
                Serializer.Serialize((Stream) stream, this);
                stream.Position = 0L;
                return (UserDefinedLayer) Serializer.Deserialize(stream);
            }
        }

        [XmlIgnore]
        public static UserDefinedLayerSerializer Serializer
        {
            get
            {
                cachedSerializer = new UserDefinedLayerSerializer();
                return cachedSerializer;
            }
        }
    }
}

