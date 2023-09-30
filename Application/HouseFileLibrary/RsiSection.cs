namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Xml.Serialization;

    [Serializable]
    public class RsiSection
    {
        [XmlAttribute("rank")]
        public uint Rank;
        [XmlAttribute("percentage")]
        public decimal Percentage;
        [XmlAttribute("rsi")]
        public decimal Rsi;
        [XmlAttribute("nominalRsi")]
        public decimal NominalRsi;

        public RsiSection()
        {
        }

        public RsiSection(uint rank, decimal percentage, decimal rsi, decimal nominalRsi = 0M)
        {
            this.Rank = rank;
            this.Percentage = percentage;
            this.Rsi = rsi;
            this.NominalRsi = nominalRsi;
        }
    }
}

