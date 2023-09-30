namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class BaseFaucetFlowRates : ResourceValueList
    {
        public static readonly BaseFaucetFlowRates UltraLowFlow = new BaseFaucetFlowRates("0", "Ultra Low flow 3.8  L/min (1.0 US gpm)", " D\x00e9bit ultra faible de 3,8 L/min (1,0 gpm US)", 3.8M, false);
        public static readonly BaseFaucetFlowRates LowFlow = new BaseFaucetFlowRates("1", "Low flow 5.7 L/min (1.5 US gpm)", "D\x00e9bit faible de 5,7 L/min (1,5 gal/min)", 5.7M, false);
        public static readonly BaseFaucetFlowRates Standard = new BaseFaucetFlowRates("2", "Standard 8.3 L/min (2.2 US gpm)", "D\x00e9bit standard 8.3 L/min (2,2 gal/min)", 8.3M, false);

        private BaseFaucetFlowRates()
        {
        }

        private BaseFaucetFlowRates(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static List<BaseFaucetFlowRates> All
        {
            get
            {
                List<BaseFaucetFlowRates> list1 = new List<BaseFaucetFlowRates>();
                list1.Add(UltraLowFlow);
                list1.Add(LowFlow);
                list1.Add(Standard);
                return list1;
            }
        }
    }
}

