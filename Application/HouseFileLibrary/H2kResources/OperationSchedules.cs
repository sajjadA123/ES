namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class OperationSchedules : ResourceValueList
    {
        public static readonly OperationSchedules Continuous = new OperationSchedules("1", "Continuous", "Continu", 1440M, false);
        public static readonly OperationSchedules FortyFiveMinsPerDay = new OperationSchedules("3", "45 min/day", "45 min/j", 45M, false);
        public static readonly OperationSchedules SeventyTwoMinsPerDay = new OperationSchedules("4", "72 min/day", "72 min/j", 72M, false);
        public static readonly OperationSchedules NinetyMinsPerDay = new OperationSchedules("5", "90 min/day", "90 min/j", 90M, false);
        public static readonly OperationSchedules FourHundredEightyMinsPerDay = new OperationSchedules("6", "480 min/day", "480 min/j", 480M, false);
        public static readonly OperationSchedules TemperatureControlled = new OperationSchedules("2", " Temperature controlled", "R\x00e9glage selon la temp\x00e9rature", 0M, false);

        private OperationSchedules()
        {
        }

        private OperationSchedules(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static OperationSchedules UserSpecified =>
            new OperationSchedules("0", "User specified", "Sp\x00e9cifi\x00e9 par l’utilisateur", 0M, true);

        public static List<OperationSchedules> All
        {
            get
            {
                List<OperationSchedules> list1 = new List<OperationSchedules>();
                list1.Add(Continuous);
                list1.Add(FortyFiveMinsPerDay);
                list1.Add(SeventyTwoMinsPerDay);
                list1.Add(NinetyMinsPerDay);
                list1.Add(FourHundredEightyMinsPerDay);
                list1.Add(UserSpecified);
                list1.Add(TemperatureControlled);
                return list1;
            }
        }
    }
}

