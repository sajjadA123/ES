namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [Serializable]
    public class Generation : Component
    {
        [XmlIgnore]
        public decimal? WindEnergyContribution;
        [XmlAttribute("solarReady")]
        public bool SolarReady;
        [XmlIgnore]
        public decimal? PhotovoltaicCapacity;
        [XmlAttribute("batteryStorage")]
        public bool BatteryStorage;
        [XmlArray("PhotovoltaicSystems"), XmlArrayItem("System", typeof(Photovoltaic))]
        public List<Photovoltaic> PhotovoltaicSystems;

        public Generation()
        {
            this.SetDefaults();
        }

        public Generation(Generation toCopy)
        {
            base.Label = toCopy.Label;
            this.SolarReady = toCopy.SolarReady;
            this.WindEnergyContribution = toCopy.WindEnergyContribution;
            if (toCopy.PhotovoltaicSystems == null)
            {
                this.PhotovoltaicSystems = null;
            }
            else
            {
                this.PhotovoltaicSystems = new List<Photovoltaic>();
                foreach (Photovoltaic photovoltaic in toCopy.PhotovoltaicSystems)
                {
                    this.PhotovoltaicSystems.Add(new Photovoltaic(photovoltaic));
                }
            }
        }

        public void SetDefaults()
        {
            base.Label = "Generation";
            this.SolarReady = false;
            this.WindEnergyContribution = null;
            this.PhotovoltaicSystems = null;
        }

        [XmlAttribute("windEnergyContribution")]
        public string WindEnergyContributionHelper
        {
            get => 
                this.WindEnergyContribution?.ToString();
            set
            {
                decimal num;
                this.WindEnergyContribution = null;
                if (!string.IsNullOrEmpty(value) && decimal.TryParse(value, out num))
                {
                    this.WindEnergyContribution = new decimal?(num);
                }
            }
        }

        [XmlAttribute("photovoltaicCapacity")]
        public string PhotovoltaicCapacityHelper
        {
            get => 
                this.PhotovoltaicCapacity?.ToString();
            set
            {
                decimal num;
                this.PhotovoltaicCapacity = null;
                if (!string.IsNullOrEmpty(value) && decimal.TryParse(value, out num))
                {
                    this.PhotovoltaicCapacity = new decimal?(num);
                }
            }
        }
    }
}

