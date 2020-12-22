using System;
using System.Collections.Generic;

#nullable disable

namespace VideoKallAPI.Models
{
    public partial class Patient
    {
        public Patient()
        {
            BloodPressureTestResults = new HashSet<BloodPressureTestResult>();
            ChestStethoscopeTestResults = new HashSet<ChestStethoscopeTestResult>();
            ClinicalNotes = new HashSet<ClinicalNote>();
            DermatoscopeTestResults = new HashSet<DermatoscopeTestResult>();
            EmergencyContacts = new HashSet<EmergencyContact>();
            GlucoseMonitorTestResults = new HashSet<GlucoseMonitorTestResult>();
            HeightTestResults = new HashSet<HeightTestResult>();
            Insurances = new HashSet<Insurance>();
            OtoscopeTestResults = new HashSet<OtoscopeTestResult>();
            PatientContacts = new HashSet<PatientContact>();
            PatientEmployments = new HashSet<PatientEmployment>();
            PatientMedicalInfos = new HashSet<PatientMedicalInfo>();
            PatientMedicalIssues = new HashSet<PatientMedicalIssue>();
            Profileimages = new HashSet<Profileimage>();
            PulseOximeterTestResults = new HashSet<PulseOximeterTestResult>();
            Releases = new HashSet<Release>();
            SeatBackStethoscopeTestResults = new HashSet<SeatBackStethoscopeTestResult>();
            SpirometerTestResults = new HashSet<SpirometerTestResult>();
            ThermometerTestResults = new HashSet<ThermometerTestResult>();
            WeightTestResults = new HashSet<WeightTestResult>();
        }

        public int PatientId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientMiddleName { get; set; }
        public string PatientLastName { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string Ssn { get; set; }
        public string MaritalStatus { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<BloodPressureTestResult> BloodPressureTestResults { get; set; }
        public virtual ICollection<ChestStethoscopeTestResult> ChestStethoscopeTestResults { get; set; }
        public virtual ICollection<ClinicalNote> ClinicalNotes { get; set; }
        public virtual ICollection<DermatoscopeTestResult> DermatoscopeTestResults { get; set; }
        public virtual ICollection<EmergencyContact> EmergencyContacts { get; set; }
        public virtual ICollection<GlucoseMonitorTestResult> GlucoseMonitorTestResults { get; set; }
        public virtual ICollection<HeightTestResult> HeightTestResults { get; set; }
        public virtual ICollection<Insurance> Insurances { get; set; }
        public virtual ICollection<OtoscopeTestResult> OtoscopeTestResults { get; set; }
        public virtual ICollection<PatientContact> PatientContacts { get; set; }
        public virtual ICollection<PatientEmployment> PatientEmployments { get; set; }
        public virtual ICollection<PatientMedicalInfo> PatientMedicalInfos { get; set; }
        public virtual ICollection<PatientMedicalIssue> PatientMedicalIssues { get; set; }
        public virtual ICollection<Profileimage> Profileimages { get; set; }
        public virtual ICollection<PulseOximeterTestResult> PulseOximeterTestResults { get; set; }
        public virtual ICollection<Release> Releases { get; set; }
        public virtual ICollection<SeatBackStethoscopeTestResult> SeatBackStethoscopeTestResults { get; set; }
        public virtual ICollection<SpirometerTestResult> SpirometerTestResults { get; set; }
        public virtual ICollection<ThermometerTestResult> ThermometerTestResults { get; set; }
        public virtual ICollection<WeightTestResult> WeightTestResults { get; set; }
    }
}
