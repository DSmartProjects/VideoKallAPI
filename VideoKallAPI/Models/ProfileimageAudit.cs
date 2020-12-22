using System;
using System.Collections.Generic;

#nullable disable

namespace VideoKallAPI.Models
{
    public partial class ProfileimageAudit
    {
        public int ProfileimageAuditId { get; set; }
        public int ProfileimageId { get; set; }
        public int PatientId { get; set; }
        public DateTime ProfileCreatedDate { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public string Size { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
