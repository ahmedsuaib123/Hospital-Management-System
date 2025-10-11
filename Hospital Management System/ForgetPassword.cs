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

namespace Hospital_Management_System
{
    public partial class ForgetPassword : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HOP36BN\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");
        
        private string userType = "";
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                
                    con.Open();

                    // Check Doctor table
                    string doctorQuery = "SELECT COUNT(*) FROM Doctor WHERE DoctorUsername = '" + username + "'";
                    SqlCommand doctorCmd = new SqlCommand(doctorQuery, con);
                    int doctorCount = (int)doctorCmd.ExecuteScalar();
                    if (doctorCount > 0)
                    {
                        userType = "Doctor";
                        ContactLabel.Visible = true;
                        ContactTextBox.Visible = true;
                        VerifyButton1.Visible = true;
                        return;
                    }

                    // Check Nurse table
                    string nurseQuery = "SELECT COUNT(*) FROM Nurse WHERE NurseUsername = '" + username + "'";
                    SqlCommand nurseCmd = new SqlCommand(nurseQuery, con);
                    int nurseCount = (int)nurseCmd.ExecuteScalar();
                    if (nurseCount > 0)
                    {
                        userType = "Nurse";
                        ContactLabel.Visible = true;
                        ContactTextBox.Visible = true;
                        VerifyButton1.Visible = true;
                        return;
                    }

                    // Check Patient table
                    string patientQuery = "SELECT COUNT(*) FROM Patient WHERE PatientUsername = '" + username + "'";
                    SqlCommand patientCmd = new SqlCommand(patientQuery, con);
                    int patientCount = (int)patientCmd.ExecuteScalar();
                    if (patientCount > 0)
                    {
                        userType = "Patient";
                        ContactLabel.Visible = true;
                        ContactTextBox.Visible = true;
                        VerifyButton1.Visible = true;
                        return;
                    }

                    // Username not found
                    MessageBox.Show("Invalid username. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            
        }

        private void VerifyButton1_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string phone = ContactTextBox.Text.Trim();

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please enter your phone number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
                
                    con.Open();

                    string query = "";

                    if (userType == "Doctor")
                        query = "SELECT COUNT(*) FROM Doctor WHERE DoctorUsername = '" + username + "' AND DoctorContact = '" + phone + "'";
                    else if (userType == "Nurse")
                        query = "SELECT COUNT(*) FROM Nurse WHERE NurseUsername = '" + username + "' AND NurseContact = '" + phone + "'";
                    else if (userType == "Patient")
                        query = "SELECT COUNT(*) FROM Patient WHERE PatientUsername = '" + username + "' AND PatientContact = '" + phone + "'";

                    SqlCommand cmd = new SqlCommand(query, con);
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Phone number verified. You can now reset your password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Show password reset fields
                        NewPasswordLabel.Visible = true;
                        NewPasswordTextBox.Visible = true;
                        ConfirmPasswordLabel.Visible = true;
                        ConfirmPasswordTextBox.Visible = true;
                        ConfirmButton.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Phone number does not match our records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            
        }
    }
}
