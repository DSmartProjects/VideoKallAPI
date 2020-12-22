using System;
using System.Collections.Generic;

#nullable disable

namespace VideoKallAPI.Models
{
    public partial class DeviceType
    {
        public int DeviceTypeId { get; set; }
        public string DeviceTypeName { get; set; }
        public string DeviceName { get; set; }
        public string Description { get; set; }
        public int? CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public int? DeviceId { get; set; }
    }
}
