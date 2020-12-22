using System;
using System.Collections.Generic;

#nullable disable

namespace VideoKallAPI.Models
{
    public partial class PatientContact
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string HomeNumber { get; set; }
        public string CellNumber { get; set; }
        public string WorkNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string AlternateEmail { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
