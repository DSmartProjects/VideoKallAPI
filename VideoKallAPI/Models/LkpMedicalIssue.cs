using System;
using System.Collections.Generic;

#nullable disable

namespace VideoKallAPI.Models
{
    public partial class LkpMedicalIssue
    {
        public LkpMedicalIssue()
        {
            PatientMedicalIssues = new HashSet<PatientMedicalIssue>();
        }

        public int MedicalIssueId { get; set; }
        public string MedicalIssueName { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<PatientMedicalIssue> PatientMedicalIssues { get; set; }
    }
}
