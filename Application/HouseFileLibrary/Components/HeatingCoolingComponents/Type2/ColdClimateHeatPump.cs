namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Runtime.CompilerServices;
    using System.Xml.Serialization;

    [Serializable]
    public class ColdClimateHeatPump
    {
        [XmlAttribute("heatingEfficiency")]
        public decimal HeatingEfficiency { get; set; }

        [XmlAttribute("coolingEfficiency")]
        public decimal CoolingEfficiency { get; set; }

        [XmlAttribute("capacity")]
        public decimal Capacity { get; set; }

        [XmlAttribute("cop")]
        public decimal Cop { get; set; }

        [XmlAttribute("capacityMaintenance")]
        public decimal CapacityMaintenance { get; set; }

        [XmlAttribute("uiUnits")]
        public string UiUnits { get; set; }

        [XmlIgnore]
        public decimal ValueInUiUnits
        {
            get => 
                (this.UiUnits.ToLowerInvariant() != "btu/hr") ? this.Capacity : Conversions.ConvertUnits(eConversionType.UNIT_KW_2_BTUHR, eUnitType.M_2_I, this.Capacity);
            set
            {
                if (this.UiUnits.ToLowerInvariant() == "btu/hr")
                {
                    this.Capacity = Conversions.ConvertUnits(eConversionType.UNIT_KW_2_BTUHR, eUnitType.I_2_M, value);
                }
                else
                {
                    this.Capacity = value;
                }
            }
        }
    }
}

