namespace CompetencyAssessment.Models
{
    
        public class UserDetails
        {
            public long ID { get; set; } // PK/Identity
            public string UserID { get; set; }
            public string Password { get; set; }
            public string Name { get; set; }
            public string EmpID { get; set; }
            public string Email { get; set; }
            public int DesignationID { get; set; }
            public string? CreatedBy { get; set; }
            public DateTime? CreatedDate { get; set; }
            public string? ModifiedBy { get; set; }
            public DateTime? ModifiedDate { get; set; }
            public bool IsActive { get; set; }
            public DateTime? PasswordChangeDate { get; set; }
        }
    }


