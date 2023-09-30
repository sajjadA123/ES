namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading;
    using System.Xml.Linq;

    public static class HouseFileExtensions
    {
        public static string CalculateSha256(this XElement xmlToChecksum)
        {
            string s = xmlToChecksum.ToChecksumString(false);
            string str2 = string.Empty;
            foreach (byte num2 in SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(s)))
            {
                str2 = str2 + num2.ToString("x2");
            }
            return str2.ToUpper();
        }

        public static string ToChecksumString(this XElement xmlToChecksum, bool checksumText = false)
        {
            string text1;
            if (xmlToChecksum == null)
            {
                return "";
            }
            bool flag = false;
            StringBuilder builder = new StringBuilder();
            XName name = xmlToChecksum.Name;
            if (name != null)
            {
                text1 = name.ToString();
            }
            else
            {
                XName local1 = name;
                text1 = null;
            }
            builder.Append("<" + text1);
            Func<XAttribute, bool> predicate = _c._9__0_0;
            if (_c._9__0_0 == null)
            {
                Func<XAttribute, bool> local2 = _c._9__0_0;
                predicate = _c._9__0_0 = a => a.Name.LocalName != "sha256";
            }
            Func<XAttribute, string> keySelector = _c._9__0_1;
            if (_c._9__0_1 == null)
            {
                Func<XAttribute, string> local3 = _c._9__0_1;
                keySelector = _c._9__0_1 = a => a.Name.LocalName;
            }
            foreach (XAttribute attribute in xmlToChecksum.Attributes().Where<XAttribute>(predicate).OrderBy<XAttribute, string>(keySelector, new StdSort()))
            {
                builder.Append(" " + attribute.Name.LocalName + "=\"");
                builder.Append(attribute.Value + "\"");
            }
            if (checksumText)
            {
                XText text = xmlToChecksum.Nodes().OfType<XText>().FirstOrDefault<XText>();
                if (text != null)
                {
                    builder.Append(">" + text.Value);
                    flag = true;
                }
            }
            if ((xmlToChecksum.Elements().Count<XElement>() > 0) && !flag)
            {
                builder.Append(">");
                flag = true;
            }
            Func<XElement, string> func3 = _c._9__0_2;
            if (_c._9__0_2 == null)
            {
                Func<XElement, string> local4 = _c._9__0_2;
                func3 = _c._9__0_2 = e => e.Name.LocalName;
            }
            foreach (XElement element in xmlToChecksum.Elements().OrderBy<XElement, string>(func3, new StdSort()))
            {
                builder.Append(element.ToChecksumString(checksumText));
            }
            if (!flag)
            {
                builder.Append("/>");
            }
            else
            {
                string text2;
                XName name2 = xmlToChecksum.Name;
                if (name2 != null)
                {
                    text2 = name2.ToString();
                }
                else
                {
                    XName local5 = name2;
                    text2 = null;
                }
                builder.Append("</" + text2 + ">");
            }
            return builder.ToString();
        }

        public static string ToTitle(this string toChange, CultureInfo culture = null)
        {
            bool flag = true;
            CultureInfo info = (culture == null) ? Thread.CurrentThread.CurrentCulture : culture;
            StringBuilder builder = new StringBuilder();
            foreach (char ch in toChange)
            {
                builder.Append(flag ? char.ToUpper(ch, info) : char.ToLower(ch, info));
                flag = !char.IsLetter(ch);
            }
            return builder.ToString();
        }

        public static string ToTitleInvariant(this string toChange) => 
            toChange.ToTitle(CultureInfo.InvariantCulture);

        public static bool VerifySha256(this XElement xmlToChecksum, string hash) => 
            xmlToChecksum.CalculateSha256() == hash.ToUpper();

        [Serializable, CompilerGenerated]
        private sealed class _c
        {
            public static readonly HouseFileExtensions._c _9 = new HouseFileExtensions._c();
            public static Func<XAttribute, bool> _9__0_0;
            public static Func<XAttribute, string> _9__0_1;
            public static Func<XElement, string> _9__0_2;

            internal bool ToChecksumStringb__0_0(XAttribute a) => 
                a.Name.LocalName != "sha256";

            internal string ToChecksumStringb__0_1(XAttribute a) => 
                a.Name.LocalName;

            internal string ToChecksumStringb__0_2(XElement e) => 
                e.Name.LocalName;

            public _c()
            {
            }
        }
    }
}

