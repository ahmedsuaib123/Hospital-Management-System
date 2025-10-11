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
    public partial class AddNurse : Form
    {

        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
        public AddNurse()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            new NurseManagement().Show();
            this.Hide();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        // ---------- Password Validation Helpers ----------
        private bool HasSpecialChar(string password) => password.Any(ch => !char.IsLetterOrDigit(ch));
        private bool HasUpperCase(string password) => password.Any(ch => char.IsUpper(ch));
        private bool HasLowerCase(string password) => password.Any(ch => char.IsLower(ch));
        private bool HasNumber(string password) => password.Any(ch => char.IsDigit(ch));

        private void AddButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;
            string gender = GenderComboBox.Text;
            string bloodGroup = BloodGroupComboBox.Text;

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
                MessageBox.Show("Password must contain at least one lowercase letter, one uppercase letter, one number, one special character and must be at least 6 characters long.");
                return;
            }

            // ---------- Required Fields Check ----------
            if (FullNameTextBox.Text == " " ||
                ContactTextBox.Text == " " ||
                UsernameTextBox.Text == " " ||
                GenderComboBox.SelectedItem == null ||
                BloodGroupComboBox.SelectedItem == null ||
                DateOfBirthPicker.Value == null)
            {
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ---------- Calculate Age ----------
            int age = DateTime.Now.Year - DateOfBirthPicker.Value.Year;
            if (DateTime.Now.DayOfYear < DateOfBirthPicker.Value.DayOfYear)
                age--;

            AgeTextBox.Text = age.ToString();

            // ---------- SQL Queries ----------
            string query = "INSERT INTO Nurse (NurseName, NurseAge, Gender, NurseContact, BloodGroup, NurseUsername) VALUES ('"
                + FullNameTextBox.Text + "', '"
                + age + "', '"
                + gender + "', '"
                + ContactTextBox.Text + "', '"
                + bloodGroup + "', '"
                + UsernameTextBox.Text + "')";

            string query2 = @"INSERT INTO Login (Username, Password, Role, Status) VALUES ('" + UsernameTextBox.Text + "', '" + PasswordTextBox.Text + "', 'Nurse', 1);";

           
                    con.Open();

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.ExecuteNonQuery();

                    con.Close();
                

                MessageBox.Show("Nurse added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ---------- Clear Form ----------
                FullNameTextBox.Clear();
                ContactTextBox.Clear();
                UsernameTextBox.Clear();
                PasswordTextBox.Clear();
                ConfirmPasswordTextBox.Clear();
                GenderComboBox.SelectedIndex = -1;
                BloodGroupComboBox.SelectedIndex = -1;
                AgeTextBox.Clear();
            
        }

        

        

        private void DateOfTimeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateOfBirthPicker.Format = DateTimePickerFormat.Short;
            DateTime dob = DateOfBirthPicker.Value;
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

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            string confirmPassword = ConfirmPasswordTextBox.Text.Trim();
            string gender = GenderComboBox.Text;
            string BloodGroup = BloodGroupComboBox.Text;

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
            
            if (FullNameTextBox.Text == " " ||
                ContactTextBox.Text == " " ||
                UsernameTextBox.Text == " " ||
                GenderComboBox.SelectedItem == null ||
                BloodGroupComboBox.SelectedItem == null  ||
                DateOfBirthPicker.Value == null)
            {
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int age = DateTime.Now.Year - DateOfBirthPicker.Value.Year;
            if (DateTime.Now.DayOfYear < DateOfBirthPicker.Value.DayOfYear)
                age--;

            AgeTextBox.Text = age.ToString();

            string query = "INSERT INTO Patient (PatientName, PatientAge, Gender, PatientContact, BloodGroup, PatientAddress, PatientUsername) VALUES ('"
                    + FullNameTextBox.Text + "', '"
                    + age + "', '"
                    + gender + "', '"
                    + ContactTextBox.Text + "', '"
                    + BloodGroup + "',  '"
                    + UsernameTextBox.Text + "')";

            string query2 = @"INSERT INTO Login (Username, Password, Role, Status) VALUES ('" + UsernameTextBox.Text + "', '" + PasswordTextBox.Text + "', 'Patient', 1); ";

            
                con.Open(); 
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
         

            MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear form fields
            FullNameTextBox.Clear();
            ContactTextBox.Clear();
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
            ConfirmPasswordTextBox.Clear();
            GenderComboBox.SelectedIndex = -1;
            BloodGroupComboBox.SelectedIndex = -1;
            AgeTextBox.Clear();
        }
    }
}
