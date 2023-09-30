namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class HousePlanShapes : ResourceList
    {
        public static readonly HousePlanShapes Rectangular = new HousePlanShapes("1", "Rectangular", "Rectangulaire", false);
        public static readonly HousePlanShapes TShape = new HousePlanShapes("2", "T-shape", "en T", false);
        public static readonly HousePlanShapes LShape = new HousePlanShapes("3", "L-shape", "en L", false);
        public static readonly HousePlanShapes Other56Corners = new HousePlanShapes("4", "Other, 5-6 corners", "Autre, 5-6 coins", false);
        public static readonly HousePlanShapes Other78Corners = new HousePlanShapes("5", "Other, 7-8 corners", "Autre, 7-8 coins", false);
        public static readonly HousePlanShapes Other910Corners = new HousePlanShapes("6", "Other, 9-10 corners", "Autre, 9-10 coins", false);
        public static readonly HousePlanShapes Other11OrMoreCorners = new HousePlanShapes("7", "Other, 11 or more corners", "Autre, 11 coins ou plus", false);

        private HousePlanShapes()
        {
        }

        private HousePlanShapes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<HousePlanShapes> All
        {
            get
            {
                List<HousePlanShapes> list1 = new List<HousePlanShapes>();
                list1.Add(Rectangular);
                list1.Add(TShape);
                list1.Add(LShape);
                list1.Add(Other56Corners);
                list1.Add(Other78Corners);
                list1.Add(Other910Corners);
                list1.Add(Other11OrMoreCorners);
                return list1;
            }
        }
    }
}

