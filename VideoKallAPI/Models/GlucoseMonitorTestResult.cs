using System;
using System.Collections.Generic;

#nullable disable

namespace VideoKallAPI.Models
{
    public partial class GlucoseMonitorTestResult
    {
        public int GlucoseMonitorTestResultId { get; set; }
        public int PatientId { get; set; }
        public int? ChairId { get; set; }
        public Guid? SessionId { get; set; }
        public string Mode { get; set; }
        public double? Value { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
