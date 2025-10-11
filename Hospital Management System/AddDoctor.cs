using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        

        private void AddButton_Click(object sender, EventArgs e)
        {

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
    }
}
