namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Reflection;
    using System.Xml.Serialization;

    [Serializable]
    public class MonthlyData
    {
        [XmlAttribute("january")]
        public decimal January;
        [XmlAttribute("february")]
        public decimal February;
        [XmlAttribute("march")]
        public decimal March;
        [XmlAttribute("april")]
        public decimal April;
        [XmlAttribute("may")]
        public decimal May;
        [XmlAttribute("june")]
        public decimal June;
        [XmlAttribute("july")]
        public decimal July;
        [XmlAttribute("august")]
        public decimal August;
        [XmlAttribute("september")]
        public decimal September;
        [XmlAttribute("october")]
        public decimal October;
        [XmlAttribute("november")]
        public decimal November;
        [XmlAttribute("december")]
        public decimal December;

        public decimal[] ToArray()
        {
            decimal[] decimalArray1 = new decimal[12];
            decimalArray1[0] = this.January;
            decimalArray1[1] = this.February;
            decimalArray1[2] = this.March;
            decimalArray1[3] = this.April;
            decimalArray1[4] = this.May;
            decimalArray1[5] = this.June;
            decimalArray1[6] = this.July;
            decimalArray1[7] = this.August;
            decimalArray1[8] = this.September;
            decimalArray1[9] = this.October;
            decimalArray1[10] = this.November;
            decimalArray1[11] = this.December;
            return decimalArray1;
        }

        [XmlIgnore]
        public decimal Annual =>
            ((((((((((this.January + this.February) + this.March) + this.April) + this.May) + this.June) + this.July) + this.August) + this.September) + this.October) + this.November) + this.December;

        public decimal this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        return this.January;

                    case 1:
                        return this.February;

                    case 2:
                        return this.March;

                    case 3:
                        return this.April;

                    case 4:
                        return this.May;

                    case 5:
                        return this.June;

                    case 6:
                        return this.July;

                    case 7:
                        return this.August;

                    case 8:
                        return this.September;

                    case 9:
                        return this.October;

                    case 10:
                        return this.November;

                    case 11:
                        return this.December;
                }
                throw new ArgumentOutOfRangeException("Valid range is from 0 (January) to 11 (December)", "index");
            }
            set
            {
                switch (i)
                {
                    case 0:
                        this.January = value;
                        return;

                    case 1:
                        this.February = value;
                        return;

                    case 2:
                        this.March = value;
                        return;

                    case 3:
                        this.April = value;
                        return;

                    case 4:
                        this.May = value;
                        return;

                    case 5:
                        this.June = value;
                        return;

                    case 6:
                        this.July = value;
                        return;

                    case 7:
                        this.August = value;
                        return;

                    case 8:
                        this.September = value;
                        return;

                    case 9:
                        this.October = value;
                        return;

                    case 10:
                        this.November = value;
                        return;

                    case 11:
                        this.December = value;
                        return;
                }
                throw new ArgumentOutOfRangeException("Valid range is from 0 (January) to 11 (December)", "index");
            }
        }
    }
}

