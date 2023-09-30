namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    public class Dryer : VentilatorObjects
    {
        [XmlIgnore]
        public ExhaustLocationOptions Exhaust = ExhaustLocationOptions.Default;

        [XmlElement("Exhaust")]
        public CodeAndText ExhaustXml
        {
            get => 
                new CodeAndText(this.Exhaust.Code.ToString(), this.Exhaust.English, this.Exhaust.French);
            set => 
                this.Exhaust = ExhaustLocationOptions.GetByCode(value.Code);
        }
    }
}

