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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hospital_Management_System
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            new PatientManagement().Show();
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
            // Check required fields
            if (FullNameTextBox.Text == " " ||
                ContactTextBox.Text == " " ||
                UsernameTextBox.Text == " " ||
                GenderComboBox.SelectedItem == null ||
                BloodGroupComboBox.SelectedItem == null ||
                AddressTextBox.Text == " " ||
                DateOfTimeDateTimePicker.Value == null)
            {
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate age from Date of Birth
            int age = DateTime.Now.Year - DateOfTimeDateTimePicker.Value.Year;
            if (DateTime.Now.DayOfYear < DateOfTimeDateTimePicker.Value.DayOfYear)
                age--;

            AgeTextBox.Text = age.ToString();

            // Prepare single query for both tables
            string query = "INSERT INTO Patient (PatientName, PatientAge, Gender, PatientContact, BloodGroup, PatientAddress, PatientUsername) VALUES ('"
                    + FullNameTextBox.Text + "', '"
                    + age + "', '"
                    + gender + "', '"
                    + ContactTextBox.Text + "', '"
                    + BloodGroup + "', '"
                    + AddressTextBox.Text + "', '"
                    + UsernameTextBox.Text + "')";

            string query2 = @"INSERT INTO Login
(Username, Password, Role, Status)
VALUES
('" + UsernameTextBox.Text + "', '" + PasswordTextBox.Text + "', 'Patient', 1); ";

    // Execute query
    using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"))
            {
                con.Open();  // <-- This line is required
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear form fields
            FullNameTextBox.Clear();
            ContactTextBox.Clear();
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
            ConfirmPasswordTextBox.Clear();
            GenderComboBox.SelectedIndex = -1;
            BloodGroupComboBox.SelectedIndex = -1;
            AddressTextBox.Clear();
            AgeTextBox.Clear();
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {

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
    }
}
