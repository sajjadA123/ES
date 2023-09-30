namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Labels
    {
        [XmlElement("English")]
        public string English;
        [XmlElement("French")]
        public string French;

        public Labels()
        {
        }

        public Labels(Labels toCopy)
        {
            this.English = toCopy.English;
            this.French = toCopy.French;
        }

        public Labels(string english, string french)
        {
            this.English = english;
            this.French = french;
        }

        public override bool Equals(object obj)
        {
            Labels labels = obj as Labels;
            return (!ReferenceEquals(labels , null) ? (base.Equals(obj) && (this == labels)) : false);
        }

        public override int GetHashCode() => 
            (this.English + this.French).GetHashCode();

        public static bool operator ==(Labels a, Labels b) => 
            (ReferenceEquals(a , null) || ReferenceEquals(b , null)) ? ReferenceEquals(a, b) : ((a.English == b.English) && (a.French == b.French));

        public static bool operator !=(Labels a, Labels b) => 
            !(a == b);
    }
}

