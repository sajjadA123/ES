using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace H2kXml.HouseFileLibrary
{
    internal sealed class PrivateImplementationDetails
    {
       // internal static readonly __StaticArrayInitTypeSize __StaticArrayInitType=108;// 108// 000039436C1F9D2F817C2BC6B19DACC162164419D2D1DB8D8BD09CAC30ED0DDF; // data size: 108 bytes

    internal static uint ComputeStringHash(string s)
    {
        uint num=0;
        if (s != null)
        {
            num = 0x811c_9dc5;
            for (int i = 0; i < s.Length; i++)
            {
                num = (s[i] ^ num) * 0x100_0193;
            }
        }
        return num;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x6c, Pack = 1)]
    private struct __StaticArrayInitTypeSize
    {
    }
}
}
