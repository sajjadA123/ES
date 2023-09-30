namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Xml.Serialization;

    [Serializable]
    public class Ventilation : Component
    {
        [XmlElement("Rooms")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents.Rooms Rooms = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents.Rooms();
        [XmlElement("Requirements")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents.Requirements Requirements = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents.Requirements();
        [XmlElement("WholeHouse")]
        public WholeHouseParamaters SupplyAndExhaust = new WholeHouseParamaters();
        [XmlArray("WholeHouseVentilatorList"), XmlArrayItem("Hrv", typeof(Hrv)), XmlArrayItem("Dryer", typeof(Dryer)), XmlArrayItem("BaseVentilator", typeof(VentilatorObjects))]
        public List<VentilatorObjects> WholeHouseVentilatorList = new List<VentilatorObjects>();
        [XmlArray("SupplementalVentilatorList"), XmlArrayItem("Hrv", typeof(Hrv)), XmlArrayItem("Dryer", typeof(Dryer)), XmlArrayItem("BaseVentilator", typeof(VentilatorObjects))]
        public List<VentilatorObjects> SupplementalVentilatorList = new List<VentilatorObjects>();

        public Ventilation()
        {
            base.Label = "Ventilation";
        }

        public void AddDryer()
        {
        }

        public int GetDryerIndex() => 
            -1;

        public void SetDryerParams()
        {
        }

        [XmlIgnore]
        public decimal WholeHouseVentilatorSupplyTotal
        {
            get
            {
                Func<VentilatorObjects, decimal> selector = cls9.f950;
                if (cls9.f950 == null)
                {
                    Func<VentilatorObjects, decimal> local1 = cls9.f950;
                    selector = cls9.f950 = vo => vo.SupplyFlowrate;
                }
                return this.WholeHouseVentilatorList.Sum<VentilatorObjects>(selector);
            }
        }

        [XmlIgnore]
        public decimal WholeHouseVentilatorExhaustTotal
        {
            get
            {
                Func<VentilatorObjects, decimal> selector = cls9.f970;
                if (cls9.f970 == null)
                {
                    Func<VentilatorObjects, decimal> local1 = cls9.f970;
                    selector = cls9.f970 = vo => vo.ExhaustFlowrate;
                }
                return this.WholeHouseVentilatorList.Sum<VentilatorObjects>(selector);
            }
        }

        [XmlIgnore]
        public decimal SupplementalVentilatorSupplyTotal
        {
            get
            {
                Func<VentilatorObjects, decimal> selector = cls9.f9100;
                if (cls9.f9100 == null)
                {
                    Func<VentilatorObjects, decimal> local1 = cls9.f9100;
                    selector = cls9.f9100 = vo => vo.SupplyFlowrate;
                }
                return this.SupplementalVentilatorList.Sum<VentilatorObjects>(selector);
            }
        }

        [XmlIgnore]
        public decimal SupplementalVentilatorExhaustTotal
        {
            get
            {
                Func<VentilatorObjects, decimal> selector = cls9.f9120;
                if (cls9.f9120 == null)
                {
                    Func<VentilatorObjects, decimal> local1 = cls9.f9120;
                    selector = cls9.f9120 = vo => vo.ExhaustFlowrate;
                }
                return this.SupplementalVentilatorList.Sum<VentilatorObjects>(selector);
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class cls9
        {
            public static readonly Ventilation c9 = new Ventilation();
            public static Func<VentilatorObjects, decimal> f950;
            public static Func<VentilatorObjects, decimal> f970;
            public static Func<VentilatorObjects, decimal> f9100;
            public static Func<VentilatorObjects, decimal> f9120;

            //internal decimal <get_SupplementalVentilatorExhaustTotal>b__12_0(VentilatorObjects vo) => 
            //    vo.ExhaustFlowrate;

            //internal decimal <get_SupplementalVentilatorSupplyTotal>b__10_0(VentilatorObjects vo) => 
            //    vo.SupplyFlowrate;

            //internal decimal <get_WholeHouseVentilatorExhaustTotal>b__7_0(VentilatorObjects vo) => 
            //    vo.ExhaustFlowrate;

            //internal decimal <get_WholeHouseVentilatorSupplyTotal>b__5_0(VentilatorObjects vo) => 
            //    vo.SupplyFlowrate;


        }
    }
}

