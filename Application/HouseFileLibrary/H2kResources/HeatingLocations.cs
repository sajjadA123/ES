namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class HeatingLocations : ResourceValueList
    {
        private HeatingLocations()
        {
        }

        private HeatingLocations(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static HeatingLocations MainFloors =>
            new HeatingLocations("1", "Main Floors", "Plancher Principaux", 0M, true);

        public static HeatingLocations Basement =>
            new HeatingLocations("2", "Basement", "Sous-Sol", 0M, true);

        public static HeatingLocations Exterior =>
            new HeatingLocations("3", "Exterior", "Ext\x00e9rieur", 0M, true);

        public static List<HeatingLocations> All
        {
            get
            {
                List<HeatingLocations> list1 = new List<HeatingLocations>();
                list1.Add(MainFloors);
                list1.Add(Basement);
                list1.Add(Exterior);
                return list1;
            }
        }
    }
}

