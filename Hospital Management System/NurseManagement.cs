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
    public partial class NurseManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HOP36BN\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");
        public NurseManagement()
        {
            InitializeComponent();
        }

        private void NurseManagement_Load(object sender, EventArgs e)
        {
            string query = "SELECT NurseID,NurseName,NurseAge,Gender,NurseContact,NurseUsername FROM Nurse";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            NurseDataGridView.DataSource = dt;

            NurseDataGridView.Columns["NurseID"].HeaderText = "ID";

            NurseDataGridView.Columns["NurseName"].HeaderText = "Full Name";

            NurseDataGridView.Columns["NurseAge"].HeaderText = "Age";

            NurseDataGridView.Columns["NurseContact"].HeaderText = "Contact";

            NurseDataGridView.Columns["NurseUsername"].HeaderText = "Username";


        }

        private void DutyScheduleButton_Click(object sender, EventArgs e)
        {
            new NurseDutySchedule().Show();
            this.Hide();
        }
    }
}
