namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;

    public interface IHouseTypes
    {
        CodeAndText ToCodeAndText();

        string Code { get; }

        string English { get; }

        string French { get; }
    }
}

