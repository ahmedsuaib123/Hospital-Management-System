using Hospital_Management;
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
    public partial class AppointmentsManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HOP36BN\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");
        public AppointmentsManagement()
        {
            InitializeComponent();
        }

        private void ShowAppointments_Load(object sender, EventArgs e)
        {
            string query = "select a.AppointmentID,p.PatientName,d.DoctorName,a.PatientContact,a.AppointmentDate,a.AppointmentSlot from Appointment a,Patient p,Doctor d where a.PatientID=p.PatientID and a.DoctorID=d.DoctorID";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            AppointmentsDataGridView.DataSource = dt;

            AppointmentsDataGridView.Columns["AppointmentID"].HeaderText = "ID";

            AppointmentsDataGridView.Columns["PatientName"].HeaderText = "Patient Name";

            AppointmentsDataGridView.Columns["DoctorName"].HeaderText = "Doctor Name";

            AppointmentsDataGridView.Columns["AppointmentDate"].HeaderText = "Date";

            AppointmentsDataGridView.Columns["AppointmentSlot"].HeaderText = "Time";

            AppointmentsDataGridView.Columns["PatientContact"].HeaderText = "Contact";

            //AppointmentsDataGridView.Columns["Status"].HeaderText = "Status";

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new AddAppointments().Show();
            this.Hide();
        }
    }
}
