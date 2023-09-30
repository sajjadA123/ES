namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class AirDistributionTypes : ResourceList
    {
        public static readonly AirDistributionTypes ForcedAirHeatingDuctwork = new AirDistributionTypes("1", "Forced air heating ductwork", "Conduites \x00e0 entra\x00eenement forc\x00e9 pour l'air chauff\x00e9", false);
        public static readonly AirDistributionTypes DedicatedLowVolumeDuctwork = new AirDistributionTypes("2", "Dedicated low volume ductwork", "Conduites \x00e0 faible volume d\x00e9di\x00e9es au VRC", false);
        public static readonly AirDistributionTypes DedicatedDuctworkWithTransferFans = new AirDistributionTypes("3", "Dedicated ductwork with transfer fans", "Conduites d\x00e9di\x00e9es et ventilateurs de transfert", false);

        private AirDistributionTypes()
        {
        }

        private AirDistributionTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<AirDistributionTypes> All
        {
            get
            {
                List<AirDistributionTypes> list1 = new List<AirDistributionTypes>();
                list1.Add(ForcedAirHeatingDuctwork);
                list1.Add(DedicatedLowVolumeDuctwork);
                list1.Add(DedicatedDuctworkWithTransferFans);
                return list1;
            }
        }
    }
}

