using System;
using System.Collections.Generic;

#nullable disable

namespace VideoKallAPI.Models
{
    public partial class LkpEmploymentStatusAudit
    {
        public int LkpEmploymentStatusAuditId { get; set; }
        public int EmploymentStatusId { get; set; }
        public string Status { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
