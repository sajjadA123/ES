namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.WindowComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using System;
    using System.Runtime.InteropServices;
    using System.Xml.Serialization;

    [Serializable]
    public class WindowConstruction : Construction
    {
        [XmlAttribute("energyStar")]
        public bool EnergyStar;

        public string frameMaterialType(bool isFrench = false)
        {
            string str = " ";
            string str2 = " ";
            if (base.Type.Code == null)
            {
                return base.Type.IdRef;
            }
            if (isFrench)
            {
                switch (base.Type.Code[4])
                {
                    case '0':
                        str = "Fixe";
                        break;

                    case '1':
                        str = "\x00c0 battants";
                        break;

                    case '2':
                    case '3':
                        str = "Coulissant";
                        break;

                    case '4':
                        str = "Porte Patio";
                        break;

                    case '5':
                        str = "Lucarne";
                        break;

                    default:
                        str = "Fixe";
                        break;
                }
                switch (base.Type.Code[5])
                {
                    case '0':
                    case '1':
                        str2 = "Aluminium";
                        break;

                    case '2':
                        str2 = "Bois";
                        break;

                    case '3':
                        str2 = "Bois recouvert";
                        break;

                    case '4':
                    case '5':
                        str2 = "Vinyle";
                        break;

                    case '6':
                        str2 = "Fibre de verre";
                        break;

                    default:
                        str2 = "Aluminium";
                        break;
                }
            }
            else
            {
                switch (base.Type.Code[4])
                {
                    case '0':
                        str = "Fixed";
                        break;

                    case '1':
                        str = "Hinged";
                        break;

                    case '2':
                    case '3':
                        str = "Slider";
                        break;

                    case '4':
                        str = "Patio door";
                        break;

                    case '5':
                        str = "Skylight";
                        break;

                    default:
                        str = "Fixed";
                        break;
                }
                switch (base.Type.Code[5])
                {
                    case '0':
                    case '1':
                        str2 = "Aluminum";
                        break;

                    case '2':
                        str2 = "Wood";
                        break;

                    case '3':
                        str2 = "Clad wood";
                        break;

                    case '4':
                    case '5':
                        str2 = "Vinyl";
                        break;

                    case '6':
                        str2 = "Fibreglass";
                        break;

                    default:
                        str2 = "Aluminum";
                        break;
                }
            }
            return (str2 + " - " + str);
        }

        public string isLowEmissivity(bool isFrench = false)
        {
            string str = isFrench ? "Oui" : "Yes";
            string str2 = isFrench ? "Non" : "No";
            return ((base.Type.Code == null) ? "" : (((base.Type.Code[1] < '1') || ((base.Type.Code[1] > '9') || (base.Type.Code[1] == '5'))) ? str2 : str));
        }

        public string numberPanes(bool isFrench = false)
        {
            string str2 = isFrench ? "Simple" : "Single";
            if (base.Type.Code == null)
            {
                return "";
            }
            return ((base.Type.Code[0] != '1') ? (((base.Type.Code[0] == '3') || (base.Type.Code[0] == '4')) ? "Triple" : "Double") : str2);
        }
    }
}

