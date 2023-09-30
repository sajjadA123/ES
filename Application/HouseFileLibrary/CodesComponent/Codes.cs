namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.CeilingComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorHeaderComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.WallComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.WindowComponents;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using Microsoft.Xml.Serialization.GeneratedAssembly;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Serialization;

    [Serializable, XmlRoot("Codes")]
    public class Codes
    {
        [XmlElement("Wall")]
        public CodesByType Wall;
        [XmlElement("Ceiling")]
        public CodesByType Ceiling;
        [XmlElement("CeilingFlat")]
        public CodesByType CeilingFlat;
        [XmlElement("Floor")]
        public CodesByType Floor;
        [XmlElement("Lintel")]
        public CodesByType Lintel;
        [XmlElement("Window")]
        public CodesByType Window;
        [XmlElement("FloorsAbove")]
        public CodesByType FloorsAbove;
        [XmlElement("FloorsAdded")]
        public CodesByType FloorsAdded;
        [XmlElement("BasementWall")]
        public CodesByType BasementWall;
        [XmlElement("CrawlspaceWall")]
        public CodesByType CrawlspaceWall;
        [XmlElement("FloorHeader")]
        public CodesByType FloorHeader;
        private uint NextId = 1;
        private HouseFile House_;
        [XmlAttribute("readOnly")]
        public bool isReadOnly;
        private static CodesSerializer cachedSerializer;

        public Codes Clone()
        {
            using (MemoryStream stream = new MemoryStream(0x400))
            {
                Serializer.Serialize((Stream) stream, this);
                stream.Position = 0L;
                return (Codes) Serializer.Deserialize(stream);
            }
        }

        private void Dereference(CodeDescriptionAndComposite codeWithIdRef)
        {
            if ((codeWithIdRef != null) && !string.IsNullOrWhiteSpace(codeWithIdRef.IdRef))
            {
                Code code = (from c in this.AllCodes
                    where c.Id == codeWithIdRef.IdRef
                    select c).FirstOrDefault<Code>();
                if (code != null)
                {
                    if ((code == null) || !(code is UserDefined))
                    {
                        codeWithIdRef.Code = ((Standard) code).Value;
                        codeWithIdRef.UserDefinedCodeLayers = null;
                    }
                    else
                    {
                        codeWithIdRef.UserDefinedCodeLayers = new List<UserDefinedLayer>();
                        foreach (UserDefinedLayer layer in ((UserDefined) code).Layers)
                        {
                            codeWithIdRef.UserDefinedCodeLayers.Add(layer.Clone());
                        }
                    }
                }
            }
        }

        private void Dereference(CodeReference codeWithIdRef)
        {
            if ((codeWithIdRef != null) && !string.IsNullOrWhiteSpace(codeWithIdRef.IdRef))
            {
                Code code = (from c in this.AllCodes
                    where c.Id == codeWithIdRef.IdRef
                    select c).FirstOrDefault<Code>();
                if (code != null)
                {
                    if ((code == null) || !(code is UserDefined))
                    {
                        codeWithIdRef.Code = ((Standard) code).Value;
                        codeWithIdRef.UserDefinedCodeLayers = null;
                    }
                    else
                    {
                        codeWithIdRef.Code = null;
                        codeWithIdRef.UserDefinedCodeLayers = new List<UserDefinedLayer>();
                        foreach (UserDefinedLayer layer in ((UserDefined) code).Layers)
                        {
                            codeWithIdRef.UserDefinedCodeLayers.Add(layer.Clone());
                        }
                    }
                }
            }
        }

        public void DereferenceAll(HouseFile instance)
        {
            switch (instance)
            {
                case (null):
                    break;

                default:
                {
                    this.House_ = instance;
                    List<BaseComponent> houseComponents = this.House_.HouseComponents;
                    if ((this.House_.EnergyUpgrades != null) && (this.House_.EnergyUpgrades.Components.Count > 0))
                    {
                        houseComponents.AddRange(this.House_.EnergyUpgrades.Components);
                    }
                    foreach (BaseComponent component in houseComponents)
                    {
                        if ((component is Basement) || (component is Walkout))
                        {
                            FoundationFloorConstruction construction = (component is Basement) ? ((Basement) component).Floor.Construction : ((Walkout) component).Floor.Construction;
                            this.Dereference(construction.FloorsAbove);
                            this.Dereference(construction.AddedToSlab);
                            FoundationWallConstruction construction2 = (component is Basement) ? ((Basement) component).Wall.Construction : ((Walkout) component).Wall.Construction;
                            this.Dereference(construction2.InteriorAddedInsulation);
                            if ((construction2.Lintels != null) && (construction2.Lintels.Code != "N/A"))
                            {
                                this.Dereference(construction2.Lintels);
                            }
                            this.Dereference(construction2.PonyWallType);
                            continue;
                        }
                        if (component is Crawlspace)
                        {
                            FoundationFloorConstruction construction = ((Crawlspace) component).Floor.Construction;
                            this.Dereference(construction.FloorsAbove);
                            this.Dereference(construction.AddedToSlab);
                            CrawlspaceWallConstruction construction4 = ((Crawlspace) component).Wall.Construction;
                            this.Dereference(construction4.Type);
                            if ((construction4.Lintels == null) || (construction4.Lintels.Code == "N/A"))
                            {
                                continue;
                            }
                            this.Dereference(construction4.Lintels);
                            continue;
                        }
                        if (component is Slab)
                        {
                            FoundationFloorConstruction construction = ((Slab) component).Floor.Construction;
                            this.Dereference(construction.AddedToSlab);
                            continue;
                        }
                        if (component is ca.nrcan.gc.OEE.HouseFileLibrary.Components.CeilingComponents.Ceiling)
                        {
                            CeilingConstruction construction = ((ca.nrcan.gc.OEE.HouseFileLibrary.Components.CeilingComponents.Ceiling) component).Construction;
                            this.Dereference(construction.CeilingType);
                            continue;
                        }
                        if (component is ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorComponents.Floor)
                        {
                            FloorConstruction construction = ((ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorComponents.Floor) component).Construction;
                            this.Dereference(construction.Type);
                            continue;
                        }
                        if (component is ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorHeaderComponents.FloorHeader)
                        {
                            FloorHeaderConstruction construction = ((ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorHeaderComponents.FloorHeader) component).Construction;
                            this.Dereference(construction.Type);
                            continue;
                        }
                        if (component is ca.nrcan.gc.OEE.HouseFileLibrary.Components.WallComponents.Wall)
                        {
                            WallConstruction construction = ((ca.nrcan.gc.OEE.HouseFileLibrary.Components.WallComponents.Wall) component).Construction;
                            this.Dereference(construction.Type);
                            this.Dereference(construction.LintelType);
                            continue;
                        }
                        if (component is ca.nrcan.gc.OEE.HouseFileLibrary.Components.WindowComponents.Window)
                        {
                            WindowConstruction construction = ((ca.nrcan.gc.OEE.HouseFileLibrary.Components.WindowComponents.Window) component).Construction;
                            this.Dereference(construction.Type);
                        }
                    }
                    break;
                }
            }
        }

        public bool IsInFavorite(Code toFind) => 
            !(toFind is UserDefined) && this.AllFavorite.Contains<Code>(toFind);

        public bool IsInFavorite(string codeIdToFind) => 
            (from ud in this.AllFavorite
                where ud.Id == codeIdToFind
                select ud).SingleOrDefault<Standard>() != null;

        public bool IsInStandard(Code toFind) => 
            !(toFind is UserDefined) && this.AllStandard.Contains<Code>(toFind);

        public bool IsInStandard(string codeIdToFind) => 
            (from ud in this.AllStandard
                where ud.Id == codeIdToFind
                select ud).SingleOrDefault<Standard>() != null;

        public bool IsInUserDefined(Code toFind) => 
            (toFind is UserDefined) ? this.AllUserDefined.Contains<Code>(toFind) : false;

        public bool IsInUserDefined(string codeIdToFind) => 
            (from ud in this.AllUserDefined
                where ud.Id == codeIdToFind
                select ud).SingleOrDefault<UserDefined>() != null;

        public bool Load(Codes dataToLoad)
        {
            this.isReadOnly = dataToLoad.isReadOnly;
            this.Wall = dataToLoad.Wall;
            this.Ceiling = dataToLoad.Ceiling;
            this.CeilingFlat = dataToLoad.CeilingFlat;
            this.Floor = dataToLoad.Floor;
            this.Lintel = dataToLoad.Lintel;
            this.Window = dataToLoad.Window;
            this.FloorsAbove = dataToLoad.FloorsAbove;
            this.FloorsAdded = dataToLoad.FloorsAdded;
            this.BasementWall = dataToLoad.BasementWall;
            this.CrawlspaceWall = dataToLoad.CrawlspaceWall;
            this.FloorHeader = dataToLoad.FloorHeader;
            return true;
        }

        public bool Load(Stream codeLibraryStream) => 
            this.Load(XDocument.Load(codeLibraryStream));

        public bool Load(string codeLibraryUri) => 
            this.Load(XDocument.Load(codeLibraryUri));

        public bool Load(XDocument codeLibraryXml) => 
            this.Load(HouseFile.XmlDeserializer<Codes>(codeLibraryXml));

        public void RebuildAll(HouseFile instance)
        {
            switch (instance)
            {
                case (null):
                    break;

                default:
                {
                    this.House_ = instance;
                    CodesByType type = this.Wall;
                    CodesByType type2 = this.Ceiling;
                    CodesByType ceilingFlat = this.CeilingFlat;
                    CodesByType type4 = this.Floor;
                    CodesByType lintel = this.Lintel;
                    CodesByType type6 = this.Window;
                    CodesByType floorsAbove = this.FloorsAbove;
                    CodesByType floorsAdded = this.FloorsAdded;
                    CodesByType basementWall = this.BasementWall;
                    CodesByType crawlspaceWall = this.CrawlspaceWall;
                    CodesByType type11 = this.FloorHeader;
                    this.Wall = new CodesByType(true);
                    this.Ceiling = new CodesByType(true);
                    this.CeilingFlat = new CodesByType(true);
                    this.Floor = new CodesByType(true);
                    this.Lintel = new CodesByType(true);
                    this.Window = new CodesByType(true);
                    this.FloorsAbove = new CodesByType(true);
                    this.FloorsAdded = new CodesByType(true);
                    this.BasementWall = new CodesByType(true);
                    this.CrawlspaceWall = new CodesByType(true);
                    this.FloorHeader = new CodesByType(true);
                    this.NextId = 1;
                    List<BaseComponent> houseComponents = this.House_.HouseComponents;
                    if ((this.House_.EnergyUpgrades != null) && (this.House_.EnergyUpgrades.Components.Count > 0))
                    {
                        houseComponents.AddRange(this.House_.EnergyUpgrades.Components);
                    }
                    foreach (BaseComponent component in houseComponents)
                    {
                        if ((component is Basement) || (component is Walkout))
                        {
                            FoundationFloorConstruction floor = (component is Basement) ? ((Basement) component).Floor.Construction : ((Walkout) component).Floor.Construction;
                            bool flag = ((floorsAbove != null) && (floorsAbove.Favorite != null)) && ((from c in floorsAbove.Favorite
                                where c.Value == floor.FloorsAbove.Code
                                select c).FirstOrDefault<Standard>() != null);
                            this.UpdateCodeReference(floor.FloorsAbove, this.FloorsAbove, flag);
                            if (floor.AddedToSlab != null)
                            {
                                flag = ((floorsAdded != null) && (floorsAdded.Favorite != null)) && ((from c in floorsAdded.Favorite
                                    where c.Value == floor.AddedToSlab.Code
                                    select c).FirstOrDefault<Standard>() != null);
                                this.UpdateCodeReference(floor.AddedToSlab, this.FloorsAdded, flag);
                            }
                            FoundationWallConstruction wall = (component is Basement) ? ((Basement) component).Wall.Construction : ((Walkout) component).Wall.Construction;
                            flag = ((basementWall != null) && (basementWall.Favorite != null)) && ((from c in basementWall.Favorite
                                where c.Value == wall.InteriorAddedInsulation.Code
                                select c).FirstOrDefault<Standard>() != null);
                            this.UpdateCodeReference(wall.InteriorAddedInsulation, this.BasementWall, flag);
                            if ((wall.Lintels != null) && (wall.Lintels.Code != "N/A"))
                            {
                                flag = ((lintel != null) && (lintel.Favorite != null)) && ((from c in lintel.Favorite
                                    where c.Value == wall.Lintels.Code
                                    select c).FirstOrDefault<Standard>() != null);
                                this.UpdateCodeReference(wall.Lintels, this.Lintel, flag);
                            }
                            if (wall.PonyWallType != null)
                            {
                                flag = ((crawlspaceWall != null) && (crawlspaceWall.Favorite != null)) && ((from c in crawlspaceWall.Favorite
                                    where c.Value == wall.PonyWallType.Code
                                    select c).FirstOrDefault<Standard>() != null);
                                this.UpdateCodeReference(wall.PonyWallType, this.CrawlspaceWall, flag);
                            }
                            continue;
                        }
                        if (component is Crawlspace)
                        {
                            FoundationFloorConstruction construction1 = ((Crawlspace) component).Floor.Construction;
                            bool flag2 = ((floorsAbove != null) && (floorsAbove.Favorite != null)) && ((from c in floorsAbove.Favorite
                                where c.Value == construction1.FloorsAbove.Code
                                select c).FirstOrDefault<Standard>() != null);
                            this.UpdateCodeReference(construction1.FloorsAbove, this.FloorsAbove, flag2);
                            if (construction1.AddedToSlab != null)
                            {
                                flag2 = ((floorsAdded != null) && (floorsAdded.Favorite != null)) && ((from c in floorsAdded.Favorite
                                    where c.Value == construction1.AddedToSlab.Code
                                    select c).FirstOrDefault<Standard>() != null);
                                this.UpdateCodeReference(construction1.AddedToSlab, this.FloorsAdded, flag2);
                            }
                            CrawlspaceWallConstruction construction2 = ((Crawlspace) component).Wall.Construction;
                            if (construction2 != null)
                            {
                                flag2 = ((crawlspaceWall != null) && (crawlspaceWall.Favorite != null)) && ((from c in crawlspaceWall.Favorite
                                    where c.Value == construction2.Type.Code
                                    select c).FirstOrDefault<Standard>() != null);
                                this.UpdateCodeReference(construction2.Type, this.CrawlspaceWall, flag2);
                                if ((construction2.Lintels != null) && (construction2.Lintels.Code != "N/A"))
                                {
                                    flag2 = ((lintel != null) && (lintel.Favorite != null)) && ((from c in lintel.Favorite
                                        where c.Value == construction2.Lintels.Code
                                        select c).FirstOrDefault<Standard>() != null);
                                    this.UpdateCodeReference(construction2.Lintels, this.Lintel, flag2);
                                }
                            }
                            continue;
                        }
                        if (component is Slab)
                        {
                            FoundationFloorConstruction construction3 = ((Slab) component).Floor.Construction;
                            if (construction3.AddedToSlab == null)
                            {
                                continue;
                            }
                            bool flag3 = ((floorsAdded != null) && (floorsAdded.Favorite != null)) && ((from c in floorsAdded.Favorite
                                where c.Value == construction3.AddedToSlab.Code
                                select c).FirstOrDefault<Standard>() != null);
                            this.UpdateCodeReference(construction3.AddedToSlab, this.FloorsAdded, flag3);
                            continue;
                        }
                        if (component is ca.nrcan.gc.OEE.HouseFileLibrary.Components.CeilingComponents.Ceiling)
                        {
                            CeilingConstruction ceiling = ((ca.nrcan.gc.OEE.HouseFileLibrary.Components.CeilingComponents.Ceiling) component).Construction;
                            bool flag4 = (ceiling.Type == CeilingTypes.Cathedral) || (ceiling.Type == CeilingTypes.Flat);
                            CodesByType type12 = flag4 ? ceilingFlat : type2;
                            bool flag5 = ((type12 != null) && (type12.Favorite != null)) && ((from c in type12.Favorite
                                where c.Value == ceiling.CeilingType.Code
                                select c).FirstOrDefault<Standard>() != null);
                            this.UpdateCodeReference(ceiling.CeilingType, flag4 ? this.CeilingFlat : this.Ceiling, flag5);
                            continue;
                        }
                        if (component is ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorComponents.Floor)
                        {
                            FloorConstruction construction4 = ((ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorComponents.Floor) component).Construction;
                            bool flag6 = ((type4 != null) && (type4.Favorite != null)) && ((from c in type4.Favorite
                                where c.Value == construction4.Type.Code
                                select c).FirstOrDefault<Standard>() != null);
                            this.UpdateCodeReference(construction4.Type, this.Floor, flag6);
                            continue;
                        }
                        if (component is ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorHeaderComponents.FloorHeader)
                        {
                            FloorHeaderConstruction floorHeader = ((ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorHeaderComponents.FloorHeader) component).Construction;
                            bool flag7 = ((type11 != null) && (type11.Favorite != null)) && ((from c in type11.Favorite
                                where c.Value == floorHeader.Type.Code
                                select c).FirstOrDefault<Standard>() != null);
                            this.UpdateCodeReference(floorHeader.Type, this.FloorHeader, flag7);
                            continue;
                        }
                        if (!(component is ca.nrcan.gc.OEE.HouseFileLibrary.Components.WallComponents.Wall))
                        {
                            if (!(component is ca.nrcan.gc.OEE.HouseFileLibrary.Components.WindowComponents.Window))
                            {
                                continue;
                            }
                            WindowConstruction window = ((ca.nrcan.gc.OEE.HouseFileLibrary.Components.WindowComponents.Window) component).Construction;
                            bool flag9 = ((type6 != null) && (type6.Favorite != null)) && ((from c in type6.Favorite
                                where c.Value == window.Type.Code
                                select c).FirstOrDefault<Standard>() != null);
                            this.UpdateCodeReference(window.Type, this.Window, flag9);
                            continue;
                        }
                        WallConstruction construction5 = ((ca.nrcan.gc.OEE.HouseFileLibrary.Components.WallComponents.Wall) component).Construction;
                        bool isFavorite = ((type != null) && (type.Favorite != null)) && ((from c in type.Favorite
                            where c.Value == construction5.Type.Code
                            select c).FirstOrDefault<Standard>() != null);
                        this.UpdateCodeReference(construction5.Type, this.Wall, isFavorite);
                        if (construction5.LintelType != null)
                        {
                            isFavorite = ((lintel != null) && (lintel.Favorite != null)) && ((from c in lintel.Favorite
                                where c.Value == construction5.LintelType.Code
                                select c).FirstOrDefault<Standard>() != null);
                            this.UpdateCodeReference(construction5.LintelType, this.Lintel, isFavorite);
                        }
                    }
                    this.Wall.NullEmptyLists();
                    if (this.Wall.AllListsAreEmpty)
                    {
                        this.Wall = null;
                    }
                    this.Ceiling.NullEmptyLists();
                    if (this.Ceiling.AllListsAreEmpty)
                    {
                        this.Ceiling = null;
                    }
                    this.CeilingFlat.NullEmptyLists();
                    if (this.CeilingFlat.AllListsAreEmpty)
                    {
                        this.CeilingFlat = null;
                    }
                    this.Floor.NullEmptyLists();
                    if (this.Floor.AllListsAreEmpty)
                    {
                        this.Floor = null;
                    }
                    this.Lintel.NullEmptyLists();
                    if (this.Lintel.AllListsAreEmpty)
                    {
                        this.Lintel = null;
                    }
                    this.Window.NullEmptyLists();
                    if (this.Window.AllListsAreEmpty)
                    {
                        this.Window = null;
                    }
                    this.FloorsAbove.NullEmptyLists();
                    if (this.FloorsAbove.AllListsAreEmpty)
                    {
                        this.FloorsAbove = null;
                    }
                    this.FloorsAdded.NullEmptyLists();
                    if (this.FloorsAdded.AllListsAreEmpty)
                    {
                        this.FloorsAdded = null;
                    }
                    this.BasementWall.NullEmptyLists();
                    if (this.BasementWall.AllListsAreEmpty)
                    {
                        this.BasementWall = null;
                    }
                    this.CrawlspaceWall.NullEmptyLists();
                    if (this.CrawlspaceWall.AllListsAreEmpty)
                    {
                        this.CrawlspaceWall = null;
                    }
                    this.FloorHeader.NullEmptyLists();
                    if (this.FloorHeader.AllListsAreEmpty)
                    {
                        this.FloorHeader = null;
                    }
                    break;
                }
            }
        }

        public bool Save(string filename)
        {
            XmlTextWriter writer = new XmlTextWriter(filename, Encoding.UTF8) {
                Formatting = Formatting.Indented
            };
            try
            {
                this.ToXml().WriteTo(writer);
            }
            catch (Exception exception)
            {
                HouseFile.Errors.Add(HouseFileError.CreateErrorFromException(exception));
                return false;
            }
            finally
            {
                writer.Close();
            }
            return true;
        }

        public XDocument ToXml()
        {
            XDocument document1 = new XDocument(new XDeclaration("1.0", "utf-8", null), Array.Empty<object>());
            document1.Add(HouseFile.XmlSerializer<Codes>(this));
            return document1;
        }

        private void UpdateCodeReference(CodeDescriptionAndComposite toUpdate, CodesByType parentList, bool isFavorite = false)
        {
            if (toUpdate != null)
            {
                toUpdate.IdRef = null;
                Code code = null;
                if (!string.IsNullOrWhiteSpace(toUpdate.Code) && (toUpdate.Code.Length == 1))
                {
                    toUpdate.UserDefinedCodeLayers = null;
                }
                if ((toUpdate.UserDefinedCodeLayers != null) && (toUpdate.UserDefinedCodeLayers.Count > 0))
                {
                    code = new UserDefined();
                    foreach (UserDefinedLayer layer in toUpdate.UserDefinedCodeLayers)
                    {
                        ((UserDefined) code).Layers.Add(layer.Clone());
                    }
                    parentList.UserDefined.Add((UserDefined) code);
                }
                else if (!string.IsNullOrWhiteSpace(toUpdate.Code) && (toUpdate.Code.Length > 1))
                {
                    List<Standard> list = isFavorite ? parentList.Favorite : parentList.Standard;
                    Code code2 = (list == null) ? null : ((Code) (from c in list
                        where c.Value == toUpdate.Code
                        select c).FirstOrDefault<Standard>());
                    if (code2 != null)
                    {
                        toUpdate.IdRef = code2.Id;
                    }
                    else
                    {
                        code = new Standard();
                        ((Standard) code).Value = toUpdate.Code;
                        list.Add((Standard) code);
                    }
                }
                if (code != null)
                {
                    uint nextId = this.NextId;
                    this.NextId = nextId + 1;
                    code.Id = $"Code {nextId}";
                    code.Label = toUpdate.Description;
                    code.Description = toUpdate.Description;
                    code.NominalRValue = toUpdate.NominalInsulation;
                    toUpdate.IdRef = code.Id;
                }
            }
        }

        private void UpdateCodeReference(CodeReference toUpdate, CodesByType parentList, bool isFavorite = false)
        {
            if (toUpdate != null)
            {
                toUpdate.IdRef = null;
                Code code = null;
                if (!string.IsNullOrWhiteSpace(toUpdate.Code) && (toUpdate.Code.Length == 1))
                {
                    toUpdate.UserDefinedCodeLayers = null;
                }
                if ((toUpdate.UserDefinedCodeLayers != null) && (toUpdate.UserDefinedCodeLayers.Count > 0))
                {
                    code = new UserDefined();
                    foreach (UserDefinedLayer layer in toUpdate.UserDefinedCodeLayers)
                    {
                        ((UserDefined) code).Layers.Add(layer.Clone());
                    }
                    parentList.UserDefined.Add((UserDefined) code);
                }
                else if (!string.IsNullOrWhiteSpace(toUpdate.Code) && (toUpdate.Code.Length > 1))
                {
                    List<Standard> list = isFavorite ? parentList.Favorite : parentList.Standard;
                    Code code2 = (list == null) ? null : ((Code) (from c in list
                        where c.Value == toUpdate.Code
                        select c).FirstOrDefault<Standard>());
                    if (code2 != null)
                    {
                        toUpdate.IdRef = code2.Id;
                    }
                    else
                    {
                        code = new Standard();
                        ((Standard) code).Value = toUpdate.Code;
                        list.Add((Standard) code);
                    }
                }
                if (code != null)
                {
                    uint nextId = this.NextId;
                    this.NextId = nextId + 1;
                    code.Id = $"Code {nextId}";
                    code.Label = toUpdate.Text;
                    code.Description = toUpdate.Text;
                    code.NominalRValue = toUpdate.RValue;
                    toUpdate.IdRef = code.Id;
                }
            }
        }

        [XmlIgnore]
        public List<Code> AllCodes
        {
            get
            {
                List<Code> list = new List<Code>();
                if (this.Wall != null)
                {
                    list.AddRange(this.Wall.AllCodes);
                }
                if (this.Ceiling != null)
                {
                    list.AddRange(this.Ceiling.AllCodes);
                }
                if (this.CeilingFlat != null)
                {
                    list.AddRange(this.CeilingFlat.AllCodes);
                }
                if (this.Floor != null)
                {
                    list.AddRange(this.Floor.AllCodes);
                }
                if (this.Lintel != null)
                {
                    list.AddRange(this.Lintel.AllCodes);
                }
                if (this.Window != null)
                {
                    list.AddRange(this.Window.AllCodes);
                }
                if (this.FloorsAbove != null)
                {
                    list.AddRange(this.FloorsAbove.AllCodes);
                }
                if (this.FloorsAdded != null)
                {
                    list.AddRange(this.FloorsAdded.AllCodes);
                }
                if (this.BasementWall != null)
                {
                    list.AddRange(this.BasementWall.AllCodes);
                }
                if (this.CrawlspaceWall != null)
                {
                    list.AddRange(this.CrawlspaceWall.AllCodes);
                }
                if (this.FloorHeader != null)
                {
                    list.AddRange(this.FloorHeader.AllCodes);
                }
                return list;
            }
        }

        [XmlIgnore]
        public List<Standard> AllFavorite
        {
            get
            {
                List<Standard> list = new List<Standard>();
                if ((this.Wall != null) && (this.Wall.Favorite != null))
                {
                    list.AddRange(this.Wall.Favorite);
                }
                if ((this.Ceiling != null) && (this.Ceiling.Favorite != null))
                {
                    list.AddRange(this.Ceiling.Favorite);
                }
                if ((this.CeilingFlat != null) && (this.CeilingFlat.Favorite != null))
                {
                    list.AddRange(this.CeilingFlat.Favorite);
                }
                if ((this.Floor != null) && (this.Floor.Favorite != null))
                {
                    list.AddRange(this.Floor.Favorite);
                }
                if ((this.Lintel != null) && (this.Lintel.Favorite != null))
                {
                    list.AddRange(this.Lintel.Favorite);
                }
                if ((this.Window != null) && (this.Window.Favorite != null))
                {
                    list.AddRange(this.Window.Favorite);
                }
                if ((this.FloorsAbove != null) && (this.FloorsAbove.Favorite != null))
                {
                    list.AddRange(this.FloorsAbove.Favorite);
                }
                if ((this.FloorsAdded != null) && (this.FloorsAdded.Favorite != null))
                {
                    list.AddRange(this.FloorsAdded.Favorite);
                }
                if ((this.BasementWall != null) && (this.BasementWall.Favorite != null))
                {
                    list.AddRange(this.BasementWall.Favorite);
                }
                if ((this.CrawlspaceWall != null) && (this.CrawlspaceWall.Favorite != null))
                {
                    list.AddRange(this.CrawlspaceWall.Favorite);
                }
                if ((this.FloorHeader != null) && (this.FloorHeader.Favorite != null))
                {
                    list.AddRange(this.FloorHeader.Favorite);
                }
                return list;
            }
        }

        [XmlIgnore]
        public List<Standard> AllStandard
        {
            get
            {
                List<Standard> list = new List<Standard>();
                if ((this.Wall != null) && (this.Wall.Standard != null))
                {
                    list.AddRange(this.Wall.Standard);
                }
                if ((this.Ceiling != null) && (this.Ceiling.Standard != null))
                {
                    list.AddRange(this.Ceiling.Standard);
                }
                if ((this.CeilingFlat != null) && (this.CeilingFlat.Standard != null))
                {
                    list.AddRange(this.CeilingFlat.Standard);
                }
                if ((this.Floor != null) && (this.Floor.Standard != null))
                {
                    list.AddRange(this.Floor.Standard);
                }
                if ((this.Lintel != null) && (this.Lintel.Standard != null))
                {
                    list.AddRange(this.Lintel.Standard);
                }
                if ((this.Window != null) && (this.Window.Standard != null))
                {
                    list.AddRange(this.Window.Standard);
                }
                if ((this.FloorsAbove != null) && (this.FloorsAbove.Standard != null))
                {
                    list.AddRange(this.FloorsAbove.Standard);
                }
                if ((this.FloorsAdded != null) && (this.FloorsAdded.Standard != null))
                {
                    list.AddRange(this.FloorsAdded.Standard);
                }
                if ((this.BasementWall != null) && (this.BasementWall.Standard != null))
                {
                    list.AddRange(this.BasementWall.Standard);
                }
                if ((this.CrawlspaceWall != null) && (this.CrawlspaceWall.Standard != null))
                {
                    list.AddRange(this.CrawlspaceWall.Standard);
                }
                if ((this.FloorHeader != null) && (this.FloorHeader.Standard != null))
                {
                    list.AddRange(this.FloorHeader.Standard);
                }
                return list;
            }
        }

        [XmlIgnore]
        public List<UserDefined> AllUserDefined
        {
            get
            {
                List<UserDefined> list = new List<UserDefined>();
                if ((this.Wall != null) && (this.Wall.UserDefined != null))
                {
                    list.AddRange(this.Wall.UserDefined);
                }
                if ((this.Ceiling != null) && (this.Ceiling.UserDefined != null))
                {
                    list.AddRange(this.Ceiling.UserDefined);
                }
                if ((this.CeilingFlat != null) && (this.CeilingFlat.UserDefined != null))
                {
                    list.AddRange(this.CeilingFlat.UserDefined);
                }
                if ((this.Floor != null) && (this.Floor.UserDefined != null))
                {
                    list.AddRange(this.Floor.UserDefined);
                }
                if ((this.Lintel != null) && (this.Lintel.UserDefined != null))
                {
                    list.AddRange(this.Lintel.UserDefined);
                }
                if ((this.Window != null) && (this.Window.UserDefined != null))
                {
                    list.AddRange(this.Window.UserDefined);
                }
                if ((this.FloorsAbove != null) && (this.FloorsAbove.UserDefined != null))
                {
                    list.AddRange(this.FloorsAbove.UserDefined);
                }
                if ((this.FloorsAdded != null) && (this.FloorsAdded.UserDefined != null))
                {
                    list.AddRange(this.FloorsAdded.UserDefined);
                }
                if ((this.BasementWall != null) && (this.BasementWall.UserDefined != null))
                {
                    list.AddRange(this.BasementWall.UserDefined);
                }
                if ((this.CrawlspaceWall != null) && (this.CrawlspaceWall.UserDefined != null))
                {
                    list.AddRange(this.CrawlspaceWall.UserDefined);
                }
                if ((this.FloorHeader != null) && (this.FloorHeader.UserDefined != null))
                {
                    list.AddRange(this.FloorHeader.UserDefined);
                }
                return list;
            }
        }

        [XmlIgnore]
        public static CodesSerializer Serializer
        {
            get
            {
                cachedSerializer = new CodesSerializer();
                return cachedSerializer;
            }
        }
    }
}

