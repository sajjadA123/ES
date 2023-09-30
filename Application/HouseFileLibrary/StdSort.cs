namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Collections.Generic;

    public class StdSort : Comparer<string>
    {
        public override int Compare(string a, string b)
        {
            int num = (b.Length < a.Length) ? b.Length : a.Length;
            for (int i = 0; i < num; i++)
            {
                if (a[i] < b[i])
                {
                    return -1;
                }
                if (a[i] > b[i])
                {
                    return 1;
                }
            }
            return ((a.Length >= b.Length) ? ((a.Length <= b.Length) ? 0 : 1) : -1);
        }
    }
}

