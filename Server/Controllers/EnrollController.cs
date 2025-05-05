using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using SharedDB;
using SharedDB.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public EnrollController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("submit")]
        public IActionResult SubmitEnrollmentForm([FromBody] StudentDTO student)
        {
            Random random = new Random();
            var stud = new Student
            {
                StudentId = "STUD-"+random.Next(1000, 9999).ToString(),
                FirstName = student.FirstName,
                MiddleName = student.MiddleName,
                LastName = student.LastName,
                Email = student.Email,
                PhoneNumber = student.PhoneNumber,
                Program = student.Program,
                Sex = student.Sex,
                BirthDate = DateOnly.FromDateTime(student.BirthDate),
                BirthPlace = null,
                Address = student.Address,
                ApprovalStatus = student.ApprovalStatus
            };
            _context.Students.Add(stud);
            _context.SaveChanges();
            return Ok(student);
        }
        [HttpGet]
        public IActionResult Enroll()
        {
            return Ok(_context.EnrollmentSettings.First());
        }
    }

    public class StudentDTO
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public required string LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Program { get; set; }
        public string? Sex { get; set; }
        public string? Address { get; set; }
        public string? ApprovalStatus { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
