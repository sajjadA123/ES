namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class DhwTankTypeOil : ResourceList, IDhwTankType
    {
        public static readonly DhwTankTypeOil NotApplicable = new DhwTankTypeOil("1", "Not Applicable", "Sans objet", false);
        public static readonly DhwTankTypeOil ConventionalTank = new DhwTankTypeOil("2", "Conventional tank", "R\x00e9servoir classique", false);
        public static readonly DhwTankTypeOil TanklessCoil = new DhwTankTypeOil("3", "Tankless coil", "Serpentin sans r\x00e9servoir", false);

        private DhwTankTypeOil()
        {
        }

        private DhwTankTypeOil(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<DhwTankTypeOil> All
        {
            get
            {
                List<DhwTankTypeOil> list1 = new List<DhwTankTypeOil>();
                list1.Add(NotApplicable);
                list1.Add(ConventionalTank);
                list1.Add(TanklessCoil);
                return list1;
            }
        }
    }
}

