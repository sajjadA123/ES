namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class ResourceValueList : ResourceList
    {
        protected decimal value;

        protected ResourceValueList()
        {
        }

        protected ResourceValueList(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
            this.value = value;
        }

        public override bool Equals(object o)
        {
            try
            {
                return (this == ((ResourceValueList) o));
            }
            catch
            {
                return false;
            }
        }

        public override int GetHashCode() => 
            this.IsUserSpecified ? this.value.GetHashCode() : base.code.GetHashCode();

        public static bool operator ==(ResourceValueList x, ResourceValueList y)
        {
            if (ReferenceEquals(x,null) || ReferenceEquals(y,null) )
                return ReferenceEquals(x, y);
            else
                if (ReferenceEquals(x.code,y.code))
                return (!x.IsUserSpecified || (ReferenceEquals(x.value,y.value)));
            else
                return false;
        }
            // ? 
            
            //: (?  : false);

        public static implicit operator CodeTextAndValue(ResourceValueList item) => 
            (item == null) ? null : new CodeTextAndValue(item.code.ToString(), item.englishText, item.frenchText, item.value);

        public static bool operator !=(ResourceValueList x, ResourceValueList y) => 
            !(x == y);

        public CodeTextAndValue ToCodeTextAndValue() => 
            (CodeTextAndValue) this;

        public decimal Value
        {
            get => 
                this.value;
            set
            {
                if (this.IsUserSpecified)
                {
                    this.value = value;
                }
            }
        }
    }
}

