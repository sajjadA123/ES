namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using System;

    [Serializable]
    public class FloorConstruction : Construction
    {
        public FloorConstruction()
        {
        }

        public FloorConstruction(FloorConstruction toCopy) : base(toCopy)
        {
        }
    }
}

