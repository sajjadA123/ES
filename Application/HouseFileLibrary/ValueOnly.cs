namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Xml.Serialization;

    public class ValueOnly
    {
        [XmlAttribute("value")]
        public decimal Value;

        public ValueOnly()
        {
            this.Value = 0.0M;
        }

        public ValueOnly(decimal initialValue)
        {
            this.Value = initialValue;
        }
    }
}

