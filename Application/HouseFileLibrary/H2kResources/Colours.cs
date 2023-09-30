namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class Colours : ResourceValueList
    {
        public static readonly Colours FlatBlack = new Colours("2", "Flat black", "Noir mat", 0.95M, false);
        public static readonly Colours DarkGray = new Colours("3", "Dark gray", "Gris fonc\x00e9", 0.91M, false);
        public static readonly Colours MediumBrown = new Colours("4", "Medium brown", "Brun moyen", 0.84M, false);
        public static readonly Colours Red = new Colours("5", "Red", "Rouge", 0.74M, false);
        public static readonly Colours MediumGreen = new Colours("6", "Medium green", "Vert moyen", 0.59M, false);
        public static readonly Colours Yellow = new Colours("7", "Yellow", "Jaune", 0.57M, false);
        public static readonly Colours Blue = new Colours("8", "Blue", "Bleu", 0.51M, false);
        public static readonly Colours LightGreen = new Colours("9", "Light green", "Vert clair", 0.47M, false);
        public static readonly Colours Default = new Colours("10", "Default", "par d\x00e9faut", 0.40M, false);
        public static readonly Colours White = new Colours("11", "White", "Blanc", 0.25M, false);

        private Colours()
        {
        }

        private Colours(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static Colours UserSpecified =>
            new Colours("1", "User specified ", "Sp\x00e9cifi\x00e9 par l'util. ", 0M, true);

        public static List<Colours> All
        {
            get
            {
                List<Colours> list1 = new List<Colours>();
                list1.Add(UserSpecified);
                list1.Add(FlatBlack);
                list1.Add(DarkGray);
                list1.Add(MediumBrown);
                list1.Add(Red);
                list1.Add(MediumGreen);
                list1.Add(Yellow);
                list1.Add(Blue);
                list1.Add(LightGreen);
                list1.Add(Default);
                list1.Add(White);
                return list1;
            }
        }
    }
}

