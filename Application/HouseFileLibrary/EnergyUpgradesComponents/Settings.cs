namespace ca.nrcan.gc.OEE.HouseFileLibrary.EnergyUpgradesComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Settings
    {
        [XmlAttribute("calculateSavingsIndividually")]
        public bool CalculateSavingsIndividually;
        [XmlElement("CathedralCeilingsFlat")]
        public Setting CathedralCeilingsFlat;
        [XmlElement("Ceilings")]
        public Setting Ceilings;
        [XmlElement("MainWalls")]
        public Setting MainWalls;
        [XmlElement("Foundation")]
        public Setting Foundation;
        [XmlElement("Floor")]
        public Setting Floor;
        [XmlElement("Windows")]
        public Setting Windows;
        [XmlElement("AirTightness")]
        public Setting AirTightness;
        [XmlElement("Doors")]
        public Setting Doors;
        [XmlElement("Heating")]
        public Setting Heating;
        [XmlElement("HotWater")]
        public Setting HotWater;
        [XmlElement("Ventilation")]
        public Setting Ventilation;
        [XmlElement("Cooling")]
        public Setting Cooling;
        [XmlElement("TemperatureSetPoints")]
        public Setting TemperatureSetPoints;
        [XmlElement("Rooms")]
        public Setting Rooms;
        [XmlElement("Units")]
        public Setting Units;
        [XmlElement("PhotovoltaicGeneration")]
        public Setting PhotovoltaicGeneration;
        [XmlElement("Baseloads")]
        public Setting Baseloads;

        public void Clear()
        {
            this.CalculateSavingsIndividually = false;
            this.CathedralCeilingsFlat = null;
            this.Ceilings = null;
            this.MainWalls = null;
            this.Foundation = null;
            this.Floor = null;
            this.Windows = null;
            this.AirTightness = null;
            this.Doors = null;
            this.Heating = null;
            this.HotWater = null;
            this.Ventilation = null;
            this.Cooling = null;
            this.TemperatureSetPoints = null;
            this.Rooms = null;
            this.Units = null;
            this.PhotovoltaicGeneration = null;
            this.Baseloads = null;
        }
    }
}

