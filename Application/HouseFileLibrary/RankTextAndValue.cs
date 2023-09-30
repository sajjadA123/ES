namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    [Serializable]
    public class RankTextAndValue
    {
        [Required, XmlAttribute("rank")]
        public string Rank;
        [XmlText]
        public string Text;
        [XmlAttribute("value")]
        public decimal Value;

        public RankTextAndValue()
        {
        }

        public RankTextAndValue(string rank, string text, decimal value)
        {
            this.Rank = rank;
            this.Text = text;
            this.Value = value;
        }
    }
}

