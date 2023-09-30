namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Photovoltaic
    {
        [XmlAttribute("rank")]
        public ushort Rank;
        [XmlElement("EquipmentInformation")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.EquipmentInformation EquipmentInformation;
        [XmlElement("Array")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents.Array Array;
        [XmlElement("Efficiency")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents.Efficiency Efficiency;
        [XmlElement("Module")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents.Module Module;

        public Photovoltaic()
        {
            this.EquipmentInformation = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.EquipmentInformation();
            this.Array = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents.Array();
            this.Efficiency = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents.Efficiency();
            this.Module = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents.Module();
        }

        public Photovoltaic(Photovoltaic toCopy)
        {
            this.EquipmentInformation = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.EquipmentInformation();
            this.Array = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents.Array();
            this.Efficiency = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents.Efficiency();
            this.Module = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents.Module();
            this.EquipmentInformation = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.EquipmentInformation(toCopy.EquipmentInformation);
            this.Array.Area = toCopy.Array.Area;
            this.Array.Slope = toCopy.Array.Slope;
            this.Array.Azimuth = toCopy.Array.Azimuth;
            this.Efficiency.MiscellaneousLosses = toCopy.Efficiency.MiscellaneousLosses;
            this.Efficiency.OtherPowerLosses = toCopy.Efficiency.OtherPowerLosses;
            this.Efficiency.InverterEfficiency = toCopy.Efficiency.InverterEfficiency;
            this.Efficiency.GridAbsorptionRate = toCopy.Efficiency.GridAbsorptionRate;
            this.Module.Efficiency = toCopy.Module.Efficiency;
            this.Module.CellTemperature = toCopy.Module.CellTemperature;
            this.Module.CoefficientOfEfficiency = toCopy.Module.CoefficientOfEfficiency;
            this.Module.Type = toCopy.Module.Type;
        }
    }
}

