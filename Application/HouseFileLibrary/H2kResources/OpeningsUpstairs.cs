namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class OpeningsUpstairs : ResourceValueList
    {
        public static readonly OpeningsUpstairs StandardDoorOpen = new OpeningsUpstairs("1", "Standard door - open", "Porte standard - ouverte", 1.56M, false);
        public static readonly OpeningsUpstairs StandardDoorClosed = new OpeningsUpstairs("2", "Standard door - closed", "Porte standard - ferm\x00e9e", 0M, false);
        public static readonly OpeningsUpstairs Stairwell = new OpeningsUpstairs("3", "Stairwell", "Puits d'escalier", 8.64M, false);

        private OpeningsUpstairs()
        {
        }

        private OpeningsUpstairs(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static OpeningsUpstairs UserSpecified =>
            new OpeningsUpstairs("4", "User specified", "Sp\x00e9cifi\x00e9 par l'utilisateur", 0M, true);

        public static List<OpeningsUpstairs> All
        {
            get
            {
                List<OpeningsUpstairs> list1 = new List<OpeningsUpstairs>();
                list1.Add(StandardDoorOpen);
                list1.Add(StandardDoorClosed);
                list1.Add(Stairwell);
                list1.Add(UserSpecified);
                return list1;
            }
        }
    }
}

