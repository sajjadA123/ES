namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class WindowAirTightness : ResourceValueList
    {
        public static readonly WindowAirTightness CsaA1 = new WindowAirTightness("1", "CSA - A1", "CSA - A1", 1.86M, false);
        public static readonly WindowAirTightness CsaA2 = new WindowAirTightness("2", "CSA - A2", "CSA - A2", 1.50M, false);
        public static readonly WindowAirTightness CsaA3 = new WindowAirTightness("3", "CSA - A3", "CSA - A3", 0.50M, false);
        public static readonly WindowAirTightness CsaFixed = new WindowAirTightness("4", "CSA - Fixed", "CSA - Fixe", 0.20M, false);

        private WindowAirTightness()
        {
        }

        private WindowAirTightness(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static WindowAirTightness UserSpecified =>
            new WindowAirTightness("0", "User specified", "Sp\x00e9cifi\x00e9 par l'utilisateur", 0M, true);

        public static List<WindowAirTightness> All
        {
            get
            {
                List<WindowAirTightness> list1 = new List<WindowAirTightness>();
                list1.Add(CsaA1);
                list1.Add(CsaA2);
                list1.Add(CsaA3);
                list1.Add(CsaFixed);
                list1.Add(UserSpecified);
                return list1;
            }
        }
    }
}

