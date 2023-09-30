namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class BaseShowerFlowRates : ResourceValueList
    {
        public static readonly BaseShowerFlowRates UltraLowFlow = new BaseShowerFlowRates("0", "Ultra Low flow 5.7 L/min (1.5 US gpm)", "Tr\x00e8s faible d\x00e9bit 5.7 L/min (1.5 \x00c9U gpm)", 5.7M, false);
        public static readonly BaseShowerFlowRates LowFlow = new BaseShowerFlowRates("1", "Low flow 7.6 L/min (2.0 US gpm)", "Faible d\x00e9bit 7.6 L/min (2.0 \x00c9U gpm)", 7.6M, false);
        public static readonly BaseShowerFlowRates Standard = new BaseShowerFlowRates("2", "Standard 9.5 L/min (2.5 US gpm)", "Standard 9.5 L/min (2.5 \x00c9U gpm)", 9.5M, false);
        public static readonly BaseShowerFlowRates Older = new BaseShowerFlowRates("3", "Older 15 L/min (4.0 US gpm)", "Plus ancien 15 L/min (4.0 \x00c9U gpm)", 15M, false);
        public static readonly BaseShowerFlowRates HighFlow = new BaseShowerFlowRates("4", "High Flow 19 L/min (5.0 US gpm)", "Haut d\x00e9bit 19 L/min (5.0 \x00c9U gpm)", 19M, false);

        private BaseShowerFlowRates()
        {
        }

        private BaseShowerFlowRates(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static List<BaseShowerFlowRates> All
        {
            get
            {
                List<BaseShowerFlowRates> list1 = new List<BaseShowerFlowRates>();
                list1.Add(UltraLowFlow);
                list1.Add(LowFlow);
                list1.Add(Standard);
                list1.Add(Older);
                list1.Add(HighFlow);
                return list1;
            }
        }
    }
}

