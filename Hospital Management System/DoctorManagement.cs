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
    public partial class DoctorManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HOP36BN\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public DoctorManagement()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void DoctorsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DoctorManagement_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Doctor";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            DoctorsDataGridView.DataSource = dt;

            DoctorsDataGridView.Columns["DoctorID"].HeaderText = "Doctor ID";

            DoctorsDataGridView.Columns["DoctorName"].HeaderText = "Full Name";

            DoctorsDataGridView.Columns["DoctorAge"].HeaderText = "Age";

            DoctorsDataGridView.Columns["DoctorContact"].HeaderText = "Contact";

            DoctorsDataGridView.Columns["AvailableSlot"].HeaderText = "Available Slot";

            DoctorsDataGridView.Columns["DoctorUsername"].HeaderText = "Username";

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new AddDoctor().Show();
            this.Hide();
        }
    }
}
