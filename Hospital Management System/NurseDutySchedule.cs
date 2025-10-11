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
using System.Windows.Forms.VisualStyles;

namespace Hospital_Management_System
{
    public partial class NurseDutySchedule : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HOP36BN\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public NurseDutySchedule()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new NurseManagement().Show();
            this.Hide();
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void NurseDutySchedule_Load(object sender, EventArgs e)
        {
            string query = "Select NurseID,NurseName from Nurse";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            textBoxUsername.Text = row.Cells["Username"].Value?.ToString() ?? "";
            textBoxRole.Text = row.Cells["Role"].Value?.ToString() ?? "";

            // get status as string (works for int/bit/varchar)
            string statusVal = row.Cells["Status"].Value?.ToString() ?? "";

            // ensure combo contains the value; if yes select it, otherwise clear selection
            if (StatusCom.Items.Contains(statusVal))
                comboBoxStatus.SelectedItem = statusVal;
            else
                comboBoxStatus.SelectedIndex = -1;
        }
    }
}
