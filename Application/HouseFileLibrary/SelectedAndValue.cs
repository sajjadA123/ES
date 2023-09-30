namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class SelectedAndValue
    {
        [XmlAttribute("selected")]
        public bool Selected;
        [XmlAttribute("value")]
        public decimal Value;
        [XmlText]
        public string Label;

        public SelectedAndValue()
        {
        }

        public SelectedAndValue(SelectedAndValue toCopy)
        {
            this.Selected = toCopy.Selected;
            this.Value = toCopy.Value;
            this.Label = toCopy.Label;
        }

        public SelectedAndValue(bool selected, decimal value)
        {
            this.Selected = selected;
            this.Value = value;
        }
    }
}

