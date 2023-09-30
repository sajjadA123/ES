namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class AirTightnessTypes : ResourceValueList
    {
        public static readonly AirTightnessTypes Loose = new AirTightnessTypes("A", "Loose (10.35 ACH @50 Pa)", "Faible (10.35 CAH @50 Pa)", 10.35M, false);
        public static readonly AirTightnessTypes Average = new AirTightnessTypes("B", "Average (4.55 ACH @ 50 Pa)", "Moyenne (4.55 CAH @ 50 Pa)", 4.55M, false);
        public static readonly AirTightnessTypes Present = new AirTightnessTypes("C", "Present (3.57 ACH @ 50 Pa)", "Construction r\x00e9cente (3.57 CAH @ 50 Pa)", 3.57M, false);
        public static readonly AirTightnessTypes EnergyTight = new AirTightnessTypes("D", "Energy tight (1.5 ACH @ 50 Pa)", "Tr\x00e8s \x00e9tanche (1.5 CAH @ 50 Pa)", 1.5M, false);

        private AirTightnessTypes()
        {
        }

        private AirTightnessTypes(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static AirTightnessTypes BlowerDoorTestValues =>
            new AirTightnessTypes("x", "Blower door test values", "Valeurs d'essai de d\x00e9pressurisation", 0M, true);

        public static List<AirTightnessTypes> All
        {
            get
            {
                List<AirTightnessTypes> list1 = new List<AirTightnessTypes>();
                list1.Add(BlowerDoorTestValues);
                list1.Add(Loose);
                list1.Add(Average);
                list1.Add(Present);
                list1.Add(EnergyTight);
                return list1;
            }
        }
    }
}

