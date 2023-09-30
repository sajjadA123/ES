namespace ca.nrcan.gc.OEE.HouseFileLibrary.HouseFileEvents
{
    using System;

    public interface ISerializationEvents
    {
        void OnDeserialization();
        void OnPostSerialization();
        void OnPreSerialization();
    }
}

