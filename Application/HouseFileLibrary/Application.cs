namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Application
    {
        [XmlElement("Name")]
        public string Name;
        [XmlElement("Version")]
        public HouseFileVersion Version;
        [XmlElement("SimulationSettings")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.SimulationSettings SimulationSettings;

        public Application()
        {
            this.SetDefaults();
        }

        public Application(Application toCopy)
        {
            this.Name = toCopy.Name;
            this.Version = (toCopy.Version == null) ? null : new HouseFileVersion(toCopy.Version);
            this.LibraryVersion = (toCopy.LibraryVersion == null) ? null : new HouseFileVersion(toCopy.LibraryVersion);
            this.SimulationSettings = (toCopy.SimulationSettings == null) ? null : new ca.nrcan.gc.OEE.HouseFileLibrary.SimulationSettings(toCopy.SimulationSettings);
        }

        public void SetDefaults()
        {
            this.Name = "HouseFile Library";
            this.Version = new HouseFileVersion(this.LibraryVersion);
        }

        [XmlElement("LibraryVersion")]
        public HouseFileVersion LibraryVersion
        {
            get => 
                HouseFile.LibraryVersion;
            set
            {
            }
        }
    }
}

