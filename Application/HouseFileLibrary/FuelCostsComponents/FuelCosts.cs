namespace ca.nrcan.gc.OEE.HouseFileLibrary.FuelCostsComponents
{
    using Microsoft.Xml.Serialization.GeneratedAssembly;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Serialization;

    [Serializable]
    public class FuelCosts
    {
        [XmlAttribute("includeCostCalculations")]
        public bool IncludeCostCalculations;
        [XmlAttribute("library")]
        public string LibraryFile;
        [XmlArray("Electricity"), XmlArrayItem("Fuel", typeof(FuelCostByType))]
        public List<FuelCostByType> Electricity = new List<FuelCostByType>();
        [XmlArray("NaturalGas"), XmlArrayItem("Fuel", typeof(FuelCostByType))]
        public List<FuelCostByType> NaturalGas = new List<FuelCostByType>();
        [XmlArray("Oil"), XmlArrayItem("Fuel", typeof(FuelCostByType))]
        public List<FuelCostByType> Oil = new List<FuelCostByType>();
        [XmlArray("Propane"), XmlArrayItem("Fuel", typeof(FuelCostByType))]
        public List<FuelCostByType> Propane = new List<FuelCostByType>();
        [XmlArray("Wood"), XmlArrayItem("Fuel", typeof(FuelCostByType))]
        public List<FuelCostByType> Wood = new List<FuelCostByType>();
        [XmlElement("Monthly")]
        public FuelCostsMonthly Monthly;
        private static FuelCostsSerializer cachedSerializer;

        public FuelCosts Clone()
        {
            using (MemoryStream stream = new MemoryStream(0x400))
            {
                Serializer.Serialize((Stream) stream, this);
                stream.Position = 0L;
                return (FuelCosts) Serializer.Deserialize(stream);
            }
        }

        [XmlIgnore]
        public static FuelCostsSerializer Serializer
        {
            get
            {
                cachedSerializer = new FuelCostsSerializer();
                return cachedSerializer;
            }
        }
    }
}

