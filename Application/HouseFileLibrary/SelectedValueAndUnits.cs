namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Runtime.InteropServices;
    using System.Xml.Serialization;

    [Serializable]
    public class SelectedValueAndUnits
    {
        [XmlAttribute("selected")]
        public bool Selected;
        [XmlAttribute("value")]
        public decimal Value;
        [XmlAttribute("uiUnits")]
        public string UiUnits;
        [XmlText]
        public string Label;

        public SelectedValueAndUnits()
        {
            this.UiUnits = string.Empty;
        }

        public SelectedValueAndUnits(bool selected, decimal value, string uiUnits = "", string label = "")
        {
            this.UiUnits = string.Empty;
            this.Selected = selected;
            this.Value = value;
            this.UiUnits = uiUnits;
            this.Label = label;
        }
    }
}

