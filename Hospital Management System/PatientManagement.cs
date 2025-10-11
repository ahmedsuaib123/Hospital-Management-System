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
    public partial class PatientManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HOP36BN\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public PatientManagement()
        {
            InitializeComponent();
        }

        private void PatientManagement_Load(object sender, EventArgs e)
        {
            string query = "SELECT PatientID,PatientName,PatientAge,Gender,PatientContact,BloodGroup,PatientAddress,PatientUsername FROM Patient";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            PatientDataGridView.DataSource = dt;

            PatientDataGridView.Columns["PatientID"].HeaderText = "Patient ID";

            PatientDataGridView.Columns["PatientName"].HeaderText = "Full Name";

            PatientDataGridView.Columns["PatientAge"].HeaderText = "Age";

            PatientDataGridView.Columns["PatientContact"].HeaderText = "Contact";

            PatientDataGridView.Columns["BloodGroup"].HeaderText = "Blood Group";

            PatientDataGridView.Columns["PatientAddress"].HeaderText = "Address";

            PatientDataGridView.Columns["PatientUsername"].HeaderText = "Username";

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new AddPatient().Show();
            this.Hide();
        }
    }
}
