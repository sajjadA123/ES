namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class DhwTankTypeElectric : ResourceList, IDhwTankType
    {
        public static readonly DhwTankTypeElectric NotApplicable = new DhwTankTypeElectric("1", "Not applicable", "Sans objet", false);
        public static readonly DhwTankTypeElectric ConventionalTank = new DhwTankTypeElectric("2", "Conventional tank", "R\x00e9servoir classique", false);
        public static readonly DhwTankTypeElectric ConserverTank = new DhwTankTypeElectric("3", "Conserver tank", "R\x00e9servoir \x00e0 conservation", false);
        public static readonly DhwTankTypeElectric Instantaneous = new DhwTankTypeElectric("4", "Instantaneous", "Chauffage instantan\x00e9", false);
        public static readonly DhwTankTypeElectric TanklessHeatPump = new DhwTankTypeElectric("5", "Tankless heat pump", "Thermopompe sans r\x00e9serv.", false);
        public static readonly DhwTankTypeElectric HeatPump = new DhwTankTypeElectric("6", "Heat pump", "Thermopompe", false);
        public static readonly DhwTankTypeElectric IntegratedHeatPump = new DhwTankTypeElectric("7", "Integrated heat pump", "Thermopompe int\x00e9gr\x00e9e", false);

        private DhwTankTypeElectric()
        {
        }

        private DhwTankTypeElectric(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<DhwTankTypeElectric> All
        {
            get
            {
                List<DhwTankTypeElectric> list1 = new List<DhwTankTypeElectric>();
                list1.Add(NotApplicable);
                list1.Add(ConventionalTank);
                list1.Add(ConserverTank);
                list1.Add(Instantaneous);
                list1.Add(TanklessHeatPump);
                list1.Add(HeatPump);
                list1.Add(IntegratedHeatPump);
                return list1;
            }
        }
    }
}

