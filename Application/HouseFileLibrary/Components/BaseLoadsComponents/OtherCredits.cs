namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class OtherCredits
    {
        [XmlElement("OtherCredit1")]
        public SelectedValueAndUnits OtherCredit1 = new SelectedValueAndUnits();
        [XmlElement("OtherCredit2")]
        public SelectedValueAndUnits OtherCredit2 = new SelectedValueAndUnits();
    }
}

