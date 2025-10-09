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
    public partial class ShowAppointments : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HOP36BN\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");
        public ShowAppointments()
        {
            InitializeComponent();
        }

        private void ShowAppointments_Load(object sender, EventArgs e)
        {
            string query = "select a.AppointmentID,p.PatientName,d.DoctorName,a.AppointmentDate,a.AppointmentSlot from Appointment a,Patient p,Doctor d where a.PatientID=p.PatientID and a.DoctorID=d.DoctorID";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            AppointmentsDataGridView.DataSource = dt;

            AppointmentsDataGridView.Columns["AppointmentID"].HeaderText = "ID";

            AppointmentsDataGridView.Columns["PatientName"].HeaderText = "Patient Name";

            AppointmentsDataGridView.Columns["DoctorName"].HeaderText = "Doctor Name";

            AppointmentsDataGridView.Columns["AppointmentDate"].HeaderText = "Date";

            AppointmentsDataGridView.Columns["AppointmentSlot"].HeaderText = "Time";

            AppointmentsDataGridView.Columns["Status"].HeaderText = "Status";

        }
    }
}
