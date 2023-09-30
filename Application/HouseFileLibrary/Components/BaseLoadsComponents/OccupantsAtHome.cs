namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class OccupantsAtHome
    {
        [XmlAttribute("occupants")]
        public ushort Occupants;
        [XmlAttribute("atHome")]
        public decimal AtHome;

        public OccupantsAtHome()
        {
        }

        public OccupantsAtHome(OccupantsAtHome toCopy)
        {
            this.Occupants = toCopy.Occupants;
            this.AtHome = toCopy.AtHome;
        }

        public OccupantsAtHome(ushort occupants, decimal atHome)
        {
            this.Occupants = occupants;
            this.AtHome = atHome;
        }
    }
}

