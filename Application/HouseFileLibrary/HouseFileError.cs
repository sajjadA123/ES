namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Diagnostics;
    using System.Text;
    using System.Xml;

    [Serializable]
    public class HouseFileError
    {
        public ErrorLevels level;
        public string englishMessage;
        public string frenchMessage;

        public HouseFileError()
        {
            this.englishMessage = string.Empty;
            this.frenchMessage = string.Empty;
        }

        public HouseFileError(string englishMessage, string frenchMessage)
        {
            this.englishMessage = string.Empty;
            this.frenchMessage = string.Empty;
            this.level = ErrorLevels.Error;
            this.englishMessage = englishMessage;
            this.frenchMessage = frenchMessage;
        }

        public HouseFileError(string englishMessage, string frenchMessage, ErrorLevels level)
        {
            this.englishMessage = string.Empty;
            this.frenchMessage = string.Empty;
            this.level = level;
            this.englishMessage = englishMessage;
            this.frenchMessage = frenchMessage;
        }

        public static HouseFileError CreateErrorFromException(Exception Source)
        {
            if (Source == null)
            {
                return null;
            }
            StringBuilder builder = new StringBuilder();
            StringBuilder builder2 = null;
            bool flag = false;
            Exception e = Source;
            while (e != null)
            {
                StackTrace trace = new StackTrace(e, true);
                if (flag)
                {
                    builder.Append(" ");
                }
                builder.Append(e.Message);
                if (e is XmlException)
                {
                    XmlException exception2 = (XmlException) e;
                    builder.Append(" (XML Line ");
                    builder.Append(exception2.LineNumber);
                    builder.Append(", Pos ");
                    builder.Append(exception2.LinePosition);
                    builder.Append(")");
                }
                else if (trace.FrameCount > 0)
                {
                    StackFrame frame = trace.GetFrame(0);
                    builder2 = new StringBuilder(" (");
                    builder2.Append(frame.GetMethod().Name);
                    builder2.Append("() in ");
                    builder2.Append(frame.GetFileName());
                    builder2.Append(" at Line ");
                    builder2.Append(frame.GetFileLineNumber());
                    builder2.Append(", Col ");
                    builder2.Append(frame.GetFileColumnNumber());
                    builder2.Append(")");
                }
                e = e.InnerException;
                flag = true;
            }
            if (builder2 != null)
            {
                builder.Append(builder2);
            }
            return new HouseFileError(builder.ToString(), builder.ToString(), ErrorLevels.Error);
        }

        public enum ErrorLevels
        {
            None,
            Warning,
            Error
        }
    }
}

