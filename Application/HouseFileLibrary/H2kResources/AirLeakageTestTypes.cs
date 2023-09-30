namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class AirLeakageTestTypes : ResourceList
    {
        public static readonly AirLeakageTestTypes OneBlowerWholeHouse = new AirLeakageTestTypes("0", "1 blower - whole house", "1 infiltrom\x00e8tre - maison compl\x00e8te", false);
        public static readonly AirLeakageTestTypes TwoBlowersWholeHouse = new AirLeakageTestTypes("1", "2 blowers - whole house", "2 infiltrom\x00e8tres - maison compl\x00e8te", false);
        public static readonly AirLeakageTestTypes OneBlowerDuplex = new AirLeakageTestTypes("2", "1 blower - Duplex", "1 infiltrom\x00e8tre - duplex", false);
        public static readonly AirLeakageTestTypes OneBlowerTriplex = new AirLeakageTestTypes("3", "1 blower - Triplex", "1 infiltrom\x00e8tre - triplex", false);
        public static readonly AirLeakageTestTypes TwoBlowersTriplex = new AirLeakageTestTypes("4", "2 blowers - Triplex", "2 infiltrom\x00e8tres - triplex", false);

        private AirLeakageTestTypes()
        {
        }

        private AirLeakageTestTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<AirLeakageTestTypes> All
        {
            get
            {
                List<AirLeakageTestTypes> list1 = new List<AirLeakageTestTypes>();
                list1.Add(OneBlowerWholeHouse);
                list1.Add(TwoBlowersWholeHouse);
                list1.Add(OneBlowerDuplex);
                list1.Add(OneBlowerTriplex);
                list1.Add(TwoBlowersTriplex);
                return list1;
            }
        }
    }
}

