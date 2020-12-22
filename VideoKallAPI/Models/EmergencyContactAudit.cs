using System;
using System.Collections.Generic;

#nullable disable

namespace VideoKallAPI.Models
{
    public partial class EmergencyContactAudit
    {
        public int EmergencyContactAuditId { get; set; }
        public int EmergencyId { get; set; }
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string RelationshipToPatient { get; set; }
        public string Address { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
