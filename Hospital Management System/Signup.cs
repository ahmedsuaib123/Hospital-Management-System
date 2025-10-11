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
    public partial class Signup : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HOP36BN\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");


        public Signup()
        {
            InitializeComponent();
        }

        private void HideOptionalFields()
        {
            QualificationLabel.Visible = false;
            QualificationTextBox.Visible = false;
            AddressLabel.Visible = false;
            AddressTextBox.Visible = false;
        }

        private void AddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QualificationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QualificationLabel_Click(object sender, EventArgs e)
        {

        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                ConfirmPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void AccountInformationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private bool HasSpecialChar(string password) => password.Any(ch => !char.IsLetterOrDigit(ch));
        private bool HasUpperCase(string password) => password.Any(ch => char.IsUpper(ch));
        private bool HasLowerCase(string password) => password.Any(ch => char.IsLower(ch));
        private bool HasNumber(string password) => password.Any(ch => char.IsDigit(ch));


        private void DateOfTimeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateOfTimeDateTimePicker.Format = DateTimePickerFormat.Short;
            DateTime dob = DateOfTimeDateTimePicker.Value;
            DateTime today = DateTime.Today;

            int age = today.Year - dob.Year;
            if (dob.Date > today.AddYears(-age)) age--;
            AgeTextBox.Text = age.ToString();
        }

        private void ContactTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = ContactTextBox.Text;
            if (input.Length > 11)
            {
                MessageBox.Show("Phone number must be 11 digits.");
                ContactTextBox.Text = input.Substring(0, 11);
                ContactTextBox.SelectionStart = ContactTextBox.Text.Length;
            }
            if (input.Length >= 2 && !input.StartsWith("01"))
            {
                MessageBox.Show("Phone number must start with 01.");
                ContactTextBox.Clear();
            }
        }

        // ---------------------- Signup Button ----------------------
        

        private void ResetButton_Click(object sender, EventArgs e)
        {
            FullNameTextBox.Text = "";
            AgeTextBox.Text = "";
            ContactTextBox.Text = "";
            BloodGroupComboBox.Text = "";
            
            QualificationTextBox.Text = "";
            
            AddressTextBox.Text = "";
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
            ConfirmPasswordTextBox.Text = "";

            if (GenderComboBox.Items.Count > 0)
                GenderComboBox.Text = "Select";
            if (CategoryComboBox.Items.Count > 0)
                CategoryComboBox.Text = "Select";

            DateOfTimeDateTimePicker.Value = DateTime.Today;

            HideOptionalFields();
            FullNameTextBox.Focus();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = CategoryComboBox.Text;

            HideOptionalFields();

            if (category == "Doctor")
            {
                QualificationLabel.Visible = true;
                QualificationTextBox.Visible = true;
            }
            else if (category == "Nurse")
            {
                //ShiftLabel.Visible = true;
                //ShiftTextBox.Visible = true;
            }
            else if (category == "Patient")
            {
                AddressLabel.Visible = true;
                AddressTextBox.Visible = true;
            }
        }

        private void ContactTextBox_TextChanged_1(object sender, EventArgs e)
        {
            string input = ContactTextBox.Text;
            if (input.Length > 11)
            {
                MessageBox.Show("Phone number must be 11 digits.");
                ContactTextBox.Text = input.Substring(0, 11);
                ContactTextBox.SelectionStart = ContactTextBox.Text.Length;
            }
            if (input.Length >= 2 && !input.StartsWith("01"))
            {
                MessageBox.Show("Phone number must start with 01.");
                ContactTextBox.Clear();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text == "" ||
               GenderComboBox.Text == "Select" ||
               BloodGroupComboBox.Text == "Select" ||
               ContactTextBox.Text == "" ||
               CategoryComboBox.Text == "Select")
            {
                MessageBox.Show("Please fill out all fields before proceeding.");
                return;
            }

            string category = CategoryComboBox.Text;
            if (category == "Doctor" && QualificationTextBox.Text == "")
            {
                MessageBox.Show("Please enter your Qualification.");
                return;
            }
            //if (category == "Nurse" && ShiftTextBox.Text == "")
            //{
            //    MessageBox.Show("Please enter your Shift.");
            //    return;
            //}
            if (category == "Patient" && (AddressTextBox.Text == ""))
            {
                MessageBox.Show("Please enter Diagnosis and Address.");
                return;
            }

            GeneralInformationsPanel.Visible = false;
            AccountInformationPanel.Visible = true;
        }

        private void SignupButton_Click_1(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            string confirmPassword = ConfirmPasswordTextBox.Text.Trim();
            string category = CategoryComboBox.Text;
            string gender = GenderComboBox.Text;
            string BloodGroup = BloodGroupComboBox.Text;
            string age = AgeTextBox.Text;

            // ---------- Username Checks ----------
            if (username == "")
            {
                MessageBox.Show("No Username Detected");
                return;
            }

            try
            {
                con.Open();
                string checkQuery = "SELECT COUNT(*) FROM Login WHERE Username = '" + username + "'";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                int count = (int)checkCmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("Username already taken. Please choose another.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking username: " + ex.Message);
                return;
            }

            // ---------- Password Checks ----------
            if (password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please enter and confirm your password.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            if (password.Length < 6 || !HasUpperCase(password) || !HasLowerCase(password) || !HasNumber(password) || !HasSpecialChar(password))
            {
                MessageBox.Show("Password must contain at least one lowercase letter, one uppercase, one number, one special character and must be at least 6 characters long.");
                return;
            }

            // ---------- Prepare Queries ----------
            string insert_query = "";
            string login_query = "";

            if (category == "Patient")
            {
                insert_query = "INSERT INTO Patient (PatientName, PatientAge, Gender, PatientContact, BloodGroup, PatientAddress, PatientUsername) VALUES ('"
                    + FullNameTextBox.Text + "', '"
                    + age + "', '"
                    + gender + "', '"
                    + ContactTextBox.Text + "', '"
                    + BloodGroup + "', '"
                    + AddressTextBox.Text + "', '"
                    + UsernameTextBox.Text + "')";
            }
            else if (category == "Doctor")
            {
                insert_query = "INSERT INTO Doctor (DoctorName, DoctorAge, Gender, DoctorContact, BloodGroup, Qualification,DoctorUsername) VALUES ('"
                    + FullNameTextBox.Text + "', '"
                    + age + "', '"
                    + gender + "', '"
                    + ContactTextBox.Text + "', '"
                    + BloodGroup + "', '"
                    + QualificationTextBox.Text + "','"
                    + UsernameTextBox.Text + "')";
            }
            else if (category == "Nurse")
            {
                insert_query = "INSERT INTO Nurse (NurseName, NurseAge, Gender, NurseContact, BloodGroup,NurseUsername) VALUES ('"
                    + FullNameTextBox.Text + "', '"
                    + age + "', '"
                    + gender + "', '"
                    + ContactTextBox.Text + "', '"
                    + BloodGroup + "','"
                    + UsernameTextBox.Text + "')";
            }
            else
            {
                MessageBox.Show("Invalid category selected!");
                return;
            }

            login_query = "INSERT INTO Login (Username, Password, Role) VALUES ('"
                + UsernameTextBox.Text + "', '"
                + PasswordTextBox.Text + "', '"
                + category + "' )";

            // ---------- Execute Queries ----------

            con.Open();

            SqlCommand cmd = new SqlCommand(insert_query, con);
            cmd.ExecuteNonQuery();

            SqlCommand loginCmd = new SqlCommand(login_query, con);
            loginCmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Account created successfully!");

            AccountInformationPanel.Hide();
            GeneralInformationsPanel.Hide();
            this.Hide();
            ResetButton_Click(sender, e);
            new Login().Show();
        }
    }
}
