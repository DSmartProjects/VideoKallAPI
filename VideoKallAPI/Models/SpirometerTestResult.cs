using System;
using System.Collections.Generic;

#nullable disable

namespace VideoKallAPI.Models
{
    public partial class SpirometerTestResult
    {
        public int SpirometerTestResultId { get; set; }
        public int PatientId { get; set; }
        public int? ChairId { get; set; }
        public Guid? SessionId { get; set; }
        public string TestType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string MeasuredUnit { get; set; }
        public double? MeasuredValue { get; set; }
        public string ParameterType { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
