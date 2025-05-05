using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDB.Models
{
    public class Student
    {
        public required string StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public required string LastName { get; set; }
        public int? Age { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Program { get; set; }
        public string? Sex { get; set; }
        public string? Address { get; set; }
        public string? Status { get; set; }
        public DateOnly? BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string? ApprovalStatus { get; set; }
        public byte[]? StudentPicture { get; set; }
    }
}
