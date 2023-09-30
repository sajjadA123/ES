namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorHeaderComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.WallComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.WindowComponents;
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(FloorConstruction)), XmlInclude(typeof(FloorHeaderConstruction)), XmlInclude(typeof(WallConstruction)), XmlInclude(typeof(WindowConstruction)), XmlRoot("Construction")]
    public abstract class Construction
    {
        [XmlElement("Type")]
        public CodeReference Type;

        public Construction()
        {
            this.Type = new CodeReference();
        }

        public Construction(Construction toCopy)
        {
            this.Type = new CodeReference();
            this.Type = new CodeReference(toCopy.Type);
        }
    }
}

