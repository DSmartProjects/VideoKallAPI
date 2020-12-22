using System;
using System.Collections.Generic;

#nullable disable

namespace VideoKallAPI.Models
{
    public partial class InsuranceAudit
    {
        public int InsuranceAuditId { get; set; }
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PrimaryInsurance { get; set; }
        public bool? IsPatientPrimaryInsPolicyHolder { get; set; }
        public string SecondaryInsurance { get; set; }
        public bool? IsPatientSecondaryInsPolicyHolder { get; set; }
        public string OtherPolicyHolderName { get; set; }
        public string RelationshipToPatient { get; set; }
        public string Ssn { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public string Employer { get; set; }
        public string PhoneNumber { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
