namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using H2kXml.HouseFileLibrary;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Xml.Linq;

    [StructLayout(LayoutKind.Sequential)]
    public struct ProvinceOrTerritory
    {
        public static readonly ProvinceOrTerritory Alberta;
        public static readonly ProvinceOrTerritory BritishColumbia;
        public static readonly ProvinceOrTerritory Manitoba;
        public static readonly ProvinceOrTerritory NewBrunswick;
        public static readonly ProvinceOrTerritory NewfoundlandAndLabrador;
        public static readonly ProvinceOrTerritory NorthwestTerritories;
        public static readonly ProvinceOrTerritory NovaScotia;
        public static readonly ProvinceOrTerritory Nunavut;
        public static readonly ProvinceOrTerritory Ontario;
        public static readonly ProvinceOrTerritory PrinceEdwardIsland;
        public static readonly ProvinceOrTerritory Quebec;
        public static readonly ProvinceOrTerritory Saskatchewan;
        public static readonly ProvinceOrTerritory Yukon;
        private string code;
        private string english;
        private string french;
        public static List<ProvinceOrTerritory> All
        {
            get
            {
                List<ProvinceOrTerritory> list1 = new List<ProvinceOrTerritory>();
                list1.Add(Alberta);
                list1.Add(BritishColumbia);
                list1.Add(Manitoba);
                list1.Add(NewBrunswick);
                list1.Add(NewfoundlandAndLabrador);
                list1.Add(NorthwestTerritories);
                list1.Add(NovaScotia);
                list1.Add(Nunavut);
                list1.Add(Ontario);
                list1.Add(PrinceEdwardIsland);
                list1.Add(Quebec);
                list1.Add(Saskatchewan);
                list1.Add(Yukon);
                return list1;
            }
        }
        public static ProvinceOrTerritory FromXml(XElement province) => 
            ((province == null) || (province.Attribute("code") == null)) ? Ontario : GetByCode(province.Attribute("code").Value);

        public static ProvinceOrTerritory GetByCode(string code) => 
            (from p in All
                where string.Equals(p.code, code.Trim(), StringComparison.CurrentCultureIgnoreCase)
                select p).FirstOrDefault<ProvinceOrTerritory>();

        public static ProvinceOrTerritory GetByName(string name) => 
            (from p in All
                where string.Equals(p.english, name.Trim(), StringComparison.CurrentCultureIgnoreCase) || string.Equals(p.french, name.Trim(), StringComparison.CurrentCultureIgnoreCase)
                select p).FirstOrDefault<ProvinceOrTerritory>();

        public static bool operator ==(ProvinceOrTerritory x, ProvinceOrTerritory y) => 
            x.code == y.code;

        public static bool operator !=(ProvinceOrTerritory x, ProvinceOrTerritory y) => 
            x.code != y.code;

        public static implicit operator string(ProvinceOrTerritory prov) => 
            prov.code;

        public override bool Equals(object o)
        {
            if (o == null)
            {
                return false;
            }
            try
            {
                return (this == ((ProvinceOrTerritory) o));
            }
            catch
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            string code = this.code;
            uint num = PrivateImplementationDetails.ComputeStringHash(code);
            if (num <= 0x2c0000fe)
            {
                if (num <= 0x27114240)
                {
                    if (num == 0x1ddd58b2)
                    {
                        if (code == "BC")
                        {
                            return 1;
                        }
                    }
                    else if (num != 0x25e65fa6)
                    {
                        if ((num == 0x27114240) && (code == "YT"))
                        {
                            return 12;
                        }
                    }
                    else if (code == "NS")
                    {
                        return 7;
                    }
                }
                else if (num == 0x27e662cc)
                {
                    if (code == "NU")
                    {
                        return 8;
                    }
                }
                else if (num != 0x28e6645f)
                {
                    if ((num == 0x2c0000fe) && (code == "PE"))
                    {
                        return 9;
                    }
                }
                else if (code == "NT")
                {
                    return 6;
                }
            }
            else if (num <= 0x40e68a27)
            {
                if (num == 0x2cd5218a)
                {
                    if (code == "AB")
                    {
                        return 0;
                    }
                }
                else if (num != 0x36e67a69)
                {
                    if ((num == 0x40e68a27) && (code == "NL"))
                    {
                        return 5;
                    }
                }
                else if (code == "NB")
                {
                    return 3;
                }
            }
            else if (num == 0x44dfd4ae)
            {
                if (code == "MB")
                {
                    return 2;
                }
            }
            else if (num != 0x5e028e4b)
            {
                if ((num == 0x8dfcc9ad) && (code == "QC"))
                {
                    return 10;
                }
            }
            else if (code == "SK")
            {
                return 11;
            }
            return 4;
        }

        public static bool IsValidCode(string code) => 
            (code != null) ? ((from p in All
                where p.Code == code
                select p).FirstOrDefault<ProvinceOrTerritory>().Code != null) : false;

        public static bool IsValidName(string name) => 
            (name != null) ? ((from p in All
                where string.Equals(p.english, name.Trim(), StringComparison.CurrentCultureIgnoreCase) || string.Equals(p.french, name.Trim(), StringComparison.CurrentCultureIgnoreCase)
                select p).FirstOrDefault<ProvinceOrTerritory>().Code != null) : false;

        public XElement Xml
        {
            get
            {
                object[] content = new object[] { new XAttribute("code", this.code), new XElement("English", new XText(this.english)), new XElement("French", new XText(this.french)) };
                return new XElement("Province", content);
            }
            set
            {
                ProvinceOrTerritory territory = FromXml(value);
                this.code = territory.code;
                this.english = territory.english;
                this.french = territory.french;
            }
        }
        public string Code =>
            this.code;
        public string English =>
            this.english;
        public string French =>
            this.french;
        private ProvinceOrTerritory(string code, string englishName, string frenchName)
        {
            this.code = code;
            this.english = englishName;
            this.french = frenchName;
        }

        private ProvinceOrTerritory(string code, string name)
        {
            this.code = code;
            this.english = name;
            this.french = name;
        }

        static ProvinceOrTerritory()
        {
            Alberta = new ProvinceOrTerritory("AB", "Alberta");
            BritishColumbia = new ProvinceOrTerritory("BC", "British Columbia", "Colombie-Britannique");
            Manitoba = new ProvinceOrTerritory("MB", "Manitoba");
            NewBrunswick = new ProvinceOrTerritory("NB", "New Brunswick", "Nouveau-Brunswick");
            NewfoundlandAndLabrador = new ProvinceOrTerritory("NL", "Newfoundland and Labrador", "Terre-Neuve-et-Labrador");
            NorthwestTerritories = new ProvinceOrTerritory("NT", "Northwest Territories", "Territoires du Nord-Ouest");
            NovaScotia = new ProvinceOrTerritory("NS", "Nova Scotia", "Nouvelle-\x00c9cosse");
            Nunavut = new ProvinceOrTerritory("NU", "Nunavut");
            Ontario = new ProvinceOrTerritory("ON", "Ontario");
            PrinceEdwardIsland = new ProvinceOrTerritory("PE", "Prince Edward Island", "\x00cele-du-Prince-\x00c9douard");
            Quebec = new ProvinceOrTerritory("QC", "Quebec", "Qu\x00e9bec");
            Saskatchewan = new ProvinceOrTerritory("SK", "Saskatchewan");
            Yukon = new ProvinceOrTerritory("YT", "Yukon", "Yukon");
        }
    }
}

