using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Management_System
{
    public partial class AdminPasswordChange : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HOP36BN\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public AdminPasswordChange()
        {
            InitializeComponent();
        }

        private void AdminPasswordChange_Load(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (NewPasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("New Password and Confirm Password do not match.");
                return;
            }

            string update_query = "update Login set Password = '" + ConfirmPasswordTextBox.Text + "' where Username = '" + Login.username + "' and Password = '" + CurrentPasswordTextBox.Text + "'";

            SqlCommand cmd = new SqlCommand(update_query, con);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Update password is successfull");
                    new AdminDashboard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Update password is not successfull");
                }
            }
            else
            {
                MessageBox.Show("Database Connection is not  valid");
            }

            CurrentPasswordTextBox.Clear();
            NewPasswordTextBox.Clear();
            ConfirmPasswordTextBox.Clear();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                //CurrentPasswordTextBox.UseSystemPasswordChar = false;
                NewPasswordTextBox.UseSystemPasswordChar = false;
                ConfirmPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                //CurrentPasswordTextBox.UseSystemPasswordChar = true;
                NewPasswordTextBox.UseSystemPasswordChar = true;
                ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
