namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Xml.Serialization;

    [Serializable]
    public class CodeReference
    {
        [XmlAttribute("idref")]
        public string IdRef;
        [XmlAttribute("code")]
        public string Code;
        [XmlAttribute("rValue")]
        public decimal RValue;
        [XmlAttribute("nominalInsulation")]
        public decimal NominalInsulation;
        [XmlIgnore]
        public string Text;
        [XmlIgnore]
        public List<UserDefinedLayer> UserDefinedCodeLayers;

        public CodeReference()
        {
        }

        public CodeReference(CodeDescriptionAndComposite toCopy)
        {
            this.IdRef = toCopy.IdRef;
            this.Code = toCopy.Code;
            this.RValue = 0M;
            this.NominalInsulation = toCopy.NominalInsulation;
            this.Text = toCopy.Description;
            if ((toCopy.UserDefinedCodeLayers != null) && (toCopy.UserDefinedCodeLayers.Count > 0))
            {
                this.UserDefinedCodeLayers = new List<UserDefinedLayer>();
                foreach (UserDefinedLayer layer in toCopy.UserDefinedCodeLayers)
                {
                    this.UserDefinedCodeLayers.Add(layer.Clone());
                }
            }
        }

        public CodeReference(CodeReference toCopy)
        {
            this.IdRef = toCopy.IdRef;
            this.Code = toCopy.Code;
            this.RValue = toCopy.RValue;
            this.NominalInsulation = toCopy.NominalInsulation;
            this.Text = toCopy.Text;
            if ((toCopy.UserDefinedCodeLayers != null) && (toCopy.UserDefinedCodeLayers.Count > 0))
            {
                this.UserDefinedCodeLayers = new List<UserDefinedLayer>();
                foreach (UserDefinedLayer layer in toCopy.UserDefinedCodeLayers)
                {
                    this.UserDefinedCodeLayers.Add(layer.Clone());
                }
            }
        }

        public CodeReference(string Code, string Text, decimal RValue = 0M, decimal NominalInsulation = 0M)
        {
            this.Code = Code;
            this.Text = Text;
            this.RValue = RValue;
            this.NominalInsulation = NominalInsulation;
        }

        [XmlText]
        public string[] TextHelper
        {
            get => 
                new string[] { this.Text };
            set
            {
                this.Text = null;
                if ((value != null) && (value.Length != 0))
                {
                    this.Text = value[0];
                }
            }
        }
    }
}

