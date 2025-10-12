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
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }


        private bool HasSpecialChar(string password) => password.Any(ch => !char.IsLetterOrDigit(ch));
        private bool HasUpperCase(string password) => password.Any(ch => char.IsUpper(ch));
        private bool HasLowerCase(string password) => password.Any(ch => char.IsLower(ch));
        private bool HasNumber(string password) => password.Any(ch => char.IsDigit(ch));
        private void AddButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            string confirmPassword = ConfirmPasswordTextBox.Text.Trim();
            string gender = GenderComboBox.Text;
            string BloodGroup = BloodGroupComboBox.Text;
            string availableSlot = AvailableSlotComboBox.Text;

            // Calculate age from Date of Birth
            int age = DateTime.Now.Year - DateOfTimeDateTimePicker.Value.Year;
            if (DateTime.Now.DayOfYear < DateOfTimeDateTimePicker.Value.DayOfYear)
                age--;

            AgeTextBox.Text = age.ToString();
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

            // ---------- Username Checks ----------
            if (username == "")
            {
                MessageBox.Show("No Username Detected");
                return;
            }

            string insert_query = "INSERT INTO Doctor (DoctorName, DoctorAge, Gender, DoctorContact, BloodGroup, Qualification, Department, AvailableSlot, DoctorUsername) VALUES ('"
            + FullNameTextBox.Text + "', '"
            + age + "', '"
            + gender + "', '"
            + ContactTextBox.Text + "', '"
            + BloodGroup + "', '"
            + QualificationTextBox.Text + "', '"
            + DepartmentTextBox.Text + "', '"
            + availableSlot + "', '"
            + UsernameTextBox.Text + "')";

            insert_query += @"INSERT INTO Login
(Username, Password, Role, Status)
VALUES
('" + username + "', '" + password + "', 'Doctor', 1)";
            // Execute query
            using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"))
            {
                con.Open();  // <-- This line is required
                SqlCommand cmd = new SqlCommand(insert_query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Doctor Added Successfully!");

            new DoctorManagement().Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            new DoctorManagement().Show();
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

        private void AddDoctor_Load(object sender, EventArgs e)
        {

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

        private void DateOfTimeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateOfTimeDateTimePicker.Format = DateTimePickerFormat.Short;
            DateTime dob = DateOfTimeDateTimePicker.Value;
            DateTime today = DateTime.Today;

            int age = today.Year - dob.Year;
            if (dob.Date > today.AddYears(-age)) age--;
            AgeTextBox.Text = age.ToString();
        }

        private void AvailableSlotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
