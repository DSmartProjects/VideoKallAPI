using System;
using System.Collections.Generic;

#nullable disable

namespace VideoKallAPI.Models
{
    public partial class PulseOximeterTestResult
    {
        public int PulseOximeterTestResultId { get; set; }
        public int PatientId { get; set; }
        public int? ChairId { get; set; }
        public Guid? SessionId { get; set; }
        public int? SpO2 { get; set; }
        public int? HeartRate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
