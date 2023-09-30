namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class MultipleSystemsElectricity : ResourceList, IMultipleSystemsEquipmentTypes
    {
        public static readonly MultipleSystemsElectricity Boiler = new MultipleSystemsElectricity("1", "Boiler", "Chaudi\x00e8re", false);
        public static readonly MultipleSystemsElectricity Baseboards = new MultipleSystemsElectricity("2", "Baseboards", "Plinthes", false);
        public static readonly MultipleSystemsElectricity ForcedAir = new MultipleSystemsElectricity("3", "Forced air", "Air puls\x00e9", false);
        public static readonly MultipleSystemsElectricity AshpCentralSplit = new MultipleSystemsElectricity("4", "ASHP - central split", "Thermopompe \x00e0 air - Syst\x00e8me central bibloc", false);
        public static readonly MultipleSystemsElectricity AshpCentralSinglePackage = new MultipleSystemsElectricity("5", "ASHP - central single package", "Thermopompe \x00e0 air - Syst\x00e8me central monobloc", false);
        public static readonly MultipleSystemsElectricity AshpMiniSplitDuctless = new MultipleSystemsElectricity("6", "ASHP - mini-split ductless", "Thermopompe \x00e0 air - Petit syst\x00e8me bibloc sans conduits", false);
        public static readonly MultipleSystemsElectricity WaterSourceHeatPump = new MultipleSystemsElectricity("7", "Water source heat pump", "Thermopompe - eau", false);
        public static readonly MultipleSystemsElectricity GroundSourceHeatPump = new MultipleSystemsElectricity("8", "Ground source heat pump", "Thermopompe - sol", false);

        private MultipleSystemsElectricity()
        {
        }

        private MultipleSystemsElectricity(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<MultipleSystemsElectricity> All
        {
            get
            {
                List<MultipleSystemsElectricity> list1 = new List<MultipleSystemsElectricity>();
                list1.Add(Boiler);
                list1.Add(Baseboards);
                list1.Add(ForcedAir);
                list1.Add(AshpCentralSplit);
                list1.Add(AshpCentralSinglePackage);
                list1.Add(AshpMiniSplitDuctless);
                list1.Add(WaterSourceHeatPump);
                list1.Add(GroundSourceHeatPump);
                return list1;
            }
        }
    }
}

