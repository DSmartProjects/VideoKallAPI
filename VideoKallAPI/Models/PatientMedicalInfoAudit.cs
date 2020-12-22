using System;
using System.Collections.Generic;

#nullable disable

namespace VideoKallAPI.Models
{
    public partial class PatientMedicalInfoAudit
    {
        public int PatientMedicalInfoAuditId { get; set; }
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string ReasonForVisit { get; set; }
        public string MedicalProblems { get; set; }
        public string PreviousSurgeries { get; set; }
        public string AllCurrentMedications { get; set; }
        public string AllergiesToMedications { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
