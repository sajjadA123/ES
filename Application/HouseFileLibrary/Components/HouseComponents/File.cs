namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class File
    {
        [XmlAttribute("evaluationDate", DataType="date")]
        public DateTime EvaluationDate;
        [XmlElement("Identification")]
        public string Identification;
        [XmlElement("PreviousFileId")]
        public string PreviousFileId;
        [XmlElement("EnrollmentId")]
        public string EnrollmentId;
        private HouseOwnerships Ownership_ = HouseOwnerships.DwellingPrivate;
        [XmlElement("TaxNumber")]
        public string TaxNumber;
        [XmlElement("EnteredBy")]
        public string EnteredBy;
        [XmlElement("UserTelephone")]
        public string UserTelephone;
        [XmlElement("UserExtension")]
        public string UserExtension;
        [XmlElement("CompanyTelephone")]
        public string CompanyTelephone;
        [XmlElement("CompanyExtension")]
        public string CompanyExtension;
        [XmlElement("Company")]
        public string Company;
        [XmlElement("BuilderName")]
        public string BuilderName;
        [XmlElement("HomeownerAuthorizationId")]
        public string HomeownerAuthorizationId;

        [XmlElement("Ownership")]
        public CodeAndText OwnershipXml
        {
            get => 
                (CodeAndText) this.Ownership;
            set
            {
                if (value == null)
                {
                    this.Ownership = null;
                }
                else
                {
                    this.Ownership = (from dt in HouseOwnerships.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<HouseOwnerships>();
                }
            }
        }

        [XmlIgnore]
        public HouseOwnerships Ownership
        {
            get => 
                this.Ownership_;
            set
            {
                if (value == null)
                {
                    this.Ownership_ = HouseOwnerships.DwellingPrivate;
                }
                else
                {
                    this.Ownership_ = value;
                }
            }
        }
    }
}

