using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (password.Text.ToLower() != "admin" || username.Text.ToLower() != "admin")
            {
                validationText.Visible = true;
                password.Text = "";
                username.Text = "";
            }
            else
            {
                //AdminDashboard ad = new AdminDashboard();
                //ad.Show();
                //this.Hide();
            }
        }

        
    }
}
