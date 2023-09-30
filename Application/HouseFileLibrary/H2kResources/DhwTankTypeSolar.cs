namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class DhwTankTypeSolar : ResourceList, IDhwTankType
    {
        public static readonly DhwTankTypeSolar NotApplicable = new DhwTankTypeSolar("1", "Not applicable", "Sans objet", false);
        public static readonly DhwTankTypeSolar SolarCollectorSystem = new DhwTankTypeSolar("2", "Solar collector system", "Chauffe-eau solaire", false);

        private DhwTankTypeSolar()
        {
        }

        private DhwTankTypeSolar(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<DhwTankTypeSolar> All
        {
            get
            {
                List<DhwTankTypeSolar> list1 = new List<DhwTankTypeSolar>();
                list1.Add(NotApplicable);
                list1.Add(SolarCollectorSystem);
                return list1;
            }
        }
    }
}

