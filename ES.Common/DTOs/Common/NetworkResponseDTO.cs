using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Common.DTOs.Common
{
    public class NetworkResponseDTO
    {
        public bool Status { get; set; }
        public string DevMessage { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
