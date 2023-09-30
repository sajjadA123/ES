namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class ThermalMass : ResourceList
    {
        public static readonly ThermalMass LightWoodFrame = new ThermalMass("1", "Light, wood frame", "L\x00e9g\x00e8re, ossature de bois", false);
        public static readonly ThermalMass MediumWoodFrame = new ThermalMass("2", "Medium, wood frame", "Moyenne, ossature de bois", false);
        public static readonly ThermalMass HeavyMasonry = new ThermalMass("3", "Heavy, masonry", "\x00c9lev\x00e9e, ma\x00e7onnerie", false);
        public static readonly ThermalMass VeryHeavyConcrete = new ThermalMass("4", "Very heavy, concrete", "Tr\x00e8s \x00e9lev\x00e9e, b\x00e9ton", false);

        private ThermalMass()
        {
        }

        private ThermalMass(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<ThermalMass> All
        {
            get
            {
                List<ThermalMass> list1 = new List<ThermalMass>();
                list1.Add(LightWoodFrame);
                list1.Add(MediumWoodFrame);
                list1.Add(HeavyMasonry);
                list1.Add(VeryHeavyConcrete);
                return list1;
            }
        }
    }
}

