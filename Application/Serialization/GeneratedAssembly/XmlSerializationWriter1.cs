namespace Microsoft.Xml.Serialization.GeneratedAssembly
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
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
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.SupplementaryHeat;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.AirLeakageReportComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.RoomComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.WallComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.WindowComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.EnergyUpgradesComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.FuelCostsComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using ca.nrcan.gc.OEE.HouseFileLibrary.WeatherLibraryHelpers;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Xml;
    using System.Xml.Serialization;
    using Array = ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents.Array;

    public class XmlSerializationWriter1 : XmlSerializationWriter
    {
        // Methods
        protected override void InitCallbacks()
        {
        }

        private string Write10_unit_classes(unit_classes v)
        {
            string str = null;
            switch (v)
            {
                case unit_classes.METRIC_UNITS:
                    str = "METRIC_UNITS";
                    break;

                case unit_classes.IMP_UNITS:
                    str = "IMP_UNITS";
                    break;

                case unit_classes.US_UNITS:
                    str = "US_UNITS";
                    break;

                default:
                    throw base.CreateInvalidEnumValueException(((long)v).ToString(CultureInfo.InvariantCulture), "ca.nrcan.gc.OEE.HouseFileLibrary.unit_classes");
            }
            return str;
        }

        private void Write100_MultipleSystems(string n, string ns, MultipleSystems o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(MultipleSystems)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("MultipleSystems", "");
                }
                List<MultipleSystemsEquipment> equipmentInformation = o.EquipmentInformation;
                if (equipmentInformation != null)
                {
                    base.WriteStartElement("EquipmentInformation", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= equipmentInformation.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write98_MultipleSystemsEquipment("Equipment", "", equipmentInformation[num], true, false);
                        num++;
                    }
                }
                this.Write99_MultipleSystemsSummary("Summary", "", o.Summary, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write101_RadiantHeatingComponent(string n, string ns, RadiantHeatingComponent o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(RadiantHeatingComponent)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("RadiantHeatingComponent", "");
                }
                base.WriteAttribute("effectiveTemperature", "", XmlConvert.ToString(o.EffectiveTemperature));
                base.WriteAttribute("fractionOfArea", "", XmlConvert.ToString(o.FractionOfArea));
                base.WriteEndElement(o);
            }
        }

        private void Write102_RadiantHeating(string n, string ns, RadiantHeating o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(RadiantHeating)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("RadiantHeating", "");
                }
                this.Write101_RadiantHeatingComponent("AtticCeiling", "", o.AtticCeiling, false, false);
                this.Write101_RadiantHeatingComponent("FlatRoof", "", o.FlatRoof, false, false);
                this.Write101_RadiantHeatingComponent("AboveCrawlspace", "", o.AboveCrawlspace, false, false);
                this.Write101_RadiantHeatingComponent("SlabOnGrade", "", o.SlabOnGrade, false, false);
                this.Write101_RadiantHeatingComponent("AboveBasement", "", o.AboveBasement, false, false);
                this.Write101_RadiantHeatingComponent("Basement", "", o.Basement, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write103_Item(string n, string ns, SupplementaryHeatEquipmentInformation o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SupplementaryHeatEquipmentInformation)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SupplementaryHeatEquipmentInformation", "");
                }
                base.WriteAttribute("csaEpa", "", XmlConvert.ToString(o.CsaEpa));
                base.WriteElementString("Manufacturer", "", o.Manufacturer);
                base.WriteElementString("Model", "", o.Model);
                base.WriteElementString("Description", "", o.Description);
                base.WriteEndElement(o);
            }
        }

        private void Write104_SupplementaryHeatEquipment(string n, string ns, SupplementaryHeatEquipment o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SupplementaryHeatEquipment)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SupplementaryHeatEquipment", "");
                }
                this.Write18_CodeAndText("EnergySource", "", o.EnergySourceXml, false, false);
                this.Write18_CodeAndText("Type", "", o.TypeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write105_Flue(string n, string ns, Flue o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Flue)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Flue", "");
                }
                base.WriteAttribute("isInterior", "", XmlConvert.ToString(o.IsInterior));
                base.WriteAttribute("diameter", "", XmlConvert.ToString(o.Diameter));
                base.WriteAttribute("area", "", XmlConvert.ToString(o.Area));
                this.Write18_CodeAndText("Type", "", o.TypeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write106_Item(string n, string ns, SupplementaryHeatSpecifications o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SupplementaryHeatSpecifications)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SupplementaryHeatSpecifications", "");
                }
                base.WriteAttribute("efficiency", "", XmlConvert.ToString(o.Efficiency));
                base.WriteAttribute("pilotLight", "", XmlConvert.ToString(o.PilotLight));
                base.WriteAttribute("damperClosed", "", XmlConvert.ToString(o.DamperClosed));
                this.Write32_MonthlyData("MonthlyUsage", "", o.MonthlyUsage, false, false);
                this.Write105_Flue("Flue", "", o.Flue, false, false);
                this.Write21_OutputCapacity("OutputCapacity", "", o.OutputCapacity, false, false);
                this.Write18_CodeAndText("YearMade", "", o.YearMadeXml, false, false);
                this.Write18_CodeAndText("Usage", "", o.UsageXml, false, false);
                this.Write23_CodeTextAndValue("LocationHeated", "", o.LocationHeatedXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write107_SupplementaryHeat(string n, string ns, ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.SupplementaryHeat.SupplementaryHeat o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.SupplementaryHeat.SupplementaryHeat)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SupplementaryHeat", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                this.Write103_Item("EquipmentInformation", "", o.EquipmentInformation, false, false);
                this.Write104_SupplementaryHeatEquipment("Equipment", "", o.Equipment, false, false);
                this.Write106_Item("Specifications", "", o.Specifications, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write108_HeatingCooling(string n, string ns, HeatingCooling o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HeatingCooling)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HeatingCooling", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write60_CoolingSeason("CoolingSeason", "", o.CoolingSeason, false, false);
                this.Write85_Type1("Type1", "", o.Type1, false, false);
                this.Write97_Type2("Type2", "", o.Type2, false, false);
                this.Write100_MultipleSystems("MultipleSystems", "", o.MultipleSystems, false, false);
                this.Write102_RadiantHeating("RadiantHeating", "", o.RadiantHeating, false, false);
                List<AdditionalOpening> additionalOpenings = o.AdditionalOpenings;
                if (additionalOpenings != null)
                {
                    base.WriteStartElement("AdditionalOpenings", "", null, false);
                    int num2 = 0;
                    while (true)
                    {
                        if (num2 >= additionalOpenings.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write17_AdditionalOpening("Opening", "", additionalOpenings[num2], true, false);
                        num2++;
                    }
                }
                List<ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.SupplementaryHeat.SupplementaryHeat> supplementaryHeating = o.SupplementaryHeating;
                if (supplementaryHeating != null)
                {
                    base.WriteStartElement("SupplementaryHeatingSystems", "", null, false);
                    int num3 = 0;
                    while (true)
                    {
                        if (num3 >= supplementaryHeating.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write107_SupplementaryHeat("System", "", supplementaryHeating[num3], true, false);
                        num3++;
                    }
                }
                base.WriteEndElement(o);
            }
        }

        private void Write109_Configuration(string n, string ns, Configuration o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Configuration)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Configuration", "");
                }
                base.WriteAttribute("type", "", o.Type);
                base.WriteAttribute("subtype", "", XmlConvert.ToString(o.Subtype));
                base.WriteAttribute("overlap", "", XmlConvert.ToString(o.Overlap));
                if (o.Text != null)
                {
                    base.WriteValue(o.Text);
                }
                base.WriteEndElement(o);
            }
        }

        private string Write11_unit_types(unit_types v)
        {
            string str = null;
            switch (v)
            {
                case unit_types.M:
                    str = "M";
                    break;

                case unit_types.M2:
                    str = "M2";
                    break;

                case unit_types.M3:
                    str = "M3";
                    break;

                case unit_types.MM:
                    str = "MM";
                    break;

                case unit_types.RSI:
                    str = "RSI";
                    break;

                case unit_types.W:
                    str = "W";
                    break;

                case unit_types.MJ:
                    str = "MJ";
                    break;

                case unit_types.PM3:
                    str = "PM3";
                    break;

                case unit_types.PL:
                    str = "PL";
                    break;

                case unit_types.PMG:
                    str = "PMG";
                    break;

                case unit_types.C:
                    str = "C";
                    break;

                case unit_types.L:
                    str = "L";
                    break;

                case unit_types.KWH:
                    str = "KWH";
                    break;

                case unit_types.Mcf:
                    str = "Mcf";
                    break;

                case unit_types.LT:
                    str = "LT";
                    break;

                case unit_types.LITRES:
                    str = "LITRES";
                    break;

                case unit_types.MG:
                    str = "MG";
                    break;

                case unit_types.KW:
                    str = "KW";
                    break;

                case unit_types.CM2:
                    str = "CM2";
                    break;

                case unit_types.LPS:
                    str = "LPS";
                    break;

                case unit_types.RVAL:
                    str = "RVAL";
                    break;

                case unit_types.CM2PM2:
                    str = "CM2PM2";
                    break;

                case unit_types.MJPD:
                    str = "MJPD";
                    break;

                case unit_types.C18:
                    str = "C18";
                    break;

                case unit_types.MJPM2PD:
                    str = "MJPM2PD";
                    break;

                case unit_types.KMPHR:
                    str = "KMPHR";
                    break;

                case unit_types.RSIPMM:
                    str = "RSIPMM";
                    break;

                case unit_types.PERPDEGC:
                    str = "PERPDEGC";
                    break;

                case unit_types.KGPSEC:
                    str = "KGPSEC";
                    break;

                case unit_types.WPDEGC:
                    str = "WPDEGC";
                    break;

                default:
                    throw base.CreateInvalidEnumValueException(((long)v).ToString(CultureInfo.InvariantCulture), "ca.nrcan.gc.OEE.HouseFileLibrary.unit_types");
            }
            return str;
        }

        private void Write110_FoundationFloorConstruction(string n, string ns, FoundationFloorConstruction o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FoundationFloorConstruction)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FoundationFloorConstruction", "");
                }
                base.WriteAttribute("isBelowFrostline", "", XmlConvert.ToString(o.IsBelowFrostline));
                base.WriteAttribute("hasIntegralFooting", "", XmlConvert.ToString(o.HasIntegralFooting));
                base.WriteAttribute("heatedFloor", "", XmlConvert.ToString(o.HeatedFloor));
                this.Write7_CodeReference("AddedToSlab", "", o.AddedToSlab, false, false);
                this.Write7_CodeReference("FloorsAbove", "", o.FloorsAbove, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write111_FoundationMeasurements(string n, string ns, FoundationMeasurements o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FoundationMeasurements)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FoundationMeasurements", "");
                }
                base.WriteAttribute("isRectangular", "", XmlConvert.ToString(o.IsRectangular));
                base.WriteAttribute("area", "", XmlConvert.ToString(o.Area));
                base.WriteAttribute("width", "", XmlConvert.ToString(o.Width));
                base.WriteAttribute("length", "", XmlConvert.ToString(o.Length));
                base.WriteAttribute("perimeter", "", XmlConvert.ToString(o.Perimeter));
                base.WriteEndElement(o);
            }
        }

        private void Write112_FoundationFloor(string n, string ns, FoundationFloor o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FoundationFloor)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FoundationFloor", "");
                }
                this.Write110_FoundationFloorConstruction("Construction", "", o.Construction, false, false);
                this.Write111_FoundationMeasurements("Measurements", "", o.Measurements, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write113_CrawlspaceWallConstruction(string n, string ns, CrawlspaceWallConstruction o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CrawlspaceWallConstruction)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CrawlspaceWallConstruction", "");
                }
                base.WriteAttribute("corners", "", XmlConvert.ToString(o.Corners));
                this.Write20_CodeDescriptionAndComposite("Type", "", o.Type, false, false);
                this.Write7_CodeReference("Lintels", "", o.Lintels, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write114_CrawlspaceWallMeasurements(string n, string ns, CrawlspaceWallMeasurements o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CrawlspaceWallMeasurements)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CrawlspaceWallMeasurements", "");
                }
                base.WriteAttribute("height", "", XmlConvert.ToString(o.Height));
                base.WriteAttribute("depth", "", XmlConvert.ToString(o.Depth));
                base.WriteEndElement(o);
            }
        }

        private void Write115_WallRValues(string n, string ns, WallRValues o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WallRValues)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WallRValues", "");
                }
                base.WriteAttribute("skirt", "", XmlConvert.ToString(o.Skirt));
                base.WriteAttribute("thermalBreak", "", XmlConvert.ToString(o.ThermalBreak));
                base.WriteEndElement(o);
            }
        }

        private void Write116_CrawlspaceWall(string n, string ns, CrawlspaceWall o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CrawlspaceWall)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CrawlspaceWall", "");
                }
                this.Write113_CrawlspaceWallConstruction("Construction", "", o.Construction, false, false);
                this.Write114_CrawlspaceWallMeasurements("Measurements", "", o.Measurements, false, false);
                this.Write115_WallRValues("RValues", "", o.RValues, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write117_Crawlspace(string n, string ns, Crawlspace o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Crawlspace)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Crawlspace", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                base.WriteAttribute("isExposedSurface", "", XmlConvert.ToString(o.IsExposedSurface));
                base.WriteAttribute("exposedSurfacePerimeter", "", o.ExposedSurfacePerimeterHelper);
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write109_Configuration("Configuration", "", o.Configuration, false, false);
                this.Write112_FoundationFloor("Floor", "", o.Floor, false, false);
                this.Write116_CrawlspaceWall("Wall", "", o.Wall, false, false);
                this.Write18_CodeAndText("VentilationType", "", o.VentilationTypeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write118_SlabWall(string n, string ns, SlabWall o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SlabWall)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SlabWall", "");
                }
                this.Write115_WallRValues("RValues", "", o.RValues, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write119_Slab(string n, string ns, Slab o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Slab)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Slab", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                base.WriteAttribute("isExposedSurface", "", XmlConvert.ToString(o.IsExposedSurface));
                base.WriteAttribute("exposedSurfacePerimeter", "", o.ExposedSurfacePerimeterHelper);
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write109_Configuration("Configuration", "", o.Configuration, false, false);
                this.Write112_FoundationFloor("Floor", "", o.Floor, false, false);
                this.Write118_SlabWall("Wall", "", o.Wall, false, false);
                base.WriteEndElement(o);
            }
        }

        private string Write12_building_types(building_types v)
        {
            string str = null;
            switch (v)
            {
                case building_types.HOUSE:
                    str = "HOUSE";
                    break;

                case building_types.MURB_ONE_UNIT:
                    str = "MURB_ONE_UNIT";
                    break;

                case building_types.MURB_WHOLE_BUILDING:
                    str = "MURB_WHOLE_BUILDING";
                    break;

                default:
                    throw base.CreateInvalidEnumValueException(((long)v).ToString(CultureInfo.InvariantCulture), "ca.nrcan.gc.OEE.HouseFileLibrary.building_types");
            }
            return str;
        }

        private void Write120_WalkoutMeasurements(string n, string ns, WalkoutMeasurements o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WalkoutMeasurements)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WalkoutMeasurements", "");
                }
                base.WriteAttribute("withSlab", "", XmlConvert.ToString(o.WithSlab));
                base.WriteAttribute("height", "", XmlConvert.ToString(o.Height));
                base.WriteAttribute("d1", "", XmlConvert.ToString(o.D1));
                base.WriteAttribute("d2", "", XmlConvert.ToString(o.D2));
                base.WriteAttribute("d3", "", XmlConvert.ToString(o.D3));
                base.WriteAttribute("d4", "", XmlConvert.ToString(o.D4));
                base.WriteAttribute("d5", "", XmlConvert.ToString(o.D5));
                base.WriteAttribute("l1", "", XmlConvert.ToString(o.L1));
                base.WriteAttribute("l2", "", XmlConvert.ToString(o.L2));
                base.WriteAttribute("l3", "", XmlConvert.ToString(o.L3));
                base.WriteAttribute("l4", "", XmlConvert.ToString(o.L4));
                base.WriteEndElement(o);
            }
        }

        private void Write121_WalkoutFloor(string n, string ns, WalkoutFloor o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WalkoutFloor)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WalkoutFloor", "");
                }
                this.Write110_FoundationFloorConstruction("Construction", "", o.Construction, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write122_FoundationWallConstruction(string n, string ns, FoundationWallConstruction o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FoundationWallConstruction)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FoundationWallConstruction", "");
                }
                base.WriteAttribute("corners", "", XmlConvert.ToString(o.Corners));
                this.Write20_CodeDescriptionAndComposite("InteriorAddedInsulation", "", o.InteriorAddedInsulation, false, false);
                this.Write20_CodeDescriptionAndComposite("ExteriorAddedInsulation", "", o.ExteriorAddedInsulation, false, false);
                this.Write7_CodeReference("Lintels", "", o.Lintels, false, false);
                this.Write20_CodeDescriptionAndComposite("PonyWallType", "", o.PonyWallType, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write123_FoundationWallMeasurements(string n, string ns, FoundationWallMeasurements o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FoundationWallMeasurements)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FoundationWallMeasurements", "");
                }
                base.WriteAttribute("height", "", XmlConvert.ToString(o.Height));
                base.WriteAttribute("depth", "", XmlConvert.ToString(o.Depth));
                base.WriteAttribute("ponyWallHeight", "", XmlConvert.ToString(o.PonyWallHeight));
                base.WriteEndElement(o);
            }
        }

        private void Write124_FoundationWall(string n, string ns, FoundationWall o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FoundationWall)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FoundationWall", "");
                }
                base.WriteAttribute("hasPonyWall", "", XmlConvert.ToString(o.HasPonyWall));
                this.Write122_FoundationWallConstruction("Construction", "", o.Construction, false, false);
                this.Write123_FoundationWallMeasurements("Measurements", "", o.Measurements, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write125_ExteriorSurfaces(string n, string ns, ExteriorSurfaces o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ExteriorSurfaces)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ExteriorSurfaces", "");
                }
                base.WriteAttribute("aboveGradeArea", "", XmlConvert.ToString(o.AboveGradeArea));
                base.WriteAttribute("belowGradeArea", "", XmlConvert.ToString(o.BelowGradeArea));
                base.WriteAttribute("ponyWallArea", "", XmlConvert.ToString(o.PonyWallArea));
                base.WriteAttribute("slabPerimeter", "", XmlConvert.ToString(o.SlabPerimeter));
                base.WriteEndElement(o);
            }
        }

        private void Write126_Location(string n, string ns, Location o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Location)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Location", "");
                }
                base.WriteAttribute("x1", "", XmlConvert.ToString(o.X1));
                base.WriteAttribute("x2", "", XmlConvert.ToString(o.X2));
                base.WriteEndElement(o);
            }
        }

        private void Write127_Locations(string n, string ns, Locations o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Locations)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Locations", "");
                }
                this.Write126_Location("L1_1", "", o.L1_1, false, false);
                this.Write126_Location("L1_2", "", o.L1_2, false, false);
                this.Write126_Location("L2_1", "", o.L2_1, false, false);
                this.Write126_Location("L2_2", "", o.L2_2, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write128_Walkout(string n, string ns, Walkout o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Walkout)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Walkout", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                base.WriteAttribute("isExposedSurface", "", XmlConvert.ToString(o.IsExposedSurface));
                base.WriteAttribute("exposedSurfacePerimeter", "", o.ExposedSurfacePerimeterHelper);
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write109_Configuration("Configuration", "", o.Configuration, false, false);
                this.Write120_WalkoutMeasurements("Measurements", "", o.Measurements, false, false);
                this.Write121_WalkoutFloor("Floor", "", o.Floor, false, false);
                this.Write124_FoundationWall("Wall", "", o.Wall, false, false);
                this.Write125_ExteriorSurfaces("ExteriorSurfaces", "", o.ExteriorSurfaces, false, false);
                this.Write127_Locations("Locations", "", o.Locations, false, false);
                this.Write23_CodeTextAndValue("OpeningUpstairs", "", o.OpeningUpstairsXml, false, false);
                this.Write18_CodeAndText("RoomType", "", o.RoomTypeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write129_Foundation(string n, string ns, Foundation o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(Foundation))
                    {
                        if (type == typeof(Basement))
                        {
                            this.Write130_Basement(n, ns, (Basement)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Walkout))
                        {
                            this.Write128_Walkout(n, ns, (Walkout)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Slab))
                        {
                            this.Write119_Slab(n, ns, (Slab)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(Crawlspace)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write117_Crawlspace(n, ns, (Crawlspace)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Foundation", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                base.WriteAttribute("isExposedSurface", "", XmlConvert.ToString(o.IsExposedSurface));
                base.WriteAttribute("exposedSurfacePerimeter", "", o.ExposedSurfacePerimeterHelper);
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write109_Configuration("Configuration", "", o.Configuration, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write13_BooleanValue(string n, string ns, BooleanValue o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(BooleanValue)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("BooleanValue", "");
                }
                base.WriteAttribute("value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write130_Basement(string n, string ns, Basement o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Basement)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Basement", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                base.WriteAttribute("isExposedSurface", "", XmlConvert.ToString(o.IsExposedSurface));
                base.WriteAttribute("exposedSurfacePerimeter", "", o.ExposedSurfacePerimeterHelper);
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write109_Configuration("Configuration", "", o.Configuration, false, false);
                this.Write112_FoundationFloor("Floor", "", o.Floor, false, false);
                this.Write124_FoundationWall("Wall", "", o.Wall, false, false);
                this.Write23_CodeTextAndValue("OpeningUpstairs", "", o.OpeningUpstairsXml, false, false);
                this.Write18_CodeAndText("RoomType", "", o.RoomTypeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write131_Array(string n, string ns, Array o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Array)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Array", "");
                }
                base.WriteAttribute("area", "", XmlConvert.ToString(o.Area));
                base.WriteAttribute("slope", "", XmlConvert.ToString(o.Slope));
                base.WriteAttribute("azimuth", "", XmlConvert.ToString(o.Azimuth));
                base.WriteEndElement(o);
            }
        }

        private void Write132_Efficiency(string n, string ns, Efficiency o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Efficiency)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Efficiency", "");
                }
                base.WriteAttribute("miscellaneousLosses", "", XmlConvert.ToString(o.MiscellaneousLosses));
                base.WriteAttribute("otherPowerLosses", "", XmlConvert.ToString(o.OtherPowerLosses));
                base.WriteAttribute("inverterEfficiency", "", XmlConvert.ToString(o.InverterEfficiency));
                base.WriteAttribute("gridAbsorptionRate", "", XmlConvert.ToString(o.GridAbsorptionRate));
                base.WriteEndElement(o);
            }
        }

        private void Write133_Module(string n, string ns, Module o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Module)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Module", "");
                }
                base.WriteAttribute("efficiency", "", XmlConvert.ToString(o.Efficiency));
                base.WriteAttribute("cellTemperature", "", XmlConvert.ToString(o.CellTemperature));
                base.WriteAttribute("coefficientOfEfficiency", "", XmlConvert.ToString(o.CoefficientOfEfficiency));
                this.Write18_CodeAndText("Type", "", o.TypeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write134_Photovoltaic(string n, string ns, Photovoltaic o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Photovoltaic)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Photovoltaic", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                this.Write66_EquipmentInformation("EquipmentInformation", "", o.EquipmentInformation, false, false);
                this.Write131_Array("Array", "", o.Array, false, false);
                this.Write132_Efficiency("Efficiency", "", o.Efficiency, false, false);
                this.Write133_Module("Module", "", o.Module, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write135_Generation(string n, string ns, Generation o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Generation)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Generation", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                base.WriteAttribute("solarReady", "", XmlConvert.ToString(o.SolarReady));
                base.WriteAttribute("batteryStorage", "", XmlConvert.ToString(o.BatteryStorage));
                base.WriteAttribute("windEnergyContribution", "", o.WindEnergyContributionHelper);
                base.WriteAttribute("photovoltaicCapacity", "", o.PhotovoltaicCapacityHelper);
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                List<Photovoltaic> photovoltaicSystems = o.PhotovoltaicSystems;
                if (photovoltaicSystems != null)
                {
                    base.WriteStartElement("PhotovoltaicSystems", "", null, false);
                    int num2 = 0;
                    while (true)
                    {
                        if (num2 >= photovoltaicSystems.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write134_Photovoltaic("System", "", photovoltaicSystems[num2], true, false);
                        num2++;
                    }
                }
                base.WriteEndElement(o);
            }
        }

        private void Write136_Solar(string n, string ns, Solar o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Solar)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Solar", "");
                }
                base.WriteAttribute("rating", "", XmlConvert.ToString(o.Rating));
                base.WriteAttribute("slope", "", XmlConvert.ToString(o.Slope));
                base.WriteAttribute("azimuth", "", XmlConvert.ToString(o.Azimuth));
                base.WriteEndElement(o);
            }
        }

        private void Write137_DrainWaterHeatRecovery(string n, string ns, DrainWaterHeatRecovery o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DrainWaterHeatRecovery)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DrainWaterHeatRecovery", "");
                }
                base.WriteAttribute("showerLength", "", XmlConvert.ToString(o.ShowerLength));
                base.WriteAttribute("dailyShowers", "", XmlConvert.ToString(o.DailyShowers));
                base.WriteAttribute("preheatShowerTank", "", XmlConvert.ToString(o.PreheatShowerTank));
                base.WriteAttribute("effectivenessAt9.5", "", XmlConvert.ToString(o.Effectiveness));
                this.Write18_CodeAndText("Efficiency", "", o.Efficiency, false, false);
                this.Write66_EquipmentInformation("EquipmentInformation", "", o.EquipmentInformation, false, false);
                this.Write18_CodeAndText("ShowerTemperature", "", o.ShowerTemperatureXml, false, false);
                this.Write18_CodeAndText("ShowerHead", "", o.ShowerHeadXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write138_HotWaterComponent(string n, string ns, HotWaterComponent o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HotWaterComponent)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HotWaterComponent", "");
                }
                base.WriteAttribute("hasDrainWaterHeatRecovery", "", XmlConvert.ToString(o.HasDrainWaterHeatRecovery));
                base.WriteAttribute("insulatingBlanket", "", XmlConvert.ToString(o.InsulatingBlanket));
                base.WriteAttribute("pilotEnergy", "", XmlConvert.ToString(o.PilotEnergy));
                base.WriteAttribute("heatPumpCoefficient", "", XmlConvert.ToString(o.HeatPumpCoefficient));
                base.WriteAttribute("combinedFlue", "", XmlConvert.ToString(o.CombinedFlue));
                base.WriteAttribute("flueDiameter", "", XmlConvert.ToString(o.FlueDiameter));
                base.WriteAttribute("energyStar", "", XmlConvert.ToString(o.EnergyStar));
                base.WriteAttribute("ecoEnergy", "", XmlConvert.ToString(o.EcoEnergy));
                base.WriteAttribute("userDefinedPilot", "", XmlConvert.ToString(o.UserDefinedPilot));
                base.WriteAttribute("fraction", "", XmlConvert.ToString(o.Fraction));
                base.WriteAttribute("connectedUnitsDwhr", "", XmlConvert.ToString(o.ConnectedUnitsDwhr));
                this.Write66_EquipmentInformation("EquipmentInformation", "", o.EquipmentInformation, false, false);
                this.Write22_EnergyFactor("EnergyFactor", "", o.EnergyFactor, false, false);
                this.Write136_Solar("Solar", "", o.Solar, false, false);
                this.Write137_DrainWaterHeatRecovery("DrainWaterHeatRecovery", "", o.DrainWaterHeatRecovery, false, false);
                this.Write18_CodeAndText("EnergySource", "", o.EnergySourceXml, false, false);
                this.Write18_CodeAndText("TankType", "", o.TankTypeXml, false, false);
                this.Write23_CodeTextAndValue("TankVolume", "", o.TankVolumeXml, false, false);
                this.Write18_CodeAndText("DrawPattern", "", o.DrawPatternXml, false, false);
                this.Write18_CodeAndText("TankLocation", "", o.TankLocationXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write139_NumberOfDwhrSystems(string n, string ns, NumberOfDwhrSystems o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(NumberOfDwhrSystems)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("NumberOfDwhrSystems", "");
                }
                base.WriteAttribute("lowEfficiency", "", XmlConvert.ToString(o.LowEfficiency));
                base.WriteAttribute("highEfficiency", "", XmlConvert.ToString(o.HighEfficiency));
                base.WriteEndElement(o);
            }
        }

        private void Write14_FansAndPumpPowerCooling(string n, string ns, FansAndPumpPowerCooling o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FansAndPumpPowerCooling)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FansAndPumpPowerCooling", "");
                }
                base.WriteAttribute("isCalculated", "", XmlConvert.ToString(o.IsCalculated));
                base.WriteAttribute("value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write140_NumberOfHotWaterSystems(string n, string ns, NumberOfHotWaterSystems o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(NumberOfHotWaterSystems)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("NumberOfHotWaterSystems", "");
                }
                base.WriteAttribute("energyStarInstantaneousCondensing", "", XmlConvert.ToString(o.EnergyStarInstantaneousCondensing));
                base.WriteAttribute("energyStarInstantaneous", "", XmlConvert.ToString(o.EnergyStarInstantaneous));
                base.WriteAttribute("condensing", "", XmlConvert.ToString(o.Condensing));
                base.WriteAttribute("instantaneous", "", XmlConvert.ToString(o.Instantaneous));
                base.WriteAttribute("heatPumpWaterHeater", "", XmlConvert.ToString(o.HeatPumpWaterHeater));
                base.WriteEndElement(o);
            }
        }

        private void Write141_HotWater(string n, string ns, HotWater o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HotWater)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HotWater", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write138_HotWaterComponent("Primary", "", o.Primary, false, false);
                this.Write138_HotWaterComponent("Secondary", "", o.Secondary, false, false);
                this.Write139_NumberOfDwhrSystems("NumberOfDwhrSystems", "", o.NumberOfDwhrSystems, false, false);
                this.Write140_NumberOfHotWaterSystems("NumberOfHotWaterSystems", "", o.NumberOfHotWaterSystems, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write142_SpecificationsHouse(string n, string ns, SpecificationsHouse o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SpecificationsHouse)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SpecificationsHouse", "");
                }
                base.WriteAttribute("volume", "", XmlConvert.ToString(o.Volume));
                base.WriteAttribute("includeCrawlspaceVolume", "", XmlConvert.ToString(o.includeCrawlspaceVolume));
                this.Write23_CodeTextAndValue("AirTightnessTest", "", o.AirTightnessTestXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write143_BlowerTest(string n, string ns, BlowerTest o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(BlowerTest)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("BlowerTest", "");
                }
                base.WriteAttribute("airChangeRate", "", XmlConvert.ToString(o.AirChangeRate));
                base.WriteAttribute("isCgsbTest", "", XmlConvert.ToString(o.IsCgsbTest));
                base.WriteAttribute("isCalculated", "", XmlConvert.ToString(o.isCalculated));
                base.WriteAttribute("leakageArea", "", XmlConvert.ToString(o.LeakageArea));
                base.WriteAttribute("guarded", "", XmlConvert.ToString(o.Guarded));
                this.Write18_CodeAndText("Pressure", "", o.PressureXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write144_BuildingSite(string n, string ns, BuildingSite o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(BuildingSite)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("BuildingSite", "");
                }
                base.WriteAttribute("highestCeiling", "", XmlConvert.ToString(o.HighestCeiling));
                this.Write18_CodeAndText("Terrain", "", o.TerrainXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write145_LocalShielding(string n, string ns, LocalShielding o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(LocalShielding)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("LocalShielding", "");
                }
                this.Write18_CodeAndText("Walls", "", o.WallsXml, false, false);
                this.Write18_CodeAndText("Flue", "", o.FlueXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write146_ExhaustDevicesTest(string n, string ns, ExhaustDevicesTest o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ExhaustDevicesTest)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ExhaustDevicesTest", "");
                }
                base.WriteAttribute("result", "", XmlConvert.ToString(o.Result));
                this.Write18_CodeAndText("TestStatus", "", o.TestStatusXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write147_CommonSurfaceArea(string n, string ns, CommonSurfaceArea o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CommonSurfaceArea)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CommonSurfaceArea", "");
                }
                base.WriteAttribute("surfacearea", "", XmlConvert.ToString(o.SurfaceArea));
                base.WriteEndElement(o);
            }
        }

        private void Write148_NaturalAirSpecifications(string n, string ns, NaturalAirSpecifications o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(NaturalAirSpecifications)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("NaturalAirSpecifications", "");
                }
                this.Write142_SpecificationsHouse("House", "", o.House, false, false);
                this.Write143_BlowerTest("BlowerTest", "", o.BlowerTest, false, false);
                this.Write144_BuildingSite("BuildingSite", "", o.BuildingSite, false, false);
                this.Write145_LocalShielding("LocalShielding", "", o.LocalShielding, false, false);
                this.Write146_ExhaustDevicesTest("ExhaustDevicesTest", "", o.ExhaustDevicesTest, false, false);
                this.Write147_CommonSurfaceArea("CommonSurfaceArea", "", o.CommonSurfaceArea, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write149_WeatherStation(string n, string ns, WeatherStation o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WeatherStation)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WeatherStation", "");
                }
                base.WriteAttribute("anemometerHeight", "", XmlConvert.ToString(o.AnemometerHeight));
                this.Write18_CodeAndText("Terrain", "", o.TerrainXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write15_CoolingFansAndPumps(string n, string ns, CoolingFansAndPumps o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CoolingFansAndPumps)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CoolingFansAndPumps", "");
                }
                base.WriteAttribute("flowRate", "", XmlConvert.ToString(o.FlowRate));
                base.WriteAttribute("hasEnergyEfficientMotor", "", XmlConvert.ToString(o.HasEnergyEfficientMotor));
                this.Write14_FansAndPumpPowerCooling("Power", "", o.Power, false, false);
                this.Write18_CodeAndText("Mode", "", o.ModeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write150_LeakageFractions(string n, string ns, LeakageFractions o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(LeakageFractions)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("LeakageFractions", "");
                }
                base.WriteAttribute("useDefaults", "", XmlConvert.ToString(o.UseDefaults));
                base.WriteAttribute("ceilings", "", XmlConvert.ToString(o.Ceilings));
                base.WriteAttribute("walls", "", XmlConvert.ToString(o.Walls));
                base.WriteAttribute("floors", "", XmlConvert.ToString(o.Floors));
                base.WriteEndElement(o);
            }
        }

        private void Write151_OtherFactors(string n, string ns, OtherFactors o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(OtherFactors)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("OtherFactors", "");
                }
                this.Write149_WeatherStation("WeatherStation", "", o.WeatherStation, false, false);
                this.Write150_LeakageFractions("LeakageFractions", "", o.LeakageFractions, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write152_PressureData(string n, string ns, PressureData o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(PressureData)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("PressureData", "");
                }
                base.WriteAttribute("initial", "", XmlConvert.ToString(o.Initial));
                base.WriteAttribute("final", "", XmlConvert.ToString(o.Final));
                base.WriteEndElement(o);
            }
        }

        private void Write153_Pressure(string n, string ns, Pressure o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Pressure)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Pressure", "");
                }
                this.Write152_PressureData("Static", "", o.Static, false, false);
                this.Write152_PressureData("Zone1", "", o.Zone1, false, false);
                this.Write152_PressureData("Zone2", "", o.Zone2, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write154_DataPoint(string n, string ns, DataPoint o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DataPoint)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DataPoint", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteAttribute("housePressure", "", XmlConvert.ToString(o.HousePressure));
                base.WriteAttribute("fanPressure", "", XmlConvert.ToString(o.FanPressure));
                base.WriteAttribute("measuredFlow", "", XmlConvert.ToString(o.MeasuredFlow));
                base.WriteAttribute("zone1Pressure", "", XmlConvert.ToString(o.Zone1Pressure));
                base.WriteAttribute("zone2Pressure", "", XmlConvert.ToString(o.Zone2Pressure));
                this.Write18_CodeAndText("FlowRanges", "", o.FlowRanges, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write155_Test(string n, string ns, Test o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Test)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Test", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteAttribute("equipment", "", XmlConvert.ToString(o.Equipment));
                base.WriteAttribute("insideTemperature", "", XmlConvert.ToString(o.InsideTemperature));
                base.WriteAttribute("zoneHeatedVolume", "", XmlConvert.ToString(o.ZoneHeatedVolume));
                base.WriteElementString("Manometer", "", o.Manometer);
                this.Write153_Pressure("Pressure", "", o.Pressure, false, false);
                this.Write18_CodeAndText("FanType", "", o.FanType, false, false);
                List<DataPoint> data = o.Data;
                if (data != null)
                {
                    base.WriteStartElement("Data", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= data.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write154_DataPoint("DataPoint", "", data[num], true, false);
                        num++;
                    }
                }
                base.WriteEndElement(o);
            }
        }

        private void Write156_AirLeakageTestData(string n, string ns, AirLeakageTestData o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(AirLeakageTestData)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("AirLeakageTestData", "");
                }
                base.WriteAttribute("hasCgsbConditions", "", XmlConvert.ToString(o.HasCgsbConditions));
                base.WriteAttribute("outsideTemperature", "", XmlConvert.ToString(o.OutsideTemperature));
                base.WriteAttribute("barometricPressure", "", XmlConvert.ToString(o.BarometricPressure));
                List<Test> testData = o.TestData;
                if (testData != null)
                {
                    base.WriteStartElement("TestData", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= testData.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write155_Test("Test", "", testData[num], true, false);
                        num++;
                    }
                }
                this.Write18_CodeAndText("TestType", "", o.TestTypeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write157_NaturalAirInfiltration(string n, string ns, NaturalAirInfiltration o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(NaturalAirInfiltration)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("NaturalAirInfiltration", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write148_NaturalAirSpecifications("Specifications", "", o.Specifications, false, false);
                this.Write151_OtherFactors("OtherFactors", "", o.OtherFactors, false, false);
                this.Write156_AirLeakageTestData("AirLeakageTestData", "", o.AirLeakageTestData, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write158_RoomConstruction(string n, string ns, RoomConstruction o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(RoomConstruction)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("RoomConstruction", "");
                }
                this.Write18_CodeAndText("FoundationBelow", "", o.FoundationBelow, false, false);
                this.Write18_CodeAndText("Type", "", o.TypeXml, false, false);
                this.Write18_CodeAndText("Floor", "", o.FloorXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write159_RoomMeasurements(string n, string ns, RoomMeasurements o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(RoomMeasurements)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("RoomMeasurements", "");
                }
                base.WriteAttribute("isRectangular", "", XmlConvert.ToString(o.IsRectangular));
                base.WriteAttribute("height", "", XmlConvert.ToString(o.Height));
                base.WriteAttribute("width", "", XmlConvert.ToString(o.Width));
                base.WriteAttribute("depth", "", XmlConvert.ToString(o.Depth));
                base.WriteAttribute("perimeter", "", XmlConvert.ToString(o.Perimeter));
                base.WriteAttribute("area", "", XmlConvert.ToString(o.Area));
                base.WriteEndElement(o);
            }
        }

        private void Write16_HeatPumpCoolingType(string n, string ns, HeatPumpCoolingType o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HeatPumpCoolingType)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HeatPumpCoolingType", "");
                }
                base.WriteAttribute("sensibleHeatRatio", "", XmlConvert.ToString(o.sensibleHeatRatio));
                base.WriteAttribute("openableWindowArea", "", XmlConvert.ToString(o.openableWindowArea));
                this.Write15_CoolingFansAndPumps("FansAndPump", "", o.FansAndPump, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write160_Room(string n, string ns, Room o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Room)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Room", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write158_RoomConstruction("Construction", "", o.Construction, false, false);
                this.Write159_RoomMeasurements("Measurements", "", o.Measurements, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write161_MainFloors(string n, string ns, MainFloors o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(MainFloors)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("MainFloors", "");
                }
                base.WriteAttribute("coolingSetPoint", "", XmlConvert.ToString(o.CoolingSetPoint));
                base.WriteAttribute("daytimeHeatingSetPoint", "", XmlConvert.ToString(o.DaytimeHeatingSetPoint));
                base.WriteAttribute("nighttimeHeatingSetPoint", "", XmlConvert.ToString(o.NighttimeHeatingSetPoint));
                base.WriteAttribute("nighttimeSetbackDuration", "", XmlConvert.ToString(o.NighttimeSetbackDuration));
                this.Write18_CodeAndText("AllowableRise", "", o.AllowableRiseXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write162_VentilationBasement(string n, string ns, VentilationBasement o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(VentilationBasement)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("VentilationBasement", "");
                }
                base.WriteAttribute("heated", "", XmlConvert.ToString(o.Heated));
                base.WriteAttribute("cooled", "", XmlConvert.ToString(o.Cooled));
                base.WriteAttribute("separateThermostat", "", XmlConvert.ToString(o.SeparateThermostat));
                base.WriteAttribute("heatingSetPoint", "", XmlConvert.ToString(o.HeatingSetPoint));
                base.WriteAttribute("basementUnit", "", XmlConvert.ToString(o.BasementUnit));
                base.WriteEndElement(o);
            }
        }

        private void Write163_Equipment(string n, string ns, Equipment o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Equipment)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Equipment", "");
                }
                base.WriteAttribute("heatingSetPoint", "", XmlConvert.ToString(o.HeatingSetPoint));
                base.WriteAttribute("coolingSetPoint", "", XmlConvert.ToString(o.CoolingSetPoint));
                base.WriteEndElement(o);
            }
        }

        private void Write164_TemperatureCrawlspace(string n, string ns, TemperatureCrawlspace o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(TemperatureCrawlspace)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("TemperatureCrawlspace", "");
                }
                base.WriteAttribute("heated", "", XmlConvert.ToString(o.Heated));
                base.WriteAttribute("heatingSetPoint", "", XmlConvert.ToString(o.HeatingSetPoint));
                base.WriteEndElement(o);
            }
        }

        private void Write165_Temperatures(string n, string ns, Temperatures o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Temperatures)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Temperatures", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write161_MainFloors("MainFloors", "", o.MainFloors, false, false);
                this.Write162_VentilationBasement("Basement", "", o.Basement, false, false);
                this.Write163_Equipment("Equipment", "", o.Equipment, false, false);
                this.Write164_TemperatureCrawlspace("Crawlspace", "", o.Crawlspace, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write166_Rooms(string n, string ns, Rooms o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Rooms)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Rooms", "");
                }
                base.WriteAttribute("living", "", XmlConvert.ToString(o.Living));
                base.WriteAttribute("bedrooms", "", XmlConvert.ToString(o.Bedrooms));
                base.WriteAttribute("bathrooms", "", XmlConvert.ToString(o.Bathrooms));
                base.WriteAttribute("utility", "", XmlConvert.ToString(o.Utility));
                base.WriteAttribute("otherHabitable", "", XmlConvert.ToString(o.OtherHabitable));
                this.Write23_CodeTextAndValue("VentilationRate", "", o.VentilationRateXml, false, false);
                this.Write23_CodeTextAndValue("DepressurizationLimit", "", o.DepressurizationLimitXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write167_Requirements(string n, string ns, Requirements o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Requirements)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Requirements", "");
                }
                base.WriteAttribute("ach", "", XmlConvert.ToString(o.Ach));
                base.WriteAttribute("supply", "", XmlConvert.ToString(o.Supply));
                base.WriteAttribute("exhaust", "", XmlConvert.ToString(o.Exhaust));
                this.Write18_CodeAndText("Use", "", o.UseXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write168_WholeHouseParamaters(string n, string ns, WholeHouseParamaters o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WholeHouseParamaters)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WholeHouseParamaters", "");
                }
                base.WriteAttribute("temperatureControlLower", "", XmlConvert.ToString(o.TemperatureControlLower));
                base.WriteAttribute("temperatureControlUpper", "", XmlConvert.ToString(o.TemperatureControlUpper));
                base.WriteAttribute("hviHrvErvInMurb", "", XmlConvert.ToString(o.HviHrvErvInMurb));
                this.Write18_CodeAndText("AirDistributionType", "", o.AirDistributionTypeXml, false, false);
                this.Write23_CodeTextAndValue("AirDistributionFanPower", "", o.AirDistributionFanPowerXml, false, false);
                this.Write23_CodeTextAndValue("OperationSchedule", "", o.OperationScheduleXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write169_Dryer(string n, string ns, Dryer o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Dryer)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Dryer", "");
                }
                base.WriteAttribute("supplyFlowrate", "", XmlConvert.ToString(o.SupplyFlowrate));
                base.WriteAttribute("exhaustFlowrate", "", XmlConvert.ToString(o.ExhaustFlowrate));
                base.WriteAttribute("fanPower1", "", XmlConvert.ToString(o.FanPower1));
                base.WriteAttribute("isDefaultFanpower", "", XmlConvert.ToString(o.IsDefaultFanpower));
                base.WriteAttribute("isEnergyStar", "", XmlConvert.ToString(o.IsEnergyStar));
                base.WriteAttribute("isHomeVentilatingInstituteCertified", "", XmlConvert.ToString(o.IsHomeVentilatingInstituteCertified));
                base.WriteAttribute("isSupplemental", "", XmlConvert.ToString(o.IsSupplemental));
                this.Write66_EquipmentInformation("EquipmentInformation", "", o.EquipmentInformation, false, false);
                this.Write18_CodeAndText("VentilatorType", "", o.VentilatorTypeXml, false, false);
                this.Write23_CodeTextAndValue("OperationSchedule", "", o.OperationScheduleXml, false, false);
                this.Write18_CodeAndText("Exhaust", "", o.ExhaustXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write17_AdditionalOpening(string n, string ns, AdditionalOpening o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(AdditionalOpening)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("AdditionalOpening", "");
                }
                base.WriteAttribute("code", "", o.Code);
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteAttribute("flueDiameter", "", XmlConvert.ToString(o.FlueDiameter));
                base.WriteAttribute("damperClosed", "", XmlConvert.ToString(o.DamperClosed));
                base.WriteAttribute("numberOfOpenings", "", XmlConvert.ToString(o.NumberOfOpenings));
                base.WriteElementString("English", "", o.EnglishText);
                base.WriteElementString("French", "", o.FrenchText);
                if (o.Text != null)
                {
                    base.WriteValue(o.Text);
                }
                base.WriteEndElement(o);
            }
        }

        private void Write170_VentilatorObjects(string n, string ns, VentilatorObjects o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(VentilatorObjects))
                    {
                        if (type == typeof(Hrv))
                        {
                            this.Write173_Hrv(n, ns, (Hrv)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(Dryer)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write169_Dryer(n, ns, (Dryer)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("VentilatorObjects", "");
                }
                base.WriteAttribute("supplyFlowrate", "", XmlConvert.ToString(o.SupplyFlowrate));
                base.WriteAttribute("exhaustFlowrate", "", XmlConvert.ToString(o.ExhaustFlowrate));
                base.WriteAttribute("fanPower1", "", XmlConvert.ToString(o.FanPower1));
                base.WriteAttribute("isDefaultFanpower", "", XmlConvert.ToString(o.IsDefaultFanpower));
                base.WriteAttribute("isEnergyStar", "", XmlConvert.ToString(o.IsEnergyStar));
                base.WriteAttribute("isHomeVentilatingInstituteCertified", "", XmlConvert.ToString(o.IsHomeVentilatingInstituteCertified));
                base.WriteAttribute("isSupplemental", "", XmlConvert.ToString(o.IsSupplemental));
                this.Write66_EquipmentInformation("EquipmentInformation", "", o.EquipmentInformation, false, false);
                this.Write18_CodeAndText("VentilatorType", "", o.VentilatorTypeXml, false, false);
                this.Write23_CodeTextAndValue("OperationSchedule", "", o.OperationScheduleXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write171_HrvDuctSpec(string n, string ns, HrvDuctSpec o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HrvDuctSpec)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HrvDuctSpec", "");
                }
                base.WriteAttribute("length", "", XmlConvert.ToString(o.Length));
                base.WriteAttribute("diameter", "", XmlConvert.ToString(o.Diameter));
                base.WriteAttribute("insulation", "", XmlConvert.ToString(o.Insulation));
                this.Write18_CodeAndText("Location", "", o.LocationXml, false, false);
                this.Write18_CodeAndText("Type", "", o.TypeXml, false, false);
                this.Write18_CodeAndText("Sealing", "", o.SealingXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write172_HrvDucts(string n, string ns, HrvDucts o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HrvDucts)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HrvDucts", "");
                }
                this.Write171_HrvDuctSpec("Supply", "", o.Supply, false, false);
                this.Write171_HrvDuctSpec("Exhaust", "", o.Exhaust, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write173_Hrv(string n, string ns, Hrv o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Hrv)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Hrv", "");
                }
                base.WriteAttribute("supplyFlowrate", "", XmlConvert.ToString(o.SupplyFlowrate));
                base.WriteAttribute("exhaustFlowrate", "", XmlConvert.ToString(o.ExhaustFlowrate));
                base.WriteAttribute("fanPower1", "", XmlConvert.ToString(o.FanPower1));
                base.WriteAttribute("isDefaultFanpower", "", XmlConvert.ToString(o.IsDefaultFanpower));
                base.WriteAttribute("isEnergyStar", "", XmlConvert.ToString(o.IsEnergyStar));
                base.WriteAttribute("isHomeVentilatingInstituteCertified", "", XmlConvert.ToString(o.IsHomeVentilatingInstituteCertified));
                base.WriteAttribute("isSupplemental", "", XmlConvert.ToString(o.IsSupplemental));
                base.WriteAttribute("temperatureCondition1", "", XmlConvert.ToString(o.TemperatureCondition1));
                base.WriteAttribute("temperatureCondition2", "", XmlConvert.ToString(o.TemperatureCondition2));
                base.WriteAttribute("fanPower2", "", XmlConvert.ToString(o.FanPower2));
                base.WriteAttribute("efficiency1", "", XmlConvert.ToString(o.Efficiency1));
                base.WriteAttribute("efficiency2", "", XmlConvert.ToString(o.Efficiency2));
                base.WriteAttribute("preheaterCapacity", "", XmlConvert.ToString(o.PreheaterCapacity));
                base.WriteAttribute("lowTempVentReduction", "", XmlConvert.ToString(o.LowTempVentReduction));
                base.WriteAttribute("coolingEfficiency", "", XmlConvert.ToString(o.CoolingEfficiency));
                this.Write66_EquipmentInformation("EquipmentInformation", "", o.EquipmentInformation, false, false);
                this.Write18_CodeAndText("VentilatorType", "", o.VentilatorTypeXml, false, false);
                this.Write23_CodeTextAndValue("OperationSchedule", "", o.OperationScheduleXml, false, false);
                this.Write172_HrvDucts("ColdAirDucts", "", o.HrvDucts, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write174_Ventilation(string n, string ns, Ventilation o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Ventilation)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Ventilation", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write166_Rooms("Rooms", "", o.Rooms, false, false);
                this.Write167_Requirements("Requirements", "", o.Requirements, false, false);
                this.Write168_WholeHouseParamaters("WholeHouse", "", o.SupplyAndExhaust, false, false);
                List<VentilatorObjects> wholeHouseVentilatorList = o.WholeHouseVentilatorList;
                if (wholeHouseVentilatorList != null)
                {
                    base.WriteStartElement("WholeHouseVentilatorList", "", null, false);
                    int num2 = 0;
                    while (true)
                    {
                        if (num2 >= wholeHouseVentilatorList.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        VentilatorObjects objects = wholeHouseVentilatorList[num2];
                        if (objects != null)
                        {
                            if (objects is Dryer)
                            {
                                this.Write169_Dryer("Dryer", "", (Dryer)objects, true, false);
                            }
                            else if (objects is Hrv)
                            {
                                this.Write173_Hrv("Hrv", "", (Hrv)objects, true, false);
                            }
                            else if (objects != null)
                            {
                                this.Write170_VentilatorObjects("BaseVentilator", "", objects, true, false);
                            }
                            else if (objects != null)
                            {
                                throw base.CreateUnknownTypeException(objects);
                            }
                        }
                        num2++;
                    }
                }
                List<VentilatorObjects> supplementalVentilatorList = o.SupplementalVentilatorList;
                if (supplementalVentilatorList != null)
                {
                    base.WriteStartElement("SupplementalVentilatorList", "", null, false);
                    int num3 = 0;
                    while (true)
                    {
                        if (num3 >= supplementalVentilatorList.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        VentilatorObjects objects2 = supplementalVentilatorList[num3];
                        if (objects2 != null)
                        {
                            if (objects2 is Dryer)
                            {
                                this.Write169_Dryer("Dryer", "", (Dryer)objects2, true, false);
                            }
                            else if (objects2 is Hrv)
                            {
                                this.Write173_Hrv("Hrv", "", (Hrv)objects2, true, false);
                            }
                            else if (objects2 != null)
                            {
                                this.Write170_VentilatorObjects("BaseVentilator", "", objects2, true, false);
                            }
                            else if (objects2 != null)
                            {
                                throw base.CreateUnknownTypeException(objects2);
                            }
                        }
                        num3++;
                    }
                }
                base.WriteEndElement(o);
            }
        }

        private void Write175_WallMeasurements(string n, string ns, WallMeasurements o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WallMeasurements)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WallMeasurements", "");
                }
                base.WriteAttribute("height", "", XmlConvert.ToString(o.Height));
                base.WriteAttribute("perimeter", "", XmlConvert.ToString(o.Perimeter));
                base.WriteEndElement(o);
            }
        }

        private void Write176_Wall(string n, string ns, Wall o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Wall)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Wall", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                base.WriteAttribute("adjacentEnclosedSpace", "", XmlConvert.ToString(o.AdjacentEnclosedSpace));
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write52_WallConstruction("Construction", "", o.Construction, false, false);
                this.Write175_WallMeasurements("Measurements", "", o.Measurements, false, false);
                this.Write18_CodeAndText("FacingDirection", "", o.FacingDirectionXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write177_WindowMeasurements(string n, string ns, WindowMeasurements o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WindowMeasurements)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WindowMeasurements", "");
                }
                base.WriteAttribute("height", "", XmlConvert.ToString(o.Height));
                base.WriteAttribute("width", "", XmlConvert.ToString(o.Width));
                base.WriteAttribute("headerHeight", "", XmlConvert.ToString(o.HeaderHeight));
                base.WriteAttribute("overhangWidth", "", XmlConvert.ToString(o.OverhangWidth));
                this.Write23_CodeTextAndValue("Tilt", "", o.TiltXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write178_WindowShading(string n, string ns, WindowShading o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WindowShading)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WindowShading", "");
                }
                base.WriteAttribute("curtain", "", XmlConvert.ToString(o.Curtain));
                base.WriteAttribute("shutterRValue", "", XmlConvert.ToString(o.ShutterRValue));
                base.WriteEndElement(o);
            }
        }

        private void Write179_EnergyStar(string n, string ns, EnergyStar o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(EnergyStar)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("EnergyStar", "");
                }
                base.WriteAttribute("energyRating", "", o.ERText);
                base.WriteAttribute("uValueMin", "", o.UValueMinText);
                base.WriteAttribute("uValueMax", "", o.UValueMaxText);
                base.WriteEndElement(o);
            }
        }

        private void Write18_CodeAndText(string n, string ns, CodeAndText o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(CodeAndText))
                    {
                        if (type == typeof(RatedValue))
                        {
                            this.Write187_RatedValue(n, ns, (RatedValue)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(CodeTextAndValue))
                        {
                            this.Write23_CodeTextAndValue(n, ns, (CodeTextAndValue)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(BathroomFaucets))
                        {
                            this.Write185_BathroomFaucets(n, ns, (BathroomFaucets)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(EnergyFactor))
                        {
                            this.Write22_EnergyFactor(n, ns, (EnergyFactor)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(OutputCapacity))
                        {
                            this.Write21_OutputCapacity(n, ns, (OutputCapacity)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(AdditionalOpening)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write17_AdditionalOpening(n, ns, (AdditionalOpening)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CodeAndText", "");
                }
                base.WriteAttribute("code", "", o.Code);
                base.WriteElementString("English", "", o.EnglishText);
                base.WriteElementString("French", "", o.FrenchText);
                if (o.Text != null)
                {
                    base.WriteValue(o.Text);
                }
                base.WriteEndElement(o);
            }
        }

        private void Write180_Window(string n, string ns, Window o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Window)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Window", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                base.WriteAttribute("number", "", XmlConvert.ToString(o.Number));
                base.WriteAttribute("er", "", XmlConvert.ToString(o.Er));
                base.WriteAttribute("shgc", "", XmlConvert.ToString(o.Shgc));
                base.WriteAttribute("frameHeight", "", XmlConvert.ToString(o.FrameHeight));
                base.WriteAttribute("frameAreaFraction", "", XmlConvert.ToString(o.FrameAreaFraction));
                base.WriteAttribute("edgeOfGlassFraction", "", XmlConvert.ToString(o.EdgeOfGlassFraction));
                base.WriteAttribute("centreOfGlassFraction", "", XmlConvert.ToString(o.CentreOfGlassFraction));
                base.WriteAttribute("adjacentEnclosedSpace", "", XmlConvert.ToString(o.AdjacentEnclosedSpace));
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write53_WindowConstruction("Construction", "", o.Construction, false, false);
                this.Write177_WindowMeasurements("Measurements", "", o.Measurements, false, false);
                this.Write178_WindowShading("Shading", "", o.Shading, false, false);
                this.Write179_EnergyStar("EnergyStar", "", o.EnergyStar, false, false);
                this.Write18_CodeAndText("FacingDirection", "", o.FacingDirectionXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write181_Component(string n, string ns, Component o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else if (!needType)
            {
                Type type = o.GetType();
                if (type != typeof(Component))
                {
                    if (type == typeof(BaseLoads))
                    {
                        this.Write195_BaseLoads(n, ns, (BaseLoads)o, isNullable, true);
                    }
                    else if (type == typeof(Window))
                    {
                        this.Write180_Window(n, ns, (Window)o, isNullable, true);
                    }
                    else if (type == typeof(Wall))
                    {
                        this.Write176_Wall(n, ns, (Wall)o, isNullable, true);
                    }
                    else if (type == typeof(Ventilation))
                    {
                        this.Write174_Ventilation(n, ns, (Ventilation)o, isNullable, true);
                    }
                    else if (type == typeof(Temperatures))
                    {
                        this.Write165_Temperatures(n, ns, (Temperatures)o, isNullable, true);
                    }
                    else if (type == typeof(Room))
                    {
                        this.Write160_Room(n, ns, (Room)o, isNullable, true);
                    }
                    else if (type == typeof(NaturalAirInfiltration))
                    {
                        this.Write157_NaturalAirInfiltration(n, ns, (NaturalAirInfiltration)o, isNullable, true);
                    }
                    else if (type == typeof(HotWater))
                    {
                        this.Write141_HotWater(n, ns, (HotWater)o, isNullable, true);
                    }
                    else if (type == typeof(Generation))
                    {
                        this.Write135_Generation(n, ns, (Generation)o, isNullable, true);
                    }
                    else if (type == typeof(Foundation))
                    {
                        this.Write129_Foundation(n, ns, (Foundation)o, isNullable, true);
                    }
                    else if (type == typeof(Basement))
                    {
                        this.Write130_Basement(n, ns, (Basement)o, isNullable, true);
                    }
                    else if (type == typeof(Walkout))
                    {
                        this.Write128_Walkout(n, ns, (Walkout)o, isNullable, true);
                    }
                    else if (type == typeof(Slab))
                    {
                        this.Write119_Slab(n, ns, (Slab)o, isNullable, true);
                    }
                    else if (type == typeof(Crawlspace))
                    {
                        this.Write117_Crawlspace(n, ns, (Crawlspace)o, isNullable, true);
                    }
                    else if (type == typeof(HeatingCooling))
                    {
                        this.Write108_HeatingCooling(n, ns, (HeatingCooling)o, isNullable, true);
                    }
                    else if (type == typeof(FloorHeader))
                    {
                        this.Write59_FloorHeader(n, ns, (FloorHeader)o, isNullable, true);
                    }
                    else if (type == typeof(Floor))
                    {
                        this.Write57_Floor(n, ns, (Floor)o, isNullable, true);
                    }
                    else if (type == typeof(Door))
                    {
                        this.Write50_Door(n, ns, (Door)o, isNullable, true);
                    }
                    else
                    {
                        if (!(type == typeof(Ceiling)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write47_Ceiling(n, ns, (Ceiling)o, isNullable, true);
                    }
                }
            }
        }

        private void Write182_OccupantsAtHome(string n, string ns, OccupantsAtHome o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(OccupantsAtHome)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("OccupantsAtHome", "");
                }
                base.WriteAttribute("occupants", "", XmlConvert.ToString(o.Occupants));
                base.WriteAttribute("atHome", "", XmlConvert.ToString(o.AtHome));
                base.WriteEndElement(o);
            }
        }

        private void Write183_Occupancy(string n, string ns, Occupancy o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Occupancy)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Occupancy", "");
                }
                base.WriteAttribute("isOccupied", "", XmlConvert.ToString(o.IsHouseOccupied));
                this.Write182_OccupantsAtHome("Adults", "", o.Adults, false, false);
                this.Write182_OccupantsAtHome("Children", "", o.Children, false, false);
                this.Write182_OccupantsAtHome("Infants", "", o.Infants, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write184_Summary(string n, string ns, Summary o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Summary)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Summary", "");
                }
                base.WriteAttribute("isSpecified", "", XmlConvert.ToString(o.IsSpecified));
                base.WriteAttribute("electricalAppliances", "", XmlConvert.ToString(o.ElectricalAppliances));
                base.WriteAttribute("lighting", "", XmlConvert.ToString(o.Lighting));
                base.WriteAttribute("otherElectric", "", XmlConvert.ToString(o.OtherElectric));
                base.WriteAttribute("exteriorUse", "", XmlConvert.ToString(o.ExteriorUse));
                base.WriteAttribute("hotWaterLoad", "", XmlConvert.ToString(o.HotWaterLoad));
                base.WriteEndElement(o);
            }
        }

        private void Write185_BathroomFaucets(string n, string ns, BathroomFaucets o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(BathroomFaucets)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("BathroomFaucets", "");
                }
                base.WriteAttribute("code", "", o.Code);
                base.WriteAttribute("value", "", XmlConvert.ToString(o.Value));
                base.WriteAttribute("numberPerOccupantPerDay", "", XmlConvert.ToString(o.NumberPerOccupantPerDay));
                base.WriteElementString("English", "", o.EnglishText);
                base.WriteElementString("French", "", o.FrenchText);
                if (o.Text != null)
                {
                    base.WriteValue(o.Text);
                }
                base.WriteEndElement(o);
            }
        }

        private void Write186_Shower(string n, string ns, Shower o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Shower)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Shower", "");
                }
                base.WriteAttribute("averageDuration", "", XmlConvert.ToString(o.AverageDuration));
                base.WriteAttribute("numberPerOccupantPerWeek", "", XmlConvert.ToString(o.NumberPerOccupantPerWeek));
                base.WriteAttribute("totalDurationPerDay", "", XmlConvert.ToString(o.TotalDurationPerDay));
                this.Write23_CodeTextAndValue("Temperature", "", o.TemperatureXml, false, false);
                this.Write23_CodeTextAndValue("FlowRate", "", o.FlowRateXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write187_RatedValue(string n, string ns, RatedValue o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(RatedValue)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("RatedValue", "");
                }
                base.WriteAttribute("code", "", o.Code);
                base.WriteAttribute("ratedWaterConsumptionPerCycle", "", XmlConvert.ToString(o.RatedWaterConsumptionPerCycle));
                base.WriteAttribute("ratedAnnualEnergyConsumption", "", XmlConvert.ToString(o.RatedAnnualEnergyConsumption));
                base.WriteElementString("English", "", o.EnglishText);
                base.WriteElementString("French", "", o.FrenchText);
                if (o.Text != null)
                {
                    base.WriteValue(o.Text);
                }
                base.WriteEndElement(o);
            }
        }

        private void Write188_ClothesWasher(string n, string ns, ClothesWasher o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ClothesWasher)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ClothesWasher", "");
                }
                base.WriteAttribute("numberPerOccupantPerWeek", "", XmlConvert.ToString(o.NumberPerOccupantPerWeek));
                this.Write187_RatedValue("RatedValues", "", o.RatedValues, false, false);
                this.Write18_CodeAndText("Temperature", "", o.TemperatureXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write189_DishWasher(string n, string ns, DishWasher o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DishWasher)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DishWasher", "");
                }
                base.WriteAttribute("numberPerOccupantPerWeek", "", XmlConvert.ToString(o.NumberPerOccupantPerWeek));
                this.Write187_RatedValue("RatedValues", "", o.RatedValues, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write19_RsiSection(string n, string ns, RsiSection o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(RsiSection)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("RsiSection", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteAttribute("percentage", "", XmlConvert.ToString(o.Percentage));
                base.WriteAttribute("rsi", "", XmlConvert.ToString(o.Rsi));
                base.WriteAttribute("nominalRsi", "", XmlConvert.ToString(o.NominalRsi));
                base.WriteEndElement(o);
            }
        }

        private void Write190_WaterUsage(string n, string ns, WaterUsage o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WaterUsage)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WaterUsage", "");
                }
                base.WriteAttribute("temperature", "", XmlConvert.ToString(o.Temperature));
                base.WriteAttribute("otherHotWaterUse", "", XmlConvert.ToString(o.OtherHotWaterUse));
                base.WriteAttribute("lowFlushToilets", "", XmlConvert.ToString(o.LowFlushToilets));
                this.Write185_BathroomFaucets("BathroomFaucets", "", o.BathroomFaucets, false, false);
                this.Write186_Shower("Shower", "", o.Shower, false, false);
                this.Write188_ClothesWasher("ClothesWasher", "", o.ClothesWasher, false, false);
                this.Write189_DishWasher("DishWasher", "", o.DishWasher, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write191_ClothesDryer(string n, string ns, ClothesDryer o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ClothesDryer)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ClothesDryer", "");
                }
                base.WriteAttribute("installed", "", XmlConvert.ToString(o.Installed));
                base.WriteAttribute("percentageOfWasherLoads", "", XmlConvert.ToString(o.PercentageOfWasherLoads));
                this.Write18_CodeAndText("Location", "", o.Location, false, false);
                this.Write18_CodeAndText("EnergySource", "", o.EnergySourceXml, false, false);
                this.Write23_CodeTextAndValue("RatedValue", "", o.RatedValueXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write192_Stove(string n, string ns, Stove o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Stove)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Stove", "");
                }
                this.Write18_CodeAndText("EnergySource", "", o.EnergySourceXml, false, false);
                this.Write23_CodeTextAndValue("RatedValue", "", o.RatedValueXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write193_ElectricalUsage(string n, string ns, ElectricalUsage o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ElectricalUsage)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ElectricalUsage", "");
                }
                base.WriteAttribute("otherLoad", "", XmlConvert.ToString(o.OtherLoad));
                base.WriteAttribute("averageExteriorUse", "", XmlConvert.ToString(o.AverageExteriorUse));
                this.Write191_ClothesDryer("ClothesDryer", "", o.ClothesDryer, false, false);
                this.Write192_Stove("Stove", "", o.Stove, false, false);
                this.Write23_CodeTextAndValue("Refrigerator", "", o.RefrigeratorXml, false, false);
                this.Write23_CodeTextAndValue("InteriorLighting", "", o.InteriorLightingXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write194_AdvancedUserSpecified(string n, string ns, AdvancedUserSpecified o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(AdvancedUserSpecified)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("AdvancedUserSpecified", "");
                }
                base.WriteAttribute("hotWaterTemperature", "", XmlConvert.ToString(o.HotWaterTemperature));
                this.Write18_CodeAndText("DryerLocation", "", o.DryerLocation, false, false);
                this.Write23_CodeTextAndValue("GasStove", "", o.GasStoveXml, false, false);
                this.Write23_CodeTextAndValue("GasDryer", "", o.GasDryerXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write195_BaseLoads(string n, string ns, BaseLoads o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(BaseLoads)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("BaseLoads", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                base.WriteAttribute("basementFractionOfInternalGains", "", XmlConvert.ToString(o.BasementFractionOfInternalGains));
                base.WriteAttribute("commonSpaceElectricalConsumption", "", XmlConvert.ToString(o.CommonSpaceElectricalConsumption));
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write183_Occupancy("Occupancy", "", o.Occupancy, false, false);
                this.Write184_Summary("Summary", "", o.Summary, false, false);
                this.Write190_WaterUsage("WaterUsage", "", o.WaterUsage, false, false);
                this.Write193_ElectricalUsage("ElectricalUsage", "", o.ElectricalUsage, false, false);
                this.Write194_AdvancedUserSpecified("AdvancedUserSpecified", "", o.AdvancedUserSpecified, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write196_BaseComponent(string n, string ns, BaseComponent o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(BaseComponent))
                    {
                        if (type == typeof(House))
                        {
                            this.Write205_House(n, ns, (House)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Component))
                        {
                            this.Write181_Component(n, ns, (Component)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(BaseLoads))
                        {
                            this.Write195_BaseLoads(n, ns, (BaseLoads)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Window))
                        {
                            this.Write180_Window(n, ns, (Window)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Wall))
                        {
                            this.Write176_Wall(n, ns, (Wall)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Ventilation))
                        {
                            this.Write174_Ventilation(n, ns, (Ventilation)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Temperatures))
                        {
                            this.Write165_Temperatures(n, ns, (Temperatures)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Room))
                        {
                            this.Write160_Room(n, ns, (Room)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(NaturalAirInfiltration))
                        {
                            this.Write157_NaturalAirInfiltration(n, ns, (NaturalAirInfiltration)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HotWater))
                        {
                            this.Write141_HotWater(n, ns, (HotWater)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Generation))
                        {
                            this.Write135_Generation(n, ns, (Generation)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Foundation))
                        {
                            this.Write129_Foundation(n, ns, (Foundation)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Basement))
                        {
                            this.Write130_Basement(n, ns, (Basement)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Walkout))
                        {
                            this.Write128_Walkout(n, ns, (Walkout)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Slab))
                        {
                            this.Write119_Slab(n, ns, (Slab)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Crawlspace))
                        {
                            this.Write117_Crawlspace(n, ns, (Crawlspace)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HeatingCooling))
                        {
                            this.Write108_HeatingCooling(n, ns, (HeatingCooling)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(FloorHeader))
                        {
                            this.Write59_FloorHeader(n, ns, (FloorHeader)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Floor))
                        {
                            this.Write57_Floor(n, ns, (Floor)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Door))
                        {
                            this.Write50_Door(n, ns, (Door)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(Ceiling)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write47_Ceiling(n, ns, (Ceiling)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("BaseComponent", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteEndElement(o);
            }
        }

        private void Write197_GableEnds(string n, string ns, GableEnds o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(GableEnds)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("GableEnds", "");
                }
                base.WriteAttribute("area", "", XmlConvert.ToString(o.area));
                this.Write23_CodeTextAndValue("SheatingMaterial", "", o.SheatingMaterialXml, false, false);
                this.Write23_CodeTextAndValue("ExteriorMaterial", "", o.ExteriorMaterialXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write198_SlopedRoof(string n, string ns, SlopedRoof o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SlopedRoof)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SlopedRoof", "");
                }
                base.WriteAttribute("area", "", XmlConvert.ToString(o.area));
                this.Write23_CodeTextAndValue("SheatingMaterial", "", o.SheatingMaterialXml, false, false);
                this.Write23_CodeTextAndValue("RoofingMaterial", "", o.RoofingMaterialXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write199_RoofCavity(string n, string ns, RoofCavity o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(RoofCavity)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("RoofCavity", "");
                }
                base.WriteAttribute("volume", "", XmlConvert.ToString(o.Volume));
                base.WriteAttribute("ventilationRate", "", XmlConvert.ToString(o.VentilationRate));
                this.Write197_GableEnds("GableEnds", "", o.GableEnds, false, false);
                this.Write198_SlopedRoof("SlopedRoof", "", o.SlopedRoof, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write2_Labels(string n, string ns, Labels o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Labels)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Labels", "");
                }
                base.WriteElementString("English", "", o.English);
                base.WriteElementString("French", "", o.French);
                base.WriteEndElement(o);
            }
        }

        private void Write20_CodeDescriptionAndComposite(string n, string ns, CodeDescriptionAndComposite o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CodeDescriptionAndComposite)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CodeDescriptionAndComposite", "");
                }
                base.WriteAttribute("idref", "", o.IdRef);
                base.WriteAttribute("code", "", o.Code);
                base.WriteAttribute("nominalInsulation", "", XmlConvert.ToString(o.NominalInsulation));
                base.WriteElementString("Description", "", o.Description);
                List<RsiSection> composite = o.Composite;
                if (composite != null)
                {
                    base.WriteStartElement("Composite", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= composite.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write19_RsiSection("Section", "", composite[num], true, false);
                        num++;
                    }
                }
                base.WriteEndElement(o);
            }
        }

        private void Write200_NumberOf(string n, string ns, NumberOf o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(NumberOf)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("NumberOf", "");
                }
                base.WriteAttribute("storeysInBuilding", "", XmlConvert.ToString(o.StoreysInBuilding));
                base.WriteAttribute("dwellingUnits", "", XmlConvert.ToString(o.DwellingUnits));
                base.WriteAttribute("nonResUnits", "", XmlConvert.ToString(o.NonResUnits));
                base.WriteAttribute("unitsVisited", "", XmlConvert.ToString(o.UnitsVisited));
                base.WriteEndElement(o);
            }
        }

        private void Write201_HeatedFloorArea(string n, string ns, HeatedFloorArea o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HeatedFloorArea)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HeatedFloorArea", "");
                }
                base.WriteAttribute("aboveGrade", "", XmlConvert.ToString(o.AboveGrade));
                base.WriteAttribute("belowGrade", "", XmlConvert.ToString(o.BelowGrade));
                base.WriteAttribute("nonResUnits", "", XmlConvert.ToString(o.NonResUnits));
                base.WriteAttribute("commonSpace", "", XmlConvert.ToString(o.CommonSpace));
                base.WriteEndElement(o);
            }
        }

        private void Write202_Specifications(string n, string ns, Specifications o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Specifications)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HouseSpecifications", "");
                }
                base.WriteAttribute("effectiveMassFraction", "", XmlConvert.ToString(o.EffectiveMassFraction));
                base.WriteAttribute("defaultRoofCavity", "", XmlConvert.ToString(o.DefaultRoofCavity));
                base.WriteAttribute("eligibleForNBC", "", XmlConvert.ToString(o.EligibleForNBC));
                base.WriteAttribute("buildingType", "", o.BuildingTypeXml);
                this.Write199_RoofCavity("RoofCavity", "", o.RoofCavity, false, false);
                this.Write200_NumberOf("NumberOf", "", o.NumberOf, false, false);
                this.Write201_HeatedFloorArea("HeatedFloorArea", "", o.HeatedFloorArea, false, false);
                this.Write18_CodeAndText("HouseType", "", o.HouseTypeXml, false, false);
                this.Write18_CodeAndText("PlanShape", "", o.PlanShapeXml, false, false);
                this.Write18_CodeAndText("Storeys", "", o.StoreysXml, false, false);
                this.Write18_CodeAndText("FacingDirection", "", o.FacingDirectionXml, false, false);
                this.Write18_CodeAndText("ThermalMass", "", o.ThermalMassXml, false, false);
                this.Write23_CodeTextAndValue("YearBuilt", "", o.YearBuiltXml, false, false);
                this.Write23_CodeTextAndValue("WallColour", "", o.WallColourXml, false, false);
                this.Write18_CodeAndText("SoilCondition", "", o.SoilConditionXml, false, false);
                this.Write23_CodeTextAndValue("RoofColour", "", o.RoofColourXml, false, false);
                this.Write18_CodeAndText("WaterLevel", "", o.WaterLevelXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write203_AttachmentFoundation(string n, string ns, AttachmentFoundation o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(AttachmentFoundation)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("AttachmentFoundation", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                base.WriteAttribute("aboveGradeArea", "", XmlConvert.ToString(o.AboveGradeArea));
                base.WriteAttribute("belowGradeArea", "", XmlConvert.ToString(o.BelowGradeArea));
                base.WriteAttribute("slabLength", "", XmlConvert.ToString(o.SlabLength));
                if (o.Text != null)
                {
                    base.WriteValue(o.Text);
                }
                base.WriteEndElement(o);
            }
        }

        private void Write204_Attachment(string n, string ns, Attachment o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Attachment)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Attachment", "");
                }
                this.Write203_AttachmentFoundation("Foundation1", "", o.Foundation1, false, false);
                this.Write203_AttachmentFoundation("Foundation2", "", o.Foundation2, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write205_House(string n, string ns, House o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(House)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("House", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                base.WriteAttribute("code", "", o.Code);
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                this.Write2_Labels("Labels", "", o.Labels, false, false);
                this.Write202_Specifications("Specifications", "", o.Specifications, false, false);
                this.Write195_BaseLoads("BaseLoads", "", o.BaseLoads, false, false);
                this.Write135_Generation("Generation", "", o.Generation, false, false);
                this.Write108_HeatingCooling("HeatingCooling", "", o.HeatingCooling, false, false);
                List<Attachment> foundationAttachments = o.FoundationAttachments;
                if (foundationAttachments != null)
                {
                    base.WriteStartElement("FoundationAttachments", "", null, false);
                    int num2 = 0;
                    while (true)
                    {
                        if (num2 >= foundationAttachments.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write204_Attachment("Attachment", "", foundationAttachments[num2], true, false);
                        num2++;
                    }
                }
                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", o.NaturalAirInfiltration, false, false);
                this.Write165_Temperatures("Temperatures", "", o.Temperatures, false, false);
                this.Write174_Ventilation("Ventilation", "", o.Ventilation, false, false);
                this.Write23_CodeTextAndValue("WindowTightness", "", o.WindowTightnessXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write206_ContinuousMedium(string n, string ns, ContinuousMedium o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ContinuousMedium)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ContinuousMedium", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteAttribute("resistivity", "", XmlConvert.ToString(o.Resistivity));
                base.WriteAttribute("thickness", "", XmlConvert.ToString(o.Thickness));
                this.Write220_Material("Material", "", o.Material, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write207_Studs(string n, string ns, Studs o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Studs)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Studs", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteAttribute("resistivity", "", XmlConvert.ToString(o.Resistivity));
                base.WriteAttribute("isWood", "", XmlConvert.ToString(o.IsWood));
                this.Write220_Material("Material", "", o.Material, false, false);
                this.Write18_CodeAndText("Quantity", "", o.Quantity, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write208_LintelUserDefined(string n, string ns, LintelUserDefined o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(LintelUserDefined)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("LintelUserDefined", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteAttribute("totalThickness", "", XmlConvert.ToString(o.TotalThickness));
                this.Write207_Studs("Studs", "", o.Studs, false, false);
                this.Write221_UserDefinedBaseComponent("Insulation", "", o.Insulation, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write209_WoodFramingType(string n, string ns, WoodFramingType o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WoodFramingType)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WoodFramingType", "");
                }
                this.Write18_CodeAndText("Structure", "", o.Structure, false, false);
                this.Write18_CodeAndText("Truss", "", o.Truss, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write21_OutputCapacity(string n, string ns, OutputCapacity o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(OutputCapacity)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("OutputCapacity", "");
                }
                base.WriteAttribute("code", "", o.Code);
                base.WriteAttribute("value", "", XmlConvert.ToString(o.Value));
                base.WriteAttribute("uiUnits", "", o.UiUnits);
                base.WriteElementString("English", "", o.EnglishText);
                base.WriteElementString("French", "", o.FrenchText);
                if (o.Text != null)
                {
                    base.WriteValue(o.Text);
                }
                base.WriteEndElement(o);
            }
        }

        private void Write210_FramingComponent(string n, string ns, FramingComponent o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FramingComponent)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FramingComponent", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteAttribute("resistivity", "", XmlConvert.ToString(o.Resistivity));
                base.WriteAttribute("thickness", "", XmlConvert.ToString(o.Thickness));
                base.WriteAttribute("width", "", XmlConvert.ToString(o.Width));
                base.WriteAttribute("spacing", "", XmlConvert.ToString(o.Spacing));
                this.Write220_Material("Material", "", o.Material, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write211_WoodFramingLayer(string n, string ns, WoodFramingLayer o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WoodFramingLayer)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WoodFramingLayer", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteAttribute("isPrimary", "", XmlConvert.ToString(o.IsPrimary));
                base.WriteAttribute("studsPerCorner", "", XmlConvert.ToString(o.StudsPerCorner));
                base.WriteAttribute("studsPerInteriorWall", "", XmlConvert.ToString(o.StudsPerInteriorWall));
                base.WriteAttribute("topAndBottomPlates", "", XmlConvert.ToString(o.TopAndBottomPlates));
                base.WriteAttribute("doubleStudsOnWindows", "", XmlConvert.ToString(o.DoubleStudsOnWindows));
                base.WriteAttribute("ridgeBoardWidth", "", XmlConvert.ToString(o.RidgeBoardWidth));
                base.WriteAttribute("blockingWidth", "", XmlConvert.ToString(o.BlockingWidth));
                this.Write222_UserDefinedComponent("CavityInsulation", "", o.CavityInsulation, false, false);
                this.Write209_WoodFramingType("Type", "", o.Type, false, false);
                this.Write210_FramingComponent("Framing", "", o.Framing, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write212_FramingLayer(string n, string ns, FramingLayer o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(FramingLayer))
                    {
                        if (type == typeof(SteelFramingLayer))
                        {
                            this.Write214_SteelFramingLayer(n, ns, (SteelFramingLayer)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(WoodFramingLayer)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write211_WoodFramingLayer(n, ns, (WoodFramingLayer)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FramingLayer", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteAttribute("isPrimary", "", XmlConvert.ToString(o.IsPrimary));
                base.WriteAttribute("studsPerCorner", "", XmlConvert.ToString(o.StudsPerCorner));
                base.WriteAttribute("studsPerInteriorWall", "", XmlConvert.ToString(o.StudsPerInteriorWall));
                base.WriteAttribute("topAndBottomPlates", "", XmlConvert.ToString(o.TopAndBottomPlates));
                base.WriteAttribute("doubleStudsOnWindows", "", XmlConvert.ToString(o.DoubleStudsOnWindows));
                base.WriteAttribute("ridgeBoardWidth", "", XmlConvert.ToString(o.RidgeBoardWidth));
                base.WriteAttribute("blockingWidth", "", XmlConvert.ToString(o.BlockingWidth));
                this.Write222_UserDefinedComponent("CavityInsulation", "", o.CavityInsulation, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write213_SteelFraming(string n, string ns, SteelFraming o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SteelFraming)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SteelFraming", "");
                }
                base.WriteAttribute("thickness", "", XmlConvert.ToString(o.Thickness));
                base.WriteAttribute("width", "", XmlConvert.ToString(o.Width));
                base.WriteAttribute("spacing", "", XmlConvert.ToString(o.Spacing));
                this.Write23_CodeTextAndValue("SteelGauge", "", o.SteelGauge, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write214_SteelFramingLayer(string n, string ns, SteelFramingLayer o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SteelFramingLayer)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SteelFramingLayer", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteAttribute("isPrimary", "", XmlConvert.ToString(o.IsPrimary));
                base.WriteAttribute("studsPerCorner", "", XmlConvert.ToString(o.StudsPerCorner));
                base.WriteAttribute("studsPerInteriorWall", "", XmlConvert.ToString(o.StudsPerInteriorWall));
                base.WriteAttribute("topAndBottomPlates", "", XmlConvert.ToString(o.TopAndBottomPlates));
                base.WriteAttribute("doubleStudsOnWindows", "", XmlConvert.ToString(o.DoubleStudsOnWindows));
                base.WriteAttribute("ridgeBoardWidth", "", XmlConvert.ToString(o.RidgeBoardWidth));
                base.WriteAttribute("blockingWidth", "", XmlConvert.ToString(o.BlockingWidth));
                this.Write222_UserDefinedComponent("CavityInsulation", "", o.CavityInsulation, false, false);
                this.Write213_SteelFraming("Framing", "", o.Framing, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write215_StrappingLayer(string n, string ns, StrappingLayer o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(StrappingLayer)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("StrappingLayer", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                this.Write210_FramingComponent("Strapping", "", o.Strapping, false, false);
                this.Write222_UserDefinedComponent("CavityInsulation", "", o.CavityInsulation, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write216_WindowUserDefined(string n, string ns, WindowUserDefined o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WindowUserDefined)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WindowUserDefined", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteAttribute("frameHeight", "", XmlConvert.ToString(o.FrameHeight));
                base.WriteAttribute("shgc", "", XmlConvert.ToString(o.Shgc));
                this.Write18_CodeAndText("GlazingType", "", o.GlazingType, false, false);
                this.Write23_CodeTextAndValue("OverallThermalResistance", "", o.OverallThermalResistance, false, false);
                this.Write18_CodeAndText("WindowStyle", "", o.WindowStyle, false, false);
                this.Write18_CodeAndText("FillGas", "", o.FillGas, false, false);
                this.Write18_CodeAndText("LowECoating", "", o.LowECoating, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write217_RsiValues(string n, string ns, RsiValues o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(RsiValues)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("RsiValues", "");
                }
                base.WriteAttribute("centreOfGlass", "", XmlConvert.ToString(o.CentreOfGlass));
                base.WriteAttribute("edgeOfGlass", "", XmlConvert.ToString(o.EdgeOfGlass));
                base.WriteAttribute("frame", "", XmlConvert.ToString(o.Frame));
                base.WriteEndElement(o);
            }
        }

        private void Write218_WindowLegacy(string n, string ns, WindowLegacy o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WindowLegacy)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WindowLegacy", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteAttribute("frameHeight", "", XmlConvert.ToString(o.FrameHeight));
                base.WriteAttribute("shgc", "", XmlConvert.ToString(o.Shgc));
                this.Write18_CodeAndText("Type", "", o.Type, false, false);
                this.Write217_RsiValues("RsiValues", "", o.RsiValues, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write219_UserDefinedLayer(string n, string ns, UserDefinedLayer o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(UserDefinedLayer))
                    {
                        if (type == typeof(UserDefinedBaseComponent))
                        {
                            this.Write221_UserDefinedBaseComponent(n, ns, (UserDefinedBaseComponent)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(UserDefinedComponent))
                        {
                            this.Write222_UserDefinedComponent(n, ns, (UserDefinedComponent)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ContinuousInsulation))
                        {
                            this.Write223_ContinuousInsulation(n, ns, (ContinuousInsulation)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(FramingComponent))
                        {
                            this.Write210_FramingComponent(n, ns, (FramingComponent)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ContinuousMedium))
                        {
                            this.Write206_ContinuousMedium(n, ns, (ContinuousMedium)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Studs))
                        {
                            this.Write207_Studs(n, ns, (Studs)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(WindowLegacy))
                        {
                            this.Write218_WindowLegacy(n, ns, (WindowLegacy)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(WindowUserDefined))
                        {
                            this.Write216_WindowUserDefined(n, ns, (WindowUserDefined)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(StrappingLayer))
                        {
                            this.Write215_StrappingLayer(n, ns, (StrappingLayer)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(FramingLayer))
                        {
                            this.Write212_FramingLayer(n, ns, (FramingLayer)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(SteelFramingLayer))
                        {
                            this.Write214_SteelFramingLayer(n, ns, (SteelFramingLayer)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(WoodFramingLayer))
                        {
                            this.Write211_WoodFramingLayer(n, ns, (WoodFramingLayer)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(LintelUserDefined)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write208_LintelUserDefined(n, ns, (LintelUserDefined)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("UserDefinedLayer", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteEndElement(o);
            }
        }

        private void Write22_EnergyFactor(string n, string ns, EnergyFactor o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(EnergyFactor)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("EnergyFactor", "");
                }
                base.WriteAttribute("code", "", o.Code);
                base.WriteAttribute("value", "", XmlConvert.ToString(o.Value));
                base.WriteAttribute("inputCapacity", "", XmlConvert.ToString(o.InputCapacity));
                base.WriteAttribute("thermalEfficiency", "", XmlConvert.ToString(o.ThermalEfficiency));
                base.WriteAttribute("standbyHeatLoss", "", XmlConvert.ToString(o.StandbyHeatLoss));
                base.WriteAttribute("standbyHeatLossMode", "", XmlConvert.ToString(o.StandbyHeatLossMode));
                base.WriteAttribute("isUniform", "", XmlConvert.ToString(o.isUniform));
                base.WriteElementString("English", "", o.EnglishText);
                base.WriteElementString("French", "", o.FrenchText);
                if (o.Text != null)
                {
                    base.WriteValue(o.Text);
                }
                base.WriteEndElement(o);
            }
        }

        private void Write220_Material(string n, string ns, Material o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Material)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Material", "");
                }
                this.Write18_CodeAndText("Category", "", o.Category, false, false);
                this.Write18_CodeAndText("Type", "", o.Type, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write221_UserDefinedBaseComponent(string n, string ns, UserDefinedBaseComponent o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(UserDefinedBaseComponent))
                    {
                        if (type == typeof(UserDefinedComponent))
                        {
                            this.Write222_UserDefinedComponent(n, ns, (UserDefinedComponent)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ContinuousInsulation))
                        {
                            this.Write223_ContinuousInsulation(n, ns, (ContinuousInsulation)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(FramingComponent))
                        {
                            this.Write210_FramingComponent(n, ns, (FramingComponent)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ContinuousMedium))
                        {
                            this.Write206_ContinuousMedium(n, ns, (ContinuousMedium)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(Studs)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write207_Studs(n, ns, (Studs)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("UserDefinedBaseComponent", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteAttribute("resistivity", "", XmlConvert.ToString(o.Resistivity));
                this.Write220_Material("Material", "", o.Material, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write222_UserDefinedComponent(string n, string ns, UserDefinedComponent o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(UserDefinedComponent))
                    {
                        if (type == typeof(ContinuousInsulation))
                        {
                            this.Write223_ContinuousInsulation(n, ns, (ContinuousInsulation)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(FramingComponent))
                        {
                            this.Write210_FramingComponent(n, ns, (FramingComponent)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(ContinuousMedium)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write206_ContinuousMedium(n, ns, (ContinuousMedium)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("UserDefinedComponent", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteAttribute("resistivity", "", XmlConvert.ToString(o.Resistivity));
                base.WriteAttribute("thickness", "", XmlConvert.ToString(o.Thickness));
                this.Write220_Material("Material", "", o.Material, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write223_ContinuousInsulation(string n, string ns, ContinuousInsulation o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ContinuousInsulation)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ContinuousInsulation", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteAttribute("resistivity", "", XmlConvert.ToString(o.Resistivity));
                base.WriteAttribute("thickness", "", XmlConvert.ToString(o.Thickness));
                this.Write220_Material("Material", "", o.Material, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write224_UserDefined(string n, string ns, UserDefined o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(UserDefined)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("UserDefined", "");
                }
                base.WriteAttribute("id", "", o.Id);
                base.WriteAttribute("nominalRValue", "", XmlConvert.ToString(o.NominalRValue));
                base.WriteElementString("Label", "", o.Label);
                base.WriteElementString("Description", "", o.Description);
                List<UserDefinedLayer> layers = o.Layers;
                if (layers != null)
                {
                    base.WriteStartElement("Layers", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= layers.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        UserDefinedLayer layer = layers[num];
                        if (layer != null)
                        {
                            if (layer is ContinuousInsulation)
                            {
                                this.Write223_ContinuousInsulation("ContinuousInsulation", "", (ContinuousInsulation)layer, true, false);
                            }
                            else if (layer is ContinuousMedium)
                            {
                                this.Write206_ContinuousMedium("ContinuousMedium", "", (ContinuousMedium)layer, true, false);
                            }
                            else if (layer is WoodFramingLayer)
                            {
                                this.Write211_WoodFramingLayer("WoodFraming", "", (WoodFramingLayer)layer, true, false);
                            }
                            else if (layer is SteelFramingLayer)
                            {
                                this.Write214_SteelFramingLayer("SteelFraming", "", (SteelFramingLayer)layer, true, false);
                            }
                            else if (layer is WindowUserDefined)
                            {
                                this.Write216_WindowUserDefined("Window", "", (WindowUserDefined)layer, true, false);
                            }
                            else if (layer is StrappingLayer)
                            {
                                this.Write215_StrappingLayer("Strapping", "", (StrappingLayer)layer, true, false);
                            }
                            else if (layer is LintelUserDefined)
                            {
                                this.Write208_LintelUserDefined("Lintel", "", (LintelUserDefined)layer, true, false);
                            }
                            else if (layer is WindowLegacy)
                            {
                                this.Write218_WindowLegacy("WindowLegacy", "", (WindowLegacy)layer, true, false);
                            }
                            else if (layer != null)
                            {
                                throw base.CreateUnknownTypeException(layer);
                            }
                        }
                        num++;
                    }
                }
                base.WriteEndElement(o);
            }
        }

        private void Write225_Code(string n, string ns, Code o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(Code))
                    {
                        if (type == typeof(Standard))
                        {
                            this.Write227_Standard(n, ns, (Standard)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(UserDefined)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write224_UserDefined(n, ns, (UserDefined)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Code", "");
                }
                base.WriteAttribute("id", "", o.Id);
                base.WriteAttribute("nominalRValue", "", XmlConvert.ToString(o.NominalRValue));
                base.WriteElementString("Label", "", o.Label);
                base.WriteElementString("Description", "", o.Description);
                base.WriteEndElement(o);
            }
        }

        private void Write226_StandardLayer(string n, string ns, StandardLayer o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(StandardLayer)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("StandardLayer", "");
                }
                this.Write18_CodeAndText("InsulationInFramingLayer", "", o.InsulationInFramingLayer, false, false);
                this.Write18_CodeAndText("ExtraInsulationLayer", "", o.ExtraInsulationLayer, false, false);
                this.Write18_CodeAndText("Framing", "", o.Framing, false, false);
                this.Write18_CodeAndText("StructureType", "", o.StructureType, false, false);
                this.Write18_CodeAndText("ComponentTypeSize", "", o.ComponentTypeSize, false, false);
                this.Write18_CodeAndText("Spacing", "", o.Spacing, false, false);
                this.Write18_CodeAndText("Insulation", "", o.Insulation, false, false);
                this.Write18_CodeAndText("InsulationLayer1", "", o.InsulationLayer1, false, false);
                this.Write18_CodeAndText("InsulationLayer2", "", o.InsulationLayer2, false, false);
                this.Write18_CodeAndText("Interior", "", o.Interior, false, false);
                this.Write18_CodeAndText("InteriorFinish", "", o.InteriorFinish, false, false);
                this.Write18_CodeAndText("Sheathing", "", o.Sheathing, false, false);
                this.Write18_CodeAndText("Exterior", "", o.Exterior, false, false);
                this.Write18_CodeAndText("Type", "", o.Type, false, false);
                this.Write18_CodeAndText("DropFraming", "", o.DropFraming, false, false);
                this.Write18_CodeAndText("Material", "", o.Material, false, false);
                this.Write18_CodeAndText("StudsCornerIntersection", "", o.StudsCornerIntersection, false, false);
                this.Write18_CodeAndText("GlazingTypes", "", o.GlazingTypes, false, false);
                this.Write18_CodeAndText("CoatingsTints", "", o.CoatingsTints, false, false);
                this.Write18_CodeAndText("FillType", "", o.FillType, false, false);
                this.Write18_CodeAndText("SpacerType", "", o.SpacerType, false, false);
                this.Write18_CodeAndText("FrameMaterial", "", o.FrameMaterial, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write227_Standard(string n, string ns, Standard o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Standard)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Standard", "");
                }
                base.WriteAttribute("id", "", o.Id);
                base.WriteAttribute("nominalRValue", "", XmlConvert.ToString(o.NominalRValue));
                base.WriteAttribute("value", "", o.Value);
                base.WriteElementString("Label", "", o.Label);
                base.WriteElementString("Description", "", o.Description);
                this.Write226_StandardLayer("Layers", "", o.Layers, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write228_CodesByType(string n, string ns, CodesByType o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CodesByType)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CodesByType", "");
                }
                List<Standard> standard = o.Standard;
                if (standard != null)
                {
                    base.WriteStartElement("Standard", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= standard.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write227_Standard("Code", "", standard[num], true, false);
                        num++;
                    }
                }
                List<Standard> favorite = o.Favorite;
                if (favorite != null)
                {
                    base.WriteStartElement("Favorite", "", null, false);
                    int num2 = 0;
                    while (true)
                    {
                        if (num2 >= favorite.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write227_Standard("Code", "", favorite[num2], true, false);
                        num2++;
                    }
                }
                List<UserDefined> userDefined = o.UserDefined;
                if (userDefined != null)
                {
                    base.WriteStartElement("UserDefined", "", null, false);
                    int num3 = 0;
                    while (true)
                    {
                        if (num3 >= userDefined.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write224_UserDefined("Code", "", userDefined[num3], true, false);
                        num3++;
                    }
                }
                base.WriteEndElement(o);
            }
        }

        private void Write229_Codes(string n, string ns, Codes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Codes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Codes", "");
                }
                base.WriteAttribute("readOnly", "", XmlConvert.ToString(o.isReadOnly));
                this.Write228_CodesByType("Wall", "", o.Wall, false, false);
                this.Write228_CodesByType("Ceiling", "", o.Ceiling, false, false);
                this.Write228_CodesByType("CeilingFlat", "", o.CeilingFlat, false, false);
                this.Write228_CodesByType("Floor", "", o.Floor, false, false);
                this.Write228_CodesByType("Lintel", "", o.Lintel, false, false);
                this.Write228_CodesByType("Window", "", o.Window, false, false);
                this.Write228_CodesByType("FloorsAbove", "", o.FloorsAbove, false, false);
                this.Write228_CodesByType("FloorsAdded", "", o.FloorsAdded, false, false);
                this.Write228_CodesByType("BasementWall", "", o.BasementWall, false, false);
                this.Write228_CodesByType("CrawlspaceWall", "", o.CrawlspaceWall, false, false);
                this.Write228_CodesByType("FloorHeader", "", o.FloorHeader, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write23_CodeTextAndValue(string n, string ns, CodeTextAndValue o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(CodeTextAndValue))
                    {
                        if (type == typeof(BathroomFaucets))
                        {
                            this.Write185_BathroomFaucets(n, ns, (BathroomFaucets)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(EnergyFactor))
                        {
                            this.Write22_EnergyFactor(n, ns, (EnergyFactor)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(OutputCapacity)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write21_OutputCapacity(n, ns, (OutputCapacity)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CodeTextAndValue", "");
                }
                base.WriteAttribute("code", "", o.Code);
                base.WriteAttribute("value", "", XmlConvert.ToString(o.Value));
                base.WriteElementString("English", "", o.EnglishText);
                base.WriteElementString("French", "", o.FrenchText);
                if (o.Text != null)
                {
                    base.WriteValue(o.Text);
                }
                base.WriteEndElement(o);
            }
        }

        private void Write230_Setting(string n, string ns, Setting o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Setting)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Setting", "");
                }
                base.WriteAttribute("cost", "", XmlConvert.ToString(o.Cost));
                base.WriteAttribute("priority", "", XmlConvert.ToString(o.priority));
                this.Write6_Cardinal("Cost", "", o.WindowCost, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write231_Settings(string n, string ns, Settings o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Settings)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Settings", "");
                }
                base.WriteAttribute("calculateSavingsIndividually", "", XmlConvert.ToString(o.CalculateSavingsIndividually));
                this.Write230_Setting("CathedralCeilingsFlat", "", o.CathedralCeilingsFlat, false, false);
                this.Write230_Setting("Ceilings", "", o.Ceilings, false, false);
                this.Write230_Setting("MainWalls", "", o.MainWalls, false, false);
                this.Write230_Setting("Foundation", "", o.Foundation, false, false);
                this.Write230_Setting("Floor", "", o.Floor, false, false);
                this.Write230_Setting("Windows", "", o.Windows, false, false);
                this.Write230_Setting("AirTightness", "", o.AirTightness, false, false);
                this.Write230_Setting("Doors", "", o.Doors, false, false);
                this.Write230_Setting("Heating", "", o.Heating, false, false);
                this.Write230_Setting("HotWater", "", o.HotWater, false, false);
                this.Write230_Setting("Ventilation", "", o.Ventilation, false, false);
                this.Write230_Setting("Cooling", "", o.Cooling, false, false);
                this.Write230_Setting("TemperatureSetPoints", "", o.TemperatureSetPoints, false, false);
                this.Write230_Setting("Rooms", "", o.Rooms, false, false);
                this.Write230_Setting("Units", "", o.Units, false, false);
                this.Write230_Setting("PhotovoltaicGeneration", "", o.PhotovoltaicGeneration, false, false);
                this.Write230_Setting("Baseloads", "", o.Baseloads, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write232_GreenerHomes(string n, string ns, GreenerHomes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(GreenerHomes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("GreenerHomes", "");
                }
                base.WriteAttribute("basementSlabInsulated", "", XmlConvert.ToString(o.BasementSlabInsulated));
                base.WriteAttribute("moistureProofCrawlSpace", "", XmlConvert.ToString(o.MoistureProofCrawlSpace));
                base.WriteAttribute("waterproofing", "", XmlConvert.ToString(o.Waterproofing));
                base.WriteAttribute("roofingMembrane", "", XmlConvert.ToString(o.RoofingMembrane));
                base.WriteAttribute("minR10ContinuousExposedFloors", "", XmlConvert.ToString(o.MinR10ContinuousExposedFloors));
                base.WriteAttribute("backwaterValve", "", XmlConvert.ToString(o.BackwaterValve));
                base.WriteAttribute("sumpPump", "", XmlConvert.ToString(o.SumpPump));
                base.WriteAttribute("smartThermostats", "", XmlConvert.ToString(o.SmartThermostats));
                base.WriteEndElement(o);
            }
        }

        private void Write233_EnergyUpgrades(string n, string ns, EnergyUpgrades o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(EnergyUpgrades)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("EnergyUpgrades", "");
                }
                this.Write231_Settings("Settings", "", o.Settings, false, false);
                List<Component> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        Component component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                this.Write232_GreenerHomes("GreenerHomes", "", o.GreenerHomes, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write234_FuelCostMinimum(string n, string ns, FuelCostMinimum o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FuelCostMinimum)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FuelCostMinimum", "");
                }
                base.WriteAttribute("units", "", XmlConvert.ToString(o.units));
                base.WriteAttribute("charge", "", XmlConvert.ToString(o.charge));
                base.WriteEndElement(o);
            }
        }

        private void Write235_FuelCostRateBlock(string n, string ns, FuelCostRateBlock o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FuelCostRateBlock)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FuelCostRateBlock", "");
                }
                base.WriteAttribute("units", "", XmlConvert.ToString(o.units));
                base.WriteAttribute("costPerUnit", "", XmlConvert.ToString(o.costPerUnit));
                base.WriteEndElement(o);
            }
        }

        private void Write236_FuelCostRateBlocks(string n, string ns, FuelCostRateBlocks o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FuelCostRateBlocks)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FuelCostRateBlocks", "");
                }
                this.Write235_FuelCostRateBlock("Block1", "", o.Block1, false, false);
                this.Write235_FuelCostRateBlock("Block2", "", o.Block2, false, false);
                this.Write235_FuelCostRateBlock("Block3", "", o.Block3, false, false);
                this.Write235_FuelCostRateBlock("Block4", "", o.Block4, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write237_FuelCostByType(string n, string ns, FuelCostByType o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FuelCostByType)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FuelCostByType", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                base.WriteElementString("Label", "", o.Label);
                base.WriteElementString("Comment", "", o.Comment);
                this.Write18_CodeAndText("Units", "", o.Units, false, false);
                this.Write234_FuelCostMinimum("Minimum", "", o.Minimum, false, false);
                this.Write236_FuelCostRateBlocks("RateBlocks", "", o.RateBlocks, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write238_FuelCostMonthlyData(string n, string ns, FuelCostMonthlyData o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FuelCostMonthlyData)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FuelCostMonthlyData", "");
                }
                base.WriteAttribute("january", "", o.January);
                base.WriteAttribute("february", "", o.February);
                base.WriteAttribute("march", "", o.March);
                base.WriteAttribute("april", "", o.April);
                base.WriteAttribute("may", "", o.May);
                base.WriteAttribute("june", "", o.June);
                base.WriteAttribute("july", "", o.July);
                base.WriteAttribute("august", "", o.August);
                base.WriteAttribute("september", "", o.September);
                base.WriteAttribute("october", "", o.October);
                base.WriteAttribute("november", "", o.November);
                base.WriteAttribute("december", "", o.December);
                base.WriteEndElement(o);
            }
        }

        private void Write239_FuelCostsMonthly(string n, string ns, FuelCostsMonthly o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FuelCostsMonthly)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FuelCostsMonthly", "");
                }
                this.Write238_FuelCostMonthlyData("Electricity", "", o.Electricity, false, false);
                this.Write238_FuelCostMonthlyData("NaturalGas", "", o.NaturalGas, false, false);
                this.Write238_FuelCostMonthlyData("Oil", "", o.Oil, false, false);
                this.Write238_FuelCostMonthlyData("Propane", "", o.Propane, false, false);
                this.Write238_FuelCostMonthlyData("Wood", "", o.Wood, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write24_CopSeerValue(string n, string ns, CopSeerValue o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CopSeerValue)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CopSeerValue", "");
                }
                base.WriteAttribute("isCop", "", XmlConvert.ToString(o.IsCop));
                base.WriteAttribute("value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write240_FuelCosts(string n, string ns, FuelCosts o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FuelCosts)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FuelCosts", "");
                }
                base.WriteAttribute("includeCostCalculations", "", XmlConvert.ToString(o.IncludeCostCalculations));
                base.WriteAttribute("library", "", o.LibraryFile);
                List<FuelCostByType> electricity = o.Electricity;
                if (electricity != null)
                {
                    base.WriteStartElement("Electricity", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= electricity.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write237_FuelCostByType("Fuel", "", electricity[num], true, false);
                        num++;
                    }
                }
                List<FuelCostByType> naturalGas = o.NaturalGas;
                if (naturalGas != null)
                {
                    base.WriteStartElement("NaturalGas", "", null, false);
                    int num2 = 0;
                    while (true)
                    {
                        if (num2 >= naturalGas.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write237_FuelCostByType("Fuel", "", naturalGas[num2], true, false);
                        num2++;
                    }
                }
                List<FuelCostByType> oil = o.Oil;
                if (oil != null)
                {
                    base.WriteStartElement("Oil", "", null, false);
                    int num3 = 0;
                    while (true)
                    {
                        if (num3 >= oil.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write237_FuelCostByType("Fuel", "", oil[num3], true, false);
                        num3++;
                    }
                }
                List<FuelCostByType> propane = o.Propane;
                if (propane != null)
                {
                    base.WriteStartElement("Propane", "", null, false);
                    int num4 = 0;
                    while (true)
                    {
                        if (num4 >= propane.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write237_FuelCostByType("Fuel", "", propane[num4], true, false);
                        num4++;
                    }
                }
                List<FuelCostByType> wood = o.Wood;
                if (wood != null)
                {
                    base.WriteStartElement("Wood", "", null, false);
                    int num5 = 0;
                    while (true)
                    {
                        if (num5 >= wood.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write237_FuelCostByType("Fuel", "", wood[num5], true, false);
                        num5++;
                    }
                }
                this.Write239_FuelCostsMonthly("Monthly", "", o.Monthly, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write241_HotWaterElectrical(string n, string ns, HotWaterElectrical o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HotWaterElectrical)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HotWaterElectrical", "");
                }
                base.WriteAttribute("dhw", "", XmlConvert.ToString(o.Dhw));
                base.WriteAttribute("primary", "", XmlConvert.ToString(o.Primary));
                base.WriteAttribute("secondary", "", XmlConvert.ToString(o.Secondary));
                base.WriteEndElement(o);
            }
        }

        private void Write242_ElectricalAnnual(string n, string ns, ElectricalAnnual o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ElectricalAnnual)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ElectricalAnnual", "");
                }
                base.WriteAttribute("baseload", "", XmlConvert.ToString(o.Baseload));
                base.WriteAttribute("airConditioning", "", XmlConvert.ToString(o.AirConditioning));
                base.WriteAttribute("appliance", "", XmlConvert.ToString(o.Appliance));
                base.WriteAttribute("lighting", "", XmlConvert.ToString(o.Lighting));
                base.WriteAttribute("heatPump", "", XmlConvert.ToString(o.HeatPump));
                base.WriteAttribute("spaceHeating", "", XmlConvert.ToString(o.SpaceHeating));
                base.WriteAttribute("spaceCooling", "", XmlConvert.ToString(o.SpaceCooling));
                base.WriteAttribute("ventilation", "", XmlConvert.ToString(o.Ventilation));
                base.WriteAttribute("total", "", XmlConvert.ToString(o.TotalInGigaJoules));
                this.Write241_HotWaterElectrical("HotWater", "", o.HotWater, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write243_PropaneAppliance(string n, string ns, PropaneAppliance o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(PropaneAppliance)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("PropaneAppliance", "");
                }
                base.WriteAttribute("baseload", "", XmlConvert.ToString(o.Baseload));
                base.WriteAttribute("hotWater", "", XmlConvert.ToString(o.HotWater));
                base.WriteAttribute("spaceHeating", "", XmlConvert.ToString(o.SpaceHeating));
                base.WriteAttribute("total", "", XmlConvert.ToString(o.TotalInGigaJoules));
                base.WriteAttribute("appliance", "", XmlConvert.ToString(o.Appliance));
                base.WriteEndElement(o);
            }
        }

        private void Write244_Consummable(string n, string ns, Consummable o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(Consummable))
                    {
                        if (type == typeof(PropaneConsummable))
                        {
                            this.Write394_PropaneConsummable(n, ns, (PropaneConsummable)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Wood))
                        {
                            this.Write247_Wood(n, ns, (Wood)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Oil))
                        {
                            this.Write246_Oil(n, ns, (Oil)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(NaturalGasAppliance))
                        {
                            this.Write245_NaturalGasAppliance(n, ns, (NaturalGasAppliance)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(PropaneAppliance)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write243_PropaneAppliance(n, ns, (PropaneAppliance)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Consummable", "");
                }
                base.WriteAttribute("baseload", "", XmlConvert.ToString(o.Baseload));
                base.WriteAttribute("hotWater", "", XmlConvert.ToString(o.HotWater));
                base.WriteAttribute("spaceHeating", "", XmlConvert.ToString(o.SpaceHeating));
                base.WriteAttribute("total", "", XmlConvert.ToString(o.TotalInGigaJoules));
                base.WriteEndElement(o);
            }
        }

        private void Write245_NaturalGasAppliance(string n, string ns, NaturalGasAppliance o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(NaturalGasAppliance)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("NaturalGasAppliance", "");
                }
                base.WriteAttribute("baseload", "", XmlConvert.ToString(o.Baseload));
                base.WriteAttribute("hotWater", "", XmlConvert.ToString(o.HotWater));
                base.WriteAttribute("spaceHeating", "", XmlConvert.ToString(o.SpaceHeating));
                base.WriteAttribute("total", "", XmlConvert.ToString(o.TotalInGigaJoules));
                base.WriteAttribute("appliance", "", XmlConvert.ToString(o.Appliance));
                base.WriteEndElement(o);
            }
        }

        private void Write246_Oil(string n, string ns, Oil o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Oil)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Oil", "");
                }
                base.WriteAttribute("baseload", "", XmlConvert.ToString(o.Baseload));
                base.WriteAttribute("hotWater", "", XmlConvert.ToString(o.HotWater));
                base.WriteAttribute("spaceHeating", "", XmlConvert.ToString(o.SpaceHeating));
                base.WriteAttribute("total", "", XmlConvert.ToString(o.TotalInGigaJoules));
                base.WriteEndElement(o);
            }
        }

        private void Write247_Wood(string n, string ns, Wood o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Wood)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Wood", "");
                }
                base.WriteAttribute("baseload", "", XmlConvert.ToString(o.Baseload));
                base.WriteAttribute("hotWater", "", XmlConvert.ToString(o.HotWater));
                base.WriteAttribute("spaceHeating", "", XmlConvert.ToString(o.SpaceHeating));
                base.WriteAttribute("total", "", XmlConvert.ToString(o.TotalInGigaJoules));
                base.WriteEndElement(o);
            }
        }

        private void Write248_PrimarySecondaryEnergy(string n, string ns, PrimarySecondaryEnergy o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(PrimarySecondaryEnergy)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("PrimarySecondaryEnergy", "");
                }
                base.WriteAttribute("primary", "", XmlConvert.ToString(o.Primary));
                base.WriteAttribute("secondary", "", XmlConvert.ToString(o.Secondary));
                base.WriteAttribute("total", "", XmlConvert.ToString(o.Total));
                base.WriteEndElement(o);
            }
        }

        private void Write249_SupplementalHeating(string n, string ns, SupplementalHeating o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SupplementalHeating)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SupplementalHeating", "");
                }
                base.WriteAttribute("system1", "", XmlConvert.ToString(o.System1));
                base.WriteAttribute("system2", "", XmlConvert.ToString(o.System2));
                base.WriteAttribute("system3", "", XmlConvert.ToString(o.System3));
                base.WriteAttribute("system4", "", XmlConvert.ToString(o.System4));
                base.WriteAttribute("system5", "", XmlConvert.ToString(o.System5));
                base.WriteEndElement(o);
            }
        }

        private void Write25_LanguageOptions(string n, string ns, LanguageOptions o, bool needType)
        {
            if (!needType && (o.GetType() != typeof(LanguageOptions)))
            {
                throw base.CreateUnknownTypeException(o);
            }
            base.WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                base.WriteXsiType("LanguageOptions", "");
            }
            base.WriteEndElement(o);
        }

        private void Write250_AnnualConsumption(string n, string ns, AnnualConsumption o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(AnnualConsumption)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("AnnualConsumption", "");
                }
                base.WriteAttribute("total", "", XmlConvert.ToString(o.Total));
                this.Write242_ElectricalAnnual("Electrical", "", o.Electrical, false, false);
                this.Write245_NaturalGasAppliance("NaturalGas", "", o.NaturalGas, false, false);
                this.Write246_Oil("Oil", "", o.Oil, false, false);
                this.Write243_PropaneAppliance("Propane", "", o.Propane, false, false);
                this.Write247_Wood("Wood", "", o.Wood, false, false);
                this.Write248_PrimarySecondaryEnergy("SpaceHeating", "", o.SpaceHeating, false, false);
                this.Write248_PrimarySecondaryEnergy("HotWater", "", o.HotWater, false, false);
                this.Write249_SupplementalHeating("SupplementalHeating", "", o.SupplementalHeating, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write251_HotWaterDemand(string n, string ns, HotWaterDemand o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HotWaterDemand)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HotWaterDemand", "");
                }
                base.WriteAttribute("base", "", XmlConvert.ToString(o.Base));
                base.WriteAttribute("primary", "", XmlConvert.ToString(o.Primary));
                base.WriteAttribute("secondary", "", XmlConvert.ToString(o.Secondary));
                base.WriteEndElement(o);
            }
        }

        private void Write252_LoadAnnual(string n, string ns, LoadAnnual o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(LoadAnnual)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("LoadAnnual", "");
                }
                base.WriteAttribute("basementHeating", "", XmlConvert.ToString(o.BasementHeating));
                base.WriteAttribute("basementCooling", "", XmlConvert.ToString(o.BasementCooling));
                base.WriteAttribute("grossHeating", "", XmlConvert.ToString(o.GrossHeating));
                base.WriteAttribute("auxiliaryEnergy", "", XmlConvert.ToString(o.AuxiliaryEnergy));
                base.WriteEndElement(o);
            }
        }

        private void Write253_DoorAndWindows(string n, string ns, DoorAndWindows o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DoorAndWindows)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DoorAndWindows", "");
                }
                base.WriteAttribute("door", "", XmlConvert.ToString(o.Door));
                this.Write6_Cardinal("Windows", "", o.Windows, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write254_AnnualHeatLoss(string n, string ns, AnnualHeatLoss o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(AnnualHeatLoss)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("AnnualHeatLoss", "");
                }
                base.WriteAttribute("total", "", XmlConvert.ToString(o.Total));
                base.WriteAttribute("ceiling", "", XmlConvert.ToString(o.Ceiling));
                base.WriteAttribute("mainWalls", "", XmlConvert.ToString(o.MainWalls));
                base.WriteAttribute("windows", "", XmlConvert.ToString(o.Windows));
                base.WriteAttribute("doors", "", XmlConvert.ToString(o.Doors));
                base.WriteAttribute("exposedFloors", "", XmlConvert.ToString(o.ExposedFloors));
                base.WriteAttribute("crawlspace", "", XmlConvert.ToString(o.Crawlspace));
                base.WriteAttribute("slab", "", XmlConvert.ToString(o.Slab));
                base.WriteAttribute("basementBelowGradeWall", "", XmlConvert.ToString(o.BasementBelowGradeWall));
                base.WriteAttribute("basementAboveGradeWall", "", XmlConvert.ToString(o.BasementAboveGradeWall));
                base.WriteAttribute("basementFloorHeaders", "", XmlConvert.ToString(o.BasementFloorHeaders));
                base.WriteAttribute("ponyWall", "", XmlConvert.ToString(o.PonyWall));
                base.WriteAttribute("floorsAboveBasement", "", XmlConvert.ToString(o.FloorsAboveBasement));
                base.WriteAttribute("airLeakageAndNaturalVentilation", "", XmlConvert.ToString(o.AirLeakageAndNaturalVentilation));
                this.Write253_DoorAndWindows("MainFloor", "", o.MainFloorDoorsAndWindows, false, false);
                this.Write253_DoorAndWindows("Basement", "", o.BasementDoorsAndWindows, false, false);
                this.Write253_DoorAndWindows("Crawlspace", "", o.CrawlspaceDoorsAndWindows, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write255_AirChangeRate(string n, string ns, AirChangeRate o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(AirChangeRate)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("AirChangeRate", "");
                }
                base.WriteAttribute("natural", "", XmlConvert.ToString(o.Natural));
                base.WriteAttribute("total", "", XmlConvert.ToString(o.Total));
                base.WriteEndElement(o);
            }
        }

        private void Write256_ValueOnly(string n, string ns, ValueOnly o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ValueOnly)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ValueOnly", "");
                }
                base.WriteAttribute("value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write257_ActualFuelCosts(string n, string ns, ActualFuelCosts o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ActualFuelCosts)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ActualFuelCosts", "");
                }
                base.WriteAttribute("electrical", "", XmlConvert.ToString(o.Electrical));
                base.WriteAttribute("naturalGas", "", XmlConvert.ToString(o.NaturalGas));
                base.WriteAttribute("oil", "", XmlConvert.ToString(o.Oil));
                base.WriteAttribute("propane", "", XmlConvert.ToString(o.Propane));
                base.WriteAttribute("wood", "", XmlConvert.ToString(o.Wood));
                base.WriteEndElement(o);
            }
        }

        private void Write258_AnnualResults(string n, string ns, AnnualResults o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(AnnualResults)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("AnnualResults", "");
                }
                this.Write250_AnnualConsumption("Consumption", "", o.Consumption, false, false);
                this.Write251_HotWaterDemand("HotWaterDemand", "", o.HotWaterDemand, false, false);
                this.Write252_LoadAnnual("Load", "", o.Load, false, false);
                this.Write254_AnnualHeatLoss("HeatLoss", "", o.HeatLoss, false, false);
                this.Write255_AirChangeRate("AirChangeRate", "", o.AirChangeRate, false, false);
                this.Write256_ValueOnly("UtilizedSolarGains", "", o.UtilizedSolarGains, false, false);
                this.Write257_ActualFuelCosts("ActualFuelCosts", "", o.ActualFuelCosts, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write259_ElectricalMonthly(string n, string ns, ElectricalMonthly o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ElectricalMonthly)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ElectricalMonthly", "");
                }
                this.Write32_MonthlyData("ImsOrP9HeatingHours", "", o.ImsOrP9HeatingHours, false, false);
                this.Write32_MonthlyData("Gross", "", o.Gross, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write26_ProvinceOrTerritory(string n, string ns, ProvinceOrTerritory o, bool needType)
        {
            if (!needType && (o.GetType() != typeof(ProvinceOrTerritory)))
            {
                throw base.CreateUnknownTypeException(o);
            }
            base.WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                base.WriteXsiType("ProvinceOrTerritory", "");
            }
            base.WriteSerializable(o.Xml, "Xml", "", false, true);
            base.WriteEndElement(o);
        }

        private void Write260_Gains(string n, string ns, Gains o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Gains)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Gains", "");
                }
                this.Write32_MonthlyData("UtilizedInternal", "", o.UtilizedInternal, false, false);
                this.Write32_MonthlyData("UtilizedSolar", "", o.UtilizedSolar, false, false);
                this.Write32_MonthlyData("CrawlspaceSolar", "", o.CrawlspaceSolar, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write261_TemperaturesMonthly(string n, string ns, TemperaturesMonthly o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(TemperaturesMonthly)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("TemperaturesMonthly", "");
                }
                this.Write32_MonthlyData("CrawlSpace", "", o.CrawlSpace, false, false);
                this.Write32_MonthlyData("Attic", "", o.Attic, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write262_BasementLoadMonthly(string n, string ns, BasementLoadMonthly o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(BasementLoadMonthly)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("BasementLoadMonthly", "");
                }
                this.Write32_MonthlyData("Heating", "", o.Heating, false, false);
                this.Write32_MonthlyData("Cooling", "", o.Cooling, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write263_LoadMonthly(string n, string ns, LoadMonthly o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(LoadMonthly)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("LoadMonthly", "");
                }
                this.Write32_MonthlyData("PhotoVoltaicUtilized", "", o.PhotoVoltaicUtilized, false, false);
                this.Write32_MonthlyData("PhotoVoltaicAvailable", "", o.PhotoVoltaicAvailable, false, false);
                this.Write32_MonthlyData("WindUtilized", "", o.WindUtilized, false, false);
                this.Write32_MonthlyData("WindAvailable", "", o.WindAvailable, false, false);
                this.Write32_MonthlyData("GrossThermal", "", o.GrossThermal, false, false);
                this.Write262_BasementLoadMonthly("Basement", "", o.Basement, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write264_BasementHeatLoss(string n, string ns, BasementHeatLoss o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(BasementHeatLoss)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("BasementHeatLoss", "");
                }
                this.Write32_MonthlyData("AboveGrade", "", o.AboveGrade, false, false);
                this.Write32_MonthlyData("BelowGrade", "", o.BelowGrade, false, false);
                this.Write32_MonthlyData("AboveGradeWall", "", o.AboveGradeWall, false, false);
                this.Write32_MonthlyData("FloorHeaders", "", o.FloorHeaders, false, false);
                this.Write32_MonthlyData("PonyWall", "", o.PonyWall, false, false);
                this.Write32_MonthlyData("FloorsAbove", "", o.FloorsAbove, false, false);
                this.Write32_MonthlyData("AirLeakageAndMechanicalVentilation", "", o.AirLeakageAndMechanicalVentilation, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write265_MonthlyHeatLoss(string n, string ns, MonthlyHeatLoss o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(MonthlyHeatLoss)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("MonthlyHeatLoss", "");
                }
                this.Write32_MonthlyData("Ceiling", "", o.Ceiling, false, false);
                this.Write32_MonthlyData("MainWalls", "", o.MainWalls, false, false);
                this.Write32_MonthlyData("Doors", "", o.Doors, false, false);
                this.Write32_MonthlyData("ExposedFloors", "", o.ExposedFloors, false, false);
                this.Write32_MonthlyData("Crawlspace", "", o.Crawlspace, false, false);
                this.Write32_MonthlyData("Slab", "", o.Slab, false, false);
                this.Write264_BasementHeatLoss("Basement", "", o.Basement, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write266_MainFloorsFactors(string n, string ns, MainFloorsFactors o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(MainFloorsFactors)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("MainFloorsFactors", "");
                }
                this.Write32_MonthlyData("SolarUtilization", "", o.SolarUtilization, false, false);
                this.Write32_MonthlyData("GainLoadRatio", "", o.GainLoadRatio, false, false);
                this.Write32_MonthlyData("MassGainRatio", "", o.MassGainRatio, false, false);
                this.Write32_MonthlyData("InternalGainsUtilization", "", o.InternalGainsUtilization, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write267_BasementFactors(string n, string ns, BasementFactors o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(BasementFactors)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("BasementFactors", "");
                }
                this.Write32_MonthlyData("SolarUtilization", "", o.SolarUtilization, false, false);
                this.Write32_MonthlyData("GainLoadRatio", "", o.GainLoadRatio, false, false);
                this.Write32_MonthlyData("MassGainRatio", "", o.MassGainRatio, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write268_Factors(string n, string ns, Factors o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Factors)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Factors", "");
                }
                this.Write266_MainFloorsFactors("MainFloors", "", o.MainFloors, false, false);
                this.Write267_BasementFactors("Basement", "", o.Basement, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write269_MonthlyAirChangeRate(string n, string ns, MonthlyAirChangeRate o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(MonthlyAirChangeRate)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("MonthlyAirChangeRate", "");
                }
                this.Write32_MonthlyData("Natural", "", o.Natural, false, false);
                this.Write32_MonthlyData("Total", "", o.Total, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write27_SelectedAndValue(string n, string ns, SelectedAndValue o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SelectedAndValue)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SelectedAndValue", "");
                }
                base.WriteAttribute("selected", "", XmlConvert.ToString(o.Selected));
                base.WriteAttribute("value", "", XmlConvert.ToString(o.Value));
                if (o.Label != null)
                {
                    base.WriteValue(o.Label);
                }
                base.WriteEndElement(o);
            }
        }

        private void Write270_MonthlyResults(string n, string ns, MonthlyResults o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(MonthlyResults)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("MonthlyResults", "");
                }
                this.Write32_MonthlyData("FractionOfTimeHeatingSystemNotOperating", "", o.FractionOfTimeHeatingSystemNotOperating, false, false);
                this.Write32_MonthlyData("SolarHotWaterEnergyContribution", "", o.SolarHotWaterEnergyContribution, false, false);
                this.Write259_ElectricalMonthly("ElectricalConsumption", "", o.ElectricalConsumption, false, false);
                this.Write260_Gains("Gains", "", o.Gains, false, false);
                this.Write32_MonthlyData("UtilizedAuxiliaryHeatRequired", "", o.UtilizedAuxiliaryHeatRequired, false, false);
                this.Write261_TemperaturesMonthly("Temperatures", "", o.Temperatures, false, false);
                this.Write263_LoadMonthly("Load", "", o.Load, false, false);
                this.Write265_MonthlyHeatLoss("HeatLoss", "", o.HeatLoss, false, false);
                this.Write268_Factors("Factors", "", o.Factors, false, false);
                this.Write269_MonthlyAirChangeRate("AirChangeRate", "", o.AirChangeRate, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write271_VentilationResults(string n, string ns, VentilationResults o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(VentilationResults)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("VentilationResults", "");
                }
                base.WriteAttribute("roomCountCapacity", "", XmlConvert.ToString(o.RoomCountCapacity));
                base.WriteAttribute("noLimitCapacity", "", XmlConvert.ToString(o.NoLimitCapacity));
                base.WriteAttribute("minimumAirChangeRate", "", XmlConvert.ToString(o.MinimumAirChangeRate));
                base.WriteAttribute("equivalentLeakageArea", "", XmlConvert.ToString(o.EquivalentLeakageArea));
                base.WriteEndElement(o);
            }
        }

        private void Write272_FanConsumption(string n, string ns, FanConsumption o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FanConsumption)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FanConsumption", "");
                }
                base.WriteAttribute("heatingHours", "", XmlConvert.ToString(o.HeatingHours));
                base.WriteAttribute("neitherHours", "", XmlConvert.ToString(o.NeitherHours));
                base.WriteAttribute("coolingHours", "", XmlConvert.ToString(o.CoolingHours));
                base.WriteAttribute("total", "", XmlConvert.ToString(o.Total));
                base.WriteEndElement(o);
            }
        }

        private void Write273_FanEnergyConsumption(string n, string ns, FanEnergyConsumption o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FanEnergyConsumption)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FanEnergyConsumption", "");
                }
                this.Write272_FanConsumption("Hrv", "", o.Hrv, false, false);
                this.Write272_FanConsumption("Heating", "", o.Heating, false, false);
                this.Write272_FanConsumption("AirConditioning", "", o.AirConditioning, false, false);
                this.Write272_FanConsumption("HrvOrExhaust", "", o.HrvOrExhaust, false, false);
                this.Write272_FanConsumption("SpaceHeating", "", o.SpaceHeating, false, false);
                this.Write272_FanConsumption("SpaceCooling", "", o.SpaceCooling, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write274_GrossAreaComponent(string n, string ns, GrossAreaComponent o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(GrossAreaComponent)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("GrossAreaComponent", "");
                }
                base.WriteAttribute("grossArea", "", XmlConvert.ToString(o.GrossArea));
                base.WriteAttribute("rsiValue", "", XmlConvert.ToString(o.RsiValue));
                base.WriteEndElement(o);
            }
        }

        private void Write275_GrossAreaWindows(string n, string ns, GrossAreaWindows o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(GrossAreaWindows)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("GrossAreaWindows", "");
                }
                this.Write274_GrossAreaComponent("South", "", o.South, false, false);
                this.Write274_GrossAreaComponent("SouthEast", "", o.SouthEast, false, false);
                this.Write274_GrossAreaComponent("East", "", o.East, false, false);
                this.Write274_GrossAreaComponent("NorthEast", "", o.NorthEast, false, false);
                this.Write274_GrossAreaComponent("North", "", o.North, false, false);
                this.Write274_GrossAreaComponent("NorthWest", "", o.NorthWest, false, false);
                this.Write274_GrossAreaComponent("West", "", o.West, false, false);
                this.Write274_GrossAreaComponent("SouthWest", "", o.SouthWest, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write276_GrossAreaBasement(string n, string ns, GrossAreaBasement o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(GrossAreaBasement)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("GrossAreaBasement", "");
                }
                base.WriteAttribute("aboveGrade", "", XmlConvert.ToString(o.AboveGrade));
                base.WriteAttribute("belowGrade", "", XmlConvert.ToString(o.BelowGrade));
                base.WriteAttribute("floorSlab", "", XmlConvert.ToString(o.FloorSlab));
                base.WriteAttribute("floorHeader", "", XmlConvert.ToString(o.FloorHeader));
                base.WriteAttribute("floorsAbove", "", XmlConvert.ToString(o.FloorsAbove));
                this.Write275_GrossAreaWindows("Windows", "", o.Windows, false, false);
                this.Write274_GrossAreaComponent("Door", "", o.Door, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write277_GrossAreaCrawlspace(string n, string ns, GrossAreaCrawlspace o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(GrossAreaCrawlspace)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("GrossAreaCrawlspace", "");
                }
                base.WriteAttribute("wall", "", XmlConvert.ToString(o.Wall));
                base.WriteAttribute("floor", "", XmlConvert.ToString(o.Floor));
                base.WriteAttribute("floorHeader", "", XmlConvert.ToString(o.FloorHeader));
                this.Write275_GrossAreaWindows("Windows", "", o.Windows, false, false);
                this.Write274_GrossAreaComponent("Door", "", o.Door, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write278_GrossAreaFloor(string n, string ns, GrossAreaFloor o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(GrossAreaFloor))
                    {
                        if (type == typeof(GrossAreaMainFloors))
                        {
                            this.Write279_GrossAreaMainFloors(n, ns, (GrossAreaMainFloors)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(GrossAreaCrawlspace))
                        {
                            this.Write277_GrossAreaCrawlspace(n, ns, (GrossAreaCrawlspace)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(GrossAreaBasement)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write276_GrossAreaBasement(n, ns, (GrossAreaBasement)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("GrossAreaFloor", "");
                }
                this.Write275_GrossAreaWindows("Windows", "", o.Windows, false, false);
                this.Write274_GrossAreaComponent("Door", "", o.Door, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write279_GrossAreaMainFloors(string n, string ns, GrossAreaMainFloors o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(GrossAreaMainFloors)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("GrossAreaMainFloors", "");
                }
                base.WriteAttribute("mainWalls", "", XmlConvert.ToString(o.MainWalls));
                this.Write275_GrossAreaWindows("Windows", "", o.Windows, false, false);
                this.Write274_GrossAreaComponent("Door", "", o.Door, false, false);
                base.WriteEndElement(o);
            }
        }

        private string Write28_ErrorLevels(HouseFileError.ErrorLevels v)
        {
            string str = null;
            switch (v)
            {
                case HouseFileError.ErrorLevels.None:
                    str = "None";
                    break;

                case HouseFileError.ErrorLevels.Warning:
                    str = "Warning";
                    break;

                case HouseFileError.ErrorLevels.Error:
                    str = "Error";
                    break;

                default:
                    throw base.CreateInvalidEnumValueException(((long)v).ToString(CultureInfo.InvariantCulture), "ca.nrcan.gc.OEE.HouseFileLibrary.HouseFileError.ErrorLevels");
            }
            return str;
        }

        private void Write280_GrossArea(string n, string ns, GrossArea o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(GrossArea)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("GrossArea", "");
                }
                base.WriteAttribute("ceiling", "", XmlConvert.ToString(o.Ceiling));
                base.WriteAttribute("doors", "", XmlConvert.ToString(o.Doors));
                base.WriteAttribute("exposedFloors", "", XmlConvert.ToString(o.ExposedFloors));
                base.WriteAttribute("slab", "", XmlConvert.ToString(o.Slab));
                base.WriteAttribute("ponyWall", "", XmlConvert.ToString(o.PonyWall));
                base.WriteAttribute("buildingSurfaceArea", "", XmlConvert.ToString(o.BuildingSurfaceArea));
                base.WriteAttribute("houseVolumeWithoutCrawlspace", "", XmlConvert.ToString(o.HouseVolumeWithoutCrawlspace));
                this.Write279_GrossAreaMainFloors("MainFloors", "", o.MainFloors, false, false);
                this.Write276_GrossAreaBasement("Basement", "", o.Basement, false, false);
                this.Write277_GrossAreaCrawlspace("Crawlspace", "", o.Crawlspace, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write281_OtherResults(string n, string ns, OtherResults o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(OtherResults)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("OtherResults", "");
                }
                base.WriteAttribute("designHeatLossRate", "", XmlConvert.ToString(o.DesignHeatLossRate));
                base.WriteAttribute("designCoolLossRate", "", XmlConvert.ToString(o.DesignCoolLossRate));
                base.WriteAttribute("seasonalHeatEfficiency", "", XmlConvert.ToString(o.SeasonalHeatEfficiency));
                this.Write271_VentilationResults("Ventilation", "", o.Ventilation, false, false);
                this.Write273_FanEnergyConsumption("FanEnergyConsumption", "", o.FanEnergyConsumption, false, false);
                this.Write280_GrossArea("GrossArea", "", o.GrossArea, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write282_Results(string n, string ns, Results o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Results)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Results", "");
                }
                base.WriteAttribute("houseCode", "", o.HouseCode);
                base.WriteAttribute("type", "", o.TypeXml);
                this.Write2_Labels("Labels", "", o.Labels, false, false);
                this.Write258_AnnualResults("Annual", "", o.Annual, false, false);
                this.Write270_MonthlyResults("Monthly", "", o.Monthly, false, false);
                this.Write281_OtherResults("Other", "", o.Other, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write283_HouseFile(string n, string ns, HouseFile o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HouseFile)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HouseFile", "");
                }
                base.WriteAttribute("uiUnits", "", o.UiUnits);
                base.WriteAttribute("lang", "http://www.w3.org/XML/1998/namespace", o.XmlLang);
                this.Write3_HouseFileVersion("Version", "", o.Version, false, false);
                this.Write5_Application("Application", "", o.Application, false, false);
                this.Write44_ProgramInformation("ProgramInformation", "", o.ProgramInformation, false, false);
                this.Write205_House("House", "", o.House, false, false);
                this.Write229_Codes("Codes", "", o.Codes, false, false);
                this.Write233_EnergyUpgrades("EnergyUpgrades", "", o.EnergyUpgrades, false, false);
                this.Write240_FuelCosts("FuelCosts", "", o.FuelCosts, false, false);
                List<Results> allResults = o.AllResults;
                if (allResults != null)
                {
                    base.WriteStartElement("AllResults", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= allResults.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write282_Results("Results", "", allResults[num], true, false);
                        num++;
                    }
                }
                base.WriteEndElement(o);
            }
        }

        private void Write284_Utf8Helper(string n, string ns, Utf8Helper o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Utf8Helper)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Utf8Helper", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write285_SelectedValueAndUnits(string n, string ns, SelectedValueAndUnits o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SelectedValueAndUnits)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SelectedValueAndUnits", "");
                }
                base.WriteAttribute("selected", "", XmlConvert.ToString(o.Selected));
                base.WriteAttribute("value", "", XmlConvert.ToString(o.Value));
                base.WriteAttribute("uiUnits", "", o.UiUnits);
                if (o.Label != null)
                {
                    base.WriteValue(o.Label);
                }
                base.WriteEndElement(o);
            }
        }

        private void Write286_WeatherRegion(string n, string ns, WeatherRegion o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WeatherRegion)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WeatherRegion", "");
                }
                base.WriteElementString("English", "", o.English);
                base.WriteElementString("French", "", o.French);
                List<WeatherLocation> weatherRegions = o.WeatherRegions;
                if (weatherRegions != null)
                {
                    base.WriteStartElement("WeatherRegions", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= weatherRegions.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write287_WeatherLocation("WeatherLocation", "", weatherRegions[num], true, false);
                        num++;
                    }
                }
                base.WriteEndElement(o);
            }
        }

        private void Write287_WeatherLocation(string n, string ns, WeatherLocation o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WeatherLocation)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WeatherLocation", "");
                }
                base.WriteElementString("English", "", o.English);
                base.WriteElementString("French", "", o.French);
                this.Write286_WeatherRegion("region", "", o.region, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write288_WeatherLibrary(string n, string ns, WeatherLibrary o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WeatherLibrary)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WeatherLibrary", "");
                }
                List<WeatherLocation> locations = o.Locations;
                if (locations != null)
                {
                    base.WriteStartElement("Locations", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= locations.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write287_WeatherLocation("WeatherLocation", "", locations[num], true, false);
                        num++;
                    }
                }
                List<WeatherRegion> regions = o.Regions;
                if (regions != null)
                {
                    base.WriteStartElement("Regions", "", null, false);
                    int num2 = 0;
                    while (true)
                    {
                        if (num2 >= regions.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write286_WeatherRegion("WeatherRegion", "", regions[num2], true, false);
                        num2++;
                    }
                }
                base.WriteEndElement(o);
            }
        }

        private void Write289_ResourceList(string n, string ns, ResourceList o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(ResourceList))
                    {
                        if (type == typeof(MultipleSystemsEfficiencyTypes))
                        {
                            this.Write390_MultipleSystemsEfficiencyTypes(n, ns, (MultipleSystemsEfficiencyTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(MultipleSystemsWood))
                        {
                            this.Write389_MultipleSystemsWood(n, ns, (MultipleSystemsWood)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(MultipleSystemsOil))
                        {
                            this.Write388_MultipleSystemsOil(n, ns, (MultipleSystemsOil)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(MultipleSystemsGasPropane))
                        {
                            this.Write387_MultipleSystemsGasPropane(n, ns, (MultipleSystemsGasPropane)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(MultipleSystemsElectricity))
                        {
                            this.Write386_MultipleSystemsElectricity(n, ns, (MultipleSystemsElectricity)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(WoodSupplementaryHeatingTypes))
                        {
                            this.Write385_WoodSupplementaryHeatingTypes(n, ns, (WoodSupplementaryHeatingTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(OilSupplementaryHeatingTypes))
                        {
                            this.Write384_OilSupplementaryHeatingTypes(n, ns, (OilSupplementaryHeatingTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(GasPropaneSupplementaryHeatingTypes))
                        {
                            this.Write383_Item(n, ns, (GasPropaneSupplementaryHeatingTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ElectricSupplementaryHeatingTypes))
                        {
                            this.Write382_Item(n, ns, (ElectricSupplementaryHeatingTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(OilComboHeatDhwTypes))
                        {
                            this.Write381_OilComboHeatDhwTypes(n, ns, (OilComboHeatDhwTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(GasPropaneComboHeatDhwTypes))
                        {
                            this.Write380_GasPropaneComboHeatDhwTypes(n, ns, (GasPropaneComboHeatDhwTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(OilFurnaceTypes))
                        {
                            this.Write379_OilFurnaceTypes(n, ns, (OilFurnaceTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(GasPropaneFurnaceTypes))
                        {
                            this.Write378_GasPropaneFurnaceTypes(n, ns, (GasPropaneFurnaceTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ElectricFurnaceTypes))
                        {
                            this.Write377_ElectricFurnaceTypes(n, ns, (ElectricFurnaceTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(WoodFurnaceTypes))
                        {
                            this.Write376_WoodFurnaceTypes(n, ns, (WoodFurnaceTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(WoodBoilerTypes))
                        {
                            this.Write375_WoodBoilerTypes(n, ns, (WoodBoilerTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(OilBoilerTypes))
                        {
                            this.Write374_OilBoilerTypes(n, ns, (OilBoilerTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(GasPropaneBoilerTypes))
                        {
                            this.Write373_GasPropaneBoilerTypes(n, ns, (GasPropaneBoilerTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ElectricBoilerTypes))
                        {
                            this.Write372_ElectricBoilerTypes(n, ns, (ElectricBoilerTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(FlueTypes))
                        {
                            this.Write371_FlueTypes(n, ns, (FlueTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(P9EnergySources))
                        {
                            this.Write370_P9EnergySources(n, ns, (P9EnergySources)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(MultipleSystemsEnergySources))
                        {
                            this.Write369_MultipleSystemsEnergySources(n, ns, (MultipleSystemsEnergySources)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(SupplementaryEnergySources))
                        {
                            this.Write368_SupplementaryEnergySources(n, ns, (SupplementaryEnergySources)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HeatingEnergySources))
                        {
                            this.Write367_HeatingEnergySources(n, ns, (HeatingEnergySources)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(CentralEquipmentTypes))
                        {
                            this.Write366_CentralEquipmentTypes(n, ns, (CentralEquipmentTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HeatPumpFunctions))
                        {
                            this.Write365_HeatPumpFunctions(n, ns, (HeatPumpFunctions)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HeatingUsages))
                        {
                            this.Write362_HeatingUsages(n, ns, (HeatingUsages)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(YearMade))
                        {
                            this.Write361_YearMade(n, ns, (YearMade)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HeatingCoolingUses))
                        {
                            this.Write359_HeatingCoolingUses(n, ns, (HeatingCoolingUses)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(CoolingFanModes))
                        {
                            this.Write358_CoolingFanModes(n, ns, (CoolingFanModes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HeatingFanModes))
                        {
                            this.Write357_HeatingFanModes(n, ns, (HeatingFanModes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Months))
                        {
                            this.Write356_Months(n, ns, (Months)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ClothesWasherTemperatures))
                        {
                            this.Write350_ClothesWasherTemperatures(n, ns, (ClothesWasherTemperatures)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ApplianceEnergySources))
                        {
                            this.Write349_ApplianceEnergySources(n, ns, (ApplianceEnergySources)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ShowerFlowRates))
                        {
                            this.Write345_ShowerFlowRates(n, ns, (ShowerFlowRates)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ShowerTemperatures))
                        {
                            this.Write344_ShowerTemperatures(n, ns, (ShowerTemperatures)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DuctSealingCharacteristics))
                        {
                            this.Write343_DuctSealingCharacteristics(n, ns, (DuctSealingCharacteristics)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DuctTypes))
                        {
                            this.Write342_DuctTypes(n, ns, (DuctTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DuctLocations))
                        {
                            this.Write341_DuctLocations(n, ns, (DuctLocations)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(VentilatorTypes))
                        {
                            this.Write340_VentilatorTypes(n, ns, (VentilatorTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(AirDistributionTypes))
                        {
                            this.Write337_AirDistributionTypes(n, ns, (AirDistributionTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(VentilationUses))
                        {
                            this.Write336_VentilationUses(n, ns, (VentilationUses)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(VentilationTypes))
                        {
                            this.Write335_VentilationTypes(n, ns, (VentilationTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(AirLeakageTestTypes))
                        {
                            this.Write333_AirLeakageTestTypes(n, ns, (AirLeakageTestTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(LocalShieldings))
                        {
                            this.Write332_LocalShieldings(n, ns, (LocalShieldings)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(TestStatuses))
                        {
                            this.Write331_TestStatuses(n, ns, (TestStatuses)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Terrains))
                        {
                            this.Write330_Terrains(n, ns, (Terrains)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(AllowableRise))
                        {
                            this.Write329_AllowableRise(n, ns, (AllowableRise)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(BlowerTestPressures))
                        {
                            this.Write328_BlowerTestPressures(n, ns, (BlowerTestPressures)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(WaterTableLevels))
                        {
                            this.Write323_WaterTableLevels(n, ns, (WaterTableLevels)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(SoilConditions))
                        {
                            this.Write318_SoilConditions(n, ns, (SoilConditions)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ThermalMass))
                        {
                            this.Write316_ThermalMass(n, ns, (ThermalMass)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HouseTypesMurb))
                        {
                            this.Write315_HouseTypesMurb(n, ns, (HouseTypesMurb)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HouseTypes))
                        {
                            this.Write314_HouseTypes(n, ns, (HouseTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HouseStoreys))
                        {
                            this.Write313_HouseStoreys(n, ns, (HouseStoreys)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HousePlanShapes))
                        {
                            this.Write312_HousePlanShapes(n, ns, (HousePlanShapes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HouseOwnerships))
                        {
                            this.Write311_HouseOwnerships(n, ns, (HouseOwnerships)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(RoomFloors))
                        {
                            this.Write310_RoomFloors(n, ns, (RoomFloors)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(RoomTypes))
                        {
                            this.Write309_RoomTypes(n, ns, (RoomTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(PhotovoltaicModules))
                        {
                            this.Write308_PhotovoltaicModules(n, ns, (PhotovoltaicModules)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DhwTankLocations))
                        {
                            this.Write307_DhwTankLocations(n, ns, (DhwTankLocations)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DhwTankTypeSolar))
                        {
                            this.Write305_DhwTankTypeSolar(n, ns, (DhwTankTypeSolar)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DhwTankTypeWood))
                        {
                            this.Write304_DhwTankTypeWood(n, ns, (DhwTankTypeWood)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DhwTankTypeOil))
                        {
                            this.Write303_DhwTankTypeOil(n, ns, (DhwTankTypeOil)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DhwTankTypeGasPropane))
                        {
                            this.Write302_DhwTankTypeGasPropane(n, ns, (DhwTankTypeGasPropane)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DhwTankTypeElectric))
                        {
                            this.Write301_DhwTankTypeElectric(n, ns, (DhwTankTypeElectric)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DhwDrawPatterns))
                        {
                            this.Write300_DhwDrawPatterns(n, ns, (DhwDrawPatterns)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DhwEnergySources))
                        {
                            this.Write299_DhwEnergySources(n, ns, (DhwEnergySources)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HouseDirections))
                        {
                            this.Write297_HouseDirections(n, ns, (HouseDirections)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(WindowDirections))
                        {
                            this.Write296_WindowDirections(n, ns, (WindowDirections)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(WallDirections))
                        {
                            this.Write295_WallDirections(n, ns, (WallDirections)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(FloorHeaderDirections))
                        {
                            this.Write294_FloorHeaderDirections(n, ns, (FloorHeaderDirections)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ResourceValueList))
                        {
                            this.Write291_ResourceValueList(n, ns, (ResourceValueList)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HeatPumpRatingTypes))
                        {
                            this.Write364_HeatPumpRatingTypes(n, ns, (HeatPumpRatingTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HeatPumpCutoffTypes))
                        {
                            this.Write363_HeatPumpCutoffTypes(n, ns, (HeatPumpCutoffTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HeatingLocations))
                        {
                            this.Write360_HeatingLocations(n, ns, (HeatingLocations)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(RefrigeratorRatedConsumptions))
                        {
                            this.Write355_RefrigeratorRatedConsumptions(n, ns, (RefrigeratorRatedConsumptions)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(StoveRatedConsumptions))
                        {
                            this.Write354_StoveRatedConsumptions(n, ns, (StoveRatedConsumptions)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DryerRatedConsumptions))
                        {
                            this.Write353_DryerRatedConsumptions(n, ns, (DryerRatedConsumptions)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(InteriorLightingTypes))
                        {
                            this.Write352_InteriorLightingTypes(n, ns, (InteriorLightingTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ApplianceEnergySourceSpecified))
                        {
                            this.Write351_ApplianceEnergySourceSpecified(n, ns, (ApplianceEnergySourceSpecified)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(BaseFaucetFlowRates))
                        {
                            this.Write348_BaseFaucetFlowRates(n, ns, (BaseFaucetFlowRates)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(BaseShowerFlowRates))
                        {
                            this.Write347_BaseShowerFlowRates(n, ns, (BaseShowerFlowRates)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(BaseShowerTemperatures))
                        {
                            this.Write346_BaseShowerTemperatures(n, ns, (BaseShowerTemperatures)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(OperationSchedules))
                        {
                            this.Write339_OperationSchedules(n, ns, (OperationSchedules)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(AirDistributionFanPowerLevels))
                        {
                            this.Write338_AirDistributionFanPowerLevels(n, ns, (AirDistributionFanPowerLevels)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(OpeningsUpstairs))
                        {
                            this.Write334_OpeningsUpstairs(n, ns, (OpeningsUpstairs)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(AirTightnessTypes))
                        {
                            this.Write327_AirTightnessTypes(n, ns, (AirTightnessTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(RoofingMaterials))
                        {
                            this.Write326_RoofingMaterials(n, ns, (RoofingMaterials)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ExteriorMaterials))
                        {
                            this.Write325_ExteriorMaterials(n, ns, (ExteriorMaterials)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(SheathingMaterials))
                        {
                            this.Write324_SheathingMaterials(n, ns, (SheathingMaterials)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DepressurizationLimits))
                        {
                            this.Write322_DepressurizationLimits(n, ns, (DepressurizationLimits)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(VentilationRate))
                        {
                            this.Write321_VentilationRate(n, ns, (VentilationRate)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(WindowAirTightness))
                        {
                            this.Write320_WindowAirTightness(n, ns, (WindowAirTightness)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Colours))
                        {
                            this.Write319_Colours(n, ns, (Colours)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(YearBuilt))
                        {
                            this.Write317_YearBuilt(n, ns, (YearBuilt)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DhwTankVolumes))
                        {
                            this.Write306_DhwTankVolumes(n, ns, (DhwTankVolumes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(WindowTilts))
                        {
                            this.Write298_WindowTilts(n, ns, (WindowTilts)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DoorTypes))
                        {
                            this.Write293_DoorTypes(n, ns, (DoorTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(CeilingSlopes))
                        {
                            this.Write292_CeilingSlopes(n, ns, (CeilingSlopes)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(CeilingTypes)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write290_CeilingTypes(n, ns, (CeilingTypes)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ResourceList", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write29_HouseFileError(string n, string ns, HouseFileError o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HouseFileError)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HouseFileError", "");
                }
                base.WriteElementString("level", "", this.Write28_ErrorLevels(o.level));
                base.WriteElementString("englishMessage", "", o.englishMessage);
                base.WriteElementString("frenchMessage", "", o.frenchMessage);
                base.WriteEndElement(o);
            }
        }

        private void Write290_CeilingTypes(string n, string ns, CeilingTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CeilingTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CeilingTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write291_ResourceValueList(string n, string ns, ResourceValueList o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(ResourceValueList))
                    {
                        if (type == typeof(HeatPumpRatingTypes))
                        {
                            this.Write364_HeatPumpRatingTypes(n, ns, (HeatPumpRatingTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HeatPumpCutoffTypes))
                        {
                            this.Write363_HeatPumpCutoffTypes(n, ns, (HeatPumpCutoffTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HeatingLocations))
                        {
                            this.Write360_HeatingLocations(n, ns, (HeatingLocations)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(RefrigeratorRatedConsumptions))
                        {
                            this.Write355_RefrigeratorRatedConsumptions(n, ns, (RefrigeratorRatedConsumptions)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(StoveRatedConsumptions))
                        {
                            this.Write354_StoveRatedConsumptions(n, ns, (StoveRatedConsumptions)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DryerRatedConsumptions))
                        {
                            this.Write353_DryerRatedConsumptions(n, ns, (DryerRatedConsumptions)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(InteriorLightingTypes))
                        {
                            this.Write352_InteriorLightingTypes(n, ns, (InteriorLightingTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ApplianceEnergySourceSpecified))
                        {
                            this.Write351_ApplianceEnergySourceSpecified(n, ns, (ApplianceEnergySourceSpecified)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(BaseFaucetFlowRates))
                        {
                            this.Write348_BaseFaucetFlowRates(n, ns, (BaseFaucetFlowRates)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(BaseShowerFlowRates))
                        {
                            this.Write347_BaseShowerFlowRates(n, ns, (BaseShowerFlowRates)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(BaseShowerTemperatures))
                        {
                            this.Write346_BaseShowerTemperatures(n, ns, (BaseShowerTemperatures)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(OperationSchedules))
                        {
                            this.Write339_OperationSchedules(n, ns, (OperationSchedules)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(AirDistributionFanPowerLevels))
                        {
                            this.Write338_AirDistributionFanPowerLevels(n, ns, (AirDistributionFanPowerLevels)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(OpeningsUpstairs))
                        {
                            this.Write334_OpeningsUpstairs(n, ns, (OpeningsUpstairs)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(AirTightnessTypes))
                        {
                            this.Write327_AirTightnessTypes(n, ns, (AirTightnessTypes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(RoofingMaterials))
                        {
                            this.Write326_RoofingMaterials(n, ns, (RoofingMaterials)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ExteriorMaterials))
                        {
                            this.Write325_ExteriorMaterials(n, ns, (ExteriorMaterials)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(SheathingMaterials))
                        {
                            this.Write324_SheathingMaterials(n, ns, (SheathingMaterials)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DepressurizationLimits))
                        {
                            this.Write322_DepressurizationLimits(n, ns, (DepressurizationLimits)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(VentilationRate))
                        {
                            this.Write321_VentilationRate(n, ns, (VentilationRate)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(WindowAirTightness))
                        {
                            this.Write320_WindowAirTightness(n, ns, (WindowAirTightness)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(Colours))
                        {
                            this.Write319_Colours(n, ns, (Colours)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(YearBuilt))
                        {
                            this.Write317_YearBuilt(n, ns, (YearBuilt)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DhwTankVolumes))
                        {
                            this.Write306_DhwTankVolumes(n, ns, (DhwTankVolumes)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(WindowTilts))
                        {
                            this.Write298_WindowTilts(n, ns, (WindowTilts)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(DoorTypes))
                        {
                            this.Write293_DoorTypes(n, ns, (DoorTypes)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(CeilingSlopes)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write292_CeilingSlopes(n, ns, (CeilingSlopes)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ResourceValueList", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write292_CeilingSlopes(string n, string ns, CeilingSlopes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CeilingSlopes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CeilingSlopes", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write293_DoorTypes(string n, string ns, DoorTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DoorTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DoorTypes", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write294_FloorHeaderDirections(string n, string ns, FloorHeaderDirections o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FloorHeaderDirections)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FloorHeaderDirections", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write295_WallDirections(string n, string ns, WallDirections o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WallDirections)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WallDirections", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write296_WindowDirections(string n, string ns, WindowDirections o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WindowDirections)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WindowDirections", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write297_HouseDirections(string n, string ns, HouseDirections o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HouseDirections)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HouseDirections", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write298_WindowTilts(string n, string ns, WindowTilts o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WindowTilts)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WindowTilts", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write299_DhwEnergySources(string n, string ns, DhwEnergySources o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DhwEnergySources)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DhwEnergySources", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write3_HouseFileVersion(string n, string ns, HouseFileVersion o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HouseFileVersion)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HouseFileVersion", "");
                }
                base.WriteAttribute("major", "", XmlConvert.ToString(o.Major));
                base.WriteAttribute("minor", "", XmlConvert.ToString(o.Minor));
                base.WriteAttribute("build", "", o.BuildString);
                this.Write2_Labels("Labels", "", o.Labels, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write300_DhwDrawPatterns(string n, string ns, DhwDrawPatterns o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DhwDrawPatterns)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DhwDrawPatterns", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write301_DhwTankTypeElectric(string n, string ns, DhwTankTypeElectric o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DhwTankTypeElectric)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DhwTankTypeElectric", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write302_DhwTankTypeGasPropane(string n, string ns, DhwTankTypeGasPropane o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DhwTankTypeGasPropane)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DhwTankTypeGasPropane", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write303_DhwTankTypeOil(string n, string ns, DhwTankTypeOil o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DhwTankTypeOil)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DhwTankTypeOil", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write304_DhwTankTypeWood(string n, string ns, DhwTankTypeWood o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DhwTankTypeWood)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DhwTankTypeWood", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write305_DhwTankTypeSolar(string n, string ns, DhwTankTypeSolar o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DhwTankTypeSolar)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DhwTankTypeSolar", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write306_DhwTankVolumes(string n, string ns, DhwTankVolumes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DhwTankVolumes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DhwTankVolumes", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write307_DhwTankLocations(string n, string ns, DhwTankLocations o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DhwTankLocations)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DhwTankLocations", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write308_PhotovoltaicModules(string n, string ns, PhotovoltaicModules o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(PhotovoltaicModules)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("PhotovoltaicModules", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write309_RoomTypes(string n, string ns, RoomTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(RoomTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("RoomTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write31_StdSort(string n, string ns, StdSort o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(StdSort)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("StdSort", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write310_RoomFloors(string n, string ns, RoomFloors o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(RoomFloors)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("RoomFloors", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write311_HouseOwnerships(string n, string ns, HouseOwnerships o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HouseOwnerships)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HouseOwnerships", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write312_HousePlanShapes(string n, string ns, HousePlanShapes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HousePlanShapes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HousePlanShapes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write313_HouseStoreys(string n, string ns, HouseStoreys o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HouseStoreys)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HouseStoreys", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write314_HouseTypes(string n, string ns, HouseTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HouseTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HouseTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write315_HouseTypesMurb(string n, string ns, HouseTypesMurb o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HouseTypesMurb)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HouseTypesMurb", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write316_ThermalMass(string n, string ns, ThermalMass o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ThermalMass)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ThermalMass", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write317_YearBuilt(string n, string ns, YearBuilt o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(YearBuilt)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("YearBuilt", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write318_SoilConditions(string n, string ns, SoilConditions o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SoilConditions)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SoilConditions", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write319_Colours(string n, string ns, Colours o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Colours)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Colours", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write32_MonthlyData(string n, string ns, MonthlyData o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(MonthlyData)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("MonthlyData", "");
                }
                base.WriteAttribute("january", "", XmlConvert.ToString(o.January));
                base.WriteAttribute("february", "", XmlConvert.ToString(o.February));
                base.WriteAttribute("march", "", XmlConvert.ToString(o.March));
                base.WriteAttribute("april", "", XmlConvert.ToString(o.April));
                base.WriteAttribute("may", "", XmlConvert.ToString(o.May));
                base.WriteAttribute("june", "", XmlConvert.ToString(o.June));
                base.WriteAttribute("july", "", XmlConvert.ToString(o.July));
                base.WriteAttribute("august", "", XmlConvert.ToString(o.August));
                base.WriteAttribute("september", "", XmlConvert.ToString(o.September));
                base.WriteAttribute("october", "", XmlConvert.ToString(o.October));
                base.WriteAttribute("november", "", XmlConvert.ToString(o.November));
                base.WriteAttribute("december", "", XmlConvert.ToString(o.December));
                base.WriteEndElement(o);
            }
        }

        private void Write320_WindowAirTightness(string n, string ns, WindowAirTightness o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WindowAirTightness)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WindowAirTightness", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write321_VentilationRate(string n, string ns, VentilationRate o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(VentilationRate)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("VentilationRate", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write322_DepressurizationLimits(string n, string ns, DepressurizationLimits o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DepressurizationLimits)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DepressurizationLimits", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write323_WaterTableLevels(string n, string ns, WaterTableLevels o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WaterTableLevels)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WaterTableLevels", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write324_SheathingMaterials(string n, string ns, SheathingMaterials o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SheathingMaterials)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SheathingMaterials", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write325_ExteriorMaterials(string n, string ns, ExteriorMaterials o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ExteriorMaterials)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ExteriorMaterials", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write326_RoofingMaterials(string n, string ns, RoofingMaterials o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(RoofingMaterials)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("RoofingMaterials", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write327_AirTightnessTypes(string n, string ns, AirTightnessTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(AirTightnessTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("AirTightnessTypes", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write328_BlowerTestPressures(string n, string ns, BlowerTestPressures o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(BlowerTestPressures)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("BlowerTestPressures", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write329_AllowableRise(string n, string ns, AllowableRise o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(AllowableRise)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("AllowableRise", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write33_RankTextAndValue(string n, string ns, RankTextAndValue o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(RankTextAndValue)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("RankTextAndValue", "");
                }
                base.WriteAttribute("rank", "", o.Rank);
                base.WriteAttribute("value", "", XmlConvert.ToString(o.Value));
                if (o.Text != null)
                {
                    base.WriteValue(o.Text);
                }
                base.WriteEndElement(o);
            }
        }

        private void Write330_Terrains(string n, string ns, Terrains o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Terrains)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Terrains", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write331_TestStatuses(string n, string ns, TestStatuses o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(TestStatuses)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("TestStatuses", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write332_LocalShieldings(string n, string ns, LocalShieldings o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(LocalShieldings)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("LocalShieldings", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write333_AirLeakageTestTypes(string n, string ns, AirLeakageTestTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(AirLeakageTestTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("AirLeakageTestTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write334_OpeningsUpstairs(string n, string ns, OpeningsUpstairs o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(OpeningsUpstairs)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("OpeningsUpstairs", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write335_VentilationTypes(string n, string ns, VentilationTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(VentilationTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("VentilationTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write336_VentilationUses(string n, string ns, VentilationUses o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(VentilationUses)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("VentilationUses", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write337_AirDistributionTypes(string n, string ns, AirDistributionTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(AirDistributionTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("AirDistributionTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write338_AirDistributionFanPowerLevels(string n, string ns, AirDistributionFanPowerLevels o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(AirDistributionFanPowerLevels)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("AirDistributionFanPowerLevels", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write339_OperationSchedules(string n, string ns, OperationSchedules o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(OperationSchedules)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("OperationSchedules", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write34_Weather(string n, string ns, Weather o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Weather)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Weather", "");
                }
                base.WriteAttribute("depthOfFrost", "", XmlConvert.ToString(o.DepthOfFrost));
                base.WriteAttribute("heatingDegreeDay", "", XmlConvert.ToString(o.HeatingDegreeDay));
                base.WriteAttribute("library", "", o.Library);
                this.Write18_CodeAndText("Region", "", o.RegionXml, false, false);
                this.Write18_CodeAndText("Location", "", o.LocationXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write340_VentilatorTypes(string n, string ns, VentilatorTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(VentilatorTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("VentilatorTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write341_DuctLocations(string n, string ns, DuctLocations o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DuctLocations)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DuctLocations", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write342_DuctTypes(string n, string ns, DuctTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DuctTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DuctTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write343_DuctSealingCharacteristics(string n, string ns, DuctSealingCharacteristics o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DuctSealingCharacteristics)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DuctSealingCharacteristics", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write344_ShowerTemperatures(string n, string ns, ShowerTemperatures o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ShowerTemperatures)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ShowerTemperatures", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write345_ShowerFlowRates(string n, string ns, ShowerFlowRates o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ShowerFlowRates)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ShowerFlowRates", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write346_BaseShowerTemperatures(string n, string ns, BaseShowerTemperatures o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(BaseShowerTemperatures)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("BaseShowerTemperatures", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write347_BaseShowerFlowRates(string n, string ns, BaseShowerFlowRates o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(BaseShowerFlowRates)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("BaseShowerFlowRates", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write348_BaseFaucetFlowRates(string n, string ns, BaseFaucetFlowRates o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(BaseFaucetFlowRates)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("BaseFaucetFlowRates", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write349_ApplianceEnergySources(string n, string ns, ApplianceEnergySources o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ApplianceEnergySources)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ApplianceEnergySources", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write35_File(string n, string ns, File o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(File)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("File", "");
                }
                base.WriteAttribute("evaluationDate", "", FromDate(o.EvaluationDate));
                base.WriteElementString("Identification", "", o.Identification);
                base.WriteElementString("PreviousFileId", "", o.PreviousFileId);
                base.WriteElementString("EnrollmentId", "", o.EnrollmentId);
                base.WriteElementString("TaxNumber", "", o.TaxNumber);
                base.WriteElementString("EnteredBy", "", o.EnteredBy);
                base.WriteElementString("UserTelephone", "", o.UserTelephone);
                base.WriteElementString("UserExtension", "", o.UserExtension);
                base.WriteElementString("CompanyTelephone", "", o.CompanyTelephone);
                base.WriteElementString("CompanyExtension", "", o.CompanyExtension);
                base.WriteElementString("Company", "", o.Company);
                base.WriteElementString("BuilderName", "", o.BuilderName);
                base.WriteElementString("HomeownerAuthorizationId", "", o.HomeownerAuthorizationId);
                this.Write18_CodeAndText("Ownership", "", o.OwnershipXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write350_ClothesWasherTemperatures(string n, string ns, ClothesWasherTemperatures o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ClothesWasherTemperatures)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ClothesWasherTemperatures", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write351_ApplianceEnergySourceSpecified(string n, string ns, ApplianceEnergySourceSpecified o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ApplianceEnergySourceSpecified)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ApplianceEnergySourceSpecified", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write352_InteriorLightingTypes(string n, string ns, InteriorLightingTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(InteriorLightingTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("InteriorLightingTypes", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write353_DryerRatedConsumptions(string n, string ns, DryerRatedConsumptions o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DryerRatedConsumptions)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DryerRatedConsumptions", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write354_StoveRatedConsumptions(string n, string ns, StoveRatedConsumptions o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(StoveRatedConsumptions)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("StoveRatedConsumptions", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write355_RefrigeratorRatedConsumptions(string n, string ns, RefrigeratorRatedConsumptions o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(RefrigeratorRatedConsumptions)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("RefrigeratorRatedConsumptions", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write356_Months(string n, string ns, Months o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Months)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Months", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write357_HeatingFanModes(string n, string ns, HeatingFanModes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HeatingFanModes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HeatingFanModes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write358_CoolingFanModes(string n, string ns, CoolingFanModes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CoolingFanModes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CoolingFanModes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write359_HeatingCoolingUses(string n, string ns, HeatingCoolingUses o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HeatingCoolingUses)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HeatingCoolingUses", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write36_Name(string n, string ns, Name o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Name)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Name", "");
                }
                base.WriteElementString("First", "", o.First);
                base.WriteElementString("Last", "", o.Last);
                base.WriteEndElement(o);
            }
        }

        private void Write360_HeatingLocations(string n, string ns, HeatingLocations o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HeatingLocations)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HeatingLocations", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write361_YearMade(string n, string ns, YearMade o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(YearMade)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("YearMade", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write362_HeatingUsages(string n, string ns, HeatingUsages o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HeatingUsages)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HeatingUsages", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write363_HeatPumpCutoffTypes(string n, string ns, HeatPumpCutoffTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HeatPumpCutoffTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HeatPumpCutoffTypes", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write364_HeatPumpRatingTypes(string n, string ns, HeatPumpRatingTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HeatPumpRatingTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HeatPumpRatingTypes", "");
                }
                base.WriteElementStringRaw("Value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        private void Write365_HeatPumpFunctions(string n, string ns, HeatPumpFunctions o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HeatPumpFunctions)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HeatPumpFunctions", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write366_CentralEquipmentTypes(string n, string ns, CentralEquipmentTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CentralEquipmentTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CentralEquipmentTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write367_HeatingEnergySources(string n, string ns, HeatingEnergySources o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HeatingEnergySources)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HeatingEnergySources", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write368_SupplementaryEnergySources(string n, string ns, SupplementaryEnergySources o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SupplementaryEnergySources)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SupplementaryEnergySources", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write369_MultipleSystemsEnergySources(string n, string ns, MultipleSystemsEnergySources o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(MultipleSystemsEnergySources)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("MultipleSystemsEnergySources", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write37_MailingAddress(string n, string ns, MailingAddress o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(MailingAddress)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("MailingAddress", "");
                }
                base.WriteElementString("Street", "", o.Street);
                base.WriteElementString("UnitNumber", "", o.UnitNumber);
                this.Write18_CodeAndText("City", "", o.City, false, false);
                base.WriteElementString("Province", "", o.ProvinceOrTerritory);
                base.WriteElementString("PostalCode", "", o.PostalCode);
                base.WriteElementString("Name", "", o.Name);
                base.WriteEndElement(o);
            }
        }

        private void Write370_P9EnergySources(string n, string ns, P9EnergySources o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(P9EnergySources)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("P9EnergySources", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write371_FlueTypes(string n, string ns, FlueTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FlueTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FlueTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write372_ElectricBoilerTypes(string n, string ns, ElectricBoilerTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ElectricBoilerTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ElectricBoilerTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write373_GasPropaneBoilerTypes(string n, string ns, GasPropaneBoilerTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(GasPropaneBoilerTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("GasPropaneBoilerTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write374_OilBoilerTypes(string n, string ns, OilBoilerTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(OilBoilerTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("OilBoilerTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write375_WoodBoilerTypes(string n, string ns, WoodBoilerTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WoodBoilerTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WoodBoilerTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write376_WoodFurnaceTypes(string n, string ns, WoodFurnaceTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WoodFurnaceTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WoodFurnaceTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write377_ElectricFurnaceTypes(string n, string ns, ElectricFurnaceTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ElectricFurnaceTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ElectricFurnaceTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write378_GasPropaneFurnaceTypes(string n, string ns, GasPropaneFurnaceTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(GasPropaneFurnaceTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("GasPropaneFurnaceTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write379_OilFurnaceTypes(string n, string ns, OilFurnaceTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(OilFurnaceTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("OilFurnaceTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write38_Address(string n, string ns, Address o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(Address))
                    {
                        if (!(type == typeof(MailingAddress)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write37_MailingAddress(n, ns, (MailingAddress)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Address", "");
                }
                base.WriteElementString("Street", "", o.Street);
                base.WriteElementString("UnitNumber", "", o.UnitNumber);
                this.Write18_CodeAndText("City", "", o.City, false, false);
                base.WriteElementString("Province", "", o.ProvinceOrTerritory);
                base.WriteElementString("PostalCode", "", o.PostalCode);
                base.WriteEndElement(o);
            }
        }

        private void Write380_GasPropaneComboHeatDhwTypes(string n, string ns, GasPropaneComboHeatDhwTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(GasPropaneComboHeatDhwTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("GasPropaneComboHeatDhwTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write381_OilComboHeatDhwTypes(string n, string ns, OilComboHeatDhwTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(OilComboHeatDhwTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("OilComboHeatDhwTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write382_Item(string n, string ns, ElectricSupplementaryHeatingTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ElectricSupplementaryHeatingTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ElectricSupplementaryHeatingTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write383_Item(string n, string ns, GasPropaneSupplementaryHeatingTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(GasPropaneSupplementaryHeatingTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("GasPropaneSupplementaryHeatingTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write384_OilSupplementaryHeatingTypes(string n, string ns, OilSupplementaryHeatingTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(OilSupplementaryHeatingTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("OilSupplementaryHeatingTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write385_WoodSupplementaryHeatingTypes(string n, string ns, WoodSupplementaryHeatingTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WoodSupplementaryHeatingTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WoodSupplementaryHeatingTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write386_MultipleSystemsElectricity(string n, string ns, MultipleSystemsElectricity o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(MultipleSystemsElectricity)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("MultipleSystemsElectricity", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write387_MultipleSystemsGasPropane(string n, string ns, MultipleSystemsGasPropane o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(MultipleSystemsGasPropane)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("MultipleSystemsGasPropane", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write388_MultipleSystemsOil(string n, string ns, MultipleSystemsOil o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(MultipleSystemsOil)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("MultipleSystemsOil", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write389_MultipleSystemsWood(string n, string ns, MultipleSystemsWood o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(MultipleSystemsWood)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("MultipleSystemsWood", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write39_Client(string n, string ns, Client o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Client)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Client", "");
                }
                this.Write36_Name("Name", "", o.Name, false, false);
                base.WriteElementString("Telephone", "", o.Telephone);
                this.Write38_Address("StreetAddress", "", o.StreetAddress, false, false);
                this.Write37_MailingAddress("MailingAddress", "", o.MailingAddress, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write390_MultipleSystemsEfficiencyTypes(string n, string ns, MultipleSystemsEfficiencyTypes o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(MultipleSystemsEfficiencyTypes)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("MultipleSystemsEfficiencyTypes", "");
                }
                base.WriteEndElement(o);
            }
        }

        private void Write391_RemoteCommunity(string n, string ns, RemoteCommunity o, bool needType)
        {
            if (!needType && (o.GetType() != typeof(RemoteCommunity)))
            {
                throw base.CreateUnknownTypeException(o);
            }
            base.WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                base.WriteXsiType("RemoteCommunity", "");
            }
            base.WriteEndElement(o);
        }

        private void Write392_ExhaustLocationOptions(string n, string ns, ExhaustLocationOptions o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ExhaustLocationOptions)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ExhaustLocationOptions", "");
                }
                base.WriteSerializable(o.Xml, "Xml", "", false, true);
                base.WriteEndElement(o);
            }
        }

        private void Write393_ResultsType(string n, string ns, ResultsType o, bool needType)
        {
            if (!needType && (o.GetType() != typeof(ResultsType)))
            {
                throw base.CreateUnknownTypeException(o);
            }
            base.WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                base.WriteXsiType("ResultsType", "");
            }
            base.WriteEndElement(o);
        }

        private void Write394_PropaneConsummable(string n, string ns, PropaneConsummable o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(PropaneConsummable)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("PropaneConsummable", "");
                }
                base.WriteAttribute("baseload", "", XmlConvert.ToString(o.Baseload));
                base.WriteAttribute("hotWater", "", XmlConvert.ToString(o.HotWater));
                base.WriteAttribute("spaceHeating", "", XmlConvert.ToString(o.SpaceHeating));
                base.WriteAttribute("total", "", XmlConvert.ToString(o.TotalInGigaJoules));
                base.WriteAttribute("appliance", "", XmlConvert.ToString(o.Appliance));
                base.WriteEndElement(o);
            }
        }

        private void Write395_ExposedSurfaces(string n, string ns, ExposedSurfaces o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ExposedSurfaces)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ExposedSurfaces", "");
                }
                base.WriteElementStringRaw("ExteriorAboveGroundArea", "", XmlConvert.ToString(o.ExteriorAboveGroundArea));
                base.WriteElementStringRaw("ExteriorBelowGroundArea", "", XmlConvert.ToString(o.ExteriorBelowGroundArea));
                base.WriteElementStringRaw("InteriorAboveGroundArea", "", XmlConvert.ToString(o.InteriorAboveGroundArea));
                base.WriteElementStringRaw("InteriorBelowGroundArea", "", XmlConvert.ToString(o.InteriorBelowGroundArea));
                base.WriteElementStringRaw("PonyWallArea", "", XmlConvert.ToString(o.PonyWallArea));
                base.WriteElementStringRaw("WalkoutPerimeter", "", XmlConvert.ToString(o.WalkoutPerimeter));
                base.WriteElementStringRaw("ExposedPerimeter", "", XmlConvert.ToString(o.ExposedPerimeter));
                base.WriteEndElement(o);
            }
        }

        private void Write396_OptionalFeatures(string n, string ns, OptionalFeatures o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(OptionalFeatures)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("OptionalFeatures", "");
                }
                this.Write285_SelectedValueAndUnits("ElectronicThermostats", "", o.ElectronicThermostats, false, false);
                this.Write285_SelectedValueAndUnits("Ventilation", "", o.Ventilation, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write397_OtherCredits(string n, string ns, OtherCredits o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(OtherCredits)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("OtherCredits", "");
                }
                this.Write285_SelectedValueAndUnits("OtherCredit1", "", o.OtherCredit1, false, false);
                this.Write285_SelectedValueAndUnits("OtherCredit2", "", o.OtherCredit2, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write398_Application(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Application", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write5_Application("Application", "", (Application)o, true, false);
            }
        }

        public void Write399_Cardinal(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Cardinal", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write6_Cardinal("Cardinal", "", (Cardinal)o, true, false);
            }
        }

        private void Write4_SimulationSettings(string n, string ns, SimulationSettings o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SimulationSettings)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SimulationSettings", "");
                }
                base.WriteAttribute("simulateBaseHouse", "", XmlConvert.ToString(o.SimulateBaseHouse));
                base.WriteAttribute("simulateUpgradedHouse", "", XmlConvert.ToString(o.SimulateUpgradedHouse));
                base.WriteAttribute("simulateByCategory", "", XmlConvert.ToString(o.SimulateByCategory));
                base.WriteEndElement(o);
            }
        }

        private void Write40_SelectedAndDate(string n, string ns, SelectedAndDate o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SelectedAndDate)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SelectedAndDate", "");
                }
                base.WriteAttribute("selected", "", XmlConvert.ToString(o.Selected));
                if (o.Date != null)
                {
                    base.WriteValue(o.Date);
                }
                base.WriteEndElement(o);
            }
        }

        public void Write400_CodeReference(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CodeReference", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write7_CodeReference("CodeReference", "", (CodeReference)o, true, false);
            }
        }

        public void Write401_eConversionType(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteEmptyTag("eConversionType", "");
            }
            else
            {
                base.WriteElementString("eConversionType", "", this.Write8_eConversionType((eConversionType)o));
            }
        }

        public void Write402_eUnitType(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteEmptyTag("eUnitType", "");
            }
            else
            {
                base.WriteElementString("eUnitType", "", this.Write9_eUnitType((eUnitType)o));
            }
        }

        public void Write403_unit_classes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteEmptyTag("unit_classes", "");
            }
            else
            {
                base.WriteElementString("unit_classes", "", this.Write10_unit_classes((unit_classes)o));
            }
        }

        public void Write404_unit_types(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteEmptyTag("unit_types", "");
            }
            else
            {
                base.WriteElementString("unit_types", "", this.Write11_unit_types((unit_types)o));
            }
        }

        public void Write405_building_types(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteEmptyTag("building_types", "");
            }
            else
            {
                base.WriteElementString("building_types", "", this.Write12_building_types((building_types)o));
            }
        }

        public void Write406_BooleanValue(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("BooleanValue", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write13_BooleanValue("BooleanValue", "", (BooleanValue)o, true, false);
            }
        }

        public void Write407_CodeAndText(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CodeAndText", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write18_CodeAndText("CodeAndText", "", (CodeAndText)o, true, false);
            }
        }

        public void Write408_CodeDescriptionAndComposite(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CodeDescriptionAndComposite", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write20_CodeDescriptionAndComposite("CodeDescriptionAndComposite", "", (CodeDescriptionAndComposite)o, true, false);
            }
        }

        public void Write409_CodeTextAndValue(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CodeTextAndValue", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write23_CodeTextAndValue("CodeTextAndValue", "", (CodeTextAndValue)o, true, false);
            }
        }

        private void Write41_SelectedAndText(string n, string ns, SelectedAndText o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SelectedAndText)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SelectedAndText", "");
                }
                base.WriteAttribute("selected", "", XmlConvert.ToString(o.Selected));
                if (o.Text != null)
                {
                    base.WriteValue(o.Text);
                }
                base.WriteEndElement(o);
            }
        }

        public void Write410_CopSeerValue(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CopSeerValue", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write24_CopSeerValue("CopSeerValue", "", (CopSeerValue)o, true, false);
            }
        }

        public void Write411_LanguageOptions(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteEmptyTag("LanguageOptions", "");
            }
            else
            {
                this.Write25_LanguageOptions("LanguageOptions", "", (LanguageOptions)o, false);
            }
        }

        public void Write412_OutputCapacity(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("OutputCapacity", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write21_OutputCapacity("OutputCapacity", "", (OutputCapacity)o, true, false);
            }
        }

        public void Write413_ProvinceOrTerritory(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteEmptyTag("ProvinceOrTerritory", "");
            }
            else
            {
                this.Write26_ProvinceOrTerritory("ProvinceOrTerritory", "", (ProvinceOrTerritory)o, false);
            }
        }

        public void Write414_SelectedAndValue(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SelectedAndValue", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write27_SelectedAndValue("SelectedAndValue", "", (SelectedAndValue)o, true, false);
            }
        }

        public void Write415_HouseFileError(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HouseFileError", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write29_HouseFileError("HouseFileError", "", (HouseFileError)o, true, false);
            }
        }

        public void Write416_StdSort(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("StdSort", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write31_StdSort("StdSort", "", (StdSort)o, true, false);
            }
        }

        public void Write417_Labels(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Labels", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write2_Labels("Labels", "", (Labels)o, true, false);
            }
        }

        public void Write418_MonthlyData(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("MonthlyData", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write32_MonthlyData("MonthlyData", "", (MonthlyData)o, true, false);
            }
        }

        public void Write419_RankTextAndValue(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("RankTextAndValue", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write33_RankTextAndValue("RankTextAndValue", "", (RankTextAndValue)o, true, false);
            }
        }

        private void Write42_CorrectedInsulation(string n, string ns, CorrectedInsulation o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CorrectedInsulation)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CorrectedInsulation", "");
                }
                this.Write41_SelectedAndText("Ceilings", "", o.Ceilings, false, false);
                this.Write41_SelectedAndText("Walls", "", o.Walls, false, false);
                this.Write41_SelectedAndText("Basement", "", o.Basement, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write420_HouseFile(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HouseFile", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write283_HouseFile("HouseFile", "", (HouseFile)o, true, false);
            }
        }

        public void Write421_Utf8Helper(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Utf8Helper", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write284_Utf8Helper("Utf8Helper", "", (Utf8Helper)o, true, false);
            }
        }

        public void Write422_RsiSection(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("RsiSection", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write19_RsiSection("RsiSection", "", (RsiSection)o, true, false);
            }
        }

        public void Write423_SelectedAndDate(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SelectedAndDate", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write40_SelectedAndDate("SelectedAndDate", "", (SelectedAndDate)o, true, false);
            }
        }

        public void Write424_SelectedAndText(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SelectedAndText", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write41_SelectedAndText("SelectedAndText", "", (SelectedAndText)o, true, false);
            }
        }

        public void Write425_SelectedValueAndUnits(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SelectedValueAndUnits", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write285_SelectedValueAndUnits("SelectedValueAndUnits", "", (SelectedValueAndUnits)o, true, false);
            }
        }

        public void Write426_SimulationSettings(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SimulationSettings", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write4_SimulationSettings("SimulationSettings", "", (SimulationSettings)o, true, false);
            }
        }

        public void Write427_ValueOnly(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ValueOnly", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write256_ValueOnly("ValueOnly", "", (ValueOnly)o, true, false);
            }
        }

        public void Write428_Version(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Version", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write3_HouseFileVersion("Version", "", (HouseFileVersion)o, true, false);
            }
        }

        public void Write429_WeatherLibrary(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WeatherLibrary", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write288_WeatherLibrary("WeatherLibrary", "", (WeatherLibrary)o, true, false);
            }
        }

        private void Write43_Justifications(string n, string ns, Justifications o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Justifications)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Justifications", "");
                }
                base.WriteAttribute("nameplateEfficiency", "", XmlConvert.ToString(o.NameplateEfficiency));
                base.WriteAttribute("combustionTestEfficiency", "", XmlConvert.ToString(o.CombustionTestEfficiency));
                base.WriteAttribute("heatingCorrection", "", XmlConvert.ToString(o.HeatingCorrection));
                base.WriteAttribute("achCorrection", "", XmlConvert.ToString(o.AchCorrection));
                base.WriteAttribute("twoBlowerDoors", "", XmlConvert.ToString(o.TwoBlowerDoors));
                base.WriteAttribute("over18Months", "", XmlConvert.ToString(o.Over18Months));
                this.Write40_SelectedAndDate("PossessionDate", "", o.PossessionDate, false, false);
                this.Write41_SelectedAndText("HeatingVolumeDecrease", "", o.HeatingVolumeDecrease, false, false);
                this.Write42_CorrectedInsulation("CorrectedInsulation", "", o.CorrectedInsulation, false, false);
                this.Write41_SelectedAndText("Other", "", o.Other, false, false);
                this.Write18_CodeAndText("EnergyStar", "", o.EnergyStar, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write430_WeatherLocation(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WeatherLocation", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write287_WeatherLocation("WeatherLocation", "", (WeatherLocation)o, true, false);
            }
        }

        public void Write431_WeatherRegion(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WeatherRegion", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write286_WeatherRegion("WeatherRegion", "", (WeatherRegion)o, true, false);
            }
        }

        public void Write432_FuelCostsMonthly(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FuelCostsMonthly", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write239_FuelCostsMonthly("FuelCostsMonthly", "", (FuelCostsMonthly)o, true, false);
            }
        }

        public void Write433_FuelCostMonthlyData(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FuelCostMonthlyData", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write238_FuelCostMonthlyData("FuelCostMonthlyData", "", (FuelCostMonthlyData)o, true, false);
            }
        }

        public void Write434_FuelCostRateBlock(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FuelCostRateBlock", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write235_FuelCostRateBlock("FuelCostRateBlock", "", (FuelCostRateBlock)o, true, false);
            }
        }

        public void Write435_FuelCostRateBlocks(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FuelCostRateBlocks", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write236_FuelCostRateBlocks("FuelCostRateBlocks", "", (FuelCostRateBlocks)o, true, false);
            }
        }

        public void Write436_FuelCostMinimum(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FuelCostMinimum", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write234_FuelCostMinimum("FuelCostMinimum", "", (FuelCostMinimum)o, true, false);
            }
        }

        public void Write437_FuelCostByType(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FuelCostByType", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write237_FuelCostByType("FuelCostByType", "", (FuelCostByType)o, true, false);
            }
        }

        public void Write438_FuelCosts(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FuelCosts", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write240_FuelCosts("FuelCosts", "", (FuelCosts)o, true, false);
            }
        }

        public void Write439_CeilingTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CeilingTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write290_CeilingTypes("CeilingTypes", "", (CeilingTypes)o, true, false);
            }
        }

        private void Write44_ProgramInformation(string n, string ns, ProgramInformation o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ProgramInformation)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ProgramInformation", "");
                }
                base.WriteAttribute("mixed", "", XmlConvert.ToString(o.Mixed));
                this.Write34_Weather("Weather", "", o.Weather, false, false);
                this.Write35_File("File", "", o.File, false, false);
                this.Write39_Client("Client", "", o.Client, false, false);
                this.Write43_Justifications("Justifications", "", o.Justifications, false, false);
                List<CodeAndText> information = o.Information;
                if (information != null)
                {
                    base.WriteStartElement("Information", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= information.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        this.Write18_CodeAndText("Info", "", information[num], true, false);
                        num++;
                    }
                }
                base.WriteEndElement(o);
            }
        }

        public void Write440_CeilingSlopes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CeilingSlopes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write292_CeilingSlopes("CeilingSlopes", "", (CeilingSlopes)o, true, false);
            }
        }

        public void Write441_DoorTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DoorTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write293_DoorTypes("DoorTypes", "", (DoorTypes)o, true, false);
            }
        }

        public void Write442_FloorHeaderDirections(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FloorHeaderDirections", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write294_FloorHeaderDirections("FloorHeaderDirections", "", (FloorHeaderDirections)o, true, false);
            }
        }

        public void Write443_WallDirections(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WallDirections", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write295_WallDirections("WallDirections", "", (WallDirections)o, true, false);
            }
        }

        public void Write444_WindowDirections(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WindowDirections", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write296_WindowDirections("WindowDirections", "", (WindowDirections)o, true, false);
            }
        }

        public void Write445_HouseDirections(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HouseDirections", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write297_HouseDirections("HouseDirections", "", (HouseDirections)o, true, false);
            }
        }

        public void Write446_WindowTilts(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WindowTilts", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write298_WindowTilts("WindowTilts", "", (WindowTilts)o, true, false);
            }
        }

        public void Write447_DhwEnergySources(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DhwEnergySources", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write299_DhwEnergySources("DhwEnergySources", "", (DhwEnergySources)o, true, false);
            }
        }

        public void Write448_DhwDrawPatterns(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DhwDrawPatterns", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write300_DhwDrawPatterns("DhwDrawPatterns", "", (DhwDrawPatterns)o, true, false);
            }
        }

        public void Write449_DhwTankTypeElectric(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DhwTankTypeElectric", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write301_DhwTankTypeElectric("DhwTankTypeElectric", "", (DhwTankTypeElectric)o, true, false);
            }
        }

        private void Write45_CeilingConstruction(string n, string ns, CeilingConstruction o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CeilingConstruction)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CeilingConstruction", "");
                }
                this.Write7_CodeReference("CeilingType", "", o.CeilingType, false, false);
                this.Write18_CodeAndText("Type", "", o.TypeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write450_DhwTankTypeGasPropane(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DhwTankTypeGasPropane", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write302_DhwTankTypeGasPropane("DhwTankTypeGasPropane", "", (DhwTankTypeGasPropane)o, true, false);
            }
        }

        public void Write451_DhwTankTypeOil(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DhwTankTypeOil", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write303_DhwTankTypeOil("DhwTankTypeOil", "", (DhwTankTypeOil)o, true, false);
            }
        }

        public void Write452_DhwTankTypeWood(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DhwTankTypeWood", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write304_DhwTankTypeWood("DhwTankTypeWood", "", (DhwTankTypeWood)o, true, false);
            }
        }

        public void Write453_DhwTankTypeSolar(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DhwTankTypeSolar", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write305_DhwTankTypeSolar("DhwTankTypeSolar", "", (DhwTankTypeSolar)o, true, false);
            }
        }

        public void Write454_DhwTankVolumes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DhwTankVolumes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write306_DhwTankVolumes("DhwTankVolumes", "", (DhwTankVolumes)o, true, false);
            }
        }

        public void Write455_DhwTankLocations(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DhwTankLocations", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write307_DhwTankLocations("DhwTankLocations", "", (DhwTankLocations)o, true, false);
            }
        }

        public void Write456_PhotovoltaicModules(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("PhotovoltaicModules", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write308_PhotovoltaicModules("PhotovoltaicModules", "", (PhotovoltaicModules)o, true, false);
            }
        }

        public void Write457_RoomTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("RoomTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write309_RoomTypes("RoomTypes", "", (RoomTypes)o, true, false);
            }
        }

        public void Write458_RoomFloors(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("RoomFloors", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write310_RoomFloors("RoomFloors", "", (RoomFloors)o, true, false);
            }
        }

        public void Write459_HouseOwnerships(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HouseOwnerships", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write311_HouseOwnerships("HouseOwnerships", "", (HouseOwnerships)o, true, false);
            }
        }

        private void Write46_CeilingMeasurements(string n, string ns, CeilingMeasurements o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CeilingMeasurements)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CeilingMeasurements", "");
                }
                base.WriteAttribute("area", "", XmlConvert.ToString(o.Area));
                base.WriteAttribute("length", "", XmlConvert.ToString(o.Length));
                base.WriteAttribute("heelHeight", "", XmlConvert.ToString(o.HeelHeight));
                this.Write23_CodeTextAndValue("Slope", "", o.SlopeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write460_HousePlanShapes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HousePlanShapes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write312_HousePlanShapes("HousePlanShapes", "", (HousePlanShapes)o, true, false);
            }
        }

        public void Write461_HouseStoreys(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HouseStoreys", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write313_HouseStoreys("HouseStoreys", "", (HouseStoreys)o, true, false);
            }
        }

        public void Write462_HouseTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HouseTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write314_HouseTypes("HouseTypes", "", (HouseTypes)o, true, false);
            }
        }

        public void Write463_HouseTypesMurb(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HouseTypesMurb", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write315_HouseTypesMurb("HouseTypesMurb", "", (HouseTypesMurb)o, true, false);
            }
        }

        public void Write464_ThermalMass(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ThermalMass", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write316_ThermalMass("ThermalMass", "", (ThermalMass)o, true, false);
            }
        }

        public void Write465_YearBuilt(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("YearBuilt", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write317_YearBuilt("YearBuilt", "", (YearBuilt)o, true, false);
            }
        }

        public void Write466_SoilConditions(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SoilConditions", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write318_SoilConditions("SoilConditions", "", (SoilConditions)o, true, false);
            }
        }

        public void Write467_Colours(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Colours", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write319_Colours("Colours", "", (Colours)o, true, false);
            }
        }

        public void Write468_WindowAirTightness(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WindowAirTightness", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write320_WindowAirTightness("WindowAirTightness", "", (WindowAirTightness)o, true, false);
            }
        }

        public void Write469_VentilationRate(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("VentilationRate", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write321_VentilationRate("VentilationRate", "", (VentilationRate)o, true, false);
            }
        }

        private void Write47_Ceiling(string n, string ns, Ceiling o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Ceiling)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Ceiling", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write45_CeilingConstruction("Construction", "", o.Construction, false, false);
                this.Write46_CeilingMeasurements("Measurements", "", o.Measurements, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write470_DepressurizationLimits(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DepressurizationLimits", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write322_DepressurizationLimits("DepressurizationLimits", "", (DepressurizationLimits)o, true, false);
            }
        }

        public void Write471_WaterTableLevels(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WaterTableLevels", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write323_WaterTableLevels("WaterTableLevels", "", (WaterTableLevels)o, true, false);
            }
        }

        public void Write472_SheathingMaterials(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SheathingMaterials", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write324_SheathingMaterials("SheathingMaterials", "", (SheathingMaterials)o, true, false);
            }
        }

        public void Write473_ExteriorMaterials(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ExteriorMaterials", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write325_ExteriorMaterials("ExteriorMaterials", "", (ExteriorMaterials)o, true, false);
            }
        }

        public void Write474_RoofingMaterials(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("RoofingMaterials", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write326_RoofingMaterials("RoofingMaterials", "", (RoofingMaterials)o, true, false);
            }
        }

        public void Write475_AirTightnessTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("AirTightnessTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write327_AirTightnessTypes("AirTightnessTypes", "", (AirTightnessTypes)o, true, false);
            }
        }

        public void Write476_BlowerTestPressures(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("BlowerTestPressures", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write328_BlowerTestPressures("BlowerTestPressures", "", (BlowerTestPressures)o, true, false);
            }
        }

        public void Write477_AllowableRise(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("AllowableRise", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write329_AllowableRise("AllowableRise", "", (AllowableRise)o, true, false);
            }
        }

        public void Write478_Terrains(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Terrains", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write330_Terrains("Terrains", "", (Terrains)o, true, false);
            }
        }

        public void Write479_TestStatuses(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("TestStatuses", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write331_TestStatuses("TestStatuses", "", (TestStatuses)o, true, false);
            }
        }

        private void Write48_DoorConstruction(string n, string ns, DoorConstruction o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DoorConstruction)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DoorConstruction", "");
                }
                base.WriteAttribute("energyStar", "", XmlConvert.ToString(o.EnergyStar));
                this.Write23_CodeTextAndValue("Type", "", o.TypeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write480_LocalShieldings(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("LocalShieldings", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write332_LocalShieldings("LocalShieldings", "", (LocalShieldings)o, true, false);
            }
        }

        public void Write481_AirLeakageTestTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("AirLeakageTestTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write333_AirLeakageTestTypes("AirLeakageTestTypes", "", (AirLeakageTestTypes)o, true, false);
            }
        }

        public void Write482_OpeningsUpstairs(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("OpeningsUpstairs", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write334_OpeningsUpstairs("OpeningsUpstairs", "", (OpeningsUpstairs)o, true, false);
            }
        }

        public void Write483_VentilationTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("VentilationTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write335_VentilationTypes("VentilationTypes", "", (VentilationTypes)o, true, false);
            }
        }

        public void Write484_VentilationUses(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("VentilationUses", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write336_VentilationUses("VentilationUses", "", (VentilationUses)o, true, false);
            }
        }

        public void Write485_AirDistributionTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("AirDistributionTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write337_AirDistributionTypes("AirDistributionTypes", "", (AirDistributionTypes)o, true, false);
            }
        }

        public void Write486_AirDistributionFanPowerLevels(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("AirDistributionFanPowerLevels", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write338_AirDistributionFanPowerLevels("AirDistributionFanPowerLevels", "", (AirDistributionFanPowerLevels)o, true, false);
            }
        }

        public void Write487_OperationSchedules(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("OperationSchedules", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write339_OperationSchedules("OperationSchedules", "", (OperationSchedules)o, true, false);
            }
        }

        public void Write488_VentilatorTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("VentilatorTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write340_VentilatorTypes("VentilatorTypes", "", (VentilatorTypes)o, true, false);
            }
        }

        public void Write489_DuctLocations(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DuctLocations", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write341_DuctLocations("DuctLocations", "", (DuctLocations)o, true, false);
            }
        }

        private void Write49_DoorMeasurements(string n, string ns, DoorMeasurements o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(DoorMeasurements)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("DoorMeasurements", "");
                }
                base.WriteAttribute("height", "", XmlConvert.ToString(o.Height));
                base.WriteAttribute("width", "", XmlConvert.ToString(o.Width));
                base.WriteEndElement(o);
            }
        }

        public void Write490_DuctTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DuctTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write342_DuctTypes("DuctTypes", "", (DuctTypes)o, true, false);
            }
        }

        public void Write491_DuctSealingCharacteristics(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DuctSealingCharacteristics", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write343_DuctSealingCharacteristics("DuctSealingCharacteristics", "", (DuctSealingCharacteristics)o, true, false);
            }
        }

        public void Write492_ShowerTemperatures(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ShowerTemperatures", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write344_ShowerTemperatures("ShowerTemperatures", "", (ShowerTemperatures)o, true, false);
            }
        }

        public void Write493_ShowerFlowRates(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ShowerFlowRates", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write345_ShowerFlowRates("ShowerFlowRates", "", (ShowerFlowRates)o, true, false);
            }
        }

        public void Write494_BaseShowerTemperatures(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("BaseShowerTemperatures", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write346_BaseShowerTemperatures("BaseShowerTemperatures", "", (BaseShowerTemperatures)o, true, false);
            }
        }

        public void Write495_BaseShowerFlowRates(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("BaseShowerFlowRates", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write347_BaseShowerFlowRates("BaseShowerFlowRates", "", (BaseShowerFlowRates)o, true, false);
            }
        }

        public void Write496_BaseFaucetFlowRates(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("BaseFaucetFlowRates", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write348_BaseFaucetFlowRates("BaseFaucetFlowRates", "", (BaseFaucetFlowRates)o, true, false);
            }
        }

        public void Write497_ApplianceEnergySources(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ApplianceEnergySources", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write349_ApplianceEnergySources("ApplianceEnergySources", "", (ApplianceEnergySources)o, true, false);
            }
        }

        public void Write498_ClothesWasherTemperatures(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ClothesWasherTemperatures", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write350_ClothesWasherTemperatures("ClothesWasherTemperatures", "", (ClothesWasherTemperatures)o, true, false);
            }
        }

        public void Write499_ApplianceEnergySourceSpecified(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ApplianceEnergySourceSpecified", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write351_ApplianceEnergySourceSpecified("ApplianceEnergySourceSpecified", "", (ApplianceEnergySourceSpecified)o, true, false);
            }
        }

        private void Write5_Application(string n, string ns, Application o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Application)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Application", "");
                }
                base.WriteElementString("Name", "", o.Name);
                this.Write3_HouseFileVersion("Version", "", o.Version, false, false);
                this.Write4_SimulationSettings("SimulationSettings", "", o.SimulationSettings, false, false);
                this.Write3_HouseFileVersion("LibraryVersion", "", o.LibraryVersion, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write50_Door(string n, string ns, Door o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Door)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Door", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                base.WriteAttribute("adjacentEnclosedSpace", "", XmlConvert.ToString(o.AdjacentEnclosedSpace));
                base.WriteAttribute("rValue", "", XmlConvert.ToString(o.RValue));
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write48_DoorConstruction("Construction", "", o.Construction, false, false);
                this.Write49_DoorMeasurements("Measurements", "", o.Measurements, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write500_InteriorLightingTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("InteriorLightingTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write352_InteriorLightingTypes("InteriorLightingTypes", "", (InteriorLightingTypes)o, true, false);
            }
        }

        public void Write501_DryerRatedConsumptions(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DryerRatedConsumptions", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write353_DryerRatedConsumptions("DryerRatedConsumptions", "", (DryerRatedConsumptions)o, true, false);
            }
        }

        public void Write502_StoveRatedConsumptions(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("StoveRatedConsumptions", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write354_StoveRatedConsumptions("StoveRatedConsumptions", "", (StoveRatedConsumptions)o, true, false);
            }
        }

        public void Write503_RefrigeratorRatedConsumptions(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("RefrigeratorRatedConsumptions", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write355_RefrigeratorRatedConsumptions("RefrigeratorRatedConsumptions", "", (RefrigeratorRatedConsumptions)o, true, false);
            }
        }

        public void Write504_Months(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Months", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write356_Months("Months", "", (Months)o, true, false);
            }
        }

        public void Write505_HeatingFanModes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HeatingFanModes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write357_HeatingFanModes("HeatingFanModes", "", (HeatingFanModes)o, true, false);
            }
        }

        public void Write506_CoolingFanModes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CoolingFanModes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write358_CoolingFanModes("CoolingFanModes", "", (CoolingFanModes)o, true, false);
            }
        }

        public void Write507_HeatingCoolingUses(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HeatingCoolingUses", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write359_HeatingCoolingUses("HeatingCoolingUses", "", (HeatingCoolingUses)o, true, false);
            }
        }

        public void Write508_HeatingLocations(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HeatingLocations", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write360_HeatingLocations("HeatingLocations", "", (HeatingLocations)o, true, false);
            }
        }

        public void Write509_YearMade(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("YearMade", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write361_YearMade("YearMade", "", (YearMade)o, true, false);
            }
        }

        private void Write51_FloorHeaderConstruction(string n, string ns, FloorHeaderConstruction o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FloorHeaderConstruction)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FloorHeaderConstruction", "");
                }
                this.Write7_CodeReference("Type", "", o.Type, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write510_HeatingUsages(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HeatingUsages", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write362_HeatingUsages("HeatingUsages", "", (HeatingUsages)o, true, false);
            }
        }

        public void Write511_HeatPumpCutoffTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HeatPumpCutoffTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write363_HeatPumpCutoffTypes("HeatPumpCutoffTypes", "", (HeatPumpCutoffTypes)o, true, false);
            }
        }

        public void Write512_HeatPumpRatingTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HeatPumpRatingTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write364_HeatPumpRatingTypes("HeatPumpRatingTypes", "", (HeatPumpRatingTypes)o, true, false);
            }
        }

        public void Write513_HeatPumpFunctions(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HeatPumpFunctions", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write365_HeatPumpFunctions("HeatPumpFunctions", "", (HeatPumpFunctions)o, true, false);
            }
        }

        public void Write514_CentralEquipmentTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CentralEquipmentTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write366_CentralEquipmentTypes("CentralEquipmentTypes", "", (CentralEquipmentTypes)o, true, false);
            }
        }

        public void Write515_HeatingEnergySources(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HeatingEnergySources", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write367_HeatingEnergySources("HeatingEnergySources", "", (HeatingEnergySources)o, true, false);
            }
        }

        public void Write516_SupplementaryEnergySources(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SupplementaryEnergySources", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write368_SupplementaryEnergySources("SupplementaryEnergySources", "", (SupplementaryEnergySources)o, true, false);
            }
        }

        public void Write517_MultipleSystemsEnergySources(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("MultipleSystemsEnergySources", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write369_MultipleSystemsEnergySources("MultipleSystemsEnergySources", "", (MultipleSystemsEnergySources)o, true, false);
            }
        }

        public void Write518_P9EnergySources(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("P9EnergySources", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write370_P9EnergySources("P9EnergySources", "", (P9EnergySources)o, true, false);
            }
        }

        public void Write519_FlueTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FlueTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write371_FlueTypes("FlueTypes", "", (FlueTypes)o, true, false);
            }
        }

        private void Write52_WallConstruction(string n, string ns, WallConstruction o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WallConstruction)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WallConstruction", "");
                }
                base.WriteAttribute("corners", "", XmlConvert.ToString(o.Corners));
                base.WriteAttribute("intersections", "", XmlConvert.ToString(o.Intersections));
                this.Write7_CodeReference("Type", "", o.Type, false, false);
                this.Write7_CodeReference("LintelType", "", o.LintelType, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write520_ElectricBoilerTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ElectricBoilerTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write372_ElectricBoilerTypes("ElectricBoilerTypes", "", (ElectricBoilerTypes)o, true, false);
            }
        }

        public void Write521_GasPropaneBoilerTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("GasPropaneBoilerTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write373_GasPropaneBoilerTypes("GasPropaneBoilerTypes", "", (GasPropaneBoilerTypes)o, true, false);
            }
        }

        public void Write522_OilBoilerTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("OilBoilerTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write374_OilBoilerTypes("OilBoilerTypes", "", (OilBoilerTypes)o, true, false);
            }
        }

        public void Write523_WoodBoilerTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WoodBoilerTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write375_WoodBoilerTypes("WoodBoilerTypes", "", (WoodBoilerTypes)o, true, false);
            }
        }

        public void Write524_WoodFurnaceTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WoodFurnaceTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write376_WoodFurnaceTypes("WoodFurnaceTypes", "", (WoodFurnaceTypes)o, true, false);
            }
        }

        public void Write525_ElectricFurnaceTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ElectricFurnaceTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write377_ElectricFurnaceTypes("ElectricFurnaceTypes", "", (ElectricFurnaceTypes)o, true, false);
            }
        }

        public void Write526_GasPropaneFurnaceTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("GasPropaneFurnaceTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write378_GasPropaneFurnaceTypes("GasPropaneFurnaceTypes", "", (GasPropaneFurnaceTypes)o, true, false);
            }
        }

        public void Write527_OilFurnaceTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("OilFurnaceTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write379_OilFurnaceTypes("OilFurnaceTypes", "", (OilFurnaceTypes)o, true, false);
            }
        }

        public void Write528_GasPropaneComboHeatDhwTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("GasPropaneComboHeatDhwTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write380_GasPropaneComboHeatDhwTypes("GasPropaneComboHeatDhwTypes", "", (GasPropaneComboHeatDhwTypes)o, true, false);
            }
        }

        public void Write529_OilComboHeatDhwTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("OilComboHeatDhwTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write381_OilComboHeatDhwTypes("OilComboHeatDhwTypes", "", (OilComboHeatDhwTypes)o, true, false);
            }
        }

        private void Write53_WindowConstruction(string n, string ns, WindowConstruction o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WindowConstruction)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WindowConstruction", "");
                }
                base.WriteAttribute("energyStar", "", XmlConvert.ToString(o.EnergyStar));
                this.Write7_CodeReference("Type", "", o.Type, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write530_Item(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ElectricSupplementaryHeatingTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write382_Item("ElectricSupplementaryHeatingTypes", "", (ElectricSupplementaryHeatingTypes)o, true, false);
            }
        }

        public void Write531_Item(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("GasPropaneSupplementaryHeatingTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write383_Item("GasPropaneSupplementaryHeatingTypes", "", (GasPropaneSupplementaryHeatingTypes)o, true, false);
            }
        }

        public void Write532_OilSupplementaryHeatingTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("OilSupplementaryHeatingTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write384_OilSupplementaryHeatingTypes("OilSupplementaryHeatingTypes", "", (OilSupplementaryHeatingTypes)o, true, false);
            }
        }

        public void Write533_WoodSupplementaryHeatingTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WoodSupplementaryHeatingTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write385_WoodSupplementaryHeatingTypes("WoodSupplementaryHeatingTypes", "", (WoodSupplementaryHeatingTypes)o, true, false);
            }
        }

        public void Write534_MultipleSystemsElectricity(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("MultipleSystemsElectricity", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write386_MultipleSystemsElectricity("MultipleSystemsElectricity", "", (MultipleSystemsElectricity)o, true, false);
            }
        }

        public void Write535_MultipleSystemsGasPropane(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("MultipleSystemsGasPropane", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write387_MultipleSystemsGasPropane("MultipleSystemsGasPropane", "", (MultipleSystemsGasPropane)o, true, false);
            }
        }

        public void Write536_MultipleSystemsOil(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("MultipleSystemsOil", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write388_MultipleSystemsOil("MultipleSystemsOil", "", (MultipleSystemsOil)o, true, false);
            }
        }

        public void Write537_MultipleSystemsWood(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("MultipleSystemsWood", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write389_MultipleSystemsWood("MultipleSystemsWood", "", (MultipleSystemsWood)o, true, false);
            }
        }

        public void Write538_MultipleSystemsEfficiencyTypes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("MultipleSystemsEfficiencyTypes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write390_MultipleSystemsEfficiencyTypes("MultipleSystemsEfficiencyTypes", "", (MultipleSystemsEfficiencyTypes)o, true, false);
            }
        }

        public void Write539_RemoteCommunity(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteEmptyTag("RemoteCommunity", "");
            }
            else
            {
                this.Write391_RemoteCommunity("RemoteCommunity", "", (RemoteCommunity)o, false);
            }
        }

        private void Write54_Construction(string n, string ns, Construction o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else if (!needType)
            {
                Type type = o.GetType();
                if (type != typeof(Construction))
                {
                    if (type == typeof(FloorConstruction))
                    {
                        this.Write55_FloorConstruction(n, ns, (FloorConstruction)o, isNullable, true);
                    }
                    else if (type == typeof(WindowConstruction))
                    {
                        this.Write53_WindowConstruction(n, ns, (WindowConstruction)o, isNullable, true);
                    }
                    else if (type == typeof(WallConstruction))
                    {
                        this.Write52_WallConstruction(n, ns, (WallConstruction)o, isNullable, true);
                    }
                    else
                    {
                        if (!(type == typeof(FloorHeaderConstruction)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write51_FloorHeaderConstruction(n, ns, (FloorHeaderConstruction)o, isNullable, true);
                    }
                }
            }
        }

        public void Write540_ResourceList(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ResourceList", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write289_ResourceList("ResourceList", "", (ResourceList)o, true, false);
            }
        }

        public void Write541_ResourceValueList(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ResourceValueList", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write291_ResourceValueList("ResourceValueList", "", (ResourceValueList)o, true, false);
            }
        }

        public void Write542_GreenerHomes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("GreenerHomes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write232_GreenerHomes("GreenerHomes", "", (GreenerHomes)o, true, false);
            }
        }

        public void Write543_EnergyUpgrades(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("EnergyUpgrades", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write233_EnergyUpgrades("EnergyUpgrades", "", (EnergyUpgrades)o, true, false);
            }
        }

        public void Write544_Setting(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Setting", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write230_Setting("Setting", "", (Setting)o, true, false);
            }
        }

        public void Write545_Settings(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Settings", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write231_Settings("Settings", "", (Settings)o, true, false);
            }
        }

        public void Write546_BaseComponent(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("BaseComponent", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write196_BaseComponent("BaseComponent", "", (BaseComponent)o, true, false);
            }
        }

        public void Write547_Component(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Component", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write181_Component("Component", "", (Component)o, true, false);
            }
        }

        public void Write548_Construction(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Construction", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write54_Construction("Construction", "", (Construction)o, true, false);
            }
        }

        public void Write549_EnergyStarEquipmentInformation(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("EnergyStarEquipmentInformation", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write65_EnergyStarEquipmentInformation("EnergyStarEquipmentInformation", "", (EnergyStarEquipmentInformation)o, true, false);
            }
        }

        private void Write55_FloorConstruction(string n, string ns, FloorConstruction o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FloorConstruction)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FloorConstruction", "");
                }
                this.Write7_CodeReference("Type", "", o.Type, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write550_EquipmentInformation(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("EquipmentInformation", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write66_EquipmentInformation("EquipmentInformation", "", (EquipmentInformation)o, true, false);
            }
        }

        public void Write551_Array(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Array", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write131_Array("Array", "", ( Array)o, true, false);
            }
        }

        public void Write552_Efficiency(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Efficiency", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write132_Efficiency("Efficiency", "", (Efficiency)o, true, false);
            }
        }

        public void Write553_Generation(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Generation", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write135_Generation("Generation", "", (Generation)o, true, false);
            }
        }

        public void Write554_Module(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Module", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write133_Module("Module", "", (Module)o, true, false);
            }
        }

        public void Write555_Photovoltaic(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Photovoltaic", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write134_Photovoltaic("Photovoltaic", "", (Photovoltaic)o, true, false);
            }
        }

        public void Write556_Floor(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Floor", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write57_Floor("Floor", "", (Floor)o, true, false);
            }
        }

        public void Write557_FloorConstruction(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FloorConstruction", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write55_FloorConstruction("FloorConstruction", "", (FloorConstruction)o, true, false);
            }
        }

        public void Write558_FloorMeasurements(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FloorMeasurements", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write56_FloorMeasurements("FloorMeasurements", "", (FloorMeasurements)o, true, false);
            }
        }

        public void Write559_EnergyStar(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("EnergyStar", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write179_EnergyStar("EnergyStar", "", (EnergyStar)o, true, false);
            }
        }

        private void Write56_FloorMeasurements(string n, string ns, FloorMeasurements o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FloorMeasurements)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FloorMeasurements", "");
                }
                base.WriteAttribute("area", "", XmlConvert.ToString(o.Area));
                base.WriteAttribute("length", "", XmlConvert.ToString(o.Length));
                base.WriteEndElement(o);
            }
        }

        public void Write560_Window(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Window", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write180_Window("Window", "", (Window)o, true, false);
            }
        }

        public void Write561_WindowMeasurements(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WindowMeasurements", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write177_WindowMeasurements("WindowMeasurements", "", (WindowMeasurements)o, true, false);
            }
        }

        public void Write562_WindowConstruction(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WindowConstruction", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write53_WindowConstruction("WindowConstruction", "", (WindowConstruction)o, true, false);
            }
        }

        public void Write563_WindowShading(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WindowShading", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write178_WindowShading("WindowShading", "", (WindowShading)o, true, false);
            }
        }

        public void Write564_Wall(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Wall", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write176_Wall("Wall", "", (Wall)o, true, false);
            }
        }

        public void Write565_WallConstruction(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WallConstruction", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write52_WallConstruction("WallConstruction", "", (WallConstruction)o, true, false);
            }
        }

        public void Write566_WallMeasurements(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WallMeasurements", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write175_WallMeasurements("WallMeasurements", "", (WallMeasurements)o, true, false);
            }
        }

        public void Write567_ExhaustLocationOptions(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ExhaustLocationOptions", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write392_ExhaustLocationOptions("ExhaustLocationOptions", "", (ExhaustLocationOptions)o, true, false);
            }
        }

        public void Write568_HrvDucts(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HrvDucts", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write172_HrvDucts("HrvDucts", "", (HrvDucts)o, true, false);
            }
        }

        public void Write569_HrvDuctSpec(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HrvDuctSpec", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write171_HrvDuctSpec("HrvDuctSpec", "", (HrvDuctSpec)o, true, false);
            }
        }

        private void Write57_Floor(string n, string ns, Floor o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Floor)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Floor", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                base.WriteAttribute("adjacentEnclosedSpace", "", XmlConvert.ToString(o.AdjacentEnclosedSpace));
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write55_FloorConstruction("Construction", "", o.Construction, false, false);
                this.Write56_FloorMeasurements("Measurements", "", o.Measurements, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write570_Requirements(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Requirements", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write167_Requirements("Requirements", "", (Requirements)o, true, false);
            }
        }

        public void Write571_Rooms(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Rooms", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write166_Rooms("Rooms", "", (Rooms)o, true, false);
            }
        }

        public void Write572_VentilatorObjects(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("VentilatorObjects", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write170_VentilatorObjects("VentilatorObjects", "", (VentilatorObjects)o, true, false);
            }
        }

        public void Write573_WholeHouseParamaters(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WholeHouseParamaters", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write168_WholeHouseParamaters("WholeHouseParamaters", "", (WholeHouseParamaters)o, true, false);
            }
        }

        public void Write574_Dryer(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Dryer", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write169_Dryer("Dryer", "", (Dryer)o, true, false);
            }
        }

        public void Write575_Hrv(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Hrv", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write173_Hrv("Hrv", "", (Hrv)o, true, false);
            }
        }

        public void Write576_Ventilation(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Ventilation", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write174_Ventilation("Ventilation", "", (Ventilation)o, true, false);
            }
        }

        public void Write577_RoomConstruction(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("RoomConstruction", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write158_RoomConstruction("RoomConstruction", "", (RoomConstruction)o, true, false);
            }
        }

        public void Write578_Room(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Room", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write160_Room("Room", "", (Room)o, true, false);
            }
        }

        public void Write579_RoomMeasurements(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("RoomMeasurements", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write159_RoomMeasurements("RoomMeasurements", "", (RoomMeasurements)o, true, false);
            }
        }

        private void Write58_FloorHeaderMeasurements(string n, string ns, FloorHeaderMeasurements o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FloorHeaderMeasurements)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FloorHeaderMeasurements", "");
                }
                base.WriteAttribute("height", "", XmlConvert.ToString(o.Height));
                base.WriteAttribute("perimeter", "", XmlConvert.ToString(o.Perimeter));
                base.WriteEndElement(o);
            }
        }

        public void Write580_Consummable(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Consummable", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write244_Consummable("Consummable", "", (Consummable)o, true, false);
            }
        }

        public void Write581_ActualFuelCosts(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ActualFuelCosts", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write257_ActualFuelCosts("ActualFuelCosts", "", (ActualFuelCosts)o, true, false);
            }
        }

        public void Write582_Oil(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Oil", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write246_Oil("Oil", "", (Oil)o, true, false);
            }
        }

        public void Write583_PropaneAppliance(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("PropaneAppliance", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write243_PropaneAppliance("PropaneAppliance", "", (PropaneAppliance)o, true, false);
            }
        }

        public void Write584_MonthlyAirChangeRate(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("MonthlyAirChangeRate", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write269_MonthlyAirChangeRate("MonthlyAirChangeRate", "", (MonthlyAirChangeRate)o, true, false);
            }
        }

        public void Write585_ResultsType(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteEmptyTag("ResultsType", "");
            }
            else
            {
                this.Write393_ResultsType("ResultsType", "", (ResultsType)o, false);
            }
        }

        public void Write586_AirChangeRate(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("AirChangeRate", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write255_AirChangeRate("AirChangeRate", "", (AirChangeRate)o, true, false);
            }
        }

        public void Write587_AnnualConsumption(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("AnnualConsumption", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write250_AnnualConsumption("AnnualConsumption", "", (AnnualConsumption)o, true, false);
            }
        }

        public void Write588_AnnualHeatLoss(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("AnnualHeatLoss", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write254_AnnualHeatLoss("AnnualHeatLoss", "", (AnnualHeatLoss)o, true, false);
            }
        }

        public void Write589_AnnualResults(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("AnnualResults", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write258_AnnualResults("AnnualResults", "", (AnnualResults)o, true, false);
            }
        }

        private void Write59_FloorHeader(string n, string ns, FloorHeader o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FloorHeader)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FloorHeader", "");
                }
                base.WriteAttribute("id", "", XmlConvert.ToString(o.Id));
                base.WriteAttribute("adjacentEnclosedSpace", "", XmlConvert.ToString(o.AdjacentEnclosedSpace));
                List<BaseComponent> components = o.Components;
                if (components != null)
                {
                    base.WriteStartElement("Components", "", null, false);
                    int num = 0;
                    while (true)
                    {
                        if (num >= components.Count)
                        {
                            base.WriteEndElement();
                            break;
                        }
                        BaseComponent component = components[num];
                        if (component != null)
                        {
                            if (component is Slab)
                            {
                                this.Write119_Slab("Slab", "", (Slab)component, true, false);
                            }
                            else if (component is Walkout)
                            {
                                this.Write128_Walkout("Walkout", "", (Walkout)component, true, false);
                            }
                            else if (component is Basement)
                            {
                                this.Write130_Basement("Basement", "", (Basement)component, true, false);
                            }
                            else if (component is Crawlspace)
                            {
                                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)component, true, false);
                            }
                            else if (component is Door)
                            {
                                this.Write50_Door("Door", "", (Door)component, true, false);
                            }
                            else if (component is HeatingCooling)
                            {
                                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)component, true, false);
                            }
                            else if (component is Ventilation)
                            {
                                this.Write174_Ventilation("Ventilation", "", (Ventilation)component, true, false);
                            }
                            else if (component is Ceiling)
                            {
                                this.Write47_Ceiling("Ceiling", "", (Ceiling)component, true, false);
                            }
                            else if (component is HotWater)
                            {
                                this.Write141_HotWater("HotWater", "", (HotWater)component, true, false);
                            }
                            else if (component is NaturalAirInfiltration)
                            {
                                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)component, true, false);
                            }
                            else if (component is Foundation)
                            {
                                this.Write129_Foundation("Foundation", "", (Foundation)component, true, false);
                            }
                            else if (component is BaseLoads)
                            {
                                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)component, true, false);
                            }
                            else if (component is Temperatures)
                            {
                                this.Write165_Temperatures("Temperatures", "", (Temperatures)component, true, false);
                            }
                            else if (component is Room)
                            {
                                this.Write160_Room("Room", "", (Room)component, true, false);
                            }
                            else if (component is Window)
                            {
                                this.Write180_Window("Window", "", (Window)component, true, false);
                            }
                            else if (component is FloorHeader)
                            {
                                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)component, true, false);
                            }
                            else if (component is Floor)
                            {
                                this.Write57_Floor("Floor", "", (Floor)component, true, false);
                            }
                            else if (component is Wall)
                            {
                                this.Write176_Wall("Wall", "", (Wall)component, true, false);
                            }
                            else if (component is Generation)
                            {
                                this.Write135_Generation("Generation", "", (Generation)component, true, false);
                            }
                            else if (component != null)
                            {
                                throw base.CreateUnknownTypeException(component);
                            }
                        }
                        num++;
                    }
                }
                base.WriteElementString("Label", "", o.Label);
                this.Write51_FloorHeaderConstruction("Construction", "", o.Construction, false, false);
                this.Write58_FloorHeaderMeasurements("Measurements", "", o.Measurements, false, false);
                this.Write18_CodeAndText("FacingDirection", "", o.FacingDirectionXml, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write590_BasementHeatLoss(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("BasementHeatLoss", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write264_BasementHeatLoss("BasementHeatLoss", "", (BasementHeatLoss)o, true, false);
            }
        }

        public void Write591_BasementLoadMonthly(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("BasementLoadMonthly", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write262_BasementLoadMonthly("BasementLoadMonthly", "", (BasementLoadMonthly)o, true, false);
            }
        }

        public void Write592_Wood(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Wood", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write247_Wood("Wood", "", (Wood)o, true, false);
            }
        }

        public void Write593_BasementFactors(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("BasementFactors", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write267_BasementFactors("BasementFactors", "", (BasementFactors)o, true, false);
            }
        }

        public void Write594_GrossAreaCrawlspace(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("GrossAreaCrawlspace", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write277_GrossAreaCrawlspace("GrossAreaCrawlspace", "", (GrossAreaCrawlspace)o, true, false);
            }
        }

        public void Write595_GrossAreaBasement(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("GrossAreaBasement", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write276_GrossAreaBasement("GrossAreaBasement", "", (GrossAreaBasement)o, true, false);
            }
        }

        public void Write596_DoorAndWindows(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DoorAndWindows", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write253_DoorAndWindows("DoorAndWindows", "", (DoorAndWindows)o, true, false);
            }
        }

        public void Write597_ElectricalAnnual(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ElectricalAnnual", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write242_ElectricalAnnual("ElectricalAnnual", "", (ElectricalAnnual)o, true, false);
            }
        }

        public void Write598_ElectricalMonthly(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ElectricalMonthly", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write259_ElectricalMonthly("ElectricalMonthly", "", (ElectricalMonthly)o, true, false);
            }
        }

        public void Write599_Factors(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Factors", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write268_Factors("Factors", "", (Factors)o, true, false);
            }
        }

        private void Write6_Cardinal(string n, string ns, Cardinal o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Cardinal)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Cardinal", "");
                }
                base.WriteAttribute("south", "", XmlConvert.ToString(o.South));
                base.WriteAttribute("southEast", "", XmlConvert.ToString(o.SouthEast));
                base.WriteAttribute("east", "", XmlConvert.ToString(o.East));
                base.WriteAttribute("northEast", "", XmlConvert.ToString(o.NorthEast));
                base.WriteAttribute("north", "", XmlConvert.ToString(o.North));
                base.WriteAttribute("northWest", "", XmlConvert.ToString(o.NorthWest));
                base.WriteAttribute("west", "", XmlConvert.ToString(o.West));
                base.WriteAttribute("southWest", "", XmlConvert.ToString(o.SouthWest));
                base.WriteEndElement(o);
            }
        }

        private void Write60_CoolingSeason(string n, string ns, CoolingSeason o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CoolingSeason)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CoolingSeason", "");
                }
                this.Write18_CodeAndText("Start", "", o.StartXml, false, false);
                this.Write18_CodeAndText("End", "", o.EndXml, false, false);
                this.Write18_CodeAndText("Design", "", o.DesignXml, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write600_FanConsumption(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FanConsumption", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write272_FanConsumption("FanConsumption", "", (FanConsumption)o, true, false);
            }
        }

        public void Write601_FanEnergyConsumption(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FanEnergyConsumption", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write273_FanEnergyConsumption("FanEnergyConsumption", "", (FanEnergyConsumption)o, true, false);
            }
        }

        public void Write602_Gains(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Gains", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write260_Gains("Gains", "", (Gains)o, true, false);
            }
        }

        public void Write603_GrossArea(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("GrossArea", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write280_GrossArea("GrossArea", "", (GrossArea)o, true, false);
            }
        }

        public void Write604_GrossAreaComponent(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("GrossAreaComponent", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write274_GrossAreaComponent("GrossAreaComponent", "", (GrossAreaComponent)o, true, false);
            }
        }

        public void Write605_GrossAreaFloor(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("GrossAreaFloor", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write278_GrossAreaFloor("GrossAreaFloor", "", (GrossAreaFloor)o, true, false);
            }
        }

        public void Write606_GrossAreaMainFloors(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("GrossAreaMainFloors", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write279_GrossAreaMainFloors("GrossAreaMainFloors", "", (GrossAreaMainFloors)o, true, false);
            }
        }

        public void Write607_GrossAreaWindows(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("GrossAreaWindows", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write275_GrossAreaWindows("GrossAreaWindows", "", (GrossAreaWindows)o, true, false);
            }
        }

        public void Write608_HotWaterDemand(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HotWaterDemand", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write251_HotWaterDemand("HotWaterDemand", "", (HotWaterDemand)o, true, false);
            }
        }

        public void Write609_HotWaterElectrical(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HotWaterElectrical", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write241_HotWaterElectrical("HotWaterElectrical", "", (HotWaterElectrical)o, true, false);
            }
        }

        private void Write61_FansAndPumpPowerHeating(string n, string ns, FansAndPumpPowerHeating o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FansAndPumpPowerHeating)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FansAndPumpPowerHeating", "");
                }
                base.WriteAttribute("isCalculated", "", XmlConvert.ToString(o.IsCalculated));
                base.WriteAttribute("low", "", XmlConvert.ToString(o.Low));
                base.WriteAttribute("high", "", XmlConvert.ToString(o.High));
                base.WriteEndElement(o);
            }
        }

        public void Write610_LoadAnnual(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("LoadAnnual", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write252_LoadAnnual("LoadAnnual", "", (LoadAnnual)o, true, false);
            }
        }

        public void Write611_LoadMonthly(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("LoadMonthly", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write263_LoadMonthly("LoadMonthly", "", (LoadMonthly)o, true, false);
            }
        }

        public void Write612_MainFloorsFactors(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("MainFloorsFactors", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write266_MainFloorsFactors("MainFloorsFactors", "", (MainFloorsFactors)o, true, false);
            }
        }

        public void Write613_MonthlyHeatLoss(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("MonthlyHeatLoss", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write265_MonthlyHeatLoss("MonthlyHeatLoss", "", (MonthlyHeatLoss)o, true, false);
            }
        }

        public void Write614_NaturalGasAppliance(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("NaturalGasAppliance", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write245_NaturalGasAppliance("NaturalGasAppliance", "", (NaturalGasAppliance)o, true, false);
            }
        }

        public void Write615_OtherResults(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("OtherResults", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write281_OtherResults("OtherResults", "", (OtherResults)o, true, false);
            }
        }

        public void Write616_MonthlyResults(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("MonthlyResults", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write270_MonthlyResults("MonthlyResults", "", (MonthlyResults)o, true, false);
            }
        }

        public void Write617_PrimarySecondaryEnergy(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("PrimarySecondaryEnergy", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write248_PrimarySecondaryEnergy("PrimarySecondaryEnergy", "", (PrimarySecondaryEnergy)o, true, false);
            }
        }

        public void Write618_PropaneConsummable(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("PropaneConsummable", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write394_PropaneConsummable("PropaneConsummable", "", (PropaneConsummable)o, true, false);
            }
        }

        public void Write619_Results(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Results", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write282_Results("Results", "", (Results)o, true, false);
            }
        }

        private void Write62_FansAndPumpsHeating(string n, string ns, FansAndPumpsHeating o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FansAndPumpsHeating)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FansAndPumpsHeating", "");
                }
                base.WriteAttribute("hasEnergyEfficientMotor", "", XmlConvert.ToString(o.HasEnergyEfficientMotor));
                this.Write61_FansAndPumpPowerHeating("Power", "", o.Power, false, false);
                this.Write18_CodeAndText("Mode", "", o.ModeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write620_SupplementalHeating(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SupplementalHeating", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write249_SupplementalHeating("SupplementalHeating", "", (SupplementalHeating)o, true, false);
            }
        }

        public void Write621_TemperaturesMonthly(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("TemperaturesMonthly", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write261_TemperaturesMonthly("TemperaturesMonthly", "", (TemperaturesMonthly)o, true, false);
            }
        }

        public void Write622_VentilationResults(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("VentilationResults", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write271_VentilationResults("VentilationResults", "", (VentilationResults)o, true, false);
            }
        }

        public void Write623_BlowerTest(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("BlowerTest", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write143_BlowerTest("BlowerTest", "", (BlowerTest)o, true, false);
            }
        }

        public void Write624_BuildingSite(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("BuildingSite", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write144_BuildingSite("BuildingSite", "", (BuildingSite)o, true, false);
            }
        }

        public void Write625_ExhaustDevicesTest(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ExhaustDevicesTest", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write146_ExhaustDevicesTest("ExhaustDevicesTest", "", (ExhaustDevicesTest)o, true, false);
            }
        }

        public void Write626_LocalShielding(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("LocalShielding", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write145_LocalShielding("LocalShielding", "", (LocalShielding)o, true, false);
            }
        }

        public void Write627_NaturalAirSpecifications(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("NaturalAirSpecifications", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write148_NaturalAirSpecifications("NaturalAirSpecifications", "", (NaturalAirSpecifications)o, true, false);
            }
        }

        public void Write628_SpecificationsHouse(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SpecificationsHouse", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write142_SpecificationsHouse("SpecificationsHouse", "", (SpecificationsHouse)o, true, false);
            }
        }

        public void Write629_WeatherStation(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WeatherStation", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write149_WeatherStation("WeatherStation", "", (WeatherStation)o, true, false);
            }
        }

        private void Write63_Type1EquipmentInformation(string n, string ns, Type1EquipmentInformation o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Type1EquipmentInformation)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Type1EquipmentInformation", "");
                }
                base.WriteAttribute("energystar", "", XmlConvert.ToString(o.EnergyStar));
                base.WriteAttribute("AHRI", "", XmlConvert.ToString(o.AHRI));
                base.WriteAttribute("epaCsa", "", XmlConvert.ToString(o.EpaCsa));
                base.WriteElementString("Manufacturer", "", o.Manufacturer);
                base.WriteElementString("Model", "", o.Model);
                base.WriteElementString("Description", "", o.Description);
                base.WriteEndElement(o);
            }
        }

        public void Write630_LeakageFractions(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("LeakageFractions", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write150_LeakageFractions("LeakageFractions", "", (LeakageFractions)o, true, false);
            }
        }

        public void Write631_NaturalAirInfiltration(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("NaturalAirInfiltration", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write157_NaturalAirInfiltration("NaturalAirInfiltration", "", (NaturalAirInfiltration)o, true, false);
            }
        }

        public void Write632_OtherFactors(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("OtherFactors", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write151_OtherFactors("OtherFactors", "", (OtherFactors)o, true, false);
            }
        }

        public void Write633_CommonSurfaceArea(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CommonSurfaceArea", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write147_CommonSurfaceArea("CommonSurfaceArea", "", (CommonSurfaceArea)o, true, false);
            }
        }

        public void Write634_AirLeakageTestData(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("AirLeakageTestData", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write156_AirLeakageTestData("AirLeakageTestData", "", (AirLeakageTestData)o, true, false);
            }
        }

        public void Write635_DataPoint(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DataPoint", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write154_DataPoint("DataPoint", "", (DataPoint)o, true, false);
            }
        }

        public void Write636_Pressure(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Pressure", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write153_Pressure("Pressure", "", (Pressure)o, true, false);
            }
        }

        public void Write637_PressureData(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("PressureData", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write152_PressureData("PressureData", "", (PressureData)o, true, false);
            }
        }

        public void Write638_Test(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Test", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write155_Test("Test", "", (Test)o, true, false);
            }
        }

        public void Write639_File(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("File", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write35_File("File", "", (File)o, true, false);
            }
        }

        private void Write64_HeatPumpEquipmentInformation(string n, string ns, HeatPumpEquipmentInformation o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HeatPumpEquipmentInformation)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HeatPumpEquipmentInformation", "");
                }
                base.WriteAttribute("energystar", "", XmlConvert.ToString(o.EnergyStar));
                base.WriteAttribute("AHRI", "", XmlConvert.ToString(o.AHRI));
                base.WriteAttribute("canCsaC448", "", XmlConvert.ToString(o.CanCsaC448));
                base.WriteElementString("Manufacturer", "", o.Manufacturer);
                base.WriteElementString("Model", "", o.Model);
                base.WriteElementString("Description", "", o.Description);
                base.WriteEndElement(o);
            }
        }

        public void Write640_House(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("House", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write205_House("House", "", (House)o, true, false);
            }
        }

        public void Write641_MainFloors(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("MainFloors", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write161_MainFloors("MainFloors", "", (MainFloors)o, true, false);
            }
        }

        public void Write642_AttachmentFoundation(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("AttachmentFoundation", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write203_AttachmentFoundation("AttachmentFoundation", "", (AttachmentFoundation)o, true, false);
            }
        }

        public void Write643_Address(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Address", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write38_Address("Address", "", (Address)o, true, false);
            }
        }

        public void Write644_Attachment(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Attachment", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write204_Attachment("Attachment", "", (Attachment)o, true, false);
            }
        }

        public void Write645_VentilationBasement(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("VentilationBasement", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write162_VentilationBasement("VentilationBasement", "", (VentilationBasement)o, true, false);
            }
        }

        public void Write646_Client(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Client", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write39_Client("Client", "", (Client)o, true, false);
            }
        }

        public void Write647_CorrectedInsulation(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CorrectedInsulation", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write42_CorrectedInsulation("CorrectedInsulation", "", (CorrectedInsulation)o, true, false);
            }
        }

        public void Write648_TemperatureCrawlspace(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("TemperatureCrawlspace", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write164_TemperatureCrawlspace("TemperatureCrawlspace", "", (TemperatureCrawlspace)o, true, false);
            }
        }

        public void Write649_Equipment(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Equipment", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write163_Equipment("Equipment", "", (Equipment)o, true, false);
            }
        }

        private void Write65_EnergyStarEquipmentInformation(string n, string ns, EnergyStarEquipmentInformation o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(EnergyStarEquipmentInformation))
                    {
                        if (type == typeof(HeatPumpEquipmentInformation))
                        {
                            this.Write64_HeatPumpEquipmentInformation(n, ns, (HeatPumpEquipmentInformation)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(Type1EquipmentInformation)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write63_Type1EquipmentInformation(n, ns, (Type1EquipmentInformation)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("EnergyStarEquipmentInformation", "");
                }
                base.WriteAttribute("energystar", "", XmlConvert.ToString(o.EnergyStar));
                base.WriteAttribute("AHRI", "", XmlConvert.ToString(o.AHRI));
                base.WriteElementString("Manufacturer", "", o.Manufacturer);
                base.WriteElementString("Model", "", o.Model);
                base.WriteElementString("Description", "", o.Description);
                base.WriteEndElement(o);
            }
        }

        public void Write650_ProgramInformation(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ProgramInformation", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write44_ProgramInformation("ProgramInformation", "", (ProgramInformation)o, true, false);
            }
        }

        public void Write651_Justifications(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Justifications", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write43_Justifications("Justifications", "", (Justifications)o, true, false);
            }
        }

        public void Write652_MailingAddress(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("MailingAddress", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write37_MailingAddress("MailingAddress", "", (MailingAddress)o, true, false);
            }
        }

        public void Write653_Name(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Name", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write36_Name("Name", "", (Name)o, true, false);
            }
        }

        public void Write654_Temperatures(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Temperatures", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write165_Temperatures("Temperatures", "", (Temperatures)o, true, false);
            }
        }

        public void Write655_Weather(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Weather", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write34_Weather("Weather", "", (Weather)o, true, false);
            }
        }

        public void Write656_GableEnds(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("GableEnds", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write197_GableEnds("GableEnds", "", (GableEnds)o, true, false);
            }
        }

        public void Write657_HeatedFloorArea(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HeatedFloorArea", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write201_HeatedFloorArea("HeatedFloorArea", "", (HeatedFloorArea)o, true, false);
            }
        }

        public void Write658_NumberOf(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("NumberOf", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write200_NumberOf("NumberOf", "", (NumberOf)o, true, false);
            }
        }

        public void Write659_SlopedRoof(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SlopedRoof", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write198_SlopedRoof("SlopedRoof", "", (SlopedRoof)o, true, false);
            }
        }

        private void Write66_EquipmentInformation(string n, string ns, EquipmentInformation o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(EquipmentInformation))
                    {
                        if (type == typeof(SupplementaryHeatEquipmentInformation))
                        {
                            this.Write103_Item(n, ns, (SupplementaryHeatEquipmentInformation)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(BaseboardsEquipmentInformation))
                        {
                            this.Write67_BaseboardsEquipmentInformation(n, ns, (BaseboardsEquipmentInformation)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(EnergyStarEquipmentInformation))
                        {
                            this.Write65_EnergyStarEquipmentInformation(n, ns, (EnergyStarEquipmentInformation)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(HeatPumpEquipmentInformation))
                        {
                            this.Write64_HeatPumpEquipmentInformation(n, ns, (HeatPumpEquipmentInformation)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(Type1EquipmentInformation)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write63_Type1EquipmentInformation(n, ns, (Type1EquipmentInformation)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("EquipmentInformation", "");
                }
                base.WriteElementString("Manufacturer", "", o.Manufacturer);
                base.WriteElementString("Model", "", o.Model);
                base.WriteElementString("Description", "", o.Description);
                base.WriteEndElement(o);
            }
        }

        public void Write660_HouseSpecifications(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HouseSpecifications", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write202_Specifications("HouseSpecifications", "", (Specifications)o, true, false);
            }
        }

        public void Write661_RoofCavity(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("RoofCavity", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write199_RoofCavity("RoofCavity", "", (RoofCavity)o, true, false);
            }
        }

        public void Write662_DrainWaterHeatRecovery(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DrainWaterHeatRecovery", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write137_DrainWaterHeatRecovery("DrainWaterHeatRecovery", "", (DrainWaterHeatRecovery)o, true, false);
            }
        }

        public void Write663_HotWaterComponent(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HotWaterComponent", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write138_HotWaterComponent("HotWaterComponent", "", (HotWaterComponent)o, true, false);
            }
        }

        public void Write664_NumberOfDwhrSystems(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("NumberOfDwhrSystems", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write139_NumberOfDwhrSystems("NumberOfDwhrSystems", "", (NumberOfDwhrSystems)o, true, false);
            }
        }

        public void Write665_NumberOfHotWaterSystems(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("NumberOfHotWaterSystems", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write140_NumberOfHotWaterSystems("NumberOfHotWaterSystems", "", (NumberOfHotWaterSystems)o, true, false);
            }
        }

        public void Write666_EnergyFactor(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("EnergyFactor", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write22_EnergyFactor("EnergyFactor", "", (EnergyFactor)o, true, false);
            }
        }

        public void Write667_Solar(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Solar", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write136_Solar("Solar", "", (Solar)o, true, false);
            }
        }

        public void Write668_HotWater(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HotWater", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write141_HotWater("HotWater", "", (HotWater)o, true, false);
            }
        }

        public void Write669_CoolingSeason(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CoolingSeason", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write60_CoolingSeason("CoolingSeason", "", (CoolingSeason)o, true, false);
            }
        }

        private void Write67_BaseboardsEquipmentInformation(string n, string ns, BaseboardsEquipmentInformation o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(BaseboardsEquipmentInformation)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("BaseboardsEquipmentInformation", "");
                }
                base.WriteAttribute("numberOfElectronicThermostats", "", XmlConvert.ToString(o.NumberOfElectronicThermostats));
                base.WriteElementString("Manufacturer", "", o.Manufacturer);
                base.WriteElementString("Model", "", o.Model);
                base.WriteElementString("Description", "", o.Description);
                base.WriteEndElement(o);
            }
        }

        public void Write670_MultipleSystemsEquipment(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("MultipleSystemsEquipment", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write98_MultipleSystemsEquipment("MultipleSystemsEquipment", "", (MultipleSystemsEquipment)o, true, false);
            }
        }

        public void Write671_MultipleSystems(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("MultipleSystems", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write100_MultipleSystems("MultipleSystems", "", (MultipleSystems)o, true, false);
            }
        }

        public void Write672_MultipleSystemsSummary(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("MultipleSystemsSummary", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write99_MultipleSystemsSummary("MultipleSystemsSummary", "", (MultipleSystemsSummary)o, true, false);
            }
        }

        public void Write673_RadiantHeating(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("RadiantHeating", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write102_RadiantHeating("RadiantHeating", "", (RadiantHeating)o, true, false);
            }
        }

        public void Write674_RadiantHeatingComponent(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("RadiantHeatingComponent", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write101_RadiantHeatingComponent("RadiantHeatingComponent", "", (RadiantHeatingComponent)o, true, false);
            }
        }

        public void Write675_AdditionalOpening(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("AdditionalOpening", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write17_AdditionalOpening("AdditionalOpening", "", (AdditionalOpening)o, true, false);
            }
        }

        public void Write676_HeatingCooling(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HeatingCooling", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write108_HeatingCooling("HeatingCooling", "", (HeatingCooling)o, true, false);
            }
        }

        public void Write677_AirConditioningEquipment(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("AirConditioningEquipment", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write87_AirConditioningEquipment("AirConditioningEquipment", "", (AirConditioningEquipment)o, true, false);
            }
        }

        public void Write678_ColdClimateHeatPump(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ColdClimateHeatPump", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write93_ColdClimateHeatPump("ColdClimateHeatPump", "", (ColdClimateHeatPump)o, true, false);
            }
        }

        public void Write679_CoolingFansAndPumps(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CoolingFansAndPumps", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write15_CoolingFansAndPumps("CoolingFansAndPumps", "", (CoolingFansAndPumps)o, true, false);
            }
        }

        private void Write68_BaseboardsSpecifications(string n, string ns, BaseboardsSpecifications o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(BaseboardsSpecifications)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("BaseboardsSpecifications", "");
                }
                base.WriteAttribute("sizingFactor", "", XmlConvert.ToString(o.SizingFactor));
                base.WriteAttribute("efficiency", "", XmlConvert.ToString(o.Efficiency));
                this.Write21_OutputCapacity("OutputCapacity", "", o.OutputCapacity, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write680_HeatPumpEquipment(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HeatPumpEquipment", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write89_HeatPumpEquipment("HeatPumpEquipment", "", (HeatPumpEquipment)o, true, false);
            }
        }

        public void Write681_HeatPumpTemperature(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HeatPumpTemperature", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write91_HeatPumpTemperature("HeatPumpTemperature", "", (HeatPumpTemperature)o, true, false);
            }
        }

        public void Write682_SourceTemperature(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SourceTemperature", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write92_SourceTemperature("SourceTemperature", "", (SourceTemperature)o, true, false);
            }
        }

        public void Write683_Type2Equipment(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Type2Equipment", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write88_Type2Equipment("Type2Equipment", "", (Type2Equipment)o, true, false);
            }
        }

        public void Write684_AirConditioning(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("AirConditioning", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write96_AirConditioning("AirConditioning", "", (AirConditioning)o, true, false);
            }
        }

        public void Write685_AirConditioningSpecifications(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("AirConditioningSpecifications", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write95_AirConditioningSpecifications("AirConditioningSpecifications", "", (AirConditioningSpecifications)o, true, false);
            }
        }

        public void Write686_HeatPumpCoolingType(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HeatPumpCoolingType", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write16_HeatPumpCoolingType("HeatPumpCoolingType", "", (HeatPumpCoolingType)o, true, false);
            }
        }

        public void Write687_FansAndPumpPowerCooling(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FansAndPumpPowerCooling", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write14_FansAndPumpPowerCooling("FansAndPumpPowerCooling", "", (FansAndPumpPowerCooling)o, true, false);
            }
        }

        public void Write688_HeatPump(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HeatPump", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write94_HeatPump("HeatPump", "", (HeatPump)o, true, false);
            }
        }

        public void Write689_HeatPumpEquipmentInformation(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HeatPumpEquipmentInformation", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write64_HeatPumpEquipmentInformation("HeatPumpEquipmentInformation", "", (HeatPumpEquipmentInformation)o, true, false);
            }
        }

        private void Write69_Baseboards(string n, string ns, Baseboards o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Baseboards)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Baseboards", "");
                }
                this.Write67_BaseboardsEquipmentInformation("EquipmentInformation", "", o.EquipmentInformation, false, false);
                this.Write68_BaseboardsSpecifications("Specifications", "", o.Specifications, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write690_HeatPumpSpecifications(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("HeatPumpSpecifications", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write90_HeatPumpSpecifications("HeatPumpSpecifications", "", (HeatPumpSpecifications)o, true, false);
            }
        }

        public void Write691_Type2(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Type2", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write97_Type2("Type2", "", (ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2.Type2)o, true, false);
            }
        }

        public void Write692_WindowUnits(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WindowUnits", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write86_WindowUnits("WindowUnits", "", (WindowUnits)o, true, false);
            }
        }

        public void Write693_Boiler(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Boiler", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write81_Boiler("Boiler", "", (Boiler)o, true, false);
            }
        }

        public void Write694_BoilerEquipment(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("BoilerEquipment", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write80_BoilerEquipment("BoilerEquipment", "", (BoilerEquipment)o, true, false);
            }
        }

        public void Write695_ComboHeatDhw(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ComboHeatDhw", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write78_ComboHeatDhw("ComboHeatDhw", "", (ComboHeatDhw)o, true, false);
            }
        }

        public void Write696_ComboHeatDhwEquipment(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ComboHeatDhwEquipment", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write77_ComboHeatDhwEquipment("ComboHeatDhwEquipment", "", (ComboHeatDhwEquipment)o, true, false);
            }
        }

        public void Write697_ComboTankAndPump(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ComboTankAndPump", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write73_ComboTankAndPump("ComboTankAndPump", "", (ComboTankAndPump)o, true, false);
            }
        }

        public void Write698_CommonEquipment(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CommonEquipment", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write74_CommonEquipment("CommonEquipment", "", (CommonEquipment)o, true, false);
            }
        }

        public void Write699_FansAndPumpsHeating(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FansAndPumpsHeating", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write62_FansAndPumpsHeating("FansAndPumpsHeating", "", (FansAndPumpsHeating)o, true, false);
            }
        }

        private void Write7_CodeReference(string n, string ns, CodeReference o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CodeReference)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CodeReference", "");
                }
                base.WriteAttribute("idref", "", o.IdRef);
                base.WriteAttribute("rValue", "", XmlConvert.ToString(o.RValue));
                base.WriteAttribute("nominalInsulation", "", XmlConvert.ToString(o.NominalInsulation));
                if (n == "Lintels")
                    base.WriteValue(o.Code);
                else
                    base.WriteAttribute("code", "", o.Code);
                string[] textHelper = o.TextHelper;
                if (textHelper != null)
                {
                    for (int i = 0; i < textHelper.Length; i++)
                    {
                        if (textHelper[i] != null)
                        {
                            base.WriteValue(textHelper[i]);
                        }
                    }
                }
                base.WriteEndElement(o);
            }
        }

        private void Write70_CommonSpecifications(string n, string ns, CommonSpecifications o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CommonSpecifications)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CommonSpecifications", "");
                }
                base.WriteAttribute("sizingFactor", "", XmlConvert.ToString(o.SizingFactor));
                base.WriteAttribute("efficiency", "", XmlConvert.ToString(o.Efficiency));
                base.WriteAttribute("isSteadyState", "", XmlConvert.ToString(o.IsSteadyState));
                base.WriteAttribute("pilotLight", "", XmlConvert.ToString(o.PilotLight));
                base.WriteAttribute("flueDiameter", "", XmlConvert.ToString(o.FlueDiameter));
                this.Write21_OutputCapacity("OutputCapacity", "", o.OutputCapacity, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write700_Furnace(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Furnace", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write76_Furnace("Furnace", "", (Furnace)o, true, false);
            }
        }

        public void Write701_FurnaceEquipment(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FurnaceEquipment", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write75_FurnaceEquipment("FurnaceEquipment", "", (FurnaceEquipment)o, true, false);
            }
        }

        public void Write702_TestData(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("TestData", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write83_TestData("TestData", "", (TestData)o, true, false);
            }
        }

        public void Write703_BaseboardsEquipmentInformation(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("BaseboardsEquipmentInformation", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write67_BaseboardsEquipmentInformation("BaseboardsEquipmentInformation", "", (BaseboardsEquipmentInformation)o, true, false);
            }
        }

        public void Write704_Baseboards(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Baseboards", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write69_Baseboards("Baseboards", "", (Baseboards)o, true, false);
            }
        }

        public void Write705_BaseboardsSpecifications(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("BaseboardsSpecifications", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write68_BaseboardsSpecifications("BaseboardsSpecifications", "", (BaseboardsSpecifications)o, true, false);
            }
        }

        public void Write706_CirculationPump(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CirculationPump", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write72_CirculationPump("CirculationPump", "", (CirculationPump)o, true, false);
            }
        }

        public void Write707_ComboEnergyFactor(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ComboEnergyFactor", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write71_ComboEnergyFactor("ComboEnergyFactor", "", (ComboEnergyFactor)o, true, false);
            }
        }

        public void Write708_Common(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Common", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write79_Common("Common", "", (Common)o, true, false);
            }
        }

        public void Write709_CommonSpecifications(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CommonSpecifications", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write70_CommonSpecifications("CommonSpecifications", "", (CommonSpecifications)o, true, false);
            }
        }

        private void Write71_ComboEnergyFactor(string n, string ns, ComboEnergyFactor o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ComboEnergyFactor)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ComboEnergyFactor", "");
                }
                base.WriteAttribute("useDefaults", "", XmlConvert.ToString(o.UseDefaults));
                base.WriteAttribute("value", "", XmlConvert.ToString(o.Value));
                base.WriteEndElement(o);
            }
        }

        public void Write710_FansAndPumpPowerHeating(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FansAndPumpPowerHeating", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write61_FansAndPumpPowerHeating("FansAndPumpPowerHeating", "", (FansAndPumpPowerHeating)o, true, false);
            }
        }

        public void Write711_P9(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("P9", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write84_P9("P9", "", (P9)o, true, false);
            }
        }

        public void Write712_P9LoadPerformance(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("P9LoadPerformance", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write82_P9LoadPerformance("P9LoadPerformance", "", (P9LoadPerformance)o, true, false);
            }
        }

        public void Write713_Type1(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Type1", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write85_Type1("Type1", "", (ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.Type1)o, true, false);
            }
        }

        public void Write714_Type1EquipmentInformation(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Type1EquipmentInformation", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write63_Type1EquipmentInformation("Type1EquipmentInformation", "", (Type1EquipmentInformation)o, true, false);
            }
        }

        public void Write715_Flue(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Flue", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write105_Flue("Flue", "", (Flue)o, true, false);
            }
        }

        public void Write716_SupplementaryHeatEquipment(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SupplementaryHeatEquipment", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write104_SupplementaryHeatEquipment("SupplementaryHeatEquipment", "", (SupplementaryHeatEquipment)o, true, false);
            }
        }

        public void Write717_Item(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SupplementaryHeatSpecifications", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write106_Item("SupplementaryHeatSpecifications", "", (SupplementaryHeatSpecifications)o, true, false);
            }
        }

        public void Write718_System(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("System", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write107_SupplementaryHeat("System", "", (ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.SupplementaryHeat.SupplementaryHeat)o, true, false);
            }
        }

        public void Write719_Item(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SupplementaryHeatEquipmentInformation", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write103_Item("SupplementaryHeatEquipmentInformation", "", (SupplementaryHeatEquipmentInformation)o, true, false);
            }
        }

        private void Write72_CirculationPump(string n, string ns, CirculationPump o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(CirculationPump)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CirculationPump", "");
                }
                base.WriteAttribute("isCalculated", "", XmlConvert.ToString(o.IsCalculated));
                base.WriteAttribute("value", "", XmlConvert.ToString(o.Value));
                base.WriteAttribute("hasEnergyEfficientMotor", "", XmlConvert.ToString(o.HasEnergyEfficientMotor));
                base.WriteEndElement(o);
            }
        }

        public void Write720_Basement(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Basement", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write130_Basement("Basement", "", (Basement)o, true, false);
            }
        }

        public void Write721_Crawlspace(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Crawlspace", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write117_Crawlspace("Crawlspace", "", (Crawlspace)o, true, false);
            }
        }

        public void Write722_ExposedSurfaces(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ExposedSurfaces", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write395_ExposedSurfaces("ExposedSurfaces", "", (ExposedSurfaces)o, true, false);
            }
        }

        public void Write723_FoundationFloorConstruction(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FoundationFloorConstruction", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write110_FoundationFloorConstruction("FoundationFloorConstruction", "", (FoundationFloorConstruction)o, true, false);
            }
        }

        public void Write724_Walkout(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Walkout", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write128_Walkout("Walkout", "", (Walkout)o, true, false);
            }
        }

        public void Write725_CrawlspaceWall(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CrawlspaceWall", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write116_CrawlspaceWall("CrawlspaceWall", "", (CrawlspaceWall)o, true, false);
            }
        }

        public void Write726_CrawlspaceWallConstruction(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CrawlspaceWallConstruction", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write113_CrawlspaceWallConstruction("CrawlspaceWallConstruction", "", (CrawlspaceWallConstruction)o, true, false);
            }
        }

        public void Write727_CrawlspaceWallMeasurements(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CrawlspaceWallMeasurements", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write114_CrawlspaceWallMeasurements("CrawlspaceWallMeasurements", "", (CrawlspaceWallMeasurements)o, true, false);
            }
        }

        public void Write728_ExteriorSurfaces(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ExteriorSurfaces", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write125_ExteriorSurfaces("ExteriorSurfaces", "", (ExteriorSurfaces)o, true, false);
            }
        }

        public void Write729_Foundation(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Foundation", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write129_Foundation("Foundation", "", (Foundation)o, true, false);
            }
        }

        private void Write73_ComboTankAndPump(string n, string ns, ComboTankAndPump o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ComboTankAndPump)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ComboTankAndPump", "");
                }
                base.WriteAttribute("waterTemperature", "", XmlConvert.ToString(o.WaterTemperature));
                this.Write71_ComboEnergyFactor("EnergyFactor", "", o.EnergyFactor, false, false);
                this.Write18_CodeAndText("TankLocation", "", o.TankLocation, false, false);
                this.Write72_CirculationPump("CirculationPump", "", o.CirculationPump, false, false);
                this.Write23_CodeTextAndValue("TankCapacity", "", o.TankCapacityXml, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write730_FoundationFloor(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FoundationFloor", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write112_FoundationFloor("FoundationFloor", "", (FoundationFloor)o, true, false);
            }
        }

        public void Write731_FoundationMeasurements(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FoundationMeasurements", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write111_FoundationMeasurements("FoundationMeasurements", "", (FoundationMeasurements)o, true, false);
            }
        }

        public void Write732_FoundationWall(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FoundationWall", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write124_FoundationWall("FoundationWall", "", (FoundationWall)o, true, false);
            }
        }

        public void Write733_FoundationWallConstruction(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FoundationWallConstruction", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write122_FoundationWallConstruction("FoundationWallConstruction", "", (FoundationWallConstruction)o, true, false);
            }
        }

        public void Write734_FoundationWallMeasurements(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FoundationWallMeasurements", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write123_FoundationWallMeasurements("FoundationWallMeasurements", "", (FoundationWallMeasurements)o, true, false);
            }
        }

        public void Write735_Location(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Location", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write126_Location("Location", "", (Location)o, true, false);
            }
        }

        public void Write736_Locations(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Locations", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write127_Locations("Locations", "", (Locations)o, true, false);
            }
        }

        public void Write737_Slab(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Slab", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write119_Slab("Slab", "", (Slab)o, true, false);
            }
        }

        public void Write738_SlabWall(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SlabWall", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write118_SlabWall("SlabWall", "", (SlabWall)o, true, false);
            }
        }

        public void Write739_WalkoutFloor(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WalkoutFloor", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write121_WalkoutFloor("WalkoutFloor", "", (WalkoutFloor)o, true, false);
            }
        }

        private void Write74_CommonEquipment(string n, string ns, CommonEquipment o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(CommonEquipment))
                    {
                        if (type == typeof(BoilerEquipment))
                        {
                            this.Write80_BoilerEquipment(n, ns, (BoilerEquipment)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ComboHeatDhwEquipment))
                        {
                            this.Write77_ComboHeatDhwEquipment(n, ns, (ComboHeatDhwEquipment)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(FurnaceEquipment)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write75_FurnaceEquipment(n, ns, (FurnaceEquipment)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("CommonEquipment", "");
                }
                base.WriteAttribute("isBiEnergy", "", XmlConvert.ToString(o.IsBiEnergy));
                base.WriteAttribute("switchoverTemperature", "", XmlConvert.ToString(o.SwitchoverTemperature));
                this.Write18_CodeAndText("EnergySource", "", o.EnergySourceXml, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write740_WalkoutMeasurements(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WalkoutMeasurements", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write120_WalkoutMeasurements("WalkoutMeasurements", "", (WalkoutMeasurements)o, true, false);
            }
        }

        public void Write741_WallRValues(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WallRValues", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write115_WallRValues("WallRValues", "", (WallRValues)o, true, false);
            }
        }

        public void Write742_Configuration(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Configuration", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write109_Configuration("Configuration", "", (Configuration)o, true, false);
            }
        }

        public void Write743_FloorHeader(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FloorHeader", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write59_FloorHeader("FloorHeader", "", (FloorHeader)o, true, false);
            }
        }

        public void Write744_FloorHeaderConstruction(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FloorHeaderConstruction", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write51_FloorHeaderConstruction("FloorHeaderConstruction", "", (FloorHeaderConstruction)o, true, false);
            }
        }

        public void Write745_FloorHeaderMeasurements(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FloorHeaderMeasurements", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write58_FloorHeaderMeasurements("FloorHeaderMeasurements", "", (FloorHeaderMeasurements)o, true, false);
            }
        }

        public void Write746_DoorConstruction(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DoorConstruction", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write48_DoorConstruction("DoorConstruction", "", (DoorConstruction)o, true, false);
            }
        }

        public void Write747_Door(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Door", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write50_Door("Door", "", (Door)o, true, false);
            }
        }

        public void Write748_DoorMeasurements(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DoorMeasurements", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write49_DoorMeasurements("DoorMeasurements", "", (DoorMeasurements)o, true, false);
            }
        }

        public void Write749_CeilingConstruction(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CeilingConstruction", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write45_CeilingConstruction("CeilingConstruction", "", (CeilingConstruction)o, true, false);
            }
        }

        private void Write75_FurnaceEquipment(string n, string ns, FurnaceEquipment o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(FurnaceEquipment)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("FurnaceEquipment", "");
                }
                base.WriteAttribute("isBiEnergy", "", XmlConvert.ToString(o.IsBiEnergy));
                base.WriteAttribute("switchoverTemperature", "", XmlConvert.ToString(o.SwitchoverTemperature));
                this.Write18_CodeAndText("EnergySource", "", o.EnergySourceXml, false, false);
                this.Write18_CodeAndText("EquipmentType", "", o.EquipmentTypeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write750_CeilingMeasurements(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CeilingMeasurements", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write46_CeilingMeasurements("CeilingMeasurements", "", (CeilingMeasurements)o, true, false);
            }
        }

        public void Write751_Ceiling(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Ceiling", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write47_Ceiling("Ceiling", "", (Ceiling)o, true, false);
            }
        }

        public void Write752_AdvancedUserSpecified(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("AdvancedUserSpecified", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write194_AdvancedUserSpecified("AdvancedUserSpecified", "", (AdvancedUserSpecified)o, true, false);
            }
        }

        public void Write753_ClothesDryer(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ClothesDryer", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write191_ClothesDryer("ClothesDryer", "", (ClothesDryer)o, true, false);
            }
        }

        public void Write754_ClothesWasher(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ClothesWasher", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write188_ClothesWasher("ClothesWasher", "", (ClothesWasher)o, true, false);
            }
        }

        public void Write755_ElectricalUsage(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ElectricalUsage", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write193_ElectricalUsage("ElectricalUsage", "", (ElectricalUsage)o, true, false);
            }
        }

        public void Write756_Shower(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Shower", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write186_Shower("Shower", "", (Shower)o, true, false);
            }
        }

        public void Write757_Stove(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Stove", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write192_Stove("Stove", "", (Stove)o, true, false);
            }
        }

        public void Write758_BathroomFaucets(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("BathroomFaucets", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write185_BathroomFaucets("BathroomFaucets", "", (BathroomFaucets)o, true, false);
            }
        }

        public void Write759_DishWasher(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("DishWasher", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write189_DishWasher("DishWasher", "", (DishWasher)o, true, false);
            }
        }

        private void Write76_Furnace(string n, string ns, Furnace o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Furnace)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Furnace", "");
                }
                this.Write63_Type1EquipmentInformation("EquipmentInformation", "", o.EquipmentInformation, false, false);
                this.Write70_CommonSpecifications("Specifications", "", o.Specifications, false, false);
                this.Write73_ComboTankAndPump("ComboTankAndPump", "", o.ComboTankAndPump, false, false);
                this.Write75_FurnaceEquipment("Equipment", "", o.Equipment, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write760_RatedValue(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("RatedValue", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write187_RatedValue("RatedValue", "", (RatedValue)o, true, false);
            }
        }

        public void Write761_Summary(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Summary", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write184_Summary("Summary", "", (Summary)o, true, false);
            }
        }

        public void Write762_Occupancy(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Occupancy", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write183_Occupancy("Occupancy", "", (Occupancy)o, true, false);
            }
        }

        public void Write763_OccupantsAtHome(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("OccupantsAtHome", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write182_OccupantsAtHome("OccupantsAtHome", "", (OccupantsAtHome)o, true, false);
            }
        }

        public void Write764_OptionalFeatures(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("OptionalFeatures", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write396_OptionalFeatures("OptionalFeatures", "", (OptionalFeatures)o, true, false);
            }
        }

        public void Write765_OtherCredits(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("OtherCredits", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write397_OtherCredits("OtherCredits", "", (OtherCredits)o, true, false);
            }
        }

        public void Write766_WaterUsage(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WaterUsage", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write190_WaterUsage("WaterUsage", "", (WaterUsage)o, true, false);
            }
        }

        public void Write767_BaseLoads(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("BaseLoads", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write195_BaseLoads("BaseLoads", "", (BaseLoads)o, true, false);
            }
        }

        public void Write768_Code(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Code", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write225_Code("Code", "", (Code)o, true, false);
            }
        }

        public void Write769_ContinuousInsulation(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ContinuousInsulation", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write223_ContinuousInsulation("ContinuousInsulation", "", (ContinuousInsulation)o, true, false);
            }
        }

        private void Write77_ComboHeatDhwEquipment(string n, string ns, ComboHeatDhwEquipment o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ComboHeatDhwEquipment)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ComboHeatDhwEquipment", "");
                }
                base.WriteAttribute("isBiEnergy", "", XmlConvert.ToString(o.IsBiEnergy));
                base.WriteAttribute("switchoverTemperature", "", XmlConvert.ToString(o.SwitchoverTemperature));
                this.Write18_CodeAndText("EnergySource", "", o.EnergySourceXml, false, false);
                this.Write18_CodeAndText("EquipmentType", "", o.EquipmentTypeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write770_FramingComponent(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FramingComponent", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write210_FramingComponent("FramingComponent", "", (FramingComponent)o, true, false);
            }
        }

        public void Write771_SteelFraming(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SteelFraming", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write213_SteelFraming("SteelFraming", "", (SteelFraming)o, true, false);
            }
        }

        public void Write772_SteelFramingLayer(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("SteelFramingLayer", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write214_SteelFramingLayer("SteelFramingLayer", "", (SteelFramingLayer)o, true, false);
            }
        }

        public void Write773_StrappingLayer(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("StrappingLayer", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write215_StrappingLayer("StrappingLayer", "", (StrappingLayer)o, true, false);
            }
        }

        public void Write774_UserDefinedBaseComponent(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("UserDefinedBaseComponent", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write221_UserDefinedBaseComponent("UserDefinedBaseComponent", "", (UserDefinedBaseComponent)o, true, false);
            }
        }

        public void Write775_UserDefinedComponent(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("UserDefinedComponent", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write222_UserDefinedComponent("UserDefinedComponent", "", (UserDefinedComponent)o, true, false);
            }
        }

        public void Write776_ContinuousMedium(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("ContinuousMedium", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write206_ContinuousMedium("ContinuousMedium", "", (ContinuousMedium)o, true, false);
            }
        }

        public void Write777_LintelUserDefined(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("LintelUserDefined", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write208_LintelUserDefined("LintelUserDefined", "", (LintelUserDefined)o, true, false);
            }
        }

        public void Write778_Material(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Material", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write220_Material("Material", "", (Material)o, true, false);
            }
        }

        public void Write779_RsiValues(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("RsiValues", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write217_RsiValues("RsiValues", "", (RsiValues)o, true, false);
            }
        }

        private void Write78_ComboHeatDhw(string n, string ns, ComboHeatDhw o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ComboHeatDhw)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ComboHeatDhw", "");
                }
                this.Write63_Type1EquipmentInformation("EquipmentInformation", "", o.EquipmentInformation, false, false);
                this.Write70_CommonSpecifications("Specifications", "", o.Specifications, false, false);
                this.Write73_ComboTankAndPump("ComboTankAndPump", "", o.ComboTankAndPump, false, false);
                this.Write77_ComboHeatDhwEquipment("Equipment", "", o.Equipment, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write780_StandardLayer(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("StandardLayer", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write226_StandardLayer("StandardLayer", "", (StandardLayer)o, true, false);
            }
        }

        public void Write781_Standard(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Standard", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write227_Standard("Standard", "", (Standard)o, true, false);
            }
        }

        public void Write782_Codes(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Codes", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write229_Codes("Codes", "", (Codes)o, true, false);
            }
        }

        public void Write783_CodesByType(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("CodesByType", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write228_CodesByType("CodesByType", "", (CodesByType)o, true, false);
            }
        }

        public void Write784_Studs(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("Studs", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write207_Studs("Studs", "", (Studs)o, true, false);
            }
        }

        public void Write785_UserDefined(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("UserDefined", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write224_UserDefined("UserDefined", "", (UserDefined)o, true, false);
            }
        }

        public void Write786_UserDefinedLayer(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("UserDefinedLayer", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write219_UserDefinedLayer("UserDefinedLayer", "", (UserDefinedLayer)o, true, false);
            }
        }

        public void Write787_WindowUserDefined(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WindowUserDefined", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write216_WindowUserDefined("WindowUserDefined", "", (WindowUserDefined)o, true, false);
            }
        }

        public void Write788_WindowLegacy(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WindowLegacy", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write218_WindowLegacy("WindowLegacy", "", (WindowLegacy)o, true, false);
            }
        }

        public void Write789_FramingLayer(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("FramingLayer", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write212_FramingLayer("FramingLayer", "", (FramingLayer)o, true, false);
            }
        }

        private void Write79_Common(string n, string ns, Common o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType)
                {
                    Type type = o.GetType();
                    if (type != typeof(Common))
                    {
                        if (type == typeof(Boiler))
                        {
                            this.Write81_Boiler(n, ns, (Boiler)o, isNullable, true);
                            return;
                        }
                        if (type == typeof(ComboHeatDhw))
                        {
                            this.Write78_ComboHeatDhw(n, ns, (ComboHeatDhw)o, isNullable, true);
                            return;
                        }
                        if (!(type == typeof(Furnace)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write76_Furnace(n, ns, (Furnace)o, isNullable, true);
                        return;
                    }
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Common", "");
                }
                this.Write63_Type1EquipmentInformation("EquipmentInformation", "", o.EquipmentInformation, false, false);
                this.Write70_CommonSpecifications("Specifications", "", o.Specifications, false, false);
                this.Write73_ComboTankAndPump("ComboTankAndPump", "", o.ComboTankAndPump, false, false);
                base.WriteEndElement(o);
            }
        }

        public void Write790_WoodFramingLayer(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WoodFramingLayer", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write211_WoodFramingLayer("WoodFramingLayer", "", (WoodFramingLayer)o, true, false);
            }
        }

        public void Write791_WoodFramingType(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteNullTagLiteral("WoodFramingType", "");
            }
            else
            {
                base.TopLevelElement();
                this.Write209_WoodFramingType("WoodFramingType", "", (WoodFramingType)o, true, false);
            }
        }

        public void Write792_ErrorLevels(object o)
        {
            base.WriteStartDocument();
            if (o == null)
            {
                base.WriteEmptyTag("ErrorLevels", "");
            }
            else
            {
                base.WriteElementString("ErrorLevels", "", this.Write28_ErrorLevels((HouseFileError.ErrorLevels)o));
            }
        }

        private string Write8_eConversionType(eConversionType v)
        {
            string str = null;
            switch (v)
            {
                case eConversionType.UNIT_RSI_2_R:
                    str = "UNIT_RSI_2_R";
                    break;

                case eConversionType.UNIT_MM_2_IN:
                    str = "UNIT_MM_2_IN";
                    break;

                case eConversionType.UNIT_RSIMM_2_RIN:
                    str = "UNIT_RSIMM_2_RIN";
                    break;

                case eConversionType.UNIT_M_2_FT:
                    str = "UNIT_M_2_FT";
                    break;

                case eConversionType.UNIT_M2_2_FT2:
                    str = "UNIT_M2_2_FT2";
                    break;

                case eConversionType.UNIT_M3_2_FT3:
                    str = "UNIT_M3_2_FT3";
                    break;

                case eConversionType.UNIT_CM2_2_IN2:
                    str = "UNIT_CM2_2_IN2";
                    break;

                case eConversionType.UNIT_W_2_BTUHR:
                    str = "UNIT_W_2_BTUHR";
                    break;

                case eConversionType.UNIT_KW_2_BTUHR:
                    str = "UNIT_KW_2_BTUHR";
                    break;

                case eConversionType.UNIT_MJDAY_2_BTUHR:
                    str = "UNIT_MJDAY_2_BTUHR";
                    break;

                case eConversionType.UNIT_MJM2DAY_2_BTUFT2HR:
                    str = "UNIT_MJM2DAY_2_BTUFT2HR";
                    break;

                case eConversionType.UNIT_L_2_GAL:
                    str = "UNIT_L_2_GAL";
                    break;

                case eConversionType.UNIT_LSEC_2_CFM:
                    str = "UNIT_LSEC_2_CFM";
                    break;

                case eConversionType.UNIT_C_2_F:
                    str = "UNIT_C_2_F";
                    break;

                case eConversionType.UNIT_KWH_2_MBTU:
                    str = "UNIT_KWH_2_MBTU";
                    break;

                case eConversionType.UNIT_GJ_2_MBTU:
                    str = "UNIT_GJ_2_MBTU";
                    break;

                case eConversionType.UNIT_MJ_2_BTU:
                    str = "UNIT_MJ_2_BTU";
                    break;

                case eConversionType.UNIT_PERCC_2_PERCF:
                    str = "UNIT_PERCC_2_PERCF";
                    break;

                case eConversionType.UNIT_KGS_2_LBMMIN:
                    str = "UNIT_KGS_2_LBMMIN";
                    break;

                case eConversionType.UNIT_LS_2_GPM:
                    str = "UNIT_LS_2_GPM";
                    break;

                case eConversionType.UNIT_WC_2_BTUHRF:
                    str = "UNIT_WC_2_BTUHRF";
                    break;

                case eConversionType.UNIT_MCF_2_M3:
                    str = "UNIT_MCF_2_M3";
                    break;

                case eConversionType.UNIT_KGPM3_2_LBMPFT3:
                    str = "UNIT_KGPM3_2_LBMPFT3";
                    break;

                case eConversionType.UNIT_KJPKGC_2_BTUPLBMF:
                    str = "UNIT_KJPKGC_2_BTUPLBMF";
                    break;

                case eConversionType.UNIT_UVALUE:
                    str = "UNIT_UVALUE";
                    break;

                default:
                    throw base.CreateInvalidEnumValueException(((long)v).ToString(CultureInfo.InvariantCulture), "ca.nrcan.gc.OEE.HouseFileLibrary.eConversionType");
            }
            return str;
        }

        private void Write80_BoilerEquipment(string n, string ns, BoilerEquipment o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(BoilerEquipment)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("BoilerEquipment", "");
                }
                base.WriteAttribute("isBiEnergy", "", XmlConvert.ToString(o.IsBiEnergy));
                base.WriteAttribute("switchoverTemperature", "", XmlConvert.ToString(o.SwitchoverTemperature));
                this.Write18_CodeAndText("EnergySource", "", o.EnergySourceXml, false, false);
                this.Write18_CodeAndText("EquipmentType", "", o.EquipmentTypeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write81_Boiler(string n, string ns, Boiler o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(Boiler)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Boiler", "");
                }
                this.Write63_Type1EquipmentInformation("EquipmentInformation", "", o.EquipmentInformation, false, false);
                this.Write70_CommonSpecifications("Specifications", "", o.Specifications, false, false);
                this.Write73_ComboTankAndPump("ComboTankAndPump", "", o.ComboTankAndPump, false, false);
                this.Write80_BoilerEquipment("Equipment", "", o.Equipment, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write82_P9LoadPerformance(string n, string ns, P9LoadPerformance o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(P9LoadPerformance)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("P9LoadPerformance", "");
                }
                base.WriteAttribute("loadPerformance15", "", XmlConvert.ToString(o.LoadPerformance15));
                base.WriteAttribute("loadPerformance40", "", XmlConvert.ToString(o.LoadPerformance40));
                base.WriteAttribute("loadPerformance100", "", XmlConvert.ToString(o.LoadPerformance100));
                base.WriteEndElement(o);
            }
        }

        private void Write83_TestData(string n, string ns, TestData o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(TestData)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("TestData", "");
                }
                base.WriteAttribute("controlsPower", "", XmlConvert.ToString(o.ControlsPower));
                base.WriteAttribute("circulationPower", "", XmlConvert.ToString(o.CirculationPower));
                base.WriteAttribute("dailyUse", "", XmlConvert.ToString(o.DailyUse));
                base.WriteAttribute("standbyLossWithFan", "", XmlConvert.ToString(o.StandbyLossWithFan));
                base.WriteAttribute("standbyLossWithoutFan", "", XmlConvert.ToString(o.StandbyLossWithoutFan));
                base.WriteAttribute("oneHourRatingHotWater", "", XmlConvert.ToString(o.OneHourRatingHotWater));
                base.WriteAttribute("oneHourRatingConcurrent", "", XmlConvert.ToString(o.OneHourRatingConcurrent));
                this.Write82_P9LoadPerformance("NetEfficiency", "", o.NetEfficiency, false, false);
                this.Write82_P9LoadPerformance("ElectricalUse", "", o.ElectricalUse, false, false);
                this.Write82_P9LoadPerformance("BlowerPower", "", o.BlowerPower, false, false);
                this.Write18_CodeAndText("EnergySource", "", o.EnergySourceXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write84_P9(string n, string ns, P9 o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(P9)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("P9", "");
                }
                base.WriteAttribute("numberOfSystems", "", XmlConvert.ToString(o.NumberOfSystems));
                base.WriteAttribute("thermalPerformanceFactor", "", XmlConvert.ToString(o.ThermalPerformanceFactor));
                base.WriteAttribute("annualElectricity", "", XmlConvert.ToString(o.AnnualElectricity));
                base.WriteAttribute("spaceHeatingCapacity", "", XmlConvert.ToString(o.SpaceHeatingCapacity));
                base.WriteAttribute("spaceHeatingEfficiency", "", XmlConvert.ToString(o.SpaceHeatingEfficiency));
                base.WriteAttribute("waterHeatingPerformanceFactor", "", XmlConvert.ToString(o.WaterHeatingPerformanceFactor));
                base.WriteAttribute("burnerInput", "", XmlConvert.ToString(o.BurnerInput));
                base.WriteAttribute("recoveryEfficiency", "", XmlConvert.ToString(o.RecoveryEfficiency));
                base.WriteAttribute("isUserSpecified", "", XmlConvert.ToString(o.IsUserSpecified));
                this.Write66_EquipmentInformation("EquipmentInformation", "", o.EquipmentInformation, false, false);
                this.Write83_TestData("TestData", "", o.TestData, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write85_Type1(string n, string ns, ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.Type1 o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.Type1)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Type1", "");
                }
                this.Write62_FansAndPumpsHeating("FansAndPump", "", o.FansAndPump, false, false);
                this.Write69_Baseboards("Baseboards", "", o.Baseboards, false, false);
                this.Write81_Boiler("Boiler", "", o.Boiler, false, false);
                this.Write78_ComboHeatDhw("ComboHeatDhw", "", o.ComboHeatDhw, false, false);
                this.Write76_Furnace("Furnace", "", o.Furnace, false, false);
                this.Write84_P9("P9", "", o.P9, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write86_WindowUnits(string n, string ns, WindowUnits o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(WindowUnits)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("WindowUnits", "");
                }
                base.WriteAttribute("totalCount", "", XmlConvert.ToString(o.TotalCount));
                base.WriteAttribute("numberOfEnergyStarUnits", "", XmlConvert.ToString(o.NumberOfEnergyStarUnits));
                base.WriteEndElement(o);
            }
        }

        private void Write87_AirConditioningEquipment(string n, string ns, AirConditioningEquipment o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(AirConditioningEquipment)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("AirConditioningEquipment", "");
                }
                base.WriteAttribute("crankcaseHeater", "", XmlConvert.ToString(o.CrankcaseHeater));
                base.WriteAttribute("numberOfHeads", "", XmlConvert.ToString(o.NumberOfHeads));
                this.Write18_CodeAndText("Type", "", o.TypeXml, false, false);
                this.Write86_WindowUnits("WindowUnits", "", o.WindowUnits, false, false);
                this.Write18_CodeAndText("CentralType", "", o.CentralTypeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write88_Type2Equipment(string n, string ns, Type2Equipment o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else if (!needType)
            {
                Type type = o.GetType();
                if (type != typeof(Type2Equipment))
                {
                    if (type == typeof(HeatPumpEquipment))
                    {
                        this.Write89_HeatPumpEquipment(n, ns, (HeatPumpEquipment)o, isNullable, true);
                    }
                    else
                    {
                        if (!(type == typeof(AirConditioningEquipment)))
                        {
                            throw base.CreateUnknownTypeException(o);
                        }
                        this.Write87_AirConditioningEquipment(n, ns, (AirConditioningEquipment)o, isNullable, true);
                    }
                }
            }
        }

        private void Write89_HeatPumpEquipment(string n, string ns, HeatPumpEquipment o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HeatPumpEquipment)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HeatPumpEquipment", "");
                }
                base.WriteAttribute("crankcaseHeater", "", XmlConvert.ToString(o.CrankcaseHeater));
                base.WriteAttribute("numberOfHeads", "", XmlConvert.ToString(o.NumberOfHeads));
                this.Write18_CodeAndText("Type", "", o.TypeXml, false, false);
                this.Write18_CodeAndText("Function", "", o.FunctionXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private string Write9_eUnitType(eUnitType v)
        {
            string str = null;
            switch (v)
            {
                case eUnitType.M_2_I:
                    str = "M_2_I";
                    break;

                case eUnitType.M_2_U:
                    str = "M_2_U";
                    break;

                case eUnitType.I_2_M:
                    str = "I_2_M";
                    break;

                case eUnitType.I_2_U:
                    str = "I_2_U";
                    break;

                case eUnitType.U_2_M:
                    str = "U_2_M";
                    break;

                case eUnitType.U_2_I:
                    str = "U_2_I";
                    break;

                default:
                    throw base.CreateInvalidEnumValueException(((long)v).ToString(CultureInfo.InvariantCulture), "ca.nrcan.gc.OEE.HouseFileLibrary.eUnitType");
            }
            return str;
        }

        private void Write90_HeatPumpSpecifications(string n, string ns, HeatPumpSpecifications o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HeatPumpSpecifications)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HeatPumpSpecifications", "");
                }
                this.Write21_OutputCapacity("OutputCapacity", "", o.OutputCapacity, false, false);
                this.Write24_CopSeerValue("HeatingEfficiency", "", o.HeatingEfficiency, false, false);
                this.Write24_CopSeerValue("CoolingEfficiency", "", o.CoolingEfficiency, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write91_HeatPumpTemperature(string n, string ns, HeatPumpTemperature o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HeatPumpTemperature)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HeatPumpTemperature", "");
                }
                this.Write23_CodeTextAndValue("CutoffType", "", o.CutoffTypeXml, false, false);
                this.Write23_CodeTextAndValue("RatingType", "", o.RatingTypeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write92_SourceTemperature(string n, string ns, SourceTemperature o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(SourceTemperature)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("SourceTemperature", "");
                }
                base.WriteAttribute("depth", "", XmlConvert.ToString(o.Depth));
                this.Write32_MonthlyData("Temperatures", "", o.Temperatures, false, false);
                this.Write18_CodeAndText("Use", "", o.UseXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write93_ColdClimateHeatPump(string n, string ns, ColdClimateHeatPump o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ColdClimateHeatPump)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("ColdClimateHeatPump", "");
                }
                base.WriteAttribute("heatingEfficiency", "", XmlConvert.ToString(o.HeatingEfficiency));
                base.WriteAttribute("coolingEfficiency", "", XmlConvert.ToString(o.CoolingEfficiency));
                base.WriteAttribute("capacity", "", XmlConvert.ToString(o.Capacity));
                base.WriteAttribute("cop", "", XmlConvert.ToString(o.Cop));
                base.WriteAttribute("capacityMaintenance", "", XmlConvert.ToString(o.CapacityMaintenance));
                base.WriteAttribute("uiUnits", "", o.UiUnits);
                base.WriteEndElement(o);
            }
        }

        private void Write94_HeatPump(string n, string ns, HeatPump o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(HeatPump)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("HeatPump", "");
                }
                this.Write64_HeatPumpEquipmentInformation("EquipmentInformation", "", o.EquipmentInformation, false, false);
                this.Write89_HeatPumpEquipment("Equipment", "", o.Equipment, false, false);
                this.Write90_HeatPumpSpecifications("Specifications", "", o.Specifications, false, false);
                this.Write91_HeatPumpTemperature("Temperature", "", o.Temperature, false, false);
                this.Write92_SourceTemperature("SourceTemperature", "", o.SourceTemperature, false, false);
                this.Write16_HeatPumpCoolingType("CoolingParameters", "", o.CoolingParameters, false, false);
                this.Write93_ColdClimateHeatPump("ColdClimateHeatPump", "", o.ColdClimateHeatPump, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write95_AirConditioningSpecifications(string n, string ns, AirConditioningSpecifications o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(AirConditioningSpecifications)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("AirConditioningSpecifications", "");
                }
                base.WriteAttribute("sizingFactor", "", XmlConvert.ToString(o.SizingFactor));
                this.Write21_OutputCapacity("RatedCapacity", "", o.RatedCapacity, false, false);
                this.Write24_CopSeerValue("Efficiency", "", o.Efficiency, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write96_AirConditioning(string n, string ns, AirConditioning o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(AirConditioning)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("AirConditioning", "");
                }
                this.Write65_EnergyStarEquipmentInformation("EquipmentInformation", "", o.EquipmentInformation, false, false);
                this.Write87_AirConditioningEquipment("Equipment", "", o.Equipment, false, false);
                this.Write95_AirConditioningSpecifications("Specifications", "", o.Specifications, false, false);
                this.Write16_HeatPumpCoolingType("CoolingParameters", "", o.CoolingParameters, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write97_Type2(string n, string ns, ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2.Type2 o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2.Type2)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("Type2", "");
                }
                base.WriteAttribute("shadingInF280Cooling", "", o.ShadingInF280Cooling);
                this.Write94_HeatPump("AirHeatPump", "", o.AirHeatPump, false, false);
                this.Write94_HeatPump("WaterHeatPump", "", o.WaterHeatPump, false, false);
                this.Write94_HeatPump("GroundHeatPump", "", o.GroundHeatPump, false, false);
                this.Write96_AirConditioning("AirConditioning", "", o.AirConditioning, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write98_MultipleSystemsEquipment(string n, string ns, MultipleSystemsEquipment o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(MultipleSystemsEquipment)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("MultipleSystemsEquipment", "");
                }
                base.WriteAttribute("rank", "", XmlConvert.ToString(o.Rank));
                base.WriteAttribute("efficiency", "", XmlConvert.ToString(o.Efficiency));
                base.WriteAttribute("flueDiameter", "", XmlConvert.ToString(o.FlueDiameter));
                base.WriteAttribute("heatingCapacitykW", "", XmlConvert.ToString(o.HeatingCapacitykW));
                base.WriteAttribute("heatingCapacityUiUnits", "", o.HeatingCapacityUiUnits);
                base.WriteAttribute("pilotLight", "", XmlConvert.ToString(o.PilotLight));
                base.WriteAttribute("energyStar", "", XmlConvert.ToString(o.EnergyStar));
                base.WriteAttribute("energyEfficientMotor", "", XmlConvert.ToString(o.EnergyEfficientMotor));
                base.WriteAttribute("identicalSystems", "", XmlConvert.ToString(o.IdenticalSystems));
                base.WriteElementString("Manufacturer", "", o.Manufacturer);
                base.WriteElementString("Model", "", o.Model);
                this.Write18_CodeAndText("EnergySource", "", o.EnergySourceXml, false, false);
                this.Write18_CodeAndText("EquipmentType", "", o.EquipmentTypeXml, false, false);
                this.Write18_CodeAndText("EfficiencyType", "", o.EfficiencyTypeXml, false, false);
                base.WriteEndElement(o);
            }
        }

        private void Write99_MultipleSystemsSummary(string n, string ns, MultipleSystemsSummary o, bool isNullable, bool needType)
        {
            if (o == null)
            {
                if (isNullable)
                {
                    base.WriteNullTagLiteral(n, ns);
                }
            }
            else
            {
                if (!needType && (o.GetType() != typeof(MultipleSystemsSummary)))
                {
                    throw base.CreateUnknownTypeException(o);
                }
                base.WriteStartElement(n, ns, o, false, null);
                if (needType)
                {
                    base.WriteXsiType("MultipleSystemsSummary", "");
                }
                base.WriteAttribute("energySaverHeatingSystems", "", XmlConvert.ToString(o.EnergySaverHeatingSystems));
                base.WriteAttribute("energySaverAirSourceHeatPump", "", XmlConvert.ToString(o.EnergySaverAirSourceHeatPump));
                base.WriteAttribute("woodAppliances", "", XmlConvert.ToString(o.WoodAppliances));
                base.WriteAttribute("epaCsaHeatingSystems", "", XmlConvert.ToString(o.EpaCsaHeatingSystems));
                base.WriteEndElement(o);
            }
        }
    }





}

