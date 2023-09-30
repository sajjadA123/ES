namespace ca.nrcan.gc.OEE.HouseFileLibrary.WeatherLibraryHelpers
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using H2kXml.HouseFileLibrary;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Xml.Linq;

    public class WeatherLibrary
    {
        private static string weatherFolder;
        private uint numberOfRegions;
        private uint numberOfLocations;
        private List<uint> indices = new List<uint>();
        public static string ParsingError;
        private uint lineCount;
        private string weatherFile = string.Empty;
        public List<WeatherLocation> Locations = new List<WeatherLocation>();
        public List<WeatherRegion> Regions = new List<WeatherRegion>();

        private List<string> CutUpString(int desiredLengths, string toCut)
        {
            if (string.IsNullOrWhiteSpace(toCut))
            {
                return null;
            }
            List<string> list = new List<string>();
            for (int i = 0; i < toCut.Length; i += desiredLengths)
            {
                string str = ((i + desiredLengths) > toCut.Length) ? toCut.Substring(i).Trim() : toCut.Substring(i, desiredLengths).Trim();
                if (!string.IsNullOrWhiteSpace(str))
                {
                    list.Add(str);
                }
            }
            return list;
        }

        private List<string> GetFields(StringReader reader, uint fieldSize, uint fieldsNeeded)
        {
            if ((reader == null) || ((fieldSize == 0) || (fieldsNeeded == 0)))
            {
                this.SetParsingError("GetFields", "Nothing to do");
                return null;
            }
            List<string> list = new List<string>();
            List<string> collection = new List<string>();
            while (list.Count < fieldsNeeded)
            {
                this.lineCount++;
                string str = reader.ReadLine();
                if ((str == null) || string.IsNullOrWhiteSpace(str))
                {
                    this.SetParsingError("GetFields", $"Ran out of data while trying to read {fieldsNeeded} fields");
                    return null;
                }
                collection = this.CutUpString((int) fieldSize, str);
                if (collection.Count == 0)
                {
                    this.SetParsingError("GetFields", "Failed to cut up the line");
                    return null;
                }
                list.AddRange(collection);
            }
            return list;
        }

        public WeatherLocation GetLocation(uint code)
        {
            WeatherLocation source = (from wr in this.Locations
                where wr.Code == code
                select wr).FirstOrDefault<WeatherLocation>();
            return ((source != null) ? new WeatherLocation(source) : null);
        }

        public WeatherLocation GetLocationFromXml(XElement location)
        {
            if ((location == null) || ((location.Attribute("code") == null) || string.IsNullOrWhiteSpace(location.Attribute("code").Value)))
            {
                return null;
            }
            uint result = 0;
            return (uint.TryParse(location.Attribute("code").Value, out result) ? this.GetLocation(result) : null);
        }

        public List<WeatherLocation> GetLocationsByRegion(uint code)
        {
            List<WeatherLocation> source = (from location in this.Locations
                where location.region.Code == code
                select location).ToList<WeatherLocation>();
            if (source.Count == 0)
            {
                return source;
            }
            Func<WeatherLocation, WeatherLocation> selector = _c._9__23_1;
            if (_c._9__23_1 == null)
            {
                Func<WeatherLocation, WeatherLocation> local1 = _c._9__23_1;
                selector = _c._9__23_1 = location => new WeatherLocation(location);
            }
            return source.Select<WeatherLocation, WeatherLocation>(selector).ToList<WeatherLocation>();
        }

        public WeatherRegion GetRegion(uint code)
        {
            WeatherRegion source = (from wr in this.Regions
                where wr.Code == code
                select wr).FirstOrDefault<WeatherRegion>();
            return ((source != null) ? new WeatherRegion(source) : null);
        }

        public WeatherRegion GetRegionFromXml(XElement region)
        {
            if ((region == null) || ((region.Attribute("code") == null) || string.IsNullOrWhiteSpace(region.Attribute("code").Value)))
            {
                return null;
            }
            uint result = 0;
            return (uint.TryParse(region.Attribute("code").Value, out result) ? this.GetRegion(result) : null);
        }

        public static WeatherLibrary Load(string path)
        {
            string str = File.Exists(path) ? path : (DefaultFolder + path);
            if (!string.IsNullOrWhiteSpace(str))
            {
                try
                {
                    WeatherLibrary library = new WeatherLibrary {
                        weatherFile = Path.GetFileName(path)
                    };
                    if (library.ParseLibrary(File.ReadAllText(str, Encoding.Default)))
                    {
                        return library;
                    }
                }
                catch (Exception exception)
                {
                    HouseFile.Errors.Add(HouseFileError.CreateErrorFromException(exception));
                }
            }
            return null;
        }

        public XElement LocationToXml(uint code)
        {
            WeatherLocation location = this.GetLocation(code);
            return location?.Xml;
        }

        public static WeatherLibrary Parse(string weatherLibrary)
        {
            WeatherLibrary library1 = new WeatherLibrary();
            library1.ParseLibrary(weatherLibrary);
            return library1;
        }

        private bool ParseHeader(StringReader reader)
        {
            string str = reader.ReadLine();
            this.lineCount++;
            if (str.Length < 10)
            {
                this.SetParsingError("ParseHeader", "Header not long enough");
                return false;
            }
            if (!uint.TryParse(str.Substring(0, 5), out this.numberOfLocations))
            {
                this.SetParsingError("ParseHeader", "Unable to parse the number of weather regions");
                return false;
            }
            if (uint.TryParse(str.Substring(5, 5), out this.numberOfRegions))
            {
                return true;
            }
            this.SetParsingError("ParseHeader", "Unable to parse the number of regions");
            return false;
        }

        private bool ParseIndices(StringReader reader)
        {
            bool flag;
            this.indices.Clear();
            if (this.numberOfLocations == 0)
            {
                return true;
            }
            List<string> list = this.GetFields(reader, 5, this.numberOfLocations);
            if (list == null)
            {
                return false;
            }
            uint result = 0;
            using (List<string>.Enumerator enumerator = list.GetEnumerator())
            {
                while (true)
                {
                    if (enumerator.MoveNext())
                    {
                        string current = enumerator.Current;
                        if (!uint.TryParse(current, out result))
                        {
                            this.SetParsingError("ParseIndices", $"Invalid index: {current}");
                            flag = false;
                        }
                        else
                        {
                            if ((result != 0) && (result <= this.Regions.Count))
                            {
                                this.indices.Add(result);
                                continue;
                            }
                            this.SetParsingError("ParseIndices", $"Index out of range (max: {this.Regions.Count}): {result}");
                            flag = false;
                        }
                    }
                    else
                    {
                        return true;
                    }
                    break;
                }
            }
            return flag;
        }

        private bool ParseLibrary(string weatherLibrary)
        {
            if (string.IsNullOrWhiteSpace(weatherLibrary))
            {
                return false;
            }
            this.Regions.Clear();
            this.lineCount = 0;
            using (StringReader reader = new StringReader(weatherLibrary))
            {
                bool flag;
                if (this.ParseHeader(reader))
                {
                    if (this.ParseRegions(reader, false))
                    {
                        if (this.ParseIndices(reader))
                        {
                            if (this.ParseLocations(reader, false))
                            {
                                if (this.ParseRegions(reader, true))
                                {
                                    this.ParseLocations(reader, true);
                                }
                                goto TR_0009;
                            }
                            else
                            {
                                flag = false;
                            }
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                }
                else
                {
                    flag = false;
                }
                return flag;
            }
        TR_0009:
            return true;
        }

        private bool ParseLocations(StringReader reader, bool inFrench = false)
        {
            if (this.numberOfLocations == 0)
            {
                return true;
            }
            List<string> list = this.GetFields(reader, 0x20, this.numberOfLocations);
            if (list == null)
            {
                return false;
            }
            CultureInfo culture = new CultureInfo("fr-CA");
            uint locationCount = 1;
            int num = 0;
            int num2 = 0;
            using (List<string>.Enumerator enumerator = list.GetEnumerator())
            {
                while (true)
                {
                    while (true)
                    {
                        if (enumerator.MoveNext())
                        {
                            string current = enumerator.Current;
                            num2 = (int)(this.indices[num++] - 1);
                            if ((num2 < 0) || (num2 >= this.Regions.Count))
                            {
                                this.SetParsingError("ParseWeatherRegions", $"Index out of range (max: {this.Regions.Count}): {num2}");
                                return false;
                            }
                            else
                            {
                                Func<WeatherLocation, bool> _9__0=null;
                                string englishName = current.Replace('_', ' ').ToTitle(culture);
                                if (englishName == "Saint John'S")
                                {
                                    englishName = "St. John's";
                                }
                                if (!inFrench)
                                {
                                    WeatherLocation item = new WeatherLocation(this.Regions[num2], locationCount, englishName);
                                    this.Locations.Add(item);
                                    break;
                                }
                                Func<WeatherLocation, bool> predicate = _9__0;
                                if (_9__0 == null)
                                {
                                    Func<WeatherLocation, bool> local1 = _9__0;
                                    predicate = _9__0 = location => location.Code == locationCount;
                                }
                                WeatherLocation location2 = this.Locations.Where<WeatherLocation>(predicate).FirstOrDefault<WeatherLocation>();
                                if (location2 != null)
                                {
                                    uint num3 = PrivateImplementationDetails.ComputeStringHash(englishName);
                                    if (num3 <= 0x83e978e5)
                                    {
                                        if (num3 <= 0x36b7a1d6)
                                        {
                                            if (num3 != 0x354191dd)
                                            {
                                                if ((num3 == 0x36b7a1d6) && (englishName == "Washington, DC"))
                                                {
                                                    englishName = "Washington, D.C.";
                                                }
                                            }
                                            else if (englishName == "La Grande Rivi\x00e9re")
                                            {
                                                englishName = "La Grande Rivi\x00e8re";
                                            }
                                        }
                                        else if (num3 == 0x36bc9c9d)
                                        {
                                            if (englishName == "Miami, Florida")
                                            {
                                                englishName = "Miami, Floride";
                                            }
                                        }
                                        else if (num3 != 0x5f7c0c57)
                                        {
                                            if ((num3 == 0x83e978e5) && (englishName == "St-Hubert"))
                                            {
                                                englishName = "Saint-Hubert";
                                            }
                                        }
                                        else if (englishName == "Denver, CO")
                                        {
                                            englishName = "Denver, Colorado";
                                        }
                                    }
                                    else if (num3 <= 0x90641c37)
                                    {
                                        if (num3 != 0x89b5974d)
                                        {
                                            if ((num3 == 0x90641c37) && (englishName == "Bismarck, ND"))
                                            {
                                                englishName = "Bismark, North Dakota";
                                            }
                                        }
                                        else if (englishName == "Sept-Iles")
                                        {
                                            englishName = "Sept-\x00celes";
                                        }
                                    }
                                    else if (num3 == 0x94af0b0d)
                                    {
                                        if (englishName == "Ste-Agathe-Des-Monts")
                                        {
                                            englishName = "Sainte-Agathe-des-Monts";
                                        }
                                    }
                                    else if (num3 != 0x97feccbb)
                                    {
                                        if ((num3 == 0xf62f6dff) && (englishName == "Saint-Jean"))
                                        {
                                            englishName = "Saint John";
                                        }
                                    }
                                    else if (englishName == "Val-D'Or")
                                    {
                                        englishName = "Val d'Or";
                                    }
                                    location2.French = englishName;
                                    break;
                                }
                                this.SetParsingError("ParseWeatherRegions", $"Unable to match up French weather region to English with code: {locationCount}");
                                return false;
                            }
                        }
                        else
                        {
                            goto TR_0003;
                        }
                        break;
                    }
                    locationCount++;
                }
            }
        TR_0003:
            return true;
        }

        private bool ParseRegions(StringReader reader, bool inFrench = false)
        {
            bool flag;
            if (this.numberOfRegions == 0)
            {
                return true;
            }
            List<string> list = this.GetFields(reader, 0x20, this.numberOfRegions);
            if (list == null)
            {
                return false;
            }
            CultureInfo culture = new CultureInfo("fr-CA");
            uint regionCount = 1;
            using (List<string>.Enumerator enumerator = list.GetEnumerator())
            {
                while (true)
                {
                    if (enumerator.MoveNext())
                    {
                        string nameFromLibrary = enumerator.Current.ToTitle(culture);
                        if (inFrench)
                        {
                            Func<WeatherRegion, bool> _9__0=null;
                            Func<WeatherRegion, bool> predicate = _9__0;
                            if (_9__0 == null)
                            {
                                Func<WeatherRegion, bool> local1 = _9__0;
                                predicate = _9__0 = region => region.Code == regionCount;
                            }
                            WeatherRegion region2 = this.Regions.Where<WeatherRegion>(predicate).FirstOrDefault<WeatherRegion>();
                            if (region2 == null)
                            {
                                this.SetParsingError("ParseWeatherRegions", $"Unable to match up French weather region to English with code: {regionCount}");
                                flag = false;
                                break;
                            }
                            if (region2.English == region2.French)
                            {
                                region2.French = nameFromLibrary;
                            }
                            regionCount++;
                            continue;
                        }
                        WeatherRegion item = new WeatherRegion(this, regionCount, nameFromLibrary);
                        if (item != null)
                        {
                            regionCount++;
                            this.Regions.Add(item);
                            continue;
                        }
                        this.SetParsingError("ParseRegions", $"Unknown region: {nameFromLibrary}");
                        flag = false;
                    }
                    else
                    {
                        return true;
                    }
                    break;
                }
            }
            return flag;
        }

        public XElement RegionToXml(uint code)
        {
            WeatherRegion region = this.GetRegion(code);
            return region?.Xml;
        }

        public bool SaveAsText(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (WeatherRegion region in this.Regions)
                    {
                        writer.WriteLine();
                        writer.WriteLine(region.English + "/" + region.French + " :");
                        foreach (WeatherLocation location in this.GetLocationsByRegion(region.Code))
                        {
                            string str = "\t\t\t";
                            if (location.English.Length > 15)
                            {
                                str = "\t";
                            }
                            else if (location.English.Length > 7)
                            {
                                str = "\t\t";
                            }
                            writer.WriteLine("\t" + location.English + str + location.French);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                HouseFile.Errors.Add(HouseFileError.CreateErrorFromException(exception));
                return false;
            }
            return true;
        }

        private void SetParsingError(string caller, string message)
        {
            ParsingError = $"{caller} [line {this.lineCount} of {this.weatherFile}]: {message}";
        }

        public static string DefaultFolder
        {
            get => 
                weatherFolder;
            set
            {
                if (Directory.Exists(value))
                {
                    weatherFolder = Path.GetFullPath(value) + Path.DirectorySeparatorChar.ToString();
                }
            }
        }

        public string FileName =>
            this.weatherFile;

        [Serializable, CompilerGenerated]
        private sealed class _c
        {
            public static readonly WeatherLibrary._c _9 = new WeatherLibrary._c();
            public static Func<WeatherLocation, WeatherLocation> _9__23_1;

            internal WeatherLocation GetLocationsByRegionb__23_1(WeatherLocation location) => 
                new WeatherLocation(location);
        }
    }
}

