namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [Serializable]
    public class CodesByType
    {
        [XmlArray("Standard"), XmlArrayItem("Code", typeof(ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Standard))]
        public List<ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Standard> Standard;
        [XmlArray("Favorite"), XmlArrayItem("Code", typeof(ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Standard))]
        public List<ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Standard> Favorite;
        [XmlArray("UserDefined"), XmlArrayItem("Code", typeof(ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.UserDefined))]
        public List<ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.UserDefined> UserDefined;

        public CodesByType()
        {
        }

        public CodesByType(bool initializeLists)
        {
            if (initializeLists)
            {
                this.Standard = new List<ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Standard>();
                this.Favorite = new List<ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Standard>();
                this.UserDefined = new List<ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.UserDefined>();
            }
        }

        public bool IsInFavorite(Code toFind) => 
            (toFind is ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Standard) && ((this.Favorite != null) && this.Favorite.Contains((ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Standard) toFind));

        public bool IsInStandard(Code toFind) => 
            (toFind is ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Standard) && ((this.Standard != null) && this.Standard.Contains((ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Standard) toFind));

        public bool IsInUserDefined(Code toFind) => 
            (toFind is ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.UserDefined) && ((this.UserDefined != null) && this.UserDefined.Contains((ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.UserDefined) toFind));

        public void NullEmptyLists()
        {
            if ((this.Standard != null) && (this.Standard.Count == 0))
            {
                this.Standard = null;
            }
            if ((this.Favorite != null) && (this.Favorite.Count == 0))
            {
                this.Favorite = null;
            }
            if ((this.UserDefined != null) && (this.UserDefined.Count == 0))
            {
                this.UserDefined = null;
            }
        }

        [XmlIgnore]
        public List<Code> AllCodes
        {
            get
            {
                List<Code> list = new List<Code>();
                if (this.Standard != null)
                {
                    list.AddRange(this.Standard);
                }
                if (this.Favorite != null)
                {
                    list.AddRange(this.Favorite);
                }
                if (this.UserDefined != null)
                {
                    list.AddRange(this.UserDefined);
                }
                return list;
            }
        }

        [XmlIgnore]
        public bool AllListsAreEmpty =>
            ((this.Standard == null) || (this.Standard.Count == 0)) ? (((this.Favorite == null) || (this.Favorite.Count == 0)) && ((this.UserDefined == null) || (this.UserDefined.Count == 0))) : false;
    }
}

