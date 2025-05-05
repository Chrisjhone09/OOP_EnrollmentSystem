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
using SharedDB.Models;
namespace OOP
{
    public partial class StudentInfo : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly AdminDashboard adminDashboard;
        private readonly string student_ID;
        public StudentInfo(AdminDashboard adminDashboard, string studentId, ApplicationDbContext context)
        {
            InitializeComponent();
            _context = context;
            this.adminDashboard = adminDashboard;
            student_ID = studentId;
            LoadStudentInformation();
        }


        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadStudentInformation()
        {

            Student student = _context.Students.FirstOrDefault(s => s.StudentId == student_ID)!;


            fullName.Text = $"{student.FirstName} {student.LastName}";
            studentId.Text = student_ID;
            bday.Value = student.BirthDate!.Value.ToDateTime(TimeOnly.MinValue);
            sex.SelectedItem = student.Sex;
            bplace.Text = student.BirthPlace;
            address.Text = student.BirthPlace;
            phone.Text = student.PhoneNumber;
            email.Text = student.Email;
            programComboBox.SelectedItem = student.Program;


        }

        private void StudentInfo_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

            var student = _context.Students.Find(student_ID);

            if (student != null)
            {
                _context.Remove(student);
                _context.SaveChanges();
                adminDashboard.LoadData("Information Technology");
                adminDashboard.LoadData("MedTech");
                adminDashboard.LoadData("Criminology");
                adminDashboard.LoadData("Information Technology");
                adminDashboard.LoadData();
                this.Close();
            }


        }

        private void StudentId_Leave(object sender, EventArgs e)
        {
            studentId.BackColor = Color.White;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var stud = _context.Students.Find(student_ID);

            stud.Sex = sex.SelectedItem!.ToString();
            stud.PhoneNumber = phone.ToString();
        }



        private void Sex_Leave(object sender, EventArgs e)
        {
            studentId.BackColor = Color.White;
        }


        private void Sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sex.SelectedItem!.ToString() != _context.Students.Find(student_ID)!.Sex)
            {
                saveBtn.Visible = true;
            }
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            if (firstName.Text != _context.Students.Find(student_ID)!.FirstName)
            {
                saveBtn.Visible = true;
            }
        }

        private void FirstName_Leave(object sender, EventArgs e)
        {
            firstName.BackColor = Color.White;
        }

        private void FirstName_Click(object sender, EventArgs e)
        {
            firstName.BackColor = Color.LightGray;
            firstName.ReadOnly = false;
        }

        private void MiddleName_TextChanged(object sender, EventArgs e)
        {
            if (middleName.Text != _context.Students.Find(student_ID)!.MiddleName)
            {
                saveBtn.Visible = true;
            }
        }

        private void MiddleName_Leave(object sender, EventArgs e)
        {
            middleName.BackColor = Color.White;
        }

        private void MiddleName_Click(object sender, EventArgs e)
        {
            middleName.BackColor = Color.LightGray;
            middleName.ReadOnly = false;
        }

        private void Lastname_TextChanged(object sender, EventArgs e)
        {
            if (lastname.Text != _context.Students.Find(student_ID)!.LastName)
            {
                saveBtn.Visible = true;
            }
        }

        private void Lastname_Click(object sender, EventArgs e)
        {
            lastname.BackColor = Color.LightGray;
            lastname.ReadOnly = false;
        }

        private void Lastname_Leave(object sender, EventArgs e)
        {
            lastname.BackColor = Color.White;
        }

        private void Bday_ValueChanged(object sender, EventArgs e)
        {
            if (bday.Value != _context.Students.Find(student_ID)!.BirthDate!.Value.ToDateTime(TimeOnly.MinValue))
            {
                saveBtn.Visible = true;
            }

        }

        private void Bplace_TextChanged(object sender, EventArgs e)
        {
            if (bplace.Text != _context.Students.Find(student_ID)!.BirthPlace)
            {
                saveBtn.Visible = true;
            }
        }

        private void Bplace_Leave(object sender, EventArgs e)
        {
            bplace.BackColor = Color.White;
        }

        private void Bplace_Click(object sender, EventArgs e)
        {
            bplace.BackColor = Color.LightGray;
            bplace.ReadOnly = false;
        }

        private void Address_TextChanged(object sender, EventArgs e)
        {
            if (address.Text != _context.Students.Find(student_ID)!.Address)
            {
                saveBtn.Visible = true;
            }
        }

        private void Address_Leave(object sender, EventArgs e)
        {
            address.BackColor = Color.White;
        }

        private void Address_Click(object sender, EventArgs e)
        {
            address.BackColor = Color.LightGray;
            address.ReadOnly = false;
        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {
            if (phone.Text != _context.Students.Find(student_ID)!.PhoneNumber)
            {
                saveBtn.Visible = true;
            }
        }

        private void Phone_Leave(object sender, EventArgs e)
        {
            phone.BackColor = Color.White;
        }

        private void Phone_Click(object sender, EventArgs e)
        {
            phone.BackColor = Color.LightGray;
            phone.ReadOnly = false;
        }

        private void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            if (email.Text != _context.Students.Find(student_ID)!.Email)
            {
                saveBtn.Visible = true;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            email.BackColor = Color.White;
        }

        private void Email_Click(object sender, EventArgs e)
        {
            email.BackColor = Color.LightGray;
            email.ReadOnly = false;
        }

        private void ProgramComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (programComboBox.SelectedItem!.ToString() != _context.Students.Find(student_ID)!.Program)
            {
                saveBtn.Visible = true;
            }
        }
    }
}
