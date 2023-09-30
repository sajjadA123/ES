namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.CeilingComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.DoorComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorHeaderComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.RoomComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.WallComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.WindowComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.EnergyUpgradesComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.FuelCostsComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using ca.nrcan.gc.OEE.HouseFileLibrary.HouseFileEvents;
    using Microsoft.Xml.Serialization.GeneratedAssembly;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlRoot("HouseFile")]
    public class HouseFile
    {
        [XmlIgnore]
        private LanguageOptions Language;
        [XmlAttribute("uiUnits")]
        public string UiUnits;
        [XmlElement("Version")]
        public HouseFileVersion Version;
        [XmlElement("Application")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Application Application = new ca.nrcan.gc.OEE.HouseFileLibrary.Application();
        [XmlElement("ProgramInformation")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.ProgramInformation ProgramInformation = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.ProgramInformation();
        [XmlElement("House")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.House House = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.House();
        [XmlElement("Codes")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Codes Codes;
        [XmlElement("EnergyUpgrades")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.EnergyUpgradesComponents.EnergyUpgrades EnergyUpgrades;
        [XmlElement("FuelCosts")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.FuelCostsComponents.FuelCosts FuelCosts = new ca.nrcan.gc.OEE.HouseFileLibrary.FuelCostsComponents.FuelCosts();
        [XmlArray("AllResults"), XmlArrayItem(typeof(Results))]
        public List<Results> AllResults;
        [XmlIgnore]
        public static List<HouseFileError> Errors = new List<HouseFileError>();
        [XmlIgnore]
        public XElement Program;
        [XmlIgnore]
        public const string LibraryName = "HouseFile Library";
        public static HouseFileSerializer cachedSerializer = null;

        public HouseFile()
        {
            this.SetDefaults();
        }

        private static void AddAllComponentsToList(BaseComponent root, List<BaseComponent> list)
        {
            if ((root != null) && (list != null))
            {
                list.Add(root);
                if (root.Components != null)
                {
                    using (List<BaseComponent>.Enumerator enumerator = root.Components.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            AddAllComponentsToList(enumerator.Current, list);
                        }
                    }
                }
            }
        }

        private static void AdjustPercentages(uint decimalPlaceForPercentages, List<NominalInsulationPercentage> groups, List<NominalInsulationPercentage> secondGroups = null)
        {
            if ((groups != null) && (groups.Count != 0))
            {
                decimal num = 0M;
                decimal num2 = 0M;
                NominalInsulationPercentage percentage = groups[0];
                NominalInsulationPercentage percentage2 = groups[0];
                decimal num3 = 0M;
                decimal num4 = 0M;
                decimal num5 = 0M;
                foreach (NominalInsulationPercentage percentage3 in groups)
                {
                    num4 = decimal.Round(percentage3.TotalAreaPercentage, (int) decimalPlaceForPercentages, MidpointRounding.AwayFromZero);
                    num3 = num4 - percentage3.TotalAreaPercentage;
                    if (num3 < num)
                    {
                        num = num3;
                        percentage = percentage3;
                    }
                    else if (num3 > num2)
                    {
                        num2 = num3;
                        percentage2 = percentage3;
                    }
                    percentage3.TotalAreaPercentage = num4;
                    num5 += num4;
                }
                if ((secondGroups != null) && (secondGroups.Count > 0))
                {
                    foreach (NominalInsulationPercentage percentage4 in secondGroups)
                    {
                        num4 = decimal.Round(percentage4.TotalAreaPercentage, (int) decimalPlaceForPercentages, MidpointRounding.AwayFromZero);
                        num3 = num4 - percentage4.TotalAreaPercentage;
                        if (num3 < num)
                        {
                            num = num3;
                            percentage = percentage4;
                        }
                        else if (num3 > num2)
                        {
                            num2 = num3;
                            percentage2 = percentage4;
                        }
                        percentage4.TotalAreaPercentage = num4;
                        num5 += num4;
                    }
                }
                if (num5 != 100.0M)
                {
                    decimal num6 = 100M - num5;
                    if (num6 < 0M)
                    {
                        percentage2.TotalAreaPercentage += num6;
                    }
                    else
                    {
                        percentage.TotalAreaPercentage += num6;
                    }
                }
            }
        }

        private static string BuildNominalInsulationString(List<NominalInsulationPercentage> groups)
        {
            StringBuilder builder = new StringBuilder();
            bool flag = true;
            foreach (NominalInsulationPercentage percentage in groups)
            {
                if (flag)
                {
                    flag = false;
                }
                else
                {
                    builder.Append(';');
                }
                builder.Append(percentage.TotalAreaPercentage);
                builder.Append(";");
                builder.Append(percentage.NominalInsulation);
            }
            return builder.ToString();
        }

        public static string CalculateSha256(XElement xmlToChecksum) => 
            xmlToChecksum.CalculateSha256();

        public static bool CanBeUpgraded(BaseComponent toCheck, bool hasProgram = false) => 
            (!(toCheck is BaseLoads) || hasProgram) ? ((toCheck is Ceiling) || ((toCheck is Door) || ((toCheck is Floor) || ((toCheck is FloorHeader) || ((toCheck is Generation) || ((toCheck is HeatingCooling) || ((toCheck is HotWater) || ((toCheck is Foundation) || ((toCheck is NaturalAirInfiltration) || ((toCheck is Room) || (((toCheck is Temperatures) && !hasProgram) || ((toCheck is Ventilation) || ((toCheck is Wall) || (toCheck is Window)))))))))))))) : true;

        public void Clear()
        {
            Errors.Clear();
            this.House = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.House();
        }

        public HouseFile Clone()
        {
            using (MemoryStream stream = new MemoryStream(0x400))
            {
                Serializer.Serialize((Stream) stream, this);
                stream.Position = 0L;
                return (HouseFile) Serializer.Deserialize(stream);
            }
        }

        public static T Clone<T>(T source) => 
            XmlDeserializer<T>(XmlSerializer<T>(source));

        public Component CreateUpgradeFromComponent(BaseComponent unupgraded)
        {
            if ((unupgraded == null) || !CanBeUpgraded(unupgraded, this.Program != null))
            {
                return null;
            }
            Component toSave = Clone<Component>((Component) unupgraded);
            toSave.Components = null;
            this.SaveUpgrade(toSave);
            return toSave;
        }

        public Component CreateUpgradeFromComponent(uint id) => 
            this.CreateUpgradeFromComponent(this.GetComponentById(id));

        public string GetCeilingFlatNominalInsulations(uint decimalPlaceForPercentages = 1, uint decimalPlaceForInsulation = 1, bool enumerateAll = true) => 
            this.GetCeilingNominalInsulations(true, decimalPlaceForPercentages, decimalPlaceForInsulation, enumerateAll);

        public string GetCeilingNominalInsulations(bool isFlat = false, uint decimalPlaceForPercentages = 1, uint decimalPlaceForInsulation = 1, bool enumerateAll = true)
        {
            List<NominalInsulationPercentage> groups = new List<NominalInsulationPercentage>();
            List<NominalInsulationPercentage> secondGroups = new List<NominalInsulationPercentage>();
            List<Ceiling> componentsByType = this.GetComponentsByType<Ceiling>();
            if ((componentsByType == null) || (componentsByType.Count <= 0))
            {
                return string.Empty;
            }
            Func<Ceiling, uint> keySelector = _c._9__48_0;
            if (_c._9__48_0 == null)
            {
                Func<Ceiling, uint> local1 = _c._9__48_0;
                keySelector = _c._9__48_0 = c => c.Id;
            }
            componentsByType = componentsByType.OrderBy<Ceiling, uint>(keySelector).ToList<Ceiling>();
            Func<Ceiling, decimal> selector = _c._9__48_1;
            if (_c._9__48_1 == null)
            {
                Func<Ceiling, decimal> local2 = _c._9__48_1;
                selector = _c._9__48_1 = f => f.Measurements.Area;
            }
            decimal num = componentsByType.Sum<Ceiling>(selector);
            NominalInsulationPercentage percentage = null;
            foreach (Ceiling ceiling in componentsByType)
            {
                decimal rValueKey = decimal.Round(Conversions.RSItoR(ceiling.Construction.CeilingType.NominalInsulation), (int) decimalPlaceForInsulation);
                decimal totalAreaPercentage = (100M * ceiling.Measurements.Area) / num;
                if ((ceiling.Construction.Type != CeilingTypes.Cathedral) && (ceiling.Construction.Type != CeilingTypes.Flat))
                {
                    if (!enumerateAll)
                    {
                        percentage = (from nip in secondGroups
                            where nip.NominalInsulation == rValueKey
                            select nip).FirstOrDefault<NominalInsulationPercentage>();
                    }
                    if (percentage == null)
                    {
                        secondGroups.Add(new NominalInsulationPercentage(rValueKey, totalAreaPercentage));
                    }
                    else
                    {
                        percentage.TotalAreaPercentage += totalAreaPercentage;
                    }
                    continue;
                }
                if (!enumerateAll)
                {
                    percentage = (from nip in groups
                        where nip.NominalInsulation == rValueKey
                        select nip).FirstOrDefault<NominalInsulationPercentage>();
                }
                if (percentage == null)
                {
                    groups.Add(new NominalInsulationPercentage(rValueKey, totalAreaPercentage));
                }
                else
                {
                    percentage.TotalAreaPercentage += totalAreaPercentage;
                }
            }
            if (groups.Count > 0)
            {
                AdjustPercentages(decimalPlaceForPercentages, groups, secondGroups);
            }
            else
            {
                AdjustPercentages(decimalPlaceForPercentages, secondGroups, null);
            }
            return (!isFlat ? BuildNominalInsulationString(secondGroups) : BuildNominalInsulationString(groups));
        }

        public string GetCeilingNonFlatNominalInsulations(uint decimalPlaceForPercentages = 1, uint decimalPlaceForInsulation = 1, bool enumerateAll = true) => 
            this.GetCeilingNominalInsulations(false, decimalPlaceForPercentages, decimalPlaceForInsulation, enumerateAll);

        public string GetCeilingTypes()
        {
            List<Ceiling> componentsByType = this.GetComponentsByType<Ceiling>();
            if ((componentsByType == null) || (componentsByType.Count == 0))
            {
                return string.Empty;
            }
            Func<Ceiling, uint> keySelector = _c._9__50_0;
            if (_c._9__50_0 == null)
            {
                Func<Ceiling, uint> local1 = _c._9__50_0;
                keySelector = _c._9__50_0 = c => c.Id;
            }
            Func<Ceiling, bool> predicate = _c._9__50_1;
            if (_c._9__50_1 == null)
            {
                Func<Ceiling, bool> local2 = _c._9__50_1;
                predicate = _c._9__50_1 = c => (c.Construction.Type == CeilingTypes.Cathedral) || (c.Construction.Type == CeilingTypes.Flat);
            }
            int num = componentsByType.OrderBy<Ceiling, uint>(keySelector).Count<Ceiling>(predicate);
            int num2 = componentsByType.Count - num;
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < num2; i++)
            {
                builder.Append('A');
                if (i < (num2 - 1))
                {
                    builder.Append(';');
                }
            }
            if ((num2 > 0) && (num > 0))
            {
                builder.Append(';');
            }
            for (int j = 0; j < num; j++)
            {
                builder.Append('F');
                if (j < (num - 1))
                {
                    builder.Append(';');
                }
            }
            return builder.ToString();
        }

        public BaseComponent GetComponentById(uint id) => 
            (from component in this.HouseComponents
                where component.Id == id
                select component).FirstOrDefault<BaseComponent>();

        public List<T> GetComponentsByType<T>()
        {
            Func<BaseComponent, bool> predicate = _c__26<T>._9__26_0;
            if (_c__26<T>._9__26_0 == null)
            {
                Func<BaseComponent, bool> local1 = _c__26<T>._9__26_0;
                predicate = _c__26<T>._9__26_0 = component => component is T;
            }
            return this.HouseComponents.Where<BaseComponent>(predicate).Cast<T>().ToList<T>();
        }

        public string GetExposedFloorArea(uint decimalPlaceForPercentages = 1, uint decimalPlaceForInsulation = 1, bool enumerateAll = true)
        {
            List<NominalInsulationPercentage> groups = new List<NominalInsulationPercentage>();
            List<Floor> componentsByType = this.GetComponentsByType<Floor>();
            if ((componentsByType == null) || (componentsByType.Count <= 0))
            {
                return string.Empty;
            }
            Func<Floor, uint> keySelector = _c._9__52_0;
            if (_c._9__52_0 == null)
            {
                Func<Floor, uint> local1 = _c._9__52_0;
                keySelector = _c._9__52_0 = f => f.Id;
            }
            NominalInsulationPercentage percentage = null;
            foreach (Floor floor in componentsByType.OrderBy<Floor, uint>(keySelector).ToList<Floor>())
            {
                decimal NominalInsulation = Math.Round(floor.Construction.Type.NominalInsulation, 2);
                decimal totalAreaPercentage = Math.Round(floor.Measurements.Area, 2);
                if (!enumerateAll)
                {
                    percentage = (from nip in groups
                        where nip.NominalInsulation == NominalInsulation
                        select nip).FirstOrDefault<NominalInsulationPercentage>();
                }
                if (percentage != null)
                {
                    percentage.TotalAreaPercentage += totalAreaPercentage;
                }
                else
                {
                    NominalInsulation = Math.Round((decimal) (NominalInsulation * 5.678M), 1);
                    totalAreaPercentage = Math.Round((decimal) (totalAreaPercentage * 10.7639M), 0);
                    groups.Add(new NominalInsulationPercentage(NominalInsulation, totalAreaPercentage));
                }
            }
            return BuildNominalInsulationString(groups);
        }

        public string GetExteriorFoundationInsulations(uint decimalPlaceForPercentages = 1, uint decimalPlaceForInsulation = 1)
        {
            Func<Foundation, uint> keySelector = _c._9__53_0;
            if (_c._9__53_0 == null)
            {
                Func<Foundation, uint> local1 = _c._9__53_0;
                keySelector = _c._9__53_0 = f => f.Id;
            }
            Func<Foundation, bool> predicate = _c._9__53_1;
            if (_c._9__53_1 == null)
            {
                Func<Foundation, bool> local2 = _c._9__53_1;
                predicate = _c._9__53_1 = f => (f is Basement) || (f is Walkout);
            }
            List<Foundation> source = this.GetComponentsByType<Foundation>().OrderBy<Foundation, uint>(keySelector).Where<Foundation>(predicate).ToList<Foundation>();
            List<NominalInsulationPercentage> groups = new List<NominalInsulationPercentage>();
            if ((source == null) || (source.Count <= 0))
            {
                return string.Empty;
            }
            Func<Foundation, uint> func3 = _c._9__53_2;
            if (_c._9__53_2 == null)
            {
                Func<Foundation, uint> local3 = _c._9__53_2;
                func3 = _c._9__53_2 = w => w.Id;
            }
            source = source.OrderBy<Foundation, uint>(func3).ToList<Foundation>();
            decimal num = source.Sum<Foundation>(f => this.GetFoundationTotalArea(f));
            foreach (Foundation foundation in source)
            {
                ExposedSurfaces extFndPortions = foundation.GetExtFndPortions();
                decimal num2 = extFndPortions.ExteriorAboveGroundArea + extFndPortions.ExteriorBelowGroundArea;
                decimal totalAreaPercentage = (num == 0M) ? 0M : ((100M * num2) / num);
                CodeDescriptionAndComposite composite = null;
                composite = !(foundation is Basement) ? ((Walkout) foundation).Wall.Construction.ExteriorAddedInsulation : ((Basement) foundation).Wall.Construction.ExteriorAddedInsulation;
                composite.CalculateRemainder();
                if (composite.Composite.Count == 0)
                {
                    groups.Add(new NominalInsulationPercentage(0M, totalAreaPercentage));
                    continue;
                }
                foreach (RsiSection section in composite.Composite)
                {
                    decimal nominalInsulation = decimal.Round(Conversions.RSItoR(section.NominalRsi), (int) decimalPlaceForInsulation, MidpointRounding.AwayFromZero);
                    groups.Add(new NominalInsulationPercentage(nominalInsulation, (section.Percentage * totalAreaPercentage) / 100M));
                }
            }
            AdjustPercentages(decimalPlaceForPercentages, groups, null);
            return BuildNominalInsulationString(groups);
        }

        public string GetFloorNominalInsulations(uint decimalPlaceForPercentages = 1, uint decimalPlaceForInsulation = 1, bool enumerateAll = true)
        {
            List<NominalInsulationPercentage> groups = new List<NominalInsulationPercentage>();
            List<Floor> componentsByType = this.GetComponentsByType<Floor>();
            if ((componentsByType == null) || (componentsByType.Count <= 0))
            {
                return string.Empty;
            }
            Func<Floor, uint> keySelector = _c._9__51_0;
            if (_c._9__51_0 == null)
            {
                Func<Floor, uint> local1 = _c._9__51_0;
                keySelector = _c._9__51_0 = f => f.Id;
            }
            componentsByType = componentsByType.OrderBy<Floor, uint>(keySelector).ToList<Floor>();
            Func<Floor, decimal> selector = _c._9__51_1;
            if (_c._9__51_1 == null)
            {
                Func<Floor, decimal> local2 = _c._9__51_1;
                selector = _c._9__51_1 = f => f.Measurements.Area;
            }
            decimal num = componentsByType.Sum<Floor>(selector);
            NominalInsulationPercentage percentage = null;
            foreach (Floor floor in componentsByType)
            {
                decimal rValueKey = decimal.Round(Conversions.RSItoR(floor.Construction.Type.NominalInsulation), (int) decimalPlaceForInsulation);
                decimal totalAreaPercentage = (100M * floor.Measurements.Area) / num;
                if (!enumerateAll)
                {
                    percentage = (from nip in groups
                        where nip.NominalInsulation == rValueKey
                        select nip).FirstOrDefault<NominalInsulationPercentage>();
                }
                if (percentage == null)
                {
                    groups.Add(new NominalInsulationPercentage(rValueKey, totalAreaPercentage));
                }
                else
                {
                    percentage.TotalAreaPercentage += totalAreaPercentage;
                }
            }
            AdjustPercentages(decimalPlaceForPercentages, groups, null);
            return BuildNominalInsulationString(groups);
        }

        public string GetFoundationDefinitions(uint decimalPlaceForPercentages = 1, uint decimalPlaceForInsulation = 1)
        {
            decimal decimal1;
            Func<Foundation, uint> keySelector = _c._9__56_0;
            if (_c._9__56_0 == null)
            {
                Func<Foundation, uint> local1 = _c._9__56_0;
                keySelector = _c._9__56_0 = f => f.Id;
            }
            Func<Foundation, bool> predicate = _c._9__56_1;
            if (_c._9__56_1 == null)
            {
                Func<Foundation, bool> local2 = _c._9__56_1;
                predicate = _c._9__56_1 = f => (f is Basement) || (f is Walkout);
            }
            List<Foundation> collection = this.GetComponentsByType<Foundation>().OrderBy<Foundation, uint>(keySelector).Where<Foundation>(predicate).ToList<Foundation>();
            Func<Foundation, uint> func3 = _c._9__56_2;
            if (_c._9__56_2 == null)
            {
                Func<Foundation, uint> local3 = _c._9__56_2;
                func3 = _c._9__56_2 = f => f.Id;
            }
            Func<Foundation, bool> func4 = _c._9__56_3;
            if (_c._9__56_3 == null)
            {
                Func<Foundation, bool> local4 = _c._9__56_3;
                func4 = _c._9__56_3 = f => f is Crawlspace;
            }
            List<Crawlspace> list2 = this.GetComponentsByType<Foundation>().OrderBy<Foundation, uint>(func3).Where<Foundation>(func4).Cast<Crawlspace>().ToList<Crawlspace>();
            List<Foundation> source = new List<Foundation>();
            source.AddRange(collection);
            source.AddRange(list2);
            if (source.Count<Foundation>() == 0)
            {
                return string.Empty;
            }
            List<NominalInsulationPercentage> groups = new List<NominalInsulationPercentage>();
            List<NominalInsulationPercentage> list5 = new List<NominalInsulationPercentage>();
            List<NominalInsulationPercentage> secondGroups = new List<NominalInsulationPercentage>();
            decimal num = source.Sum<Foundation>(f => this.GetFoundationTotalArea(f));
            if (list2 == null)
            {
                decimal1 = 0M;
            }
            else
            {
                Func<Crawlspace, decimal> selector = _c._9__56_5;
                if (_c._9__56_5 == null)
                {
                    Func<Crawlspace, decimal> local5 = _c._9__56_5;
                    selector = _c._9__56_5 = c => c.Floor.Measurements.FloorArea;
                }
                decimal1 = list2.Sum<Crawlspace>(selector);
            }
            decimal num2 = decimal1;
            foreach (Foundation foundation in source)
            {
                ExposedSurfaces extFndPortions = foundation.GetExtFndPortions();
                decimal num3 = extFndPortions.ExteriorAboveGroundArea + extFndPortions.ExteriorBelowGroundArea;
                decimal totalAreaPercentage = (num == 0M) ? 0M : ((100M * num3) / num);
                CodeDescriptionAndComposite ponyWallType = null;
                ponyWallType = !(foundation is Basement) ? (!(foundation is Crawlspace) ? ((Walkout) foundation).Wall.Construction.InteriorAddedInsulation : ((Crawlspace) foundation).Wall.Construction.Type) : ((Basement) foundation).Wall.Construction.InteriorAddedInsulation;
                ponyWallType.CalculateRemainder();
                switch (ponyWallType.Composite.Count)
                {
                    case 1 :
                        groups.Add(new NominalInsulationPercentage(0M, totalAreaPercentage));
                        break;

                    default:
                        foreach (RsiSection section in ponyWallType.Composite)
                        {
                            decimal nominalInsulation = decimal.Round(Conversions.RSItoR(section.NominalRsi), (int) decimalPlaceForInsulation, MidpointRounding.AwayFromZero);
                            groups.Add(new NominalInsulationPercentage(nominalInsulation, (section.Percentage * totalAreaPercentage) / 100M));
                        }
                        break;
                }
                if (foundation is Crawlspace)
                {
                    list5.Add(new NominalInsulationPercentage(decimal.Round(Conversions.RSItoR(((Crawlspace) foundation).Floor.Construction.FloorsAbove.NominalInsulation), (int) decimalPlaceForInsulation, MidpointRounding.AwayFromZero), (num2 == 0M) ? 0M : ((100M * ((Crawlspace) foundation).Floor.Measurements.FloorArea) / num2)));
                }
                if ((!(foundation is Basement) || !((Basement) foundation).Wall.HasPonyWall) ? ((foundation is Walkout) && ((Walkout) foundation).Wall.HasPonyWall) : true)
                {
                    decimal num8 = (num == 0M) ? 0M : ((100M * extFndPortions.PonyWallArea) / num);
                    if (foundation is Basement)
                    {
                        ponyWallType = ((Basement) foundation).Wall.Construction.PonyWallType;
                    }
                    else if (foundation is Walkout)
                    {
                        ponyWallType = ((Walkout) foundation).Wall.Construction.PonyWallType;
                    }
                    ponyWallType.CalculateRemainder();
                    foreach (RsiSection section2 in ponyWallType.Composite)
                    {
                        decimal nominalInsulation = decimal.Round(Conversions.RSItoR(section2.NominalRsi), (int) decimalPlaceForInsulation, MidpointRounding.AwayFromZero);
                        secondGroups.Add(new NominalInsulationPercentage(nominalInsulation, (section2.Percentage * num8) / 100M));
                    }
                }
            }
            AdjustPercentages(decimalPlaceForPercentages, groups, secondGroups);
            StringBuilder builder = new StringBuilder();
            if (groups.Count > 0)
            {
                builder.Append(BuildNominalInsulationString(groups));
            }
            if (list5.Count > 0)
            {
                if (groups.Count > 0)
                {
                    builder.Append(';');
                }
                AdjustPercentages(decimalPlaceForPercentages, list5, null);
                builder.Append(BuildNominalInsulationString(list5));
            }
            if (secondGroups.Count > 0)
            {
                if ((groups.Count > 0) || (list5.Count > 0))
                {
                    builder.Append(';');
                }
                builder.Append(BuildNominalInsulationString(secondGroups));
            }
            return builder.ToString();
        }

        public string GetFoundationFloorHeaderNominalInsulations(uint decimalPlaceForPercentages = 1, uint decimalPlaceForInsulation = 1, bool enumerateAll = true)
        {
            List<NominalInsulationPercentage> groups = new List<NominalInsulationPercentage>();
            List<FloorHeader> componentsByType = this.GetComponentsByType<FloorHeader>();
            if ((componentsByType == null) || (componentsByType.Count == 0))
            {
                return string.Empty;
            }
            Func<FloorHeader, uint> keySelector = _c._9__54_0;
            if (_c._9__54_0 == null)
            {
                Func<FloorHeader, uint> local1 = _c._9__54_0;
                keySelector = _c._9__54_0 = f => f.Id;
            }
            Func<FloorHeader, bool> predicate = _c._9__54_1;
            if (_c._9__54_1 == null)
            {
                Func<FloorHeader, bool> local2 = _c._9__54_1;
                predicate = _c._9__54_1 = fh => fh.Parent is Foundation;
            }
            List<FloorHeader> source = componentsByType.OrderBy<FloorHeader, uint>(keySelector).Where<FloorHeader>(predicate).ToList<FloorHeader>();
            if ((source == null) || (source.Count <= 0))
            {
                return string.Empty;
            }
            Func<FloorHeader, decimal> selector = _c._9__54_2;
            if (_c._9__54_2 == null)
            {
                Func<FloorHeader, decimal> local3 = _c._9__54_2;
                selector = _c._9__54_2 = fh => fh.Measurements.Area;
            }
            decimal num = source.Sum<FloorHeader>(selector);
            NominalInsulationPercentage percentage = null;
            foreach (FloorHeader header in source)
            {
                decimal rValueKey = decimal.Round(Conversions.RSItoR(header.Construction.Type.NominalInsulation), (int) decimalPlaceForInsulation);
                decimal totalAreaPercentage = (100M * header.Measurements.Area) / num;
                if (!enumerateAll)
                {
                    percentage = (from nip in groups
                        where nip.NominalInsulation == rValueKey
                        select nip).FirstOrDefault<NominalInsulationPercentage>();
                }
                if (percentage == null)
                {
                    groups.Add(new NominalInsulationPercentage(rValueKey, totalAreaPercentage));
                }
                else
                {
                    percentage.TotalAreaPercentage += totalAreaPercentage;
                }
            }
            AdjustPercentages(decimalPlaceForPercentages, groups, null);
            return BuildNominalInsulationString(groups);
        }

        private decimal GetFoundationTotalArea(Foundation foundation)
        {
            ExposedSurfaces extFndPortions = foundation.GetExtFndPortions();
            return ((extFndPortions.ExteriorAboveGroundArea + extFndPortions.ExteriorBelowGroundArea) + extFndPortions.PonyWallArea);
        }

        public string GetFoundationTypes()
        {
            Func<Foundation, uint> keySelector = _c._9__57_0;
            if (_c._9__57_0 == null)
            {
                Func<Foundation, uint> local1 = _c._9__57_0;
                keySelector = _c._9__57_0 = f => f.Id;
            }
            Func<Foundation, bool> predicate = _c._9__57_1;
            if (_c._9__57_1 == null)
            {
                Func<Foundation, bool> local2 = _c._9__57_1;
                predicate = _c._9__57_1 = f => (f is Basement) || (f is Walkout);
            }
            List<Foundation> list = this.GetComponentsByType<Foundation>().OrderBy<Foundation, uint>(keySelector).Where<Foundation>(predicate).ToList<Foundation>();
            Func<Foundation, uint> func3 = _c._9__57_2;
            if (_c._9__57_2 == null)
            {
                Func<Foundation, uint> local3 = _c._9__57_2;
                func3 = _c._9__57_2 = f => f.Id;
            }
            Func<Foundation, bool> func4 = _c._9__57_3;
            if (_c._9__57_3 == null)
            {
                Func<Foundation, bool> local4 = _c._9__57_3;
                func4 = _c._9__57_3 = f => f is Crawlspace;
            }
            List<Foundation> list2 = this.GetComponentsByType<Foundation>().OrderBy<Foundation, uint>(func3).Where<Foundation>(func4).ToList<Foundation>();
            if ((list.Count + list2.Count) == 0)
            {
                return string.Empty;
            }
            StringBuilder builder = new StringBuilder();
            int num = 1;
            foreach (Foundation foundation in list)
            {
                CodeDescriptionAndComposite composite = (foundation is Basement) ? ((Basement) foundation).Wall.Construction.InteriorAddedInsulation : ((Walkout) foundation).Wall.Construction.InteriorAddedInsulation;
                if (composite.Composite.Count == 0)
                {
                    builder.Append($"B{num++};");
                    continue;
                }
                foreach (RsiSection local5 in composite.Composite)
                {
                    builder.Append($"B{num++};");
                }
            }
            StringBuilder builder2 = new StringBuilder();
            int num2 = 1;
            int num3 = 1;
            using (List<Foundation>.Enumerator enumerator = list2.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    CodeDescriptionAndComposite type = ((Crawlspace) enumerator.Current).Wall.Construction.Type;
                    if (type.Composite.Count == 0)
                    {
                        builder.Append($"C{num2++};");
                    }
                    else
                    {
                        foreach (RsiSection local6 in type.Composite)
                        {
                            builder.Append($"C{num2++};");
                        }
                    }
                    builder2.Append($"F{num3++};");
                }
            }
            builder.Append(builder2);
            int num4 = 1;
            foreach (Foundation foundation2 in list)
            {
                FoundationWall wall = (foundation2 is Basement) ? ((Basement) foundation2).Wall : ((Walkout) foundation2).Wall;
                if (wall.HasPonyWall && (wall.Construction.PonyWallType != null))
                {
                    foreach (RsiSection local7 in wall.Construction.PonyWallType.Composite)
                    {
                        builder.Append($"P{num4++};");
                    }
                }
            }
            if ((builder.Length > 0) && (builder[builder.Length - 1] == ';'))
            {
                builder.Remove(builder.Length - 1, 1);
            }
            return builder.ToString();
        }

        public Component GetUpgradeById(uint id) => 
            (from component in this.EnergyUpgrades.Components
                where component.Id == id
                select component).FirstOrDefault<Component>();

        public HouseFile GetUpgradedHouse()
        {
            HouseFile file = new HouseFile();
            file.Load(this);
            if (file.HasUpgrades())
            {
                foreach (Component component in file.EnergyUpgrades.Components)
                {
                    BaseComponent componentById = file.GetComponentById(component.Id);
                    if (componentById != null)
                    {
                        component.Components = componentById.Components;
                        BaseComponent parent = componentById.Parent;
                        if (component is BaseLoads)
                        {
                            file.House.BaseLoads = (BaseLoads) component;
                            continue;
                        }
                        if (component is Generation)
                        {
                            file.House.Generation = (Generation) component;
                            continue;
                        }
                        if (component is HeatingCooling)
                        {
                            file.House.HeatingCooling = (HeatingCooling) component;
                            continue;
                        }
                        if (component is NaturalAirInfiltration)
                        {
                            file.House.NaturalAirInfiltration = (NaturalAirInfiltration) component;
                            continue;
                        }
                        if (component is Temperatures)
                        {
                            file.House.Temperatures = (Temperatures) component;
                            continue;
                        }
                        if (component is Ventilation)
                        {
                            file.House.Ventilation = (Ventilation) component;
                            continue;
                        }
                        parent.Components.Remove(componentById);
                        parent.Components.Add(component);
                    }
                }
                file.EnergyUpgrades = null;
                file.AllResults = null;
                file.UpdateReferences();
            }
            return file;
        }

        public Component GetUpgradeForComponent(BaseComponent unupgraded) => 
            (unupgraded != null) ? this.GetUpgradeById(unupgraded.Id) : null;

        public List<T> GetUpgradesByType<T>()
        {
            if (this.EnergyUpgrades == null)
            {
                return new List<T>();
            }
            Func<Component, bool> predicate = _c__29<T>._9__29_0;
            if (_c__29<T>._9__29_0 == null)
            {
                Func<Component, bool> local1 = _c__29<T>._9__29_0;
                predicate = _c__29<T>._9__29_0 = component => component is T;
            }
            return this.EnergyUpgrades.Components.Where<Component>(predicate).Cast<T>().ToList<T>();
        }

        public string GetWallNominalInsulations(uint decimalPlaceForPercentages = 1, uint decimalPlaceForInsulation = 1, bool enumerateAll = true)
        {
            List<NominalInsulationPercentage> groups = new List<NominalInsulationPercentage>();
            List<Wall> componentsByType = this.GetComponentsByType<Wall>();
            if ((componentsByType == null) || (componentsByType.Count <= 0))
            {
                return string.Empty;
            }
            Func<Wall, uint> keySelector = _c._9__58_0;
            if (_c._9__58_0 == null)
            {
                Func<Wall, uint> local1 = _c._9__58_0;
                keySelector = _c._9__58_0 = w => w.Id;
            }
            componentsByType = componentsByType.OrderBy<Wall, uint>(keySelector).ToList<Wall>();
            Func<Wall, decimal> selector = _c._9__58_1;
            if (_c._9__58_1 == null)
            {
                Func<Wall, decimal> local2 = _c._9__58_1;
                selector = _c._9__58_1 = w => w.Measurements.Area;
            }
            decimal num = componentsByType.Sum<Wall>(selector);
            NominalInsulationPercentage percentage = null;
            foreach (Wall wall in componentsByType)
            {
                decimal rValueKey = decimal.Round(Conversions.RSItoR(wall.Construction.Type.NominalInsulation), (int) decimalPlaceForInsulation);
                decimal totalAreaPercentage = (100M * wall.Measurements.Area) / num;
                if (!enumerateAll)
                {
                    percentage = (from nip in groups
                        where nip.NominalInsulation == rValueKey
                        select nip).FirstOrDefault<NominalInsulationPercentage>();
                }
                if (percentage == null)
                {
                    groups.Add(new NominalInsulationPercentage(rValueKey, totalAreaPercentage));
                }
                else
                {
                    percentage.TotalAreaPercentage += totalAreaPercentage;
                }
            }
            AdjustPercentages(decimalPlaceForPercentages, groups, null);
            return BuildNominalInsulationString(groups);
        }

        public static bool HasErrors() => 
            Errors.Count > 0;

        public bool HasUpgrades() => 
            (this.EnergyUpgrades != null) ? (this.EnergyUpgrades.Components.Count > 0) : false;

        public bool IsSame(HouseFile otherHouse) => 
            ReferenceEquals(this, otherHouse);

        public bool Load(HouseFile dataToLoad)
        {
            if (dataToLoad == null)
            {
                return false;
            }
            this.Clear();
            try
            {
                this.Language = LanguageOptions.Clone(dataToLoad.Language);
                this.UiUnits = dataToLoad.UiUnits;
                this.Version = new HouseFileVersion(dataToLoad.Version);
                this.Application = new ca.nrcan.gc.OEE.HouseFileLibrary.Application(dataToLoad.Application);
                this.Program = (dataToLoad.Program == null) ? null : new XElement(dataToLoad.Program);
                this.ProgramInformation = dataToLoad.ProgramInformation.Clone();
                this.House = dataToLoad.House.Clone();
                if (this.House.NaturalAirInfiltration != null)
                {
                    this.House.NaturalAirInfiltration.SetDefaults();
                }
                this.UpdateReferences();
                this.Codes = dataToLoad.Codes?.Clone();
                this.EnergyUpgrades = dataToLoad.EnergyUpgrades?.Clone();
                this.FuelCosts = dataToLoad.FuelCosts.Clone();
                if (dataToLoad.AllResults == null)
                {
                    this.AllResults = null;
                }
                else
                {
                    this.AllResults = new List<Results>();
                    foreach (Results results in dataToLoad.AllResults)
                    {
                        this.AllResults.Add(results.Clone());
                    }
                }
            }
            catch (Exception exception)
            {
                Errors.Add(HouseFileError.CreateErrorFromException(exception));
                return false;
            }
            foreach (ISerializationEvents events in this.HouseComponents)
            {
                if (events != null)
                {
                    events.OnDeserialization();
                }
            }
            if (this.EnergyUpgrades != null)
            {
                foreach (ISerializationEvents events2 in this.EnergyUpgrades.Components)
                {
                    if (events2 != null)
                    {
                        events2.OnDeserialization();
                    }
                }
            }
            if (this.Codes != null)
            {
                this.Codes.DereferenceAll(this);
            }
            return true;
        }

        public bool Load(Stream houseFileStream)
        {
            try
            {
                return this.Load(XDocument.Load(houseFileStream), null);
            }
            catch (Exception exception)
            {
                Errors.Add(HouseFileError.CreateErrorFromException(exception));
                return false;
            }
        }

        public bool Load(XDocument houseFileXml, string xsdUri = null)
        {
            try
            {
                bool flag = true;
                if (!string.IsNullOrWhiteSpace(xsdUri) && System.IO.File.Exists(xsdUri))
                {
                    flag = ValidateAgainstSchema(houseFileXml, xsdUri);
                }
                if (flag)
                {
                    var tmp= Serializer.Deserialize(houseFileXml.CreateReader());
                    HouseFile dataToLoad = (HouseFile) tmp;
                    flag = this.Load(dataToLoad);
                }
                if (flag)
                {
                    this.Program = (houseFileXml.Root.Element("Program") == null) ? null : new XElement(houseFileXml.Root.Element("Program"));
                }
                XElement element = houseFileXml.Root.Element("AllResults");
                if (flag && ((element != null) && ((this.AllResults != null) && (this.AllResults.Count > 0))))
                {
                    int num = 0;
                    foreach (XElement element2 in element.Elements("Results"))
                    {
                        if (element2.Attribute("sha256") == null)
                        {
                            this.AllResults[num].IsChecksumVerified = false;
                            string[] textArray3 = new string[] { "Missing checksum on Results #", (num + 1).ToString(), "(Label: ", this.AllResults[num].Labels.English, ")" };
                            string[] textArray4 = new string[] { "Le checksum manque sur Results #", (num + 1).ToString(), "(Label: ", this.AllResults[num].Labels.English, ")" };
                            Errors.Add(new HouseFileError(string.Concat(textArray3), string.Concat(textArray4)));
                        }
                        else
                        {
                            this.AllResults[num].IsChecksumVerified = element2.VerifySha256(element2.Attribute("sha256").Value);
                            if (!this.AllResults[num].IsChecksumVerified)
                            {
                                string[] textArray1 = new string[] { "Checksum error on Results #", (num + 1).ToString(), "(Label: ", this.AllResults[num].Labels.English, ")" };
                                string[] textArray2 = new string[] { "Erreur de checksum sur Results #", (num + 1).ToString(), "(Label: ", this.AllResults[num].Labels.English, ")" };
                                Errors.Add(new HouseFileError(string.Concat(textArray1), string.Concat(textArray2)));
                            }
                        }
                        num++;
                    }
                }
                return flag;
            }
            catch (Exception exception)
            {
                Errors.Add(HouseFileError.CreateErrorFromException(exception));
                return false;
            }
        }

        public bool LoadFromString(string houseFileXml)
        {
            try
            {
                return this.Load(XDocument.Parse(houseFileXml), null);
            }
            catch (Exception exception)
            {
                Errors.Add(HouseFileError.CreateErrorFromException(exception));
                return false;
            }
        }

        public bool LoadFromUri(string houseFileUri, string xsdUri = null)
        {
            try
            {
                return this.Load(XDocument.Load(houseFileUri), xsdUri);
            }
            catch (Exception exception)
            {
                Errors.Add(HouseFileError.CreateErrorFromException(exception));
                return false;
            }
        }

        public void MoveComponentToNewParent(BaseComponent toMove, BaseComponent newParent)
        {
            if (toMove.Parent != null)
            {
                toMove.Parent.Components.Remove(toMove);
            }
            toMove.Parent = newParent;
            if (newParent != null)
            {
                newParent.Components.Add(toMove);
            }
        }

        public void RemoveComponent(BaseComponent toRemove)
        {
            if (toRemove != null)
            {
                if (this.EnergyUpgrades != null)
                {
                    Component upgradeToRemove = (from c in this.EnergyUpgrades.Components
                        where c.Id == toRemove.Id
                        select c).FirstOrDefault<Component>();
                    if (upgradeToRemove != null)
                    {
                        this.RemoveUpgrade(upgradeToRemove);
                    }
                }
                if (toRemove.Components != null)
                {
                    while (toRemove.Components.Count > 0)
                    {
                        this.RemoveComponent(toRemove.Components[0]);
                    }
                }
                if (toRemove.Parent != null)
                {
                    toRemove.Parent.Components.Remove(toRemove);
                }
            }
        }

        public void RemoveComponent(uint id)
        {
            this.RemoveComponent(this.GetComponentById(id));
        }

        public void RemoveUpgrade(Component upgradeToRemove)
        {
            if (upgradeToRemove != null)
            {
                if (upgradeToRemove.Components != null)
                {
                    while (upgradeToRemove.Components.Count > 0)
                    {
                        this.RemoveComponent(upgradeToRemove.Components[0]);
                    }
                }
                this.EnergyUpgrades.Components.Remove(upgradeToRemove);
            }
        }

        public void RemoveUpgrade(uint id)
        {
            this.RemoveUpgrade(this.GetUpgradeById(id));
        }

        public void Reset()
        {
            this.Clear();
            this.SetDefaults();
        }

        public bool Save() => 
            this.Save(this.House.Labels.English + ".h2k");

        public bool Save(string filename)
        {
            XmlTextWriter writer = new XmlTextWriter(filename, Encoding.UTF8) {
                Formatting = Formatting.Indented
            };
            try
            {
                this.ToXml().WriteTo(writer);
            }
            catch (Exception exception)
            {
                Errors.Add(HouseFileError.CreateErrorFromException(exception));
                return false;
            }
            finally
            {
                writer.Close();
            }
            return true;
        }

        public void SaveComponent(BaseComponent toSave, BaseComponent parent = null)
        {
            if ((toSave.Id == 0) && !(toSave is ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.House))
            {
                toSave.Id = this.NextId;
            }
            else
            {
                BaseComponent componentById = this.GetComponentById(toSave.Id);
                this.RemoveComponent(componentById);
            }
            if (parent != null)
            {
                toSave.Parent = parent;
                toSave.Parent.Components = new List<BaseComponent>();
                toSave.Parent.Components.Add(toSave);
            }
        }

        public void SaveUpgrade(Component toSave)
        {
            if (toSave.Id != 0)
            {
                this.RemoveUpgrade(this.GetUpgradeById(toSave.Id));
                this.EnergyUpgrades.Components.Add(toSave);
            }
        }

        public void SetDefaults()
        {
            this.Version = new HouseFileVersion(1, 3);
            this.Language = LanguageOptions.English;
        }

        public override string ToString() => 
            Utf8Helper.ToStringWithDeclaration(this.ToXml());

        public XDocument ToXml()
        {
            foreach (ISerializationEvents events in this.HouseComponents)
            {
                if (events != null)
                {
                    events.OnPreSerialization();
                }
            }
            if (this.EnergyUpgrades != null)
            {
                foreach (ISerializationEvents events2 in this.EnergyUpgrades.Components)
                {
                    if (events2 != null)
                    {
                        events2.OnPreSerialization();
                    }
                }
            }
            this.Codes = new ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Codes();
            this.Codes.RebuildAll(this);
            if (this.Codes.AllCodes.Count == 0)
            {
                this.Codes = null;
            }
            XDocument document = new XDocument(new XDeclaration("1.0", "UTF-8", null), System.Array.Empty<object>());
            using (XmlWriter writer = document.CreateWriter())
            {
                Serializer.Serialize(writer, this);
            }
            foreach (ISerializationEvents events3 in this.HouseComponents)
            {
                if (events3 != null)
                {
                    events3.OnPostSerialization();
                }
            }
            if (this.EnergyUpgrades != null)
            {
                foreach (ISerializationEvents events4 in this.EnergyUpgrades.Components)
                {
                    if (events4 != null)
                    {
                        events4.OnPostSerialization();
                    }
                }
            }
            if (document.Root.Element("AllResults") != null)
            {
                foreach (XElement element in document.Root.Element("AllResults").Elements("Results"))
                {
                    string str = element.CalculateSha256();
                    if (element.Attribute("sha256") == null)
                    {
                        element.Add(new XAttribute("sha256", str));
                        continue;
                    }
                    element.Attribute("sha256").Value = str;
                }
            }
            if (this.Program != null)
            {
                document.Root.Add(new XElement(this.Program));
            }
            return document;
        }

        private void UpdateReferences()
        {
            this.UpdateReferences(this.House);
        }

        private void UpdateReferences(BaseComponent houseComponent)
        {
            if (houseComponent != null)
            {
                houseComponent.HouseFile = this;
                if (houseComponent is ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.House)
                {
                    ((ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.House) houseComponent).BaseLoads.Parent = houseComponent;
                    ((ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.House) houseComponent).HeatingCooling.Parent = houseComponent;
                    ((ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.House) houseComponent).Generation.Parent = houseComponent;
                    ((ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.House) houseComponent).NaturalAirInfiltration.Parent = houseComponent;
                    ((ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.House) houseComponent).Temperatures.Parent = houseComponent;
                    if (((ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.House) houseComponent).Ventilation != null)
                    {
                        ((ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.House) houseComponent).Ventilation.Parent = houseComponent;
                    }
                }
                foreach (Component component in houseComponent.Components)
                {
                    component.Parent = houseComponent;
                    this.UpdateReferences(component);
                }
            }
        }

        public static bool ValidateAgainstSchema(string xmlUri, string xsdUri) => 
            ValidateAgainstSchema(XDocument.Load(xmlUri), xsdUri);

        public static bool ValidateAgainstSchema(XDocument xmlFile, string xsdUri)
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", xsdUri);
            bool valid = true;
            xmlFile.Validate(schemas, delegate (object o, ValidationEventArgs e) {
                Errors.Add(new HouseFileError(e.Message, e.Message));
                valid = false;
            });
            return valid;
        }

        public static bool VerifySha256(XElement xmlToChecksum, string hash) => 
            xmlToChecksum.VerifySha256(hash);

        public static T XmlDeserializer<T>(XDocument serialized)
        {
            T local;
            if (serialized == null)
            {
                return default(T);
            }
            XmlReader xmlReader = serialized.CreateReader();
            try
            {
                local = (T) new System.Xml.Serialization.XmlSerializer(typeof(T)).Deserialize(xmlReader);
            }
            catch (Exception exception)
            {
                Errors.Add(HouseFileError.CreateErrorFromException(exception));
                local = default(T);
            }
            finally
            {
                xmlReader.Close();
            }
            return local;
        }

        public static T XmlDeserializer<T>(XElement serialized)
        {
            object[] content = new object[] { serialized };
            return XmlDeserializer<T>(new XDocument(new XDeclaration("1.0", "utf-8", "yes"), content));
        }

        public static XElement XmlSerializer<T>(T data)
        {
            XDocument document = new XDocument();
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            XmlWriter xmlWriter = document.CreateWriter();
            try
            {
                serializer.Serialize(xmlWriter, data);
            }
            finally
            {
                xmlWriter.Close();
            }
            return document.Root;
        }

        public static void XmlSerializer<T>(string outputFilename, T data)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            FileStream stream = new FileStream(outputFilename, FileMode.Create, FileAccess.Write);
            try
            {
                serializer.Serialize((Stream) stream, data);
            }
            finally
            {
                stream.Close();
            }
        }

        [XmlAttribute("xml:lang")]
        public string XmlLang
        {
            get => 
                (string) this.Language;
            set => 
                this.Language = LanguageOptions.FromLanguageCode(value);
        }

        [XmlIgnore]
        public List<BaseComponent> HouseComponents
        {
            get
            {
                List<BaseComponent> list = new List<BaseComponent>();
                AddAllComponentsToList(this.House, list);
                list.Add(this.House.BaseLoads);
                list.Add(this.House.Generation);
                list.Add(this.House.HeatingCooling);
                list.Add(this.House.NaturalAirInfiltration);
                list.Add(this.House.Temperatures);
                if (this.House.Ventilation != null)
                {
                    list.Add(this.House.Ventilation);
                }
                return list;
            }
        }

        public uint NextId
        {
            get
            {
                List<BaseComponent> houseComponents = this.HouseComponents;
                if (houseComponents.Count == 0)
                {
                    return 1;
                }
                Func<BaseComponent, uint> selector = _c._9__18_0;
                if (_c._9__18_0 == null)
                {
                    Func<BaseComponent, uint> local1 = _c._9__18_0;
                    selector = _c._9__18_0 = c => c.Id;
                }
                return (houseComponents.Select<BaseComponent, uint>(selector).Max<uint>() + 1);
            }
        }

        [XmlIgnore]
        public static HouseFileVersion LibraryVersion =>
            new HouseFileVersion(typeof(HouseFile).Assembly.GetName().Version);

        [XmlIgnore]
        public static HouseFileSerializer Serializer
        {
            get
            {
                cachedSerializer = new HouseFileSerializer();
                return cachedSerializer;
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class _c
        {
            public static readonly HouseFile._c _9 = new HouseFile._c();
            public static Func<BaseComponent, uint> _9__18_0;
            public static Func<Ceiling, uint> _9__48_0;
            public static Func<Ceiling, decimal> _9__48_1;
            public static Func<Ceiling, uint> _9__50_0;
            public static Func<Ceiling, bool> _9__50_1;
            public static Func<Floor, uint> _9__51_0;
            public static Func<Floor, decimal> _9__51_1;
            public static Func<Floor, uint> _9__52_0;
            public static Func<Foundation, uint> _9__53_0;
            public static Func<Foundation, bool> _9__53_1;
            public static Func<Foundation, uint> _9__53_2;
            public static Func<FloorHeader, uint> _9__54_0;
            public static Func<FloorHeader, bool> _9__54_1;
            public static Func<FloorHeader, decimal> _9__54_2;
            public static Func<Foundation, uint> _9__56_0;
            public static Func<Foundation, bool> _9__56_1;
            public static Func<Foundation, uint> _9__56_2;
            public static Func<Foundation, bool> _9__56_3;
            public static Func<Crawlspace, decimal> _9__56_5;
            public static Func<Foundation, uint> _9__57_0;
            public static Func<Foundation, bool> _9__57_1;
            public static Func<Foundation, uint> _9__57_2;
            public static Func<Foundation, bool> _9__57_3;
            public static Func<Wall, uint> _9__58_0;
            public static Func<Wall, decimal> _9__58_1;

            //internal uint <get_NextId>b__18_0(BaseComponent c) => 
            //    c.Id;

            //internal uint <GetCeilingNominalInsulations>b__48_0(Ceiling c) => 
            //    c.Id;

            //internal decimal <GetCeilingNominalInsulations>b__48_1(Ceiling f) => 
            //    f.Measurements.Area;

            //internal uint <GetCeilingTypes>b__50_0(Ceiling c) => 
            //    c.Id;

            //internal bool <GetCeilingTypes>b__50_1(Ceiling c) => 
            //    (c.Construction.Type == CeilingTypes.Cathedral) || (c.Construction.Type == CeilingTypes.Flat);

            //internal uint <GetExposedFloorArea>b__52_0(Floor f) => 
            //    f.Id;

            //internal uint <GetExteriorFoundationInsulations>b__53_0(Foundation f) => 
            //    f.Id;

            //internal bool <GetExteriorFoundationInsulations>b__53_1(Foundation f) => 
            //    (f is Basement) || (f is Walkout);

            //internal uint <GetExteriorFoundationInsulations>b__53_2(Foundation w) => 
            //    w.Id;

            //internal uint <GetFloorNominalInsulations>b__51_0(Floor f) => 
            //    f.Id;

            //internal decimal <GetFloorNominalInsulations>b__51_1(Floor f) => 
            //    f.Measurements.Area;

            //internal uint <GetFoundationDefinitions>b__56_0(Foundation f) => 
            //    f.Id;

            //internal bool <GetFoundationDefinitions>b__56_1(Foundation f) => 
            //    (f is Basement) || (f is Walkout);

            //internal uint <GetFoundationDefinitions>b__56_2(Foundation f) => 
            //    f.Id;

            //internal bool <GetFoundationDefinitions>b__56_3(Foundation f) => 
            //    f is Crawlspace;

            //internal decimal <GetFoundationDefinitions>b__56_5(Crawlspace c) => 
            //    c.Floor.Measurements.FloorArea;

            //internal uint <GetFoundationFloorHeaderNominalInsulations>b__54_0(FloorHeader f) => 
            //    f.Id;

            //internal bool <GetFoundationFloorHeaderNominalInsulations>b__54_1(FloorHeader fh) => 
            //    fh.Parent is Foundation;

            //internal decimal <GetFoundationFloorHeaderNominalInsulations>b__54_2(FloorHeader fh) => 
            //    fh.Measurements.Area;

            //internal uint <GetFoundationTypes>b__57_0(Foundation f) => 
            //    f.Id;

            //internal bool <GetFoundationTypes>b__57_1(Foundation f) => 
            //    (f is Basement) || (f is Walkout);

            //internal uint <GetFoundationTypes>b__57_2(Foundation f) => 
            //    f.Id;

            //internal bool <GetFoundationTypes>b__57_3(Foundation f) => 
            //    f is Crawlspace;

            //internal uint <GetWallNominalInsulations>b__58_0(Wall w) => 
            //    w.Id;

            //internal decimal <GetWallNominalInsulations>b__58_1(Wall w) => 
            //    w.Measurements.Area;
        }

        [Serializable, CompilerGenerated]
        private sealed class _c__26<T>
        {
            public static readonly HouseFile._c__26<T> _9;
            public static Func<BaseComponent, bool> _9__26_0;

            static _c__26()
            {
                HouseFile._c__26<T>._9 = new HouseFile._c__26<T>();
            }

            //internal bool <GetComponentsByType>b__26_0(BaseComponent component) => 
            //    component is T;

            public _c__26()
            {
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class _c__29<T>
        {
            public static readonly HouseFile._c__29<T> _9;
            public static Func<Component, bool> _9__29_0;

            static _c__29()
            {
                HouseFile._c__29<T>._9 = new HouseFile._c__29<T>();
            }

            //internal bool <GetUpgradesByType>b__29_0(Component component) => 
            //    component is T;
        }

        public class NominalInsulationPercentage
        {
            public decimal NominalInsulation;
            public decimal TotalAreaPercentage;

            public NominalInsulationPercentage(decimal nominalInsulation, decimal totalAreaPercentage)
            {
                this.NominalInsulation = nominalInsulation;
                this.TotalAreaPercentage = totalAreaPercentage;
            }
        }
    }
}

