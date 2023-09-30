namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Occupancy
    {
        [XmlAttribute("isOccupied")]
        public bool IsHouseOccupied;
        [XmlElement("Adults")]
        public OccupantsAtHome Adults;
        [XmlElement("Children")]
        public OccupantsAtHome Children;
        [XmlElement("Infants")]
        public OccupantsAtHome Infants;

        public Occupancy()
        {
            this.Adults = new OccupantsAtHome();
            this.Children = new OccupantsAtHome();
            this.Infants = new OccupantsAtHome();
            this.SetDefaults();
        }

        public Occupancy(Occupancy toCopy)
        {
            this.Adults = new OccupantsAtHome();
            this.Children = new OccupantsAtHome();
            this.Infants = new OccupantsAtHome();
            this.Adults = new OccupantsAtHome(toCopy.Adults);
            this.Children = new OccupantsAtHome(toCopy.Children);
            this.Infants = new OccupantsAtHome(toCopy.Infants);
        }

        public void SetDefaults()
        {
            this.Adults.Occupants = 2;
            this.Adults.AtHome = 50M;
            this.Children.Occupants = 1;
            this.Children.AtHome = 50M;
            this.Infants.Occupants = 0;
            this.Infants.AtHome = 0M;
            this.IsHouseOccupied = true;
        }

        [XmlIgnore]
        public int TotalOccupants =>
            (this.Adults.Occupants + this.Children.Occupants) + this.Infants.Occupants;
    }
}

