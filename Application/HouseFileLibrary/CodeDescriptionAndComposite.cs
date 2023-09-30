namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent;
    using ca.nrcan.gc.OEE.HouseFileLibrary.HouseFileEvents;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Xml.Serialization;

    [Serializable]
    public class CodeDescriptionAndComposite : ISerializationEvents
    {
        [XmlElement("Description")]
        public string Description;
        [XmlArray("Composite"), XmlArrayItem("Section", typeof(RsiSection))]
        public List<RsiSection> Composite;
        [XmlAttribute("idref")]
        public string IdRef;
        [XmlAttribute("code")]
        public string Code;
        [XmlAttribute("nominalInsulation")]
        public decimal NominalInsulation;
        [XmlIgnore]
        public List<UserDefinedLayer> UserDefinedCodeLayers;

        public CodeDescriptionAndComposite()
        {
            this.Composite = new List<RsiSection>();
        }

        public CodeDescriptionAndComposite(CodeDescriptionAndComposite toCopy)
        {
            this.Composite = new List<RsiSection>();
            this.IdRef = toCopy.IdRef;
            this.Code = toCopy.Code;
            this.NominalInsulation = toCopy.NominalInsulation;
            this.Description = toCopy.Description;
            if ((toCopy.UserDefinedCodeLayers != null) && (toCopy.UserDefinedCodeLayers.Count > 0))
            {
                this.UserDefinedCodeLayers = new List<UserDefinedLayer>();
                foreach (UserDefinedLayer layer in toCopy.UserDefinedCodeLayers)
                {
                    this.UserDefinedCodeLayers.Add(layer.Clone());
                }
            }
        }

        public CodeDescriptionAndComposite(CodeReference toCopy)
        {
            this.Composite = new List<RsiSection>();
            this.IdRef = toCopy.IdRef;
            this.Code = toCopy.Code;
            this.NominalInsulation = toCopy.NominalInsulation;
            this.Description = toCopy.Text;
            if ((toCopy.UserDefinedCodeLayers != null) && (toCopy.UserDefinedCodeLayers.Count > 0))
            {
                this.UserDefinedCodeLayers = new List<UserDefinedLayer>();
                foreach (UserDefinedLayer layer in toCopy.UserDefinedCodeLayers)
                {
                    this.UserDefinedCodeLayers.Add(layer.Clone());
                }
            }
        }

        public void CalculateRemainder()
        {
            if (this.Composite.Count != 0)
            {
                decimal num = new decimal(100);
                foreach (RsiSection section in this.Composite)
                {
                    num -= section.Percentage;
                }
                if (num > 0M)
                {
                    this.Composite[this.Composite.Count - 1].Percentage = num;
                }
            }
        }

        public decimal EffectiveRsiValue(decimal coreRsiValue = 0M)
        {
            this.CalculateRemainder();
            decimal num = 0M;
            foreach (RsiSection section in this.Composite)
            {
                if ((section.Percentage > 0M) && ((section.Rsi + coreRsiValue) != 0M))
                {
                    num += section.Percentage / (section.Rsi + coreRsiValue);
                }
            }
            decimal num2 = (num == 0M) ? 0M : (100M / num);
            return ((num2 < coreRsiValue) ? 0M : (num2 - coreRsiValue));
        }

        public void OnDeserialization()
        {
            this.CalculateRemainder();
        }

        public void OnPostSerialization()
        {
        }

        public void OnPreSerialization()
        {
            this.CalculateRemainder();
        }

        public static implicit operator CodeDescriptionAndComposite(CodeReference toCopy) => 
            new CodeDescriptionAndComposite(toCopy);
    }
}

