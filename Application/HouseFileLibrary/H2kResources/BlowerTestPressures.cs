namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class BlowerTestPressures : ResourceList
    {
        public static readonly BlowerTestPressures FourPascals = new BlowerTestPressures("2", "4 Pa", "4 Pa", false);
        public static readonly BlowerTestPressures TenPascals = new BlowerTestPressures("1", "10 Pa", "10 Pa", false);

        private BlowerTestPressures()
        {
        }

        private BlowerTestPressures(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<BlowerTestPressures> All
        {
            get
            {
                List<BlowerTestPressures> list1 = new List<BlowerTestPressures>();
                list1.Add(FourPascals);
                list1.Add(TenPascals);
                return list1;
            }
        }
    }
}

