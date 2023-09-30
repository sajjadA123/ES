namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct RemoteCommunity
    {
        private string Name_;
        private ProvinceOrTerritory Location_;
        private static List<RemoteCommunity> CERRC_;
        public RemoteCommunity(string CombinedName, string ProvinceOrTerritoryCode)
        {
            this.Name_ = CombinedName.Trim();
            this.Location_ = ProvinceOrTerritory.GetByCode(ProvinceOrTerritoryCode);
        }

        public RemoteCommunity(string Name, string AlternativeName, string ProvinceOrTerritoryCode)
        {
            this.Name_ = Name.Trim() + "; " + AlternativeName.Trim();
            this.Location_ = ProvinceOrTerritory.GetByCode(ProvinceOrTerritoryCode);
        }

        public string Name =>
            this.Name_;
        public ProvinceOrTerritory Location =>
            this.Location_;
        public static List<RemoteCommunity> CERRC
        {
            get
            {
                if (CERRC_ == null)
                {
                    PopulateCERRC();
                }
                return CERRC_;
            }
        }
        public static string[] CERRCByProvinceOrTerritory(ProvinceOrTerritory Filter)
        {
            Func<RemoteCommunity, string> selector = _c._9__11_1;
            if (_c._9__11_1 == null)
            {
                Func<RemoteCommunity, string> local1 = _c._9__11_1;
                selector = _c._9__11_1 = rc => rc.Name;
            }
            return (from rc in CERRC
                where rc.Location == Filter
                select rc).Select<RemoteCommunity, string>(selector).ToArray<string>();
        }

        public static string[] CERRCAll()
        {
            Func<RemoteCommunity, string> selector = _c._9__12_0;
            if (_c._9__12_0 == null)
            {
                Func<RemoteCommunity, string> local1 = _c._9__12_0;
                selector = _c._9__12_0 = rc => rc.Name;
            }
            return CERRC.Select<RemoteCommunity, string>(selector).ToArray<string>();
        }

        private static void PopulateCERRC()
        {
            if (CERRC_ == null)
            {
                CERRC_ = new List<RemoteCommunity>();
                CERRC_.Add(new RemoteCommunity("Les \x00celes-de-la-Madeleine; Magdalen Islands", "QC"));
                CERRC_.Add(new RemoteCommunity("Ocean Falls", "BC"));
                CERRC_.Add(new RemoteCommunity("Whitehorse 8", "YT"));
                CERRC_.Add(new RemoteCommunity("Bella Bella; Bella Bella 1", "BC"));
                CERRC_.Add(new RemoteCommunity("Wagisla", "BC"));
                CERRC_.Add(new RemoteCommunity("Shearwater", "BC"));
                CERRC_.Add(new RemoteCommunity("Bella Coola; Bella Coola 1", "BC"));
                CERRC_.Add(new RemoteCommunity("Firvale", "BC"));
                CERRC_.Add(new RemoteCommunity("Hagensborg", "BC"));
                CERRC_.Add(new RemoteCommunity("Masset; Old Masset", "BC"));
                CERRC_.Add(new RemoteCommunity("Old Masset; Masset 1", "BC"));
                CERRC_.Add(new RemoteCommunity("Port Clements", "BC"));
                CERRC_.Add(new RemoteCommunity("Queen Charlotte; Queen Charlotte City", "BC"));
                CERRC_.Add(new RemoteCommunity("Sandspit", "BC"));
                CERRC_.Add(new RemoteCommunity("Skidegate Landing", "BC"));
                CERRC_.Add(new RemoteCommunity("Tlell", "BC"));
                CERRC_.Add(new RemoteCommunity("Anahim Lake; Ulkatcho 14A", "BC"));
                CERRC_.Add(new RemoteCommunity("Atlin", "BC"));
                CERRC_.Add(new RemoteCommunity("Da'naxda'xw First Nation; Da'naxda'xw; Awaetlala; Sim Creek; Dead Point 5", "BC"));
                CERRC_.Add(new RemoteCommunity("Dease Lake", "BC"));
                CERRC_.Add(new RemoteCommunity("Quaee 7; Tsawataineuk", "BC"));
                CERRC_.Add(new RemoteCommunity("Kwadacha; Fort Ware; Fort Ware 1", "BC"));
                CERRC_.Add(new RemoteCommunity("Good Hope Lake; Dease River", "BC"));
                CERRC_.Add(new RemoteCommunity("Jade City", "BC"));
                CERRC_.Add(new RemoteCommunity("Gwawaenuk; Kwa-wa-aineuk; Hopetown; Hopetown 10A", "BC"));
                CERRC_.Add(new RemoteCommunity("Kulkayu; Gitga’at; Hartley Bay", "BC"));
                CERRC_.Add(new RemoteCommunity("Hesquiaht; Refuge Cove 6; Hesquiaht", "BC"));
                CERRC_.Add(new RemoteCommunity("Klemtu; Kitasoo", "BC"));
                CERRC_.Add(new RemoteCommunity("Kwikwasut'inuxw Haxwa'mis; Gwayasdums; Gwayasdums 1", "BC"));
                CERRC_.Add(new RemoteCommunity("Kluskus; Lhoosk' uz Dene Nation", "BC"));
                CERRC_.Add(new RemoteCommunity("Liard First Nation; Liard River 3; Lower Post 3", "BC"));
                CERRC_.Add(new RemoteCommunity("Owikeno; Katit 1; Oweekeno; Rivers Inlet", "BC"));
                CERRC_.Add(new RemoteCommunity("Telegraph Creek; Tahltan Nation", "BC"));
                CERRC_.Add(new RemoteCommunity("Tlatlasikwala; Bull Harbour; Hope Island 1", "BC"));
                CERRC_.Add(new RemoteCommunity("Toad River Area", "BC"));
                CERRC_.Add(new RemoteCommunity("Tsay Keh Dene; Finlay River", "BC"));
                CERRC_.Add(new RemoteCommunity("Uchucklesaht; Elhlateese; Elhlateese 2", "BC"));
                CERRC_.Add(new RemoteCommunity("Xeni Gwet'in First Nation; Nemiah Valley; Chilco Lake; Lohbiee", "BC"));
                CERRC_.Add(new RemoteCommunity("Sechelt Creek", "BC"));
                CERRC_.Add(new RemoteCommunity("Seymour Inlet", "BC"));
                CERRC_.Add(new RemoteCommunity("Sheemahantt Conservancy", "BC"));
                CERRC_.Add(new RemoteCommunity("Timfor", "BC"));
                CERRC_.Add(new RemoteCommunity("Knight Inlet", "BC"));
                CERRC_.Add(new RemoteCommunity("Narrows Inlet Logging Div", "BC"));
                CERRC_.Add(new RemoteCommunity("Quatam River", "BC"));
                CERRC_.Add(new RemoteCommunity("Scott Cove", "BC"));
                CERRC_.Add(new RemoteCommunity("Cleagh Creek", "BC"));
                CERRC_.Add(new RemoteCommunity("Drury Inlet", "BC"));
                CERRC_.Add(new RemoteCommunity("Machmell; Machmell River", "BC"));
                CERRC_.Add(new RemoteCommunity("Mooyah Bay; Mooya Bay", "BC"));
                CERRC_.Add(new RemoteCommunity("Moses Inlet", "BC"));
                CERRC_.Add(new RemoteCommunity("Phillips Arm", "BC"));
                CERRC_.Add(new RemoteCommunity("Pitt Lake", "BC"));
                CERRC_.Add(new RemoteCommunity("Gilford Island; Gwa’yas’dums; Gwayadums 1", "BC"));
                CERRC_.Add(new RemoteCommunity("Kingcome Inlet", "BC"));
                CERRC_.Add(new RemoteCommunity("Kitkatla; Kitkatlah", "BC"));
                CERRC_.Add(new RemoteCommunity("Queens Cove", "BC"));
                CERRC_.Add(new RemoteCommunity("Nuchatlaht; Nuchatlitz; Oclucje; Oclucje 7", "BC"));
                CERRC_.Add(new RemoteCommunity("Tide Lake", "BC"));
                CERRC_.Add(new RemoteCommunity("Myra Falls; Western Mines at Myra Falls", "BC"));
                CERRC_.Add(new RemoteCommunity("Table Mountain Gold Project; Erickson Gold Mine Village", "BC"));
                CERRC_.Add(new RemoteCommunity("Big Bar; Jesmond Creek", "BC"));
                CERRC_.Add(new RemoteCommunity("Bob Quinn Lake", "BC"));
                CERRC_.Add(new RemoteCommunity("Boulder Bay", "BC"));
                CERRC_.Add(new RemoteCommunity("Germansen Landing", "BC"));
                CERRC_.Add(new RemoteCommunity("Stave Lake", "BC"));
                CERRC_.Add(new RemoteCommunity("Lasqueti Island; Lasqueti Island Trust Area", "BC"));
                CERRC_.Add(new RemoteCommunity("Savary Island", "BC"));
                CERRC_.Add(new RemoteCommunity("Seymour Arm", "BC"));
                CERRC_.Add(new RemoteCommunity("Eastgate", "BC"));
                CERRC_.Add(new RemoteCommunity("Longworth", "BC"));
                CERRC_.Add(new RemoteCommunity("Lower Post; Fort Liard", "BC"));
                CERRC_.Add(new RemoteCommunity("Penny", "BC"));
                CERRC_.Add(new RemoteCommunity("Dome Creek", "BC"));
                CERRC_.Add(new RemoteCommunity("Crescent Spur", "BC"));
                CERRC_.Add(new RemoteCommunity("Meziadin Lake; Meziadin Junction; Meziadin Subdivision", "BC"));
                CERRC_.Add(new RemoteCommunity("Dease River 4; Good Hope Lake", "BC"));
                CERRC_.Add(new RemoteCommunity("Beaver Creek", "YT"));
                CERRC_.Add(new RemoteCommunity("Burwash Landing", "YT"));
                CERRC_.Add(new RemoteCommunity("Destruction Bay", "YT"));
                CERRC_.Add(new RemoteCommunity("Old Crow", "YT"));
                CERRC_.Add(new RemoteCommunity("Watson Lake", "YT"));
                CERRC_.Add(new RemoteCommunity("Carmacks", "YT"));
                CERRC_.Add(new RemoteCommunity("Carcross", "YT"));
                CERRC_.Add(new RemoteCommunity("Champagne; Champagne Landing", "YT"));
                CERRC_.Add(new RemoteCommunity("Dawson; Dawson City", "YT"));
                CERRC_.Add(new RemoteCommunity("Faro", "YT"));
                CERRC_.Add(new RemoteCommunity("Haines Junction", "YT"));
                CERRC_.Add(new RemoteCommunity("Johnsons Crossing", "YT"));
                CERRC_.Add(new RemoteCommunity("Keno; Keno Hill", "YT"));
                CERRC_.Add(new RemoteCommunity("Marsh Lake", "YT"));
                CERRC_.Add(new RemoteCommunity("Mayo; Mayo 6", "YT"));
                CERRC_.Add(new RemoteCommunity("Pelly Crossing", "YT"));
                CERRC_.Add(new RemoteCommunity("Ross River", "YT"));
                CERRC_.Add(new RemoteCommunity("Stewart Crossing", "YT"));
                CERRC_.Add(new RemoteCommunity("Tagish and Marsh Lake; Tagish", "YT"));
                CERRC_.Add(new RemoteCommunity("Teslin; Teslin Post 13", "YT"));
                CERRC_.Add(new RemoteCommunity("Whitehorse", "YT"));
                CERRC_.Add(new RemoteCommunity("Chipewyan Lake", "AB"));
                CERRC_.Add(new RemoteCommunity("Fort Chipewyan", "AB"));
                CERRC_.Add(new RemoteCommunity("Steen River", "AB"));
                CERRC_.Add(new RemoteCommunity("Jasper; Jasper National Park", "AB"));
                CERRC_.Add(new RemoteCommunity("Indian Cabins", "AB"));
                CERRC_.Add(new RemoteCommunity("Peace Point; Peace Point 222", "AB"));
                CERRC_.Add(new RemoteCommunity("Narrows Point", "AB"));
                CERRC_.Add(new RemoteCommunity("Coral Harbour; Salliq; Salliit", "NU"));
                CERRC_.Add(new RemoteCommunity("Arviat; Eskimo Point", "NU"));
                CERRC_.Add(new RemoteCommunity("Naujaat; Repulse Bay", "NU"));
                CERRC_.Add(new RemoteCommunity("Baker Lake; Qamani'tuaq", "NU"));
                CERRC_.Add(new RemoteCommunity("Chesterfield Inlet; Igluligaarjuk", "NU"));
                CERRC_.Add(new RemoteCommunity("Rankin Inlet; Kangiqliniq; Kangirliniq", "NU"));
                CERRC_.Add(new RemoteCommunity("Whale Cove; Tikiraqjuaq", "NU"));
                CERRC_.Add(new RemoteCommunity("Hall Beach; Sanirajak", "NU"));
                CERRC_.Add(new RemoteCommunity("Kimmirut; Lake Harbour", "NU"));
                CERRC_.Add(new RemoteCommunity("Arctic Bay; Ikpiarjuk", "NU"));
                CERRC_.Add(new RemoteCommunity("Resolute; Resolute Bay", "NU"));
                CERRC_.Add(new RemoteCommunity("Iqaluit; Frobisher Bay", "NU"));
                CERRC_.Add(new RemoteCommunity("Cape Dorset; Kinngait", "NU"));
                CERRC_.Add(new RemoteCommunity("Grise Fiord; Aujuittuq", "NU"));
                CERRC_.Add(new RemoteCommunity("Igloolik", "NU"));
                CERRC_.Add(new RemoteCommunity("Pangnirtung", "NU"));
                CERRC_.Add(new RemoteCommunity("Sanikiluaq", "NU"));
                CERRC_.Add(new RemoteCommunity("Qikiqtarjuaq; Broughton Island", "NU"));
                CERRC_.Add(new RemoteCommunity("Clyde River; Kanngiqtugaapik", "NU"));
                CERRC_.Add(new RemoteCommunity("Pond Inlet; Mittimatalik", "NU"));
                CERRC_.Add(new RemoteCommunity("Kugaaruk; Pelly Bay; Arviligjuaq", "NU"));
                CERRC_.Add(new RemoteCommunity("Taloyoak; Spence Bay", "NU"));
                CERRC_.Add(new RemoteCommunity("Kugluktuk; Coppermine; Qurluktuk", "NU"));
                CERRC_.Add(new RemoteCommunity("Cambridge Bay; Iqaluktuuttiaq", "NU"));
                CERRC_.Add(new RemoteCommunity("Gjoa Haven; Uqsuqtuuq", "NU"));
                CERRC_.Add(new RemoteCommunity("Mary River Iron Ore Project", "NU"));
                CERRC_.Add(new RemoteCommunity("Hope Bay Gold Mine", "NU"));
                CERRC_.Add(new RemoteCommunity("Meadowbank Gold Mine", "NU"));
                CERRC_.Add(new RemoteCommunity("Blanc-Sablon", "QC"));
                CERRC_.Add(new RemoteCommunity("Bradore-Bay; Brador Bay", "QC"));
                CERRC_.Add(new RemoteCommunity("Chevery; Netagamu River", "QC"));
                CERRC_.Add(new RemoteCommunity("Harrington Harbour", "QC"));
                CERRC_.Add(new RemoteCommunity("La Tabati\x00e8re; Gros-M\x00e9catina", "QC"));
                CERRC_.Add(new RemoteCommunity("T\x00eate-\x00e0-la-Baleine", "QC"));
                CERRC_.Add(new RemoteCommunity("Mutton Bay; Baie-des-Moutons", "QC"));
                CERRC_.Add(new RemoteCommunity("Lourdes-de-Blanc-Sablon", "QC"));
                CERRC_.Add(new RemoteCommunity("Middle Bay; Bonne-Esp\x00e9rance", "QC"));
                CERRC_.Add(new RemoteCommunity("Vieux-Fort; Old Fort Bay; Bonne-Esp\x00e9rance", "QC"));
                CERRC_.Add(new RemoteCommunity("Rivi\x00e8re-Saint-Paul; St. Paul's River; Bonne-Esp\x00e9rance", "QC"));
                CERRC_.Add(new RemoteCommunity("Saint-Augustin; St. Augustine", "QC"));
                CERRC_.Add(new RemoteCommunity("Clova", "QC"));
                CERRC_.Add(new RemoteCommunity("L'\x00cele d'Anticosti; Anticosti", "QC"));
                CERRC_.Add(new RemoteCommunity("Havre-Aubert; Amherst Island", "QC"));
                CERRC_.Add(new RemoteCommunity("Grosse-\x00cele", "QC"));
                CERRC_.Add(new RemoteCommunity("La Romaine; Unamen Shipu", "QC"));
                CERRC_.Add(new RemoteCommunity("Obedjiwan; Opitciwan", "QC"));
                CERRC_.Add(new RemoteCommunity("Lac-Rapide; Rapid Lake", "QC"));
                CERRC_.Add(new RemoteCommunity("Umiujaq", "QC"));
                CERRC_.Add(new RemoteCommunity("Akulivik; Cape Smith", "QC"));
                CERRC_.Add(new RemoteCommunity("Aupaluk", "QC"));
                CERRC_.Add(new RemoteCommunity("Inukjuak; Port Harrison", "QC"));
                CERRC_.Add(new RemoteCommunity("Ivujivik; C Wolstenholme", "QC"));
                CERRC_.Add(new RemoteCommunity("Kangiqsualujjuaq; George R", "QC"));
                CERRC_.Add(new RemoteCommunity("Kangiqsujuaq; Maricourt; Wakeham Bay", "QC"));
                CERRC_.Add(new RemoteCommunity("Tasiujaq; Leaf Bay", "QC"));
                CERRC_.Add(new RemoteCommunity("Puvirnituq; Puvirnituq", "QC"));
                CERRC_.Add(new RemoteCommunity("Quaqtaq", "QC"));
                CERRC_.Add(new RemoteCommunity("Salluit", "QC"));
                CERRC_.Add(new RemoteCommunity("Kangirsuk; Payne Bay", "QC"));
                CERRC_.Add(new RemoteCommunity("Kuujjuaq; Fort Chimo", "QC"));
                CERRC_.Add(new RemoteCommunity("Kuujjuarapik; Great Whale", "QC"));
                CERRC_.Add(new RemoteCommunity("Whapmagoostui", "QC"));
                CERRC_.Add(new RemoteCommunity("Schefferville; Caniapiscau", "QC"));
                CERRC_.Add(new RemoteCommunity("Matimekosh", "QC"));
                CERRC_.Add(new RemoteCommunity("Kawawachikamach", "QC"));
                CERRC_.Add(new RemoteCommunity("Raglan Mine; Kattiniq", "QC"));
                CERRC_.Add(new RemoteCommunity("Renard Diamond Mine", "QC"));
                CERRC_.Add(new RemoteCommunity("Nunavik Nickel Mine; Kattiniq", "QC"));
                CERRC_.Add(new RemoteCommunity("Kitcisakik; Grand Lac Victoria", "QC"));
                CERRC_.Add(new RemoteCommunity("Fran\x00e7ois", "NL"));
                CERRC_.Add(new RemoteCommunity("Grey River; Little River", "NL"));
                CERRC_.Add(new RemoteCommunity("Little Bay Islands", "NL"));
                CERRC_.Add(new RemoteCommunity("McCallum", "NL"));
                CERRC_.Add(new RemoteCommunity("Ramea", "NL"));
                CERRC_.Add(new RemoteCommunity("St. Brendan's", "NL"));
                CERRC_.Add(new RemoteCommunity("Charlottetown", "NL"));
                CERRC_.Add(new RemoteCommunity("L'Anse-au-Loup; Wolf Cove", "NL"));
                CERRC_.Add(new RemoteCommunity("Forteau", "NL"));
                CERRC_.Add(new RemoteCommunity("L'Anse-au-Clair", "NL"));
                CERRC_.Add(new RemoteCommunity("West St. Modeste", "NL"));
                CERRC_.Add(new RemoteCommunity("Red Bay", "NL"));
                CERRC_.Add(new RemoteCommunity("Pinware; Pied Noir", "NL"));
                CERRC_.Add(new RemoteCommunity("Norman's Bay; Norman Bay", "NL"));
                CERRC_.Add(new RemoteCommunity("Mary's Harbour", "NL"));
                CERRC_.Add(new RemoteCommunity("Lodge Bay; Ranger Lodge", "NL"));
                CERRC_.Add(new RemoteCommunity("Port Hope Simpson", "NL"));
                CERRC_.Add(new RemoteCommunity("St Lewis; Fox Harbour; Ilha de Frey Luis", "NL"));
                CERRC_.Add(new RemoteCommunity("Black Tickle; Kikkertet", "NL"));
                CERRC_.Add(new RemoteCommunity("Cartwright", "NL"));
                CERRC_.Add(new RemoteCommunity("Paradise River", "NL"));
                CERRC_.Add(new RemoteCommunity("Hopedale; Agvituk", "NL"));
                CERRC_.Add(new RemoteCommunity("Makkovik; Maquuvik", "NL"));
                CERRC_.Add(new RemoteCommunity("Nain; Nunajnguk", "NL"));
                CERRC_.Add(new RemoteCommunity("Postville; Kaipokok; Qipuqqaq", "NL"));
                CERRC_.Add(new RemoteCommunity("Rigolet; Kikiaq", "NL"));
                CERRC_.Add(new RemoteCommunity("Natuashish 2; Mushuau Innu First Nation", "NL"));
                CERRC_.Add(new RemoteCommunity("Voisey's Bay Mine", "NL"));
                CERRC_.Add(new RemoteCommunity("Kinoosao; Thomas Clark 204", "SK"));
                CERRC_.Add(new RemoteCommunity("Barren Lands; Brochet 197", "MB"));
                CERRC_.Add(new RemoteCommunity("Brochet", "MB"));
                CERRC_.Add(new RemoteCommunity("Lac Brochet; Northlands; Lac Brochet 197A", "MB"));
                CERRC_.Add(new RemoteCommunity("Shamattawa; Shamattawa 1", "MB"));
                CERRC_.Add(new RemoteCommunity("Tadoule Lake; Sayisi Dene; Churchill 1", "MB"));
                CERRC_.Add(new RemoteCommunity("Diavik Diamond Mine", "NT"));
                CERRC_.Add(new RemoteCommunity("Ekati Diamond Mine", "NT"));
                CERRC_.Add(new RemoteCommunity("Gahcho Ku\x00e9 Mine", "NT"));
                CERRC_.Add(new RemoteCommunity("Prairie Creek Mine", "NT"));
                CERRC_.Add(new RemoteCommunity("Enterprise", "NT"));
                CERRC_.Add(new RemoteCommunity("Fort Providence; Deh G\x00e1h Got'ie Dene", "NT"));
                CERRC_.Add(new RemoteCommunity("Hay River", "NT"));
                CERRC_.Add(new RemoteCommunity("Hay River Dene 1; K'atl'odeeche", "NT"));
                CERRC_.Add(new RemoteCommunity("Kakisa; Ka'a'gee Tu", "NT"));
                CERRC_.Add(new RemoteCommunity("Ndilǫ; N'dilo; Yellowknife", "NT"));
                CERRC_.Add(new RemoteCommunity("Sambaa K'e; Trout Lake", "NT"));
                CERRC_.Add(new RemoteCommunity("Wekwe\x00e8t\x00ec; Snare Lake", "NT"));
                CERRC_.Add(new RemoteCommunity("Yellowknife", "NT"));
                CERRC_.Add(new RemoteCommunity("Aklavik", "NT"));
                CERRC_.Add(new RemoteCommunity("Behchokǫ̀; Rae-Edzo", "NT"));
                CERRC_.Add(new RemoteCommunity("Colville Lake; Behdzi Ahda", "NT"));
                CERRC_.Add(new RemoteCommunity("D\x00e9lįne; Fort Franklin", "NT"));
                CERRC_.Add(new RemoteCommunity("Detah; Dettah", "NT"));
                CERRC_.Add(new RemoteCommunity("Fort Good Hope; K'asho Got'ine", "NT"));
                CERRC_.Add(new RemoteCommunity("Fort Liard; Ahcho Kue", "NT"));
                CERRC_.Add(new RemoteCommunity("Fort McPherson; Tetl'it Zheh", "NT"));
                CERRC_.Add(new RemoteCommunity("Fort Resolution; Deninu K'ue", "NT"));
                CERRC_.Add(new RemoteCommunity("Fort Simpson; Liidlii Kue", "NT"));
                CERRC_.Add(new RemoteCommunity("Fort Smith; Salt River", "NT"));
                CERRC_.Add(new RemoteCommunity("Gam\x00e8t\x00ec; Rae Lakes", "NT"));
                CERRC_.Add(new RemoteCommunity("Inuvik", "NT"));
                CERRC_.Add(new RemoteCommunity("Jean Marie River; Tthets’ek’ehdeli", "NT"));
                CERRC_.Add(new RemoteCommunity("Łutselk'e", "NT"));
                CERRC_.Add(new RemoteCommunity("Nahanni Butte; Tthen\x00e1\x00e1g\x00f3", "NT"));
                CERRC_.Add(new RemoteCommunity("Norman Wells; Tłegǫ́hłı̨", "NT"));
                CERRC_.Add(new RemoteCommunity("Paulatuk; Paulatuuq", "NT"));
                CERRC_.Add(new RemoteCommunity("Sachs Harbour; Ikahuak", "NT"));
                CERRC_.Add(new RemoteCommunity("Tsiigehtchic; Arctic Red River; Gwichya Gwich'in", "NT"));
                CERRC_.Add(new RemoteCommunity("Tuktoyaktuk; Tuktuyaaqtuuq", "NT"));
                CERRC_.Add(new RemoteCommunity("Tulita; Fort Norman", "NT"));
                CERRC_.Add(new RemoteCommunity("Ulukhaktok; Ulukhaqtuuq; Holman", "NT"));
                CERRC_.Add(new RemoteCommunity("Whatį̀; Lac La Martre", "NT"));
                CERRC_.Add(new RemoteCommunity("Wrigley; Pehdzeh Ki", "NT"));
                CERRC_.Add(new RemoteCommunity("Armstrong", "ON"));
                CERRC_.Add(new RemoteCommunity("Bearskin Lake", "ON"));
                CERRC_.Add(new RemoteCommunity("Biscotasing", "ON"));
                CERRC_.Add(new RemoteCommunity("Collins; Namaygoosisagagun", "ON"));
                CERRC_.Add(new RemoteCommunity("Deer Lake", "ON"));
                CERRC_.Add(new RemoteCommunity("Fort Severn; Fort Severn 89", "ON"));
                CERRC_.Add(new RemoteCommunity("Gull Bay; Kiashke Zaaging Anishinaabek; Gull River 55", "ON"));
                CERRC_.Add(new RemoteCommunity("Kasabonika", "ON"));
                CERRC_.Add(new RemoteCommunity("Kingfisher Lake; Kingfisher Lake 1", "ON"));
                CERRC_.Add(new RemoteCommunity("Kitchenuhmaykoosib; Kitchenuhmaykoosib Inninuwug; Big Trout Lake", "ON"));
                CERRC_.Add(new RemoteCommunity("Neskantaga; Lansdowne House", "ON"));
                CERRC_.Add(new RemoteCommunity("Oba", "ON"));
                CERRC_.Add(new RemoteCommunity("Ogoki; Ogoki Post; Marten Falls 65", "ON"));
                CERRC_.Add(new RemoteCommunity("Sachigo Lake; Sachigo Lake 1; Sachigo Lake 2", "ON"));
                CERRC_.Add(new RemoteCommunity("Sandy Lake", "ON"));
                CERRC_.Add(new RemoteCommunity("Sultan", "ON"));
                CERRC_.Add(new RemoteCommunity("Wapekeka Reserve 1; Wapekeka Reserve 2; Angling Lake", "ON"));
                CERRC_.Add(new RemoteCommunity("Weagamow Lake; North Caribou Lake; Weagamow Lake 87", "ON"));
                CERRC_.Add(new RemoteCommunity("Webequie", "ON"));
                CERRC_.Add(new RemoteCommunity("Whitesand", "ON"));
                CERRC_.Add(new RemoteCommunity("Fort Hope; Eabametoong; Fort Hope 64", "ON"));
                CERRC_.Add(new RemoteCommunity("Keewaywin; Kee-Way-Win", "ON"));
                CERRC_.Add(new RemoteCommunity("Muskrat Dam Lake", "ON"));
                CERRC_.Add(new RemoteCommunity("Summer Beaver; Nibinamik", "ON"));
                CERRC_.Add(new RemoteCommunity("North Spirit Lake", "ON"));
                CERRC_.Add(new RemoteCommunity("Peawanuck; Winisk 90; Weenusk", "ON"));
                CERRC_.Add(new RemoteCommunity("Pikangikum; Pikangikum 14", "ON"));
                CERRC_.Add(new RemoteCommunity("Poplar Hill", "ON"));
                CERRC_.Add(new RemoteCommunity("Wawakapewin; Long Dog Lake", "ON"));
                CERRC_.Add(new RemoteCommunity("Wunnumin Lake; Wunnumin; Wunnumin 1; Wunnumin 2; ", "ON"));
            }
        }
        [Serializable, CompilerGenerated]
        private sealed class _c
        {
            public static readonly RemoteCommunity._c _9 = new RemoteCommunity._c();
            public static Func<RemoteCommunity, string> _9__11_1;
            public static Func<RemoteCommunity, string> _9__12_0;

            //internal string <CERRCAll>b__12_0(RemoteCommunity rc) => 
            //    rc.Name;

            //internal string <CERRCByProvinceOrTerritory>b__11_1(RemoteCommunity rc) => 
            //    rc.Name;

            public _c()
            {
            }
        }
    }
}

