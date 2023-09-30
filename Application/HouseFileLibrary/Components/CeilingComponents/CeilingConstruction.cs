namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.CeilingComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class CeilingConstruction
    {
        private CeilingTypes Type_;
        [XmlElement("CeilingType")]
        public CodeReference CeilingType;

        public CeilingConstruction()
        {
            this.Type_ = CeilingTypes.AtticGable;
            this.CeilingType = new CodeReference();
        }

        public CeilingConstruction(CeilingConstruction toCopy)
        {
            this.Type_ = CeilingTypes.AtticGable;
            this.CeilingType = new CodeReference();
            this.Type = toCopy.Type;
            this.CeilingType = new CodeReference(toCopy.CeilingType);
        }

        [XmlElement("Type")]
        public CodeAndText TypeXml
        {
            get => 
                (CodeAndText) this.Type;
            set
            {
                if (value == null)
                {
                    this.Type = null;
                }
                else
                {
                    this.Type = (from dt in CeilingTypes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<CeilingTypes>();
                }
            }
        }

        [XmlIgnore]
        public CeilingTypes Type
        {
            get => 
                this.Type_;
            set
            {
                if (value == null)
                {
                    this.Type_ = CeilingTypes.AtticGable;
                }
                else
                {
                    this.Type_ = value;
                }
            }
        }
    }
}

