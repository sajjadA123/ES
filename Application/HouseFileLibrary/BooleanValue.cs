namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Xml.Serialization;

    public class BooleanValue
    {
        [XmlAttribute("value")]
        public bool Value;

        public BooleanValue()
        {
            this.Value = false;
        }

        public BooleanValue(bool initialValue)
        {
            this.Value = initialValue;
        }
    }
}

