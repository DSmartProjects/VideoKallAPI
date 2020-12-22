using System;
using System.Collections.Generic;

#nullable disable

namespace VideoKallAPI.Models
{
    public partial class PatientEmploymentAudit
    {
        public int PatientEmploymentAuditId { get; set; }
        public int EmploymentStatusId { get; set; }
        public int PatientId { get; set; }
        public string Employer { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
