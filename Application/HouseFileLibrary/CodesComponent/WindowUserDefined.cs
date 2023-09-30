namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Runtime.InteropServices;
    using System.Xml.Serialization;

    [Serializable]
    public class WindowUserDefined : UserDefinedLayer
    {
        [XmlAttribute("frameHeight")]
        public decimal FrameHeight;
        [XmlAttribute("shgc")]
        public decimal Shgc;
        [XmlElement("GlazingType")]
        public CodeAndText GlazingType;
        [XmlElement("OverallThermalResistance")]
        public CodeTextAndValue OverallThermalResistance;
        [XmlElement("WindowStyle")]
        public CodeAndText WindowStyle;
        [XmlElement("FillGas")]
        public CodeAndText FillGas;
        [XmlElement("LowECoating")]
        public CodeAndText LowECoating;

        public WindowUserDefined()
        {
            this.GlazingType = new CodeAndText("1", "Single (SG)", "Single (SG)");
            this.OverallThermalResistance = new CodeTextAndValue("1", "RSI/R-Value", "RSI/R-Value", 0M);
            this.WindowStyle = new CodeAndText("1", "Awning", "Awning");
            this.FillGas = new CodeAndText("1", "Air", "Air");
            this.LowECoating = new CodeAndText("1", "Clear", "Clear");
        }

        public WindowUserDefined(uint rank, decimal overallThermalResistance, decimal frameHeight, decimal shgc, bool isUValue = false)
        {
            this.GlazingType = new CodeAndText("1", "Single (SG)", "Single (SG)");
            this.OverallThermalResistance = new CodeTextAndValue("1", "RSI/R-Value", "RSI/R-Value", 0M);
            this.WindowStyle = new CodeAndText("1", "Awning", "Awning");
            this.FillGas = new CodeAndText("1", "Air", "Air");
            this.LowECoating = new CodeAndText("1", "Clear", "Clear");
            base.Rank = rank;
            this.FrameHeight = frameHeight;
            this.Shgc = shgc;
            this.OverallThermalResistance.Value = overallThermalResistance;
            if (isUValue)
            {
                this.OverallThermalResistance.Code = "2";
                this.OverallThermalResistance.EnglishText = "U-Value";
                this.OverallThermalResistance.FrenchText = "U-Value";
            }
            else
            {
                this.OverallThermalResistance.Code = "1";
                this.OverallThermalResistance.EnglishText = "RSI/R-Value";
                this.OverallThermalResistance.FrenchText = "RSI/R-Value";
            }
        }
    }
}

