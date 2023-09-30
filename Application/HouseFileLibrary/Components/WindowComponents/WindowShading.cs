namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.WindowComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class WindowShading
    {
        [XmlAttribute("curtain")]
        public decimal Curtain;
        [XmlAttribute("shutterRValue")]
        public decimal ShutterRValue;

        public WindowShading()
        {
            this.Curtain = 1M;
        }

        public WindowShading(decimal curtain, decimal shutterRValue)
        {
            this.Curtain = 1M;
            this.Curtain = curtain;
            this.ShutterRValue = shutterRValue;
        }
    }
}

