namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using ca.nrcan.gc.OEE.HouseFileLibrary.HouseFileEvents;
    using Microsoft.Xml.Serialization.GeneratedAssembly;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class House : BaseComponent
    {
        [XmlAttribute("code")]
        public string Code;
        [XmlElement("Labels")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Labels Labels = new Labels();
        [XmlElement("Specifications")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.Specifications Specifications = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.Specifications();
        private WindowAirTightness WindowTightness_ = WindowAirTightness.CsaA1;
        [XmlElement("BaseLoads")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.BaseLoads BaseLoads = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.BaseLoads();
        [XmlElement("Generation")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents.Generation Generation = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents.Generation();
        [XmlElement("HeatingCooling")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.HeatingCooling HeatingCooling = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.HeatingCooling();
        [XmlArray("FoundationAttachments"), XmlArrayItem("Attachment", typeof(Attachment))]
        public List<Attachment> FoundationAttachments;
        [XmlElement("NaturalAirInfiltration")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.NaturalAirInfiltration NaturalAirInfiltration = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.NaturalAirInfiltration();
        [XmlElement("Temperatures")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.Temperatures Temperatures = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.Temperatures();
        [XmlElement("Ventilation")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents.Ventilation Ventilation;
        private static HouseSerializer cachedSerializer;

        public House()
        {
            this.SetDefaults();
        }

        public House Clone()
        {
            using (MemoryStream stream = new MemoryStream(0x400))
            {
                Serializer.Serialize((Stream) stream, this);
                stream.Position = 0L;
                return (House) Serializer.Deserialize(stream);
            }
        }

        public void SetDefaults()
        {
            this.Id = 0;
            this.Labels.English = "House";
            this.Labels.French = "Maison";
        }



        [XmlAttribute("id")]
        public uint Id
        {
            get => 
                0;
            set
            {
            }
        }

        [XmlElement("WindowTightness")]
        public CodeTextAndValue WindowTightnessXml
        {
            get => 
                (CodeTextAndValue) this.WindowTightness;
            set
            {
                if (value == null)
                {
                    this.WindowTightness = null;
                }
                else
                {
                    this.WindowTightness = (from dt in WindowAirTightness.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<WindowAirTightness>();
                    if (this.WindowTightness.IsUserSpecified)
                    {
                        this.WindowTightness.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public WindowAirTightness WindowTightness
        {
            get => 
                this.WindowTightness_;
            set
            {
                if (value == null)
                {
                    this.WindowTightness_ = WindowAirTightness.CsaA1;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.WindowTightness_ = value;
                }
                else
                {
                    this.WindowTightness_ = (from us in WindowAirTightness.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<WindowAirTightness>();
                    this.WindowTightness_.Value = value.Value;
                }
            }
        }

        [XmlIgnore]
        public static HouseSerializer Serializer
        {
            get
            {
                cachedSerializer = new HouseSerializer();
                return cachedSerializer;
            }
        }
    }
}

