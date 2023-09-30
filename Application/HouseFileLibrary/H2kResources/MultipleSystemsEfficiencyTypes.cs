namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class MultipleSystemsEfficiencyTypes : ResourceList
    {
        public static readonly MultipleSystemsEfficiencyTypes Percent = new MultipleSystemsEfficiencyTypes("1", "%", "%", false);
        public static readonly MultipleSystemsEfficiencyTypes SteadyState = new MultipleSystemsEfficiencyTypes("2", "Steady State", "R\x00e9gime permanent", false);
        public static readonly MultipleSystemsEfficiencyTypes Afue = new MultipleSystemsEfficiencyTypes("3", "AFUE", "AFUE", false);
        public static readonly MultipleSystemsEfficiencyTypes Cop = new MultipleSystemsEfficiencyTypes("4", "COP", "COP", false);
        public static readonly MultipleSystemsEfficiencyTypes Hspf = new MultipleSystemsEfficiencyTypes("5", "HSPF", "HSPF", false);

        private MultipleSystemsEfficiencyTypes()
        {
        }

        private MultipleSystemsEfficiencyTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<MultipleSystemsEfficiencyTypes> All
        {
            get
            {
                List<MultipleSystemsEfficiencyTypes> list1 = new List<MultipleSystemsEfficiencyTypes>();
                list1.Add(Percent);
                list1.Add(SteadyState);
                list1.Add(Afue);
                list1.Add(Cop);
                list1.Add(Hspf);
                return list1;
            }
        }
    }
}

