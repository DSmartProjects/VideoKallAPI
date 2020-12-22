using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace VideoKallAPI.Models
{
    public partial class VK_SMCContext : DbContext
    {
        public VK_SMCContext()
        {
        }

        public VK_SMCContext(DbContextOptions<VK_SMCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BloodPressureTestResult> BloodPressureTestResults { get; set; }
        public virtual DbSet<ChestStethoscopeTestResult> ChestStethoscopeTestResults { get; set; }
        public virtual DbSet<ClinicalNote> ClinicalNotes { get; set; }
        public virtual DbSet<DermatoscopeTestResult> DermatoscopeTestResults { get; set; }
        public virtual DbSet<DeviceType> DeviceTypes { get; set; }
        public virtual DbSet<EmergencyContact> EmergencyContacts { get; set; }
        public virtual DbSet<EmergencyContactAudit> EmergencyContactAudits { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<GlucoseMonitorTestResult> GlucoseMonitorTestResults { get; set; }
        public virtual DbSet<HeightTestResult> HeightTestResults { get; set; }
        public virtual DbSet<Insurance> Insurances { get; set; }
        public virtual DbSet<InsuranceAudit> InsuranceAudits { get; set; }
        public virtual DbSet<LkpEmploymentStatus> LkpEmploymentStatuses { get; set; }
        public virtual DbSet<LkpEmploymentStatusAudit> LkpEmploymentStatusAudits { get; set; }
        public virtual DbSet<LkpMedicalIssue> LkpMedicalIssues { get; set; }
        public virtual DbSet<LkpMedicalIssuesAudit> LkpMedicalIssuesAudits { get; set; }
        public virtual DbSet<OtoscopeTestResult> OtoscopeTestResults { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientAudit> PatientAudits { get; set; }
        public virtual DbSet<PatientContact> PatientContacts { get; set; }
        public virtual DbSet<PatientContactAudit> PatientContactAudits { get; set; }
        public virtual DbSet<PatientEmployment> PatientEmployments { get; set; }
        public virtual DbSet<PatientEmploymentAudit> PatientEmploymentAudits { get; set; }
        public virtual DbSet<PatientMedicalInfo> PatientMedicalInfos { get; set; }
        public virtual DbSet<PatientMedicalInfoAudit> PatientMedicalInfoAudits { get; set; }
        public virtual DbSet<PatientMedicalIssue> PatientMedicalIssues { get; set; }
        public virtual DbSet<PatientMedicalIssuesAudit> PatientMedicalIssuesAudits { get; set; }
        public virtual DbSet<Profileimage> Profileimages { get; set; }
        public virtual DbSet<ProfileimageAudit> ProfileimageAudits { get; set; }
        public virtual DbSet<PulseOximeterTestResult> PulseOximeterTestResults { get; set; }
        public virtual DbSet<Release> Releases { get; set; }
        public virtual DbSet<ReleaseAudit> ReleaseAudits { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SeatBackStethoscopeTestResult> SeatBackStethoscopeTestResults { get; set; }
        public virtual DbSet<SpirometerTestResult> SpirometerTestResults { get; set; }
        public virtual DbSet<Temp> Temps { get; set; }
        public virtual DbSet<TempMedicalIssue> TempMedicalIssues { get; set; }
        public virtual DbSet<ThermometerTestResult> ThermometerTestResults { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAudit> UserAudits { get; set; }
        public virtual DbSet<WeightTestResult> WeightTestResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=VK_SMC;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BloodPressureTestResult>(entity =>
            {
                entity.ToTable("Blood_Pressure_Test_Result");

                entity.Property(e => e.BloodPressureTestResultId).HasColumnName("Blood_Pressure_Test_Result_ID");

                entity.Property(e => e.ChairId).HasColumnName("Chair_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.SessionId)
                    .HasColumnName("Session_ID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.BloodPressureTestResults)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Blood_Pressure_Test_Result_Patient");
            });

            modelBuilder.Entity<ChestStethoscopeTestResult>(entity =>
            {
                entity.ToTable("Chest_Stethoscope_Test_Result");

                entity.Property(e => e.ChestStethoscopeTestResultId).HasColumnName("Chest_Stethoscope_Test_Result_ID");

                entity.Property(e => e.ChairId).HasColumnName("Chair_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.SessionId)
                    .HasColumnName("Session_ID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ChestStethoscopeTestResults)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chest_Stethoscope_Test_Result_Patient");
            });

            modelBuilder.Entity<ClinicalNote>(entity =>
            {
                entity.ToTable("Clinical_Note");

                entity.Property(e => e.ClinicalNoteId).HasColumnName("Clinical_Note_ID");

                entity.Property(e => e.ChairId).HasColumnName("Chair_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.SessionId)
                    .HasColumnName("Session_ID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ClinicalNotes)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Clinical_Note_Patient");
            });

            modelBuilder.Entity<DermatoscopeTestResult>(entity =>
            {
                entity.ToTable("Dermatoscope_Test_Result");

                entity.Property(e => e.DermatoscopeTestResultId).HasColumnName("Dermatoscope_Test_Result_ID");

                entity.Property(e => e.ChairId).HasColumnName("Chair_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.SessionId)
                    .HasColumnName("Session_ID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.DermatoscopeTestResults)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dermatoscope_Test_Result_Patient");
            });

            modelBuilder.Entity<DeviceType>(entity =>
            {
                entity.ToTable("Device_Type");

                entity.Property(e => e.DeviceTypeId).HasColumnName("DeviceType_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasMaxLength(10)
                    .HasColumnName("Created_Date")
                    .IsFixedLength(true);

                entity.Property(e => e.DeviceId).HasColumnName("Device_ID");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(50)
                    .HasColumnName("Device_Name");

                entity.Property(e => e.DeviceTypeName)
                    .HasMaxLength(50)
                    .HasColumnName("Device_TypeName");
            });

            modelBuilder.Entity<EmergencyContact>(entity =>
            {
                entity.HasKey(e => e.EmergencyId)
                    .HasName("PK__Emergenc__41242F0618D9B2E7");

                entity.ToTable("Emergency_Contact");

                entity.Property(e => e.EmergencyId).HasColumnName("Emergency_ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Contact_Number");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.RelationshipToPatient)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Relationship_to_Patient");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.EmergencyContacts)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Emergency__Patie__3DB3258D");
            });

            modelBuilder.Entity<EmergencyContactAudit>(entity =>
            {
                entity.ToTable("Emergency_Contact_Audit");

                entity.Property(e => e.EmergencyContactAuditId).HasColumnName("Emergency_Contact_Audit_ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Contact_Number");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.EmergencyId).HasColumnName("Emergency_ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.RelationshipToPatient)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Relationship_to_Patient");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.HasKey(e => e.ErrorId)
                    .HasName("PK__ErrorLog__7A235C0AEA5859E4");

                entity.ToTable("ErrorLog");

                entity.Property(e => e.ErrorId).HasColumnName("Error_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.ErrorLog1)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ErrorLog");
            });

            modelBuilder.Entity<GlucoseMonitorTestResult>(entity =>
            {
                entity.ToTable("Glucose_Monitor_Test_Result");

                entity.Property(e => e.GlucoseMonitorTestResultId).HasColumnName("Glucose_Monitor_Test_Result_ID");

                entity.Property(e => e.ChairId).HasColumnName("Chair_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.Mode).HasMaxLength(50);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.SessionId)
                    .HasColumnName("Session_ID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.GlucoseMonitorTestResults)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Glucose_Monitor_Test_Result_Patient");
            });

            modelBuilder.Entity<HeightTestResult>(entity =>
            {
                entity.ToTable("Height_Test_Result");

                entity.Property(e => e.HeightTestResultId).HasColumnName("Height_Test_Result_ID");

                entity.Property(e => e.ChairId).HasColumnName("Chair_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.Height).HasMaxLength(10);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.SessionId)
                    .HasColumnName("Session_ID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.HeightTestResults)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Height_Test_Result_Patient");
            });

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.ToTable("Insurance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Employer)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPatientPrimaryInsPolicyHolder).HasColumnName("Is_Patient_Primary_Ins_Policy_Holder");

                entity.Property(e => e.IsPatientSecondaryInsPolicyHolder).HasColumnName("Is_Patient_Secondary_Ins_Policy_Holder");

                entity.Property(e => e.OtherPolicyHolderName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Other_Policy_holder_Name");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Number");

                entity.Property(e => e.PrimaryInsurance)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Primary_Insurance");

                entity.Property(e => e.RelationshipToPatient)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Relationship_to_Patient");

                entity.Property(e => e.SecondaryInsurance)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Secondary_Insurance");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength(true);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Insurances)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Insurance__Patie__1C722D53");
            });

            modelBuilder.Entity<InsuranceAudit>(entity =>
            {
                entity.HasKey(e => e.InsuranceAuditId)
                    .HasName("PK__Insuranc__E858B816605516E3");

                entity.ToTable("Insurance_Audit");

                entity.Property(e => e.InsuranceAuditId).HasColumnName("Insurance_Audit_ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Employer)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPatientPrimaryInsPolicyHolder).HasColumnName("Is_Patient_Primary_Ins_Policy_Holder");

                entity.Property(e => e.IsPatientSecondaryInsPolicyHolder).HasColumnName("Is_Patient_Secondary_Ins_Policy_Holder");

                entity.Property(e => e.OtherPolicyHolderName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Other_Policy_holder_Name");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Number");

                entity.Property(e => e.PrimaryInsurance)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Primary_Insurance");

                entity.Property(e => e.RelationshipToPatient)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Relationship_to_Patient");

                entity.Property(e => e.SecondaryInsurance)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Secondary_Insurance");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength(true);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");
            });

            modelBuilder.Entity<LkpEmploymentStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LKP_Employment_Status");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.EmploymentStatusId).HasColumnName("Employment_Status_ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");

                entity.HasOne(d => d.EmploymentStatus)
                    .WithMany()
                    .HasForeignKey(d => d.EmploymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LKP_Emplo__Emplo__63D8CE75");
            });

            modelBuilder.Entity<LkpEmploymentStatusAudit>(entity =>
            {
                entity.ToTable("LKP_Employment_Status_Audit");

                entity.Property(e => e.LkpEmploymentStatusAuditId).HasColumnName("LKP_Employment_Status_Audit_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.EmploymentStatusId).HasColumnName("Employment_Status_ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");
            });

            modelBuilder.Entity<LkpMedicalIssue>(entity =>
            {
                entity.HasKey(e => e.MedicalIssueId)
                    .HasName("PK__LKP_Medi__E09894ED1299D2C9");

                entity.ToTable("LKP_Medical_Issues");

                entity.Property(e => e.MedicalIssueId).HasColumnName("Medical_Issue_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MedicalIssueName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Medical_Issue_Name");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");
            });

            modelBuilder.Entity<LkpMedicalIssuesAudit>(entity =>
            {
                entity.ToTable("LKP_Medical_Issues_Audit");

                entity.Property(e => e.LkpMedicalIssuesAuditId).HasColumnName("LKP_Medical_Issues_Audit_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MedicalIssueId).HasColumnName("Medical_Issue_ID");

                entity.Property(e => e.MedicalIssueName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Medical_Issue_Name");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");
            });

            modelBuilder.Entity<OtoscopeTestResult>(entity =>
            {
                entity.ToTable("Otoscope_Test_Result");

                entity.Property(e => e.OtoscopeTestResultId).HasColumnName("Otoscope_Test_Result_ID");

                entity.Property(e => e.ChairId).HasColumnName("Chair_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.SessionId)
                    .HasColumnName("Session_ID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.OtoscopeTestResults)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Otoscope_Test_Result_Patient");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Marital_Status");

                entity.Property(e => e.PatientFirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Patient_FirstName");

                entity.Property(e => e.PatientLastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Patient_LastName");

                entity.Property(e => e.PatientMiddleName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Patient_MiddleName");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength(true);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");
            });

            modelBuilder.Entity<PatientAudit>(entity =>
            {
                entity.ToTable("Patient_Audit");

                entity.Property(e => e.PatientAuditId).HasColumnName("Patient_Audit_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Marital_Status");

                entity.Property(e => e.PatientFirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Patient_FirstName");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PatientLastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Patient_LastName");

                entity.Property(e => e.PatientMiddleName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Patient_MiddleName");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength(true);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");
            });

            modelBuilder.Entity<PatientContact>(entity =>
            {
                entity.ToTable("Patient_Contact");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AlternateEmail)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Alternate_Email");

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Cell_Number");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HomeNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Home_Number");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");

                entity.Property(e => e.WorkNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Work_Number");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientContacts)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Patient_C__Patie__09FE775D");
            });

            modelBuilder.Entity<PatientContactAudit>(entity =>
            {
                entity.HasKey(e => e.PatientContactAuditId)
                    .HasName("PK__Patient___8D09370A56DA810B");

                entity.ToTable("Patient_Contact_Audit");

                entity.Property(e => e.PatientContactAuditId).HasColumnName("Patient_Contact_Audit_ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AlternateEmail)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Alternate_Email");

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Cell_Number");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HomeNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Home_Number");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");

                entity.Property(e => e.WorkNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Work_Number");
            });

            modelBuilder.Entity<PatientEmployment>(entity =>
            {
                entity.HasKey(e => e.EmploymentStatusId)
                    .HasName("PK__Patient___072DFB76B40C58AD");

                entity.ToTable("Patient_Employment");

                entity.Property(e => e.EmploymentStatusId).HasColumnName("Employment_Status_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Employer)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientEmployments)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Patient_E__Patie__5A4F643B");
            });

            modelBuilder.Entity<PatientEmploymentAudit>(entity =>
            {
                entity.ToTable("Patient_Employment_Audit");

                entity.Property(e => e.PatientEmploymentAuditId).HasColumnName("Patient_Employment_Audit_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Employer)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentStatusId).HasColumnName("Employment_Status_ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");
            });

            modelBuilder.Entity<PatientMedicalInfo>(entity =>
            {
                entity.ToTable("Patient_Medical_Info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllCurrentMedications)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("All_Current_Medications");

                entity.Property(e => e.AllergiesToMedications)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Allergies_to_Medications");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MedicalProblems)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Medical_Problems");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PreviousSurgeries)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Previous_Surgeries");

                entity.Property(e => e.ReasonForVisit)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Reason_for_Visit");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientMedicalInfos)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Patient_M__Patie__147C05D0");
            });

            modelBuilder.Entity<PatientMedicalInfoAudit>(entity =>
            {
                entity.HasKey(e => e.PatientMedicalInfoAuditId)
                    .HasName("PK__Patient___DB4C3FDF70AA29EF");

                entity.ToTable("Patient_Medical_Info_Audit");

                entity.Property(e => e.PatientMedicalInfoAuditId).HasColumnName("Patient_Medical_Info_Audit_ID");

                entity.Property(e => e.AllCurrentMedications)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("All_Current_Medications");

                entity.Property(e => e.AllergiesToMedications)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Allergies_to_Medications");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MedicalProblems)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Medical_Problems");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PreviousSurgeries)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Previous_Surgeries");

                entity.Property(e => e.ReasonForVisit)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Reason_for_Visit");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");
            });

            modelBuilder.Entity<PatientMedicalIssue>(entity =>
            {
                entity.ToTable("Patient_Medical_Issues");

                entity.Property(e => e.PatientMedicalIssueId).HasColumnName("Patient_Medical_Issue_ID");

                entity.Property(e => e.ConditonExists)
                    .IsRequired()
                    .HasColumnName("Conditon_Exists")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MedicalIssueId).HasColumnName("Medical_Issue_ID");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");

                entity.HasOne(d => d.MedicalIssue)
                    .WithMany(p => p.PatientMedicalIssues)
                    .HasForeignKey(d => d.MedicalIssueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Patient_M__Medic__0B7CAB7B");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientMedicalIssues)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Patient_M__Patie__0C70CFB4");
            });

            modelBuilder.Entity<PatientMedicalIssuesAudit>(entity =>
            {
                entity.ToTable("Patient_Medical_Issues_Audit");

                entity.Property(e => e.PatientMedicalIssuesAuditId).HasColumnName("Patient_Medical_Issues_Audit_ID");

                entity.Property(e => e.ConditonExists)
                    .IsRequired()
                    .HasColumnName("Conditon_Exists")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MedicalIssueId).HasColumnName("Medical_Issue_ID");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PatientMedicalIssueId).HasColumnName("Patient_Medical_Issue_ID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");
            });

            modelBuilder.Entity<Profileimage>(entity =>
            {
                entity.ToTable("Profileimage");

                entity.Property(e => e.ProfileimageId).HasColumnName("Profileimage_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.ProfileCreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Profile_Created_Date");

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Profileimages)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Profileim__Patie__4AD81681");
            });

            modelBuilder.Entity<ProfileimageAudit>(entity =>
            {
                entity.ToTable("Profileimage_Audit");

                entity.Property(e => e.ProfileimageAuditId).HasColumnName("Profileimage_Audit_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.ProfileCreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Profile_Created_Date");

                entity.Property(e => e.ProfileimageId).HasColumnName("Profileimage_ID");

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");
            });

            modelBuilder.Entity<PulseOximeterTestResult>(entity =>
            {
                entity.ToTable("Pulse_Oximeter_Test_Result");

                entity.Property(e => e.PulseOximeterTestResultId).HasColumnName("Pulse_Oximeter_Test_Result_ID");

                entity.Property(e => e.ChairId).HasColumnName("Chair_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.HeartRate).HasColumnName("Heart_Rate");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.SessionId)
                    .HasColumnName("Session_ID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PulseOximeterTestResults)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pulse_Oximeter_Test_Result_Patient");
            });

            modelBuilder.Entity<Release>(entity =>
            {
                entity.ToTable("Release");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.RelationshipToPatient)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Relationship_to_Patient");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Releases)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Release__Patient__278EDA44");
            });

            modelBuilder.Entity<ReleaseAudit>(entity =>
            {
                entity.HasKey(e => e.ReleaseAuditId)
                    .HasName("PK__Release___73EA34A084191E19");

                entity.ToTable("Release_Audit");

                entity.Property(e => e.ReleaseAuditId).HasColumnName("Release_Audit_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.RelationshipToPatient)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Relationship_to_Patient");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .HasColumnName("Role_Name");
            });

            modelBuilder.Entity<SeatBackStethoscopeTestResult>(entity =>
            {
                entity.ToTable("Seat_Back_Stethoscope_Test_Result");

                entity.HasIndex(e => e.StethoscopeId, "UC_StethoscopeID")
                    .IsUnique();

                entity.Property(e => e.SeatBackStethoscopeTestResultId).HasColumnName("Seat_Back_Stethoscope_Test_Result_ID");

                entity.Property(e => e.ChairId).HasColumnName("Chair_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.SessionId)
                    .HasColumnName("Session_ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.StethoscopeId).HasColumnName("Stethoscope_ID");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.SeatBackStethoscopeTestResults)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Seat_Back_Stethoscope_Test_Result_Patient");
            });

            modelBuilder.Entity<SpirometerTestResult>(entity =>
            {
                entity.ToTable("Spirometer_Test_Result");

                entity.Property(e => e.SpirometerTestResultId).HasColumnName("Spirometer_Test_Result_ID");

                entity.Property(e => e.ChairId).HasColumnName("Chair_ID");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.MeasuredUnit)
                    .HasMaxLength(10)
                    .HasColumnName("Measured_Unit");

                entity.Property(e => e.MeasuredValue).HasColumnName("Measured_Value");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ParameterType)
                    .HasMaxLength(20)
                    .HasColumnName("Parameter_Type");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.SessionId)
                    .HasColumnName("Session_ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TestType)
                    .HasMaxLength(50)
                    .HasColumnName("Test_Type");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.SpirometerTestResults)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Spirometer_Test_Result_Patient");
            });

            modelBuilder.Entity<Temp>(entity =>
            {
                entity.ToTable("Temp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempMedicalIssue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Medical_Issues");

                entity.Property(e => e.ConditonExists)
                    .IsRequired()
                    .HasColumnName("Conditon_Exists")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MedicalIssueId).HasColumnName("Medical_Issue_ID");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");

                entity.HasOne(d => d.MedicalIssue)
                    .WithMany()
                    .HasForeignKey(d => d.MedicalIssueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Temp_Medi__Medic__07E124C1");

                entity.HasOne(d => d.Patient)
                    .WithMany()
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Temp_Medi__Patie__08D548FA");
            });

            modelBuilder.Entity<ThermometerTestResult>(entity =>
            {
                entity.ToTable("Thermometer_Test_Result");

                entity.Property(e => e.ThermometerTestResultId).HasColumnName("Thermometer_Test_Result_ID");

                entity.Property(e => e.ChairId).HasColumnName("Chair_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.Mode).HasMaxLength(20);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.SessionId)
                    .HasColumnName("Session_ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Value).HasMaxLength(20);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ThermometerTestResults)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Thermometer_Test_Result_Patient");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Hash)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("hash");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("salt");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_User_Roles");
            });

            modelBuilder.Entity<UserAudit>(entity =>
            {
                entity.ToTable("User_Audit");

                entity.Property(e => e.UserAuditId).HasColumnName("User_Audit_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Created_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Hash)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("hash");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("salt");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Updated_date");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WeightTestResult>(entity =>
            {
                entity.ToTable("Weight_Test_Result");

                entity.Property(e => e.WeightTestResultId).HasColumnName("Weight_Test_Result_ID");

                entity.Property(e => e.ChairId).HasColumnName("Chair_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.SessionId)
                    .HasColumnName("Session_ID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.WeightTestResults)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Weight_Test_Result_Patient");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
