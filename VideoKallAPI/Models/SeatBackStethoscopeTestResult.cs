﻿using System;
using System.Collections.Generic;

#nullable disable

namespace VideoKallAPI.Models
{
    public partial class SeatBackStethoscopeTestResult
    {
        public int SeatBackStethoscopeTestResultId { get; set; }
        public int PatientId { get; set; }
        public int? ChairId { get; set; }
        public Guid? SessionId { get; set; }
        public int? StethoscopeId { get; set; }
        public byte[] Recording { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
