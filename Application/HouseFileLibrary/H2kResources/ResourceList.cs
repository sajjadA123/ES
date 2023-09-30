namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Runtime.InteropServices;

    [Serializable]
    public class ResourceList
    {
        protected string code;
        protected string englishText;
        protected string frenchText;
        protected bool isUserSpecified;

        protected ResourceList()
        {
        }

        protected ResourceList(string code, string englishText, string frenchText, bool isUserSpecified = false)
        {
            this.code = code;
            this.englishText = englishText;
            this.frenchText = frenchText;
            this.isUserSpecified = isUserSpecified;
        }

        public override bool Equals(object o)
        {
            try
            {
                return (this == ((ResourceList) o));
            }
            catch
            {
                return false;
            }
        }

        public override int GetHashCode() => 
            this.code.GetHashCode();

        public static bool operator ==(ResourceList x, ResourceList y)
        {
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
                return ReferenceEquals(x, y);
            else
               return ReferenceEquals(x.code, y.code);
                
        }

        public static implicit operator CodeAndText(ResourceList item) => 
            (item == null) ? null : new CodeAndText(item.code, item.englishText, item.frenchText);

        public static bool operator !=(ResourceList x, ResourceList y) => 
            !(x == y);

        public virtual CodeAndText ToCodeAndText() => 
            (CodeAndText) this;

        public virtual string Code =>
            this.code;

        public virtual string English =>
            this.englishText;

        public virtual string French =>
            this.frenchText;

        public virtual bool IsUserSpecified =>
            this.isUserSpecified;
    }
}

