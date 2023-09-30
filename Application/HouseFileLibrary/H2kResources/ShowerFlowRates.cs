namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class ShowerFlowRates : ResourceList
    {
        public static readonly ShowerFlowRates UltraLowFlow = new ShowerFlowRates("0", "Ultra Low flow 5.7 L/min (1.5 US gpm)", "Tr\x00e8s faible d\x00e9bit 5.7 L/min (1.5 \x00c9U gpm)", false);
        public static readonly ShowerFlowRates LowFlow = new ShowerFlowRates("1", "Low flow 7.6 L/min (2.0 US gpm)", "Faible d\x00e9bit 7.6 L/min (2.0 \x00c9U gpm)", false);
        public static readonly ShowerFlowRates Standard = new ShowerFlowRates("2", "Standard 9.5 L/min (2.5 US gpm)", "Standard 9.5 L/min (2.5 \x00c9U gpm)", false);
        public static readonly ShowerFlowRates Older = new ShowerFlowRates("3", "Older 15 L/min (4.0 US gpm)", "Plus ancien 15 L/min (4.0 \x00c9U gpm)", false);
        public static readonly ShowerFlowRates HighFlow = new ShowerFlowRates("4", "High Flow 19 L/min (5.0 US gpm)", "Haut d\x00e9bit 19 L/min (5.0 \x00c9U gpm)", false);

        private ShowerFlowRates()
        {
        }

        private ShowerFlowRates(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<ShowerFlowRates> All
        {
            get
            {
                List<ShowerFlowRates> list1 = new List<ShowerFlowRates>();
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

