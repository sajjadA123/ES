namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class HouseOwnerships : ResourceList
    {
        public static readonly HouseOwnerships DwellingPrivate = new HouseOwnerships("1", "Dwelling private", "Logement priv\x00e9", false);
        public static readonly HouseOwnerships DwellingCorporate = new HouseOwnerships("2", "Dwelling corporate", "Logement corporatif", false);
        public static readonly HouseOwnerships DwellingAboriginal = new HouseOwnerships("3", "Dwelling Aboriginal", "Logement autochtone", false);
        public static readonly HouseOwnerships SpecialProjectsAboriginal = new HouseOwnerships("4", "Special Projects (aboriginal)", "Projets sp\x00e9ciaux (autochtones)", false);
        public static readonly HouseOwnerships SpecialProjectsNonAboriginal = new HouseOwnerships("5", "Special Projects (non-aboriginal)", "Projets sp\x00e9ciaux (non autochtones)", false);
        public static readonly HouseOwnerships FederalHousing = new HouseOwnerships("6", "Federal housing", "Propri\x00e9t\x00e9 f\x00e9d\x00e9rale", false);
        public static readonly HouseOwnerships ProvincialHousing = new HouseOwnerships("7", "Provincial housing", "Propri\x00e9t\x00e9 provinciale", false);
        public static readonly HouseOwnerships MunicipalHousing = new HouseOwnerships("8", "Municipal housing", "Propri\x00e9t\x00e9 municipale", false);
        public static readonly HouseOwnerships DoNotWantIncentive = new HouseOwnerships("9", "Do not want incentive", "Ne d\x00e9sire pas d'indicatif", false);

        private HouseOwnerships()
        {
        }

        private HouseOwnerships(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<HouseOwnerships> All
        {
            get
            {
                List<HouseOwnerships> list1 = new List<HouseOwnerships>();
                list1.Add(DwellingPrivate);
                list1.Add(DwellingCorporate);
                list1.Add(DwellingAboriginal);
                list1.Add(SpecialProjectsAboriginal);
                list1.Add(SpecialProjectsNonAboriginal);
                list1.Add(FederalHousing);
                list1.Add(ProvincialHousing);
                list1.Add(MunicipalHousing);
                list1.Add(DoNotWantIncentive);
                return list1;
            }
        }
    }
}

