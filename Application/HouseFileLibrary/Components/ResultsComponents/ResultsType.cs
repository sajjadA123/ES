namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Xml.Linq;

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct ResultsType
    {
        public static readonly ResultsType AllUpgrades;
        public static readonly ResultsType Base;
        public static readonly ResultsType AirTightness;
        public static readonly ResultsType BaseLoads;
        public static readonly ResultsType Ceilings;
        public static readonly ResultsType CeilingsCathedralFlat;
        public static readonly ResultsType Cooling;
        public static readonly ResultsType Doors;
        public static readonly ResultsType Floors;
        public static readonly ResultsType Foundation;
        public static readonly ResultsType Generation;
        public static readonly ResultsType Heating;
        public static readonly ResultsType HotWater;
        public static readonly ResultsType Rooms;
        public static readonly ResultsType Temperature;
        public static readonly ResultsType Ventilation;
        public static readonly ResultsType Walls;
        public static readonly ResultsType WindowsAll;
        public static readonly ResultsType WindowsEast;
        public static readonly ResultsType WindowsNorth;
        public static readonly ResultsType WindowsNorthEast;
        public static readonly ResultsType WindowsNorthWest;
        public static readonly ResultsType WindowsSouth;
        public static readonly ResultsType WindowsSouthEast;
        public static readonly ResultsType WindowsSoutWest;
        public static readonly ResultsType WindowsWest;
        private string code;
        private string english;
        private string french;
        public static implicit operator string(ResultsType type) => 
            type.code;

        public static bool operator ==(ResultsType x, ResultsType y) => 
            x.code == y.code;

        public static bool operator !=(ResultsType x, ResultsType y) => 
            x.code != y.code;

        public override bool Equals(object o)
        {
            try
            {
                return (this == ((ResultsType) o));
            }
            catch
            {
                return false;
            }
        }

        public override int GetHashCode() => 
            this.code.GetHashCode();

        public static List<ResultsType> All
        {
            get
            {
                List<ResultsType> list1 = new List<ResultsType>();
                list1.Add(AirTightness);
                list1.Add(AllUpgrades);
                list1.Add(Base);
                list1.Add(BaseLoads);
                list1.Add(Ceilings);
                list1.Add(CeilingsCathedralFlat);
                list1.Add(Cooling);
                list1.Add(Doors);
                list1.Add(Floors);
                list1.Add(Foundation);
                list1.Add(Generation);
                list1.Add(Heating);
                list1.Add(HotWater);
                list1.Add(Rooms);
                list1.Add(Temperature);
                list1.Add(Ventilation);
                list1.Add(Walls);
                list1.Add(WindowsAll);
                list1.Add(WindowsEast);
                list1.Add(WindowsNorth);
                list1.Add(WindowsNorthEast);
                list1.Add(WindowsNorthWest);
                list1.Add(WindowsSouth);
                list1.Add(WindowsSouthEast);
                list1.Add(WindowsSoutWest);
                list1.Add(WindowsWest);
                return list1;
            }
        }
        public static ResultsType FromCode(string code) => 
            (from t in All
                where t.code.Equals(code, StringComparison.CurrentCultureIgnoreCase)
                select t).FirstOrDefault<ResultsType>();

        public string Code =>
            this.code;
        public string English =>
            this.english;
        public string French =>
            this.french;
        public XAttribute Xml =>
            new XAttribute("type", this.code);
        private ResultsType(string codeToUse, string englishDescription, string frenchDescription)
        {
            if (string.IsNullOrWhiteSpace(codeToUse))
            {
                throw new ArgumentOutOfRangeException("Attempt to create invalid ResultsType: codeToUse must not be empty!");
            }
            this.code = codeToUse;
            this.english = englishDescription;
            this.french = frenchDescription;
        }

        static ResultsType()
        {
            AllUpgrades = new ResultsType("AllUpgrades", "All Upgrades", "Toutes les Am\x00e9liorations");
            Base = new ResultsType("Base", "Base Case", "Cas de Base");
            AirTightness = new ResultsType("AirTightness", "Air Tightness", "\x00c9tanch\x00e9it\x00e9 \x00e0 l'Air");
            BaseLoads = new ResultsType("BaseLoads", "Base Loads", "Charges de base");
            Ceilings = new ResultsType("Ceilings", "Ceiling", "Plafond");
            CeilingsCathedralFlat = new ResultsType("CeilingsCathedralFlat", "Flat or Cathedral Ceiling", "Plafond Cath\x00e9drale ou Plat");
            Cooling = new ResultsType("Cooling", "Cooling System", "Syst\x00e8me de Refroidissement");
            Doors = new ResultsType("Doors", "Door", "Porte");
            Floors = new ResultsType("Floors", "Floor", "Plancher");
            Foundation = new ResultsType("Foundation", "Foundation", "Fondation");
            Generation = new ResultsType("Generation", "Generation", "G\x00e9n\x00e9ration");
            Heating = new ResultsType("Heating", "Heating System", "Syst\x00e8me de Chauffage");
            HotWater = new ResultsType("HotWater", "Domestic Hot Water", "Eau chaude domestique");
            Rooms = new ResultsType("Rooms", "Room", "Pi\x00e8ce");
            Temperature = new ResultsType("Temperature", "Temperature", "Temp\x00e9rature");
            Ventilation = new ResultsType("Ventilation", "Ventilation", "Ventilation");
            Walls = new ResultsType("Walls", "Wall", "Mur");
            WindowsAll = new ResultsType("WindowsAll", "All Windows", "Toutes les Fen\x00eatres");
            WindowsEast = new ResultsType("WindowsEast", "East Window", "Est Fen\x00eatre");
            WindowsNorth = new ResultsType("WindowsNorth", "North Window", "Nord Fen\x00eatre");
            WindowsNorthEast = new ResultsType("WindowsNorthEast", "Northeast Window", "Nord-est Fen\x00eatre");
            WindowsNorthWest = new ResultsType("WindowsNorthWest", "Northwest Window", "Nord-ouest Fen\x00eatre");
            WindowsSouth = new ResultsType("WindowsSouth", "South Window", "Sud Fen\x00eatre");
            WindowsSouthEast = new ResultsType("WindowsSouthEast", "Southeast Window", "Sud-est Fen\x00eatre");
            WindowsSoutWest = new ResultsType("WindowsSoutWest", "Southwest Window", "Sud-ouest Fen\x00eatre");
            WindowsWest = new ResultsType("WindowsWest", "West Window", "Ouest Fen\x00eatre");
        }
    }
}

