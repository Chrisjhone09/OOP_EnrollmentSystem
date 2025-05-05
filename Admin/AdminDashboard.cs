using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SharedDB;
using SharedDB.Models;
namespace OOP
{
    public partial class AdminDashboard : Form
    {
        private readonly ApplicationDbContext _context;


        private string selectedImagePath;

        public AdminDashboard(ApplicationDbContext context)
        {


            InitializeComponent();

            _context = context;
            totalStudents.Text = _context!.Students.Count().ToString();
            educTotalNumber.Text = _context!.Students.Where(s => s.Program == "Education").Count().ToString();
            hmTotalNumber.Text = _context!.Students.Where(s => s.Program == "Hospitality Management").Count().ToString();
            crimTotalNumber.Text = _context!.Students.Where(s => s.Program == "Criminology").Count().ToString();
            medtechTotalNumber.Text = _context!.Students.Where(s => s.Program == "MedTech").Count().ToString();
            infoTechTotalNumber.Text = _context!.Students.Where(s => s.Program == "Information Technology").Count().ToString();


            if (_context.EnrollmentSettings.Count() == 0)
            {
                EnrollmentSetting settings = new()
                {
                    AllowRequest = false,
                    AutoAccept = false,
                    Limit = 200
                };
                _context.EnrollmentSettings.Add(settings);
                _context.SaveChanges();
            }
            LoadData("Requests");

        }
        

        public void LoadData(string program)
        {
            switch (program)
            {
                case "Information Technology":

                    dataGridInfoTech.DataSource = _context.Students
                        .Where(s => s.Program == program || s.Status != "Pending")
                        .ToList();
                    totalStudents.Text = _context.Students.Count().ToString();

                    ; break;

                case "MedTech":

                    dataGridMedTech.DataSource = _context.Students
                        .Where(s => s.Program == program || s.Status != "Pending")
                        .ToList();
                    totalStudents.Text = _context.Students.Count().ToString();
                    ; break;

                case "Criminology":
                    dataGridCrim.DataSource = _context.Students
                        .Where(s => s.Program == program || s.Status != "Pending")
                        .ToList();
                    totalStudents.Text = _context.Students.Count().ToString();
                    ; break;
                case "Education":
                    dataGridEduc.DataSource = _context.Students
                        .Where(s => s.Program == program || s.Status != "Pending")
                        .ToList();
                    totalStudents.Text = _context.Students.Count().ToString();
                    ; break;
                case "Hospitality Management":
                    dataGridHM.DataSource = _context.Students
                        .Where(s => s.Program == program || s.Status != "Pending")
                        .ToList();
                    totalStudents.Text = _context.Students.Count().ToString();
                    ; break;
                case "Requests":
                    requestGridView.DataSource = _context.Students.Where(s => s.ApprovalStatus == "Pending").ToList();
                    break;
            }



        }
        public void LoadData()
        {

            dataGridAll.DataSource = _context.Students.ToList();
            totalStudents.Text = _context.Students.Count().ToString();
        }
        private void SaveButton(object sender, EventArgs e)
        {

            string fname = firstName.Text;
            string mName = middleName.Text;
            string lName = lastName.Text;
            int student_age = Convert.ToInt32(age.Text);
            string student_sex = sex.Text;
            DateOnly bDate = DateOnly.FromDateTime(birthdate.Value);
            string bPlace = birthPlace.Text;
            string phoneNumber = phone.Text;
            string student_email = email.Text;
            string student_program = program.Text;
            string student_address = address.Text;
            byte[] imgData = File.ReadAllBytes(selectedImagePath);


            Random rand = new();

            var student = new Student
            {
                StudentId = DateTime.Now.Year.ToString() + "-" + rand.Next(1000, 9999),
                FirstName = fname,
                MiddleName = string.IsNullOrEmpty(mName) ? "" : mName,
                LastName = lName,
                Age = student_age,
                BirthDate = bDate,
                BirthPlace = bPlace,
                PhoneNumber = phoneNumber,
                Program = student_program,
                Email = student_email,
                Address = student_address,
                Sex = student_sex,
                StudentPicture = imgData
            };

            _context.Students.Add(student);
            _context.SaveChanges();

            LoadData();
        }



        private void SearchStudent(object sender, EventArgs e)
        {

            string stringSearch = searchBox.Text;

            dataGridAll.DataSource = _context.Students.Where(s => s.FirstName.Contains(stringSearch) ||
                                                                 s.MiddleName.Contains(stringSearch) ||
                                                                 s.LastName.Contains(stringSearch)).ToList();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void SearchStudent(object sender, KeyEventArgs e)
        {
            string strName = searchBox.Text;

            dataGridAll.DataSource = _context.Students.Where(s => s.FirstName!.Contains(strName) ||
                                                                 s.MiddleName!.Contains(strName) ||
                                                                 s.LastName.Contains(strName) ||
                                                                 s.StudentId.Contains(strName)).ToList();
            dataGridMedTech.DataSource = _context.Students.Where(s => s.FirstName!.Contains(strName) ||
                                                                 s.MiddleName!.Contains(strName) ||
                                                                 s.LastName.Contains(strName) ||
                                                                 s.StudentId.Contains(strName)).ToList();
            dataGridInfoTech.DataSource = _context.Students.Where(s => s.FirstName!.Contains(strName) ||
                                                                 s.MiddleName!.Contains(strName) ||
                                                                 s.LastName.Contains(strName) ||
                                                                 s.StudentId.Contains(strName)).ToList();
            dataGridHM.DataSource = _context.Students.Where(s => s.FirstName!.Contains(strName) ||
                                                                 s.MiddleName!.Contains(strName) ||
                                                                 s.LastName.Contains(strName) ||
                                                                 s.StudentId.Contains(strName)).ToList();
            dataGridCrim.DataSource = _context.Students.Where(s => s.FirstName!.Contains(strName) ||
                                                                 s.MiddleName!.Contains(strName) ||
                                                                 s.LastName.Contains(strName) ||
                                                                 s.StudentId.Contains(strName)).ToList();
            dataGridEduc.DataSource = _context.Students.Where(s => s.FirstName!.Contains(strName) ||
                                                                 s.MiddleName!.Contains(strName) ||
                                                                 s.LastName.Contains(strName) ||
                                                                 s.StudentId.Contains(strName)).ToList();


        }


        private void StudentList(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: LoadData("Requests"); break;
                case 1: LoadData(); break;
                case 2: LoadData("Information Technology"); break;
                case 3: LoadData("Hospitality Management"); break;
                case 4: LoadData("Criminology"); break;
                case 5: LoadData("Education"); break;
                case 6: LoadData("MedTech"); break;
            }
        }



        private void Show_Student_Information(object sender, DataGridViewCellEventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    string studentId = requestGridView.Rows[e.RowIndex].Cells["StudentId"].Value?.ToString()!;
                    ApprovalForm appForm = new ApprovalForm(studentId, this, _context);
                    appForm.Show();
                    break;
                case 1:
                    string studentId_all_dataGrid = dataGridAll.Rows[e.RowIndex].Cells["All_StudentId"].Value?.ToString()!;
                    StudentInfo studentInfo_All_dataGrid = new(this, studentId_all_dataGrid, _context);

                    studentInfo_All_dataGrid.Show();
                    break;
                case 2:
                    string studentId_IT = dataGridInfoTech.Rows[e.RowIndex].Cells["InfoTech_StudentId"].Value?.ToString()!;
                    StudentInfo studentInfo_IT_dataGrid = new(this, studentId_IT, _context);

                    studentInfo_IT_dataGrid.Show();
                    break;
                case 3:
                    string studentId_HM = dataGridHM.Rows[e.RowIndex].Cells["HM_studentId"].Value?.ToString()!;
                    StudentInfo studentInfo_HM_dataGrid = new(this, studentId_HM, _context);

                    studentInfo_HM_dataGrid.Show();
                    break;
                case 4:
                    string studentId_Crim = dataGridCrim.Rows[e.RowIndex].Cells["Crim_studentId"].Value?.ToString()!;
                    StudentInfo studentInfo_Crim_dataGrid = new(this, studentId_Crim, _context);

                    studentInfo_Crim_dataGrid.Show();
                    break;
                case 5:
                    string studentId_Educ = dataGridEduc.Rows[e.RowIndex].Cells["Educ_StudentId"].Value?.ToString()!;
                    StudentInfo studentInfo_Educ_dataGrid = new(this, studentId_Educ, _context);

                    studentInfo_Educ_dataGrid.Show();
                    break;
                case 6:
                    string studentId_MedTech = dataGridMedTech.Rows[e.RowIndex].Cells["MedTech_StudentId"].Value?.ToString()!;
                    StudentInfo studentInfo_MedTech_dataGrid = new(this, studentId_MedTech, _context);

                    studentInfo_MedTech_dataGrid.Show();
                    break;
            }

        }

        private void EnableRequest(object sender, EventArgs e)
        {
            var set = _context.EnrollmentSettings.First(); ;
            set.AllowRequest = true;
            _context.Update(set);
            _context.SaveChanges();

        }

        private void DisableRequest(object sender, EventArgs e)
        {
            var set = _context.EnrollmentSettings.First(); ;
            set.AllowRequest = false;
            _context.Update(set);
            _context.SaveChanges();

        }

        private void NumberOfRequest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SetNumberOfRequest(object sender, EventArgs e)
        {
            var set = _context.EnrollmentSettings.First();

            set.Limit = numberOfRequest.Text == null ? 0 : Convert.ToInt32(numberOfRequest.Text);
            _context.Update(set);
            _context.SaveChanges();
        }

        private void EnableAutoAccept(object sender, EventArgs e)
        {
            var set = _context.EnrollmentSettings.First(); ;
            set.AutoAccept = true;
            _context.Update(set);
            _context.SaveChanges();

        }

        private void DisableAutoAccept(object sender, EventArgs e)
        {
            var set = _context.EnrollmentSettings.First(); ;
            set.AutoAccept = false;
            _context.Update(set);
            _context.SaveChanges();

        }

        private void StudentImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                studentImage.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            LoadData("Requests");
            LoadData();
            LoadData("Information Technology");
            LoadData("Hospitality Management");
            LoadData("Criminology");
            LoadData("Education");
            LoadData("MedTech");
        }

    }
}
