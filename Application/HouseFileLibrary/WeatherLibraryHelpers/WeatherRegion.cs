namespace ca.nrcan.gc.OEE.HouseFileLibrary.WeatherLibraryHelpers
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using H2kXml.HouseFileLibrary;
    using System;
    using System.Collections.Generic;
    using System.Xml.Linq;

    public class WeatherRegion
    {
        private WeatherLibrary library;
        private uint code;
        public string English;
        public string French;

        private WeatherRegion()
        {
            this.English = string.Empty;
            this.French = string.Empty;
        }

        public WeatherRegion(WeatherRegion source)
        {
            this.English = string.Empty;
            this.French = string.Empty;
            this.code = source.code;
            this.English = source.English;
            this.French = source.French;
            this.library = source.library;
        }

        public WeatherRegion(WeatherLibrary library, uint code, string nameFromLibrary)
        {
            this.English = string.Empty;
            this.French = string.Empty;
            this.library = library;
            this.code = code;
            ProvinceOrTerritory? canadianRegionByLibraryName = this.GetCanadianRegionByLibraryName(nameFromLibrary);
            if (canadianRegionByLibraryName != null)
            {
                this.English = canadianRegionByLibraryName.Value.English;
                this.French = canadianRegionByLibraryName.Value.French;
            }
            else
            {
                this.English = nameFromLibrary;
                this.French = nameFromLibrary;
            }
        }

        private ProvinceOrTerritory? GetCanadianRegionByLibraryName(string libraryName)
        {
            ProvinceOrTerritory? nullable = null;
            string s = libraryName.Trim().ToUpperInvariant();
            uint num = PrivateImplementationDetails.ComputeStringHash(s);
            if (num > 0x490e4723)
            {
                if (num > 0x99d1c929)
                {
                    if (num > 0x9cf0e700)
                    {
                        if (num == 0xbea46b0c)
                        {
                            if (s != "PRINCE EDWARD ISLAND")
                            {
                                return nullable;
                            }
                            goto TR_0015;
                        }
                        else if (num == 0xcbd4819a)
                        {
                            if (s == "MANITOBA")
                            {
                                nullable = new ProvinceOrTerritory?(ProvinceOrTerritory.Manitoba);
                            }
                            return nullable;
                        }
                        else if ((num != 0xf9416f11) || (s != "YUKON"))
                        {
                            return nullable;
                        }
                    }
                    else
                    {
                        if (num == 0x9a5e34f7)
                        {
                            if (s == "ONTARIO")
                            {
                                nullable = new ProvinceOrTerritory?(ProvinceOrTerritory.Ontario);
                            }
                        }
                        else if (num != 0x9be2bf82)
                        {
                            if ((num == 0x9cf0e700) && (s == "NUNAVUT"))
                            {
                                nullable = new ProvinceOrTerritory?(ProvinceOrTerritory.Nunavut);
                            }
                        }
                        else if (s == "SASKATCHEWAN")
                        {
                            nullable = new ProvinceOrTerritory?(ProvinceOrTerritory.Saskatchewan);
                        }
                        return nullable;
                    }
                }
                else if (num > 0x6368a9bf)
                {
                    if (num == 0x8f14867a)
                    {
                        if (s == "ALBERTA")
                        {
                            nullable = new ProvinceOrTerritory?(ProvinceOrTerritory.Alberta);
                        }
                        return nullable;
                    }
                    else if (num == 0x93116163)
                    {
                        if (s != "YUKON TERRITORY")
                        {
                            return nullable;
                        }
                    }
                    else
                    {
                        if ((num != 0x99d1c929) || (s != "TERRE-NEUVE"))
                        {
                            return nullable;
                        }
                        goto TR_0006;
                    }
                }
                else
                {
                    if (num == 0x4bc8fce9)
                    {
                        if (s != "NORTHWEST TERRITORIES")
                        {
                            return nullable;
                        }
                    }
                    else if (num == 0x5a5b8c6e)
                    {
                        if (s != "COLOMBIE-BRITANNIQUE")
                        {
                            return nullable;
                        }
                        goto TR_0003;
                    }
                    else if ((num != 0x6368a9bf) || (s != "T.N.-O."))
                    {
                        return nullable;
                    }
                    goto TR_0008;
                }
                goto TR_0010;
            }
            else if (num > 0x249b27f6)
            {
                if (num > 0x35f23ff3)
                {
                    if (num == 0x389ef2c6)
                    {
                        if (s != "NOVA SCOTIA")
                        {
                            return nullable;
                        }
                    }
                    else if (num == 0x3b0d0804)
                    {
                        if (s != "NOUVELLE-\x00c9COSSE")
                        {
                            return nullable;
                        }
                    }
                    else
                    {
                        if ((num != 0x490e4723) || (s != "I.P.\x00c9."))
                        {
                            return nullable;
                        }
                        goto TR_0015;
                    }
                    return new ProvinceOrTerritory?(ProvinceOrTerritory.NovaScotia);
                }
                else
                {
                    if (num == 0x2e846a18)
                    {
                        if (s != "QU\x00c9BEC")
                        {
                            return nullable;
                        }
                        goto TR_0001;
                    }
                    else if (num == 0x33da5513)
                    {
                        if (s != "TERRITOIRE DU YUKON")
                        {
                            return nullable;
                        }
                    }
                    else
                    {
                        if ((num != 0x35f23ff3) || (s != "NEW BRUNSWICK"))
                        {
                            return nullable;
                        }
                        goto TR_000B;
                    }
                    goto TR_0010;
                }
            }
            else
            {
                if (num > 0xa8ba9ac)
                {
                    if (num == 0xf84e521)
                    {
                        if (s != "NOUVEAU-BRUNSWICK")
                        {
                            return nullable;
                        }
                    }
                    else
                    {
                        if (num == 0x150146b5)
                        {
                            if (s != "NORTHWEST TERRITORY")
                            {
                                return nullable;
                            }
                        }
                        else
                        {
                            if ((num != 0x249b27f6) || (s != "NEWFOUNDLAND"))
                            {
                                return nullable;
                            }
                            goto TR_0006;
                        }
                        goto TR_0008;
                    }
                }
                else
                {
                    if (num == 0x5b23a94)
                    {
                        if (s != "BRITISH COLUMBIA")
                        {
                            return nullable;
                        }
                    }
                    else
                    {
                        if ((num != 0xa8ba9ac) || (s != "QUEBEC"))
                        {
                            return nullable;
                        }
                        goto TR_0001;
                    }
                    goto TR_0003;
                }
                goto TR_000B;
            }
            goto TR_0015;
        TR_0001:
            return new ProvinceOrTerritory?(ProvinceOrTerritory.Quebec);
        TR_0003:
            return new ProvinceOrTerritory?(ProvinceOrTerritory.BritishColumbia);
        TR_0006:
            return new ProvinceOrTerritory?(ProvinceOrTerritory.NewfoundlandAndLabrador);
        TR_0008:
            return new ProvinceOrTerritory?(ProvinceOrTerritory.NorthwestTerritories);
        TR_000B:
            return new ProvinceOrTerritory?(ProvinceOrTerritory.NewBrunswick);
        TR_0010:
            return new ProvinceOrTerritory?(ProvinceOrTerritory.Yukon);
        TR_0015:
            return new ProvinceOrTerritory?(ProvinceOrTerritory.PrinceEdwardIsland);
        }

        public uint Code =>
            this.code;

        public XElement Xml
        {
            get
            {
                object[] content = new object[] { new XAttribute("code", this.code), new XElement("English", new XText(this.English)), new XElement("French", new XText(this.French)) };
                return new XElement("Region", content);
            }
        }

        public List<WeatherLocation> WeatherRegions =>
            this.library?.GetLocationsByRegion(this.code);
    }
}

