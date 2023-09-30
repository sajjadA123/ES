namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents
{
    using System;
    using System.Xml.Linq;

    public class ExhaustLocationOptions
    {
        public static readonly ExhaustLocationOptions Indoors = new ExhaustLocationOptions(3, "Vented indoors", "\x00c9vacuation int\x00e9rieure");
        public static readonly ExhaustLocationOptions Outdoors = new ExhaustLocationOptions(1, "Vented outdoors", "\x00c9vacuation ext\x00e9rieure");
        private string englishText;
        private string frenchText;
        private ushort code;

        private ExhaustLocationOptions()
        {
        }

        private ExhaustLocationOptions(ushort code, string english, string french)
        {
            this.code = code;
            this.englishText = english;
            this.frenchText = french;
        }

        public override bool Equals(object o)
        {
            try
            {
                return (this == ((ExhaustLocationOptions) o));
            }
            catch
            {
                return false;
            }
        }

        public static ExhaustLocationOptions FromXml(XElement exhaust) => 
            ((exhaust == null) || (exhaust.Attribute("code") == null)) ? Default : GetByCode(exhaust.Attribute("code").Value);

        public static ExhaustLocationOptions GetByCode(string code)
        {
            ushort result = 0;
            return (!ushort.TryParse(code, out result) ? Default : GetByCode(result));
        }

        public static ExhaustLocationOptions GetByCode(ushort code) => 
            (code != Indoors) ? Default : Indoors;

        public override int GetHashCode() => 
            this.code;

        public static bool operator ==(ExhaustLocationOptions x, ExhaustLocationOptions y) => 
            x.code == y.code;

        public static implicit operator ushort(ExhaustLocationOptions location) => 
            location.code;

        public static bool operator !=(ExhaustLocationOptions x, ExhaustLocationOptions y) => 
            x.code != y.code;

        public static ExhaustLocationOptions Default =>
            Outdoors;

        public ushort Code =>
            this.code;

        public string English =>
            this.englishText;

        public string French =>
            this.frenchText;

        public XElement Xml
        {
            get
            {
                object[] content = new object[] { new XAttribute("code", this.code), new XElement("English", new XText(this.englishText)), new XElement("French", new XText(this.frenchText)) };
                return new XElement("Exhaust", content);
            }
            set
            {
                ExhaustLocationOptions options = FromXml(value);
                this.code = options.code;
                this.englishText = options.englishText;
                this.frenchText = options.englishText;
            }
        }
    }
}

