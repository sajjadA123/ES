namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class TestStatuses : ResourceList
    {
        public static readonly TestStatuses NotApplicable = new TestStatuses("1", "Not applicable", "Non applicable", false);
        public static readonly TestStatuses NotPossibleToPerformTest = new TestStatuses("2", "Not possible to perform test", "Impossible d'effectuer le test", false);
        public static readonly TestStatuses TestResult = new TestStatuses("3", "Test result", "R\x00e9sultat du test", false);

        private TestStatuses()
        {
        }

        private TestStatuses(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<TestStatuses> All
        {
            get
            {
                List<TestStatuses> list1 = new List<TestStatuses>();
                list1.Add(NotApplicable);
                list1.Add(NotPossibleToPerformTest);
                list1.Add(TestResult);
                return list1;
            }
        }
    }
}

