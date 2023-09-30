namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class PhotovoltaicModules : ResourceList
    {
        public static readonly PhotovoltaicModules MonoSi = new PhotovoltaicModules("1", "Mono-Si", "Mono-Si", false);
        public static readonly PhotovoltaicModules PolySi = new PhotovoltaicModules("2", "Poly-Si", "Poly-Si", false);
        public static readonly PhotovoltaicModules ASi = new PhotovoltaicModules("3", "a-Si", "a-Si", false);
        public static readonly PhotovoltaicModules Cdte = new PhotovoltaicModules("4", "CdTe", "CdTe", false);
        public static readonly PhotovoltaicModules Cls = new PhotovoltaicModules("5", "ClS", "ClS", false);
        public static readonly PhotovoltaicModules UserSpecified = new PhotovoltaicModules("6", "User Specified", "Sp\x00e9cifi\x00e9 par l'utilisateur", false);

        private PhotovoltaicModules()
        {
        }

        private PhotovoltaicModules(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<PhotovoltaicModules> All
        {
            get
            {
                List<PhotovoltaicModules> list1 = new List<PhotovoltaicModules>();
                list1.Add(MonoSi);
                list1.Add(PolySi);
                list1.Add(ASi);
                list1.Add(Cdte);
                list1.Add(Cls);
                list1.Add(UserSpecified);
                return list1;
            }
        }
    }
}

