namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class HeatPumpEquipment : Type2Equipment
    {
        private HeatPumpFunctions Function_ = HeatPumpFunctions.Heating;

        [XmlElement("Function")]
        public CodeAndText FunctionXml
        {
            get => 
                (CodeAndText) this.Function;
            set
            {
                if (value == null)
                {
                    this.Function = null;
                }
                else
                {
                    this.Function = (from dt in HeatPumpFunctions.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<HeatPumpFunctions>();
                }
            }
        }

        [XmlIgnore]
        public HeatPumpFunctions Function
        {
            get => 
                this.Function_;
            set
            {
                if (value == null)
                {
                    this.Function_ = HeatPumpFunctions.Heating;
                }
                else
                {
                    this.Function_ = value;
                }
            }
        }
    }
}

