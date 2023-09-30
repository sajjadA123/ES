namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.HouseFileEvents;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class FoundationWallConstruction : ISerializationEvents
    {
        [XmlAttribute("corners")]
        public ushort Corners;
        [XmlElement("InteriorAddedInsulation")]
        public CodeDescriptionAndComposite InteriorAddedInsulation = new CodeDescriptionAndComposite();
        [XmlElement("ExteriorAddedInsulation")]
        public CodeDescriptionAndComposite ExteriorAddedInsulation = new CodeDescriptionAndComposite();
        [XmlElement("Lintels")]
        public CodeReference Lintels;
        [XmlElement("PonyWallType")]
        public CodeDescriptionAndComposite PonyWallType;

        public void OnDeserialization()
        {
            if (this.InteriorAddedInsulation != null)
            {
                this.InteriorAddedInsulation.OnDeserialization();
            }
            if (this.ExteriorAddedInsulation != null)
            {
                this.ExteriorAddedInsulation.OnDeserialization();
            }
            if (this.PonyWallType != null)
            {
                this.PonyWallType.OnDeserialization();
            }
        }

        public void OnPostSerialization()
        {
            if (this.InteriorAddedInsulation != null)
            {
                this.InteriorAddedInsulation.OnPostSerialization();
            }
            if (this.ExteriorAddedInsulation != null)
            {
                this.ExteriorAddedInsulation.OnPostSerialization();
            }
            if (this.PonyWallType != null)
            {
                this.PonyWallType.OnPostSerialization();
            }
        }

        public void OnPreSerialization()
        {
            if (this.InteriorAddedInsulation != null)
            {
                this.InteriorAddedInsulation.OnPreSerialization();
            }
            if (this.ExteriorAddedInsulation != null)
            {
                this.ExteriorAddedInsulation.OnPreSerialization();
            }
            if (this.PonyWallType != null)
            {
                this.PonyWallType.OnPreSerialization();
            }
        }
    }
}

