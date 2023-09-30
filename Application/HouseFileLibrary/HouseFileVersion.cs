namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlRoot("Version")]
    public class HouseFileVersion : IComparable
    {
        private bool hasBuild;
        private ca.nrcan.gc.OEE.HouseFileLibrary.Labels labels;
        private uint major;
        private uint minor;
        private uint build;

        public HouseFileVersion()
        {
            this.labels = new ca.nrcan.gc.OEE.HouseFileLibrary.Labels(string.Empty, string.Empty);
            this.SetDefaults();
        }

        public HouseFileVersion(HouseFileVersion source)
        {
            this.labels = new ca.nrcan.gc.OEE.HouseFileLibrary.Labels(string.Empty, string.Empty);
            this.Set(source.major, source.minor, source.build, source.labels.English, source.labels.French);
        }

        public HouseFileVersion(Version version)
        {
            this.labels = new ca.nrcan.gc.OEE.HouseFileLibrary.Labels(string.Empty, string.Empty);
            this.SetDefaults();
            this.Major = (uint) version.Major;
            this.Minor = (uint) version.Minor;
            if (version.Build > 0)
            {
                this.Build = (uint) version.Build;
                this.hasBuild = true;
            }
        }

        public HouseFileVersion(uint major, uint minor)
        {
            this.labels = new ca.nrcan.gc.OEE.HouseFileLibrary.Labels(string.Empty, string.Empty);
            this.SetDefaults();
            this.Set(major, minor);
        }

        public HouseFileVersion(uint major, uint minor, uint build)
        {
            this.labels = new ca.nrcan.gc.OEE.HouseFileLibrary.Labels(string.Empty, string.Empty);
            this.SetDefaults();
            this.Set(major, minor, build);
        }

        public HouseFileVersion(uint major, uint minor, uint build, string englishLabel, string frenchLabel)
        {
            this.labels = new ca.nrcan.gc.OEE.HouseFileLibrary.Labels(string.Empty, string.Empty);
            this.SetDefaults();
            this.Set(major, minor, build, englishLabel, frenchLabel);
        }

        private void ClearBuildStringLabels()
        {
            string text = this.Text;
            if (this.Labels.English == text)
            {
                this.Labels.English = string.Empty;
            }
            if (this.Labels.French == text)
            {
                this.Labels.French = string.Empty;
            }
        }

        public int CompareTo(object obj)
        {
            if (!(obj is HouseFileVersion))
            {
                throw new ArgumentException("object is not a HouseFileVersion");
            }
            HouseFileVersion version = (HouseFileVersion) obj;
            return ((this >= version) ? ((this <= version) ? 0 : 1) : -1);
        }

        public bool Equals(HouseFileVersion v) => 
            base.Equals(v) && (this == v);

        public override bool Equals(object obj)
        {
            HouseFileVersion version = obj as HouseFileVersion;
            return ((version != null) ? (base.Equals(obj) && (this == version)) : false);
        }

        public override int GetHashCode() => 
            this.Text.GetHashCode();

        public static bool operator ==(HouseFileVersion a, HouseFileVersion b) => 
            !(a != b);

        public static bool operator >(HouseFileVersion a, HouseFileVersion b)
        {
            if (!ReferenceEquals(a , null) && ReferenceEquals(b , null))
            {
                return true;
            }
            if (!ReferenceEquals(a , null) || ReferenceEquals(b , null))
            {
                if (ReferenceEquals(a , null) && ReferenceEquals(b , null))
                {
                    return false;
                }
                if (a.Major != b.Major)
                {
                    return (a.Major > b.Major);
                }
                if (a.Minor != b.Minor)
                {
                    return (a.Minor > b.Minor);
                }
                if (a.hasBuild && (b.hasBuild && (a.Build != b.Build)))
                {
                    return (a.Build > b.Build);
                }
                if (a.hasBuild && !b.hasBuild)
                {
                    return true;
                }
                if (a.hasBuild)
                {
                    return false;
                }
                bool hasBuild = b.hasBuild;
            }
            return false;
        }

        public static bool operator >=(HouseFileVersion a, HouseFileVersion b) => 
            a >= b;

        public static bool operator !=(HouseFileVersion a, HouseFileVersion b)
        {
               return  (a < b) || (a > b);
        }
           

        public static bool operator <(HouseFileVersion a, HouseFileVersion b)
        {
            if (ReferenceEquals(a ,null) && !ReferenceEquals (b , null))
            {
                return true;
            }
            if (!ReferenceEquals(a , null) && ReferenceEquals(b , null))
            {
                return false;
            }
            if (ReferenceEquals(a , null) && ReferenceEquals(b , null))
            {
                return false;
            }
            if (a.Major != b.Major)
            {
                return (a.Major < b.Major);
            }
            if (a.Minor != b.Minor)
            {
                return (a.Minor < b.Minor);
            }
            if (a.hasBuild && (b.hasBuild && (a.Build != b.Build)))
            {
                return (a.Build < b.Build);
            }
            if (a.hasBuild && !b.hasBuild)
            {
                return false;
            }
            if (!a.hasBuild && b.hasBuild)
            {
                return true;
            }
            if (!(a.Labels != b.Labels))
            {
                return false;
            }
            string str = a.Labels.English.Trim();
            string str2 = a.Labels.French.Trim();
            string text = a.Text;
            bool flag = ((str.Length <= 0) || (str == text)) ? ((str2.Length > 0) && (str2 != text)) : true;
            str = b.Labels.English.Trim();
            str2 = b.Labels.French.Trim();
            text = b.Text;
            bool flag2 = ((str.Length <= 0) || (str == text)) ? ((str2.Length > 0) && (str2 != text)) : true;
            return ((!flag || flag2) ? (!flag & flag2) : false);
        }

        public static bool operator <=(HouseFileVersion a, HouseFileVersion b) => 
            a <= b;

        public void Set(uint major, uint minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public void Set(uint major, uint minor, uint build)
        {
            this.Major = major;
            this.Minor = minor;
            this.Build = build;
            this.hasBuild = true;
        }

        public void Set(uint major, uint minor, uint build, string englishLabel, string frenchLabel)
        {
            this.Major = major;
            this.Minor = minor;
            this.Build = build;
            this.hasBuild = true;
            this.labels.English = englishLabel;
            this.labels.French = frenchLabel;
        }

        public void SetDefaults()
        {
            this.labels.English = string.Empty;
            this.labels.French = string.Empty;
            this.hasBuild = false;
            this.Set(1, 0);
        }

        [XmlAttribute("major")]
        public uint Major
        {
            get => 
                this.major;
            set
            {
                this.ClearBuildStringLabels();
                this.major = value;
            }
        }

        [XmlAttribute("minor")]
        public uint Minor
        {
            get => 
                this.minor;
            set
            {
                this.ClearBuildStringLabels();
                this.minor = value;
            }
        }

        [XmlAttribute("build")]
        public string BuildString
        {
            get => 
                !this.hasBuild ? null : this.Build.ToString();
            set
            {
                uint num;
                if (!uint.TryParse(value, out num))
                {
                    this.Build = 0;
                }
                else
                {
                    this.Build = num;
                    this.hasBuild = true;
                }
            }
        }

        [XmlIgnore]
        public uint Build
        {
            get => 
                this.build;
            set
            {
                this.ClearBuildStringLabels();
                this.build = value;
            }
        }

        [XmlIgnore]
        public string Text
        {
            get => 
                this.hasBuild ? (this.TextWithoutBuild + "b" + this.Build.ToString()) : this.TextWithoutBuild;
            set
            {
            }
        }

        [XmlElement("Labels")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Labels Labels
        {
            get
            {
                if ((this.labels.English.Trim().Length == 0) && (this.labels.French.Trim().Length == 0))
                {
                    this.labels.English = this.Text;
                    this.labels.French = this.labels.English;
                }
                return this.labels;
            }
            set => 
                this.labels = value;
        }

        [XmlIgnore]
        public string TextWithoutBuild =>
            "v" + this.Major.ToString() + "." + this.Minor.ToString();

        [XmlIgnore]
        public bool HasBuild =>
            this.hasBuild;
    }
}

