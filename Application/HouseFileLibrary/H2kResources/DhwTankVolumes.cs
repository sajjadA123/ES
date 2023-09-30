namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class DhwTankVolumes : ResourceValueList
    {
        public static readonly DhwTankVolumes Litres114 = new DhwTankVolumes("2", "113.6 L, 25.0 Imp, 30 US gal", "113.6 L, 25.0 imp, 30 gal \x00c9U", 113.6M, false);
        public static readonly DhwTankVolumes Litres151 = new DhwTankVolumes("3", "151.4 L, 33.3 Imp, 40 US gal", "151.4 L, 33.3 imp, 40 gal \x00c9U", 151.4M, false);
        public static readonly DhwTankVolumes Litres189 = new DhwTankVolumes("4", "189.3 L, 41.6 Imp, 50 US gal", "189.3 L, 41.6 imp, 50 gal \x00c9U", 189.3M, false);
        public static readonly DhwTankVolumes Litres246 = new DhwTankVolumes("5", "246.1 L, 54.1 Imp, 65 US gal", "246.1 L, 54.1 imp, 65 gal \x00c9U", 246.1M, false);
        public static readonly DhwTankVolumes Litres303 = new DhwTankVolumes("6", "302.8 L, 66.6 Imp, 80 US gal", "302.8 L, 66.6 imp, 80 gal \x00c9U", 302.8M, false);
        public static readonly DhwTankVolumes NotApplicable = new DhwTankVolumes("7", "Not applicable", "Sans objet", 0.0M, false);

        private DhwTankVolumes()
        {
        }

        private DhwTankVolumes(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static DhwTankVolumes UserSpecified =>
            new DhwTankVolumes("1", "User specified", "Sp\x00e9cifi\x00e9 par l'utilisateur", 0M, true);

        public static List<DhwTankVolumes> All
        {
            get
            {
                List<DhwTankVolumes> list1 = new List<DhwTankVolumes>();
                list1.Add(UserSpecified);
                list1.Add(Litres114);
                list1.Add(Litres151);
                list1.Add(Litres189);
                list1.Add(Litres246);
                list1.Add(Litres303);
                list1.Add(NotApplicable);
                return list1;
            }
        }
    }
}

