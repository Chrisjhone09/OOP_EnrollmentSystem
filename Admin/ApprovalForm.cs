using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedDB;
using SharedDB.Service;
namespace OOP
{
    public partial class ApprovalForm : Form
    {
        private readonly string _studentId;
        private readonly AdminDashboard _adminDashboard;
        private readonly ApplicationDbContext _context;


        public ApprovalForm(string studentId, AdminDashboard adminDashboard, ApplicationDbContext context)
        {
            InitializeComponent();
            _studentId = studentId;
            _adminDashboard = adminDashboard;
            _context = context;
            LoadStudentInfo();

        }

        private void LoadStudentInfo()
        {
            var student = _context.Students.Find(_studentId)!;
            studentName.Text = student.LastName + " " + student.FirstName;
            age.Text = student.Age.ToString();
            sex.Text = student.Sex;
            phone.Text = student.PhoneNumber;
            address.Text = student.Address;
            birthday.Text = student.BirthDate.ToString();
            email.Text = student.Email;

        }

        private async Task Approve_Click(object sender, EventArgs e)
        {
            var student = _context.Students.Find(_studentId)!;
            student.ApprovalStatus = "Approved";
            _context.SaveChanges();
            await EmailService.SendEmailAsync(student.Email!, student.LastName + " " + student.FirstName);
            this.Close();
        }

        private async Task Reject_Click(object sender, EventArgs e)
        {
            var student = _context.Students.Find(_studentId);
            _context.Students.Remove(student!);
            _context.SaveChanges();

            string message =
            $"<p><strong>Dear <em>{student!.LastName + " " + student.FirstName} </em>,</strong></p>" +
            "<p><em>We hope this message finds you well.</em> Thank you for your interest in <strong><em>Colegio de Kidapawan</em></strong>. After careful consideration, we <strong>regret to inform you</strong> that your enrollment has been <strong><em>rejected</em></strong> at this time.</p>" +
            "<p>This decision was based on a <em>thorough review</em> of available slots. We understand this news may be disappointing, and we encourage you to <strong>apply again in the future</strong> or explore <em>other opportunities</em> we offer.</p>" +
            "<p>If you have any questions or would like feedback on your application, please feel free to contact our <strong>admissions office</strong>.</p> " +
            "<p><strong>Sincerely,</strong><br>  " +
            "<em>Colegio de Kidapawan Registrar</em></p>";

            await EmailService.SendEmailAsync(student.Email!, student.LastName + " " + student.FirstName, message);
            this.Close();

            _adminDashboard.LoadData();
        }
    }
}
