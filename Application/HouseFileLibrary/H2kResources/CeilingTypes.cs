namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class CeilingTypes : ResourceList
    {
        public static readonly CeilingTypes AtticGable = new CeilingTypes("2", "Attic/gable", "Combles/pignon", false);
        public static readonly CeilingTypes AtticHip = new CeilingTypes("3", "Attic/hip", "Combles/ar\x00eate", false);
        public static readonly CeilingTypes Cathedral = new CeilingTypes("4", "Cathedral", "Cath\x00e9drale", false);
        public static readonly CeilingTypes Flat = new CeilingTypes("5", "Flat", "Plat", false);
        public static readonly CeilingTypes Scissor = new CeilingTypes("6", "Scissor", "Ciseaux", false);

        private CeilingTypes()
        {
        }

        private CeilingTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<CeilingTypes> All
        {
            get
            {
                List<CeilingTypes> list1 = new List<CeilingTypes>();
                list1.Add(AtticGable);
                list1.Add(AtticHip);
                list1.Add(Cathedral);
                list1.Add(Flat);
                list1.Add(Scissor);
                return list1;
            }
        }
    }
}

