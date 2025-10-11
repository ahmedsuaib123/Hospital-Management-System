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
    public partial class ViewAppointments : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public ViewAppointments()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new PatientDashboard().Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to close the application?", "Closing Window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ViewAppointments_Load(object sender, EventArgs e)
        {
            string query = "select a.AppointmentID,d.DoctorName,a.AppointmentDate,a.AppointmentSlot from Appointment a,Patient p,Doctor d where a.PatientID=p.PatientID and a.DoctorID=d.DoctorID and p.PatientUsername='" + Login.username + "'";

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
        }
    }
}
