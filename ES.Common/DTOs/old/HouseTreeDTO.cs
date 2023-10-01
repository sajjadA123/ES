using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Common.DTOs
{
    public class HouseTreeDTO
    {
        public int id { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public bool isDirectory { get; set; }
        public bool expanded { get; set; }
        public List<HouseTreeDTO> children { get; set; }
    }
}
