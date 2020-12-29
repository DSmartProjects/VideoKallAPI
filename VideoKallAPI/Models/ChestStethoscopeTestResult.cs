using System;
using System.Collections.Generic;

#nullable disable

namespace VideoKallAPI.Models
{
    public partial class ChestStethoscopeTestResult
    {
        public int ChestStethoscopeTestResultId { get; set; }
        public int PatientId { get; set; }
        public int? ChairId { get; set; }
        public Guid? SessionId { get; set; }
        public byte[] Recording { get; set; }
        public string Recording_Path { get; set; }
        
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
