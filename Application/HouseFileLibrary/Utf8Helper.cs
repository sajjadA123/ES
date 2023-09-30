namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml.Linq;

    public class Utf8Helper
    {
        public static string ToStringWithDeclaration(XDocument doc)
        {
            if (doc == null)
            {
                return string.Empty;
            }
            doc.Declaration = new XDeclaration("1.0", "UTF-8", null);
            StringWriter textWriter = new Utf8StringWriter();
            doc.Save(textWriter, SaveOptions.None);
            return textWriter.ToString();
        }

        private class Utf8StringWriter : StringWriter
        {
            public override System.Text.Encoding Encoding =>
                System.Text.Encoding.UTF8;
        }
    }
}

