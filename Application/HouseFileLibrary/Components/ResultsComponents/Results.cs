namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using Microsoft.Xml.Serialization.GeneratedAssembly;
    using System;
    using System.IO;
    using System.Xml.Serialization;

    [Serializable]
    public class Results
    {
        [XmlAttribute("houseCode")]
        public string HouseCode;
        [XmlIgnore]
        public ResultsType Type = ResultsType.Base;
        [XmlElement("Labels")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Labels Labels = new ca.nrcan.gc.OEE.HouseFileLibrary.Labels();
        [XmlElement("Annual")]
        public AnnualResults Annual = new AnnualResults();
        [XmlElement("Monthly")]
        public MonthlyResults Monthly = new MonthlyResults();
        [XmlElement("Other")]
        public OtherResults Other = new OtherResults();
        [XmlIgnore]
        public bool IsChecksumVerified;
        private static ResultsSerializer cachedSerializer;

        public Results Clone()
        {
            using (MemoryStream stream = new MemoryStream(0x400))
            {
                Serializer.Serialize((Stream) stream, this);
                stream.Position = 0L;
                return (Results) Serializer.Deserialize(stream);
            }
        }

        [XmlAttribute("type")]
        public string TypeXml
        {
            get => 
                (this.Type != ResultsType.Base) ? this.Type.Code : null;
            set
            {
                this.Type = ResultsType.FromCode(value);
                ResultsType type = this.Type;
            }
        }

        [XmlIgnore]
        public static ResultsSerializer Serializer
        {
            get
            {
                cachedSerializer = new ResultsSerializer();
                return cachedSerializer;
            }
        }
    }
}

