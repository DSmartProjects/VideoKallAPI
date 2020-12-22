using System;
using System.Collections.Generic;

#nullable disable

namespace VideoKallAPI.Models
{
    public partial class PatientMedicalIssue
    {
        public long PatientMedicalIssueId { get; set; }
        public int MedicalIssueId { get; set; }
        public int PatientId { get; set; }
        public bool? ConditonExists { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual LkpMedicalIssue MedicalIssue { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
