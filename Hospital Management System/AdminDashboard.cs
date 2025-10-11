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
    public partial class AdminDashboard : Form
    {

        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to Logout?", "Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
        }

        private void ManagePatientsLabel_Click(object sender, EventArgs e)
        {
            new PatientManagement().Show();
            this.Hide();
        }

        private void ManageDoctorsLabel_Click(object sender, EventArgs e)
        {
            new DoctorManagement().Show();
            this.Hide();
        }

        private void ManageNurseLabel_Click(object sender, EventArgs e)
        {
            new NurseManagement().Show();
            this.Hide();
        }

        private void MedicalRecordsLabel_Click(object sender, EventArgs e)
        {
            new MedicalRecords().Show();
            this.Hide();
        }

        private void AppointmentLabel_Click(object sender, EventArgs e)
        {
            new AppointmentsManagement().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PasswordChangeLabel_Click(object sender, EventArgs e)
        {
            new AdminPasswordChange().Show();
            this.Hide();
        }

        private void DepartmentsLabel_Click(object sender, EventArgs e)
        {
            new DepartmentManagement().Show();
            this.Hide();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            string patient_query = "Select COUNT(*) from Patient";
            string doctor_query = "Select COUNT(*) from Doctor";
            string nurse_query = "Select COUNT(*) from Nurse";
            string appointment_query = "Select COUNT(*) from Appointment";


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(patient_query, con);

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(doctor_query, con);

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(nurse_query, con);

            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(appointment_query, con);


            con.Open();
            da.Fill(dt);
            da1.Fill(dt1);
            da2.Fill(dt2);
            da3.Fill(dt3);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                PatientCountLabel.Text = dt.Rows[0][0].ToString();
                DoctorsCountLabel.Text = dt1.Rows[0][0].ToString();
                NursesCountLabel.Text = dt2.Rows[0][0].ToString();
                AppointmentsCountLabel.Text= dt3.Rows[0][0].ToString();
            }

            WelcomeLabel.Text ="Welcome, "+Login.username;

        }

        private void PatientsCountPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            new CheckAccountStatus().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ManageAdminsLabel_Click(object sender, EventArgs e)
        {
            new AdminManagement().Show();
            this.Hide();
        }
    }
}
