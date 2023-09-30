namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class DhwTankTypeGasPropane : ResourceList, IDhwTankType
    {
        public static readonly DhwTankTypeGasPropane NotApplicable = new DhwTankTypeGasPropane("1", "Not Applicable", "Sans objet", false);
        public static readonly DhwTankTypeGasPropane ConventionalTank = new DhwTankTypeGasPropane("2", "Conventional tank", "R\x00e9servoir classique", false);
        public static readonly DhwTankTypeGasPropane ConventionalTankPilot = new DhwTankTypeGasPropane("3", "Conventional tank (pilot)", "R\x00e9servoir classique (veilleuse)", false);
        public static readonly DhwTankTypeGasPropane TanklessCoil = new DhwTankTypeGasPropane("4", "Tankless coil", "Serpentin sans r\x00e9servoir", false);
        public static readonly DhwTankTypeGasPropane Instantaneous = new DhwTankTypeGasPropane("5", "Instantaneous", "Instantan\x00e9", false);
        public static readonly DhwTankTypeGasPropane InstantaneousCondensing = new DhwTankTypeGasPropane("12", "Instantaneous (condensing)", "Instantan\x00e9 (\x00e0 condensation)", false);
        public static readonly DhwTankTypeGasPropane InstantaneousPilot = new DhwTankTypeGasPropane("6", "Instantaneous (pilot)", "Instantan\x00e9 (veilleuse)", false);
        public static readonly DhwTankTypeGasPropane InducedDraftFan = new DhwTankTypeGasPropane("7", "Induced draft fan", "\x00e0 tirage induit", false);
        public static readonly DhwTankTypeGasPropane InducedDraftFanPilot = new DhwTankTypeGasPropane("8", "Induced draft fan (pilot)", "\x00e0 tirage induit (veilleuse)", false);
        public static readonly DhwTankTypeGasPropane DirectVentSealed = new DhwTankTypeGasPropane("9", "Direct vent (sealed)", "\x00e0 \x00e9vacuation directe (scell\x00e9)", false);
        public static readonly DhwTankTypeGasPropane DirectVentSealedPilot = new DhwTankTypeGasPropane("10", "Direct vent (sealed, pilot)", "\x00e0 \x00e9vacuation directe (scell\x00e9, veill.)", false);
        public static readonly DhwTankTypeGasPropane Condensing = new DhwTankTypeGasPropane("11", "Condensing", "R\x00e9servoir de condensation", false);

        private DhwTankTypeGasPropane()
        {
        }

        private DhwTankTypeGasPropane(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<DhwTankTypeGasPropane> All
        {
            get
            {
                List<DhwTankTypeGasPropane> list1 = new List<DhwTankTypeGasPropane>();
                list1.Add(NotApplicable);
                list1.Add(ConventionalTank);
                list1.Add(ConventionalTankPilot);
                list1.Add(TanklessCoil);
                list1.Add(Instantaneous);
                list1.Add(InstantaneousCondensing);
                list1.Add(InstantaneousPilot);
                list1.Add(InducedDraftFan);
                list1.Add(InducedDraftFanPilot);
                list1.Add(DirectVentSealed);
                list1.Add(DirectVentSealedPilot);
                list1.Add(Condensing);
                return list1;
            }
        }
    }
}

