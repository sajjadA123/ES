namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class CopSeerValue
    {
        [XmlAttribute("isCop")]
        public bool IsCop;
        [XmlAttribute("value")]
        public decimal Value;

        public CopSeerValue()
        {
        }

        public CopSeerValue(bool isCop, decimal newValue)
        {
            this.Set(isCop, newValue);
        }

        public void Set(bool isCop, decimal newValue)
        {
            this.IsCop = isCop;
            this.Value = newValue;
        }
    }
}

