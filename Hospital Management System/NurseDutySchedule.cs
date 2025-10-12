using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class NurseDutySchedule : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public NurseDutySchedule()
        {
            InitializeComponent();
        }

        private void NurseDutySchedule_Load(object sender, EventArgs e)
        {
            LoadNurses();
        }

        // Load nurse list
        private void LoadNurses()
        {
            try
            {
                string query = "SELECT NurseID, NurseName FROM Nurse";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading nurses: " + ex.Message);
            }
        }

        // Load duty schedule filtered by nurseID
        private void LoadDutySchedule(string nurseID = null)
        {
            try
            {
                string query = @"SELECT nd.DutyDate, nd.Shift
                                 FROM NurseDuty nd
                                 JOIN Nurse n ON nd.NurseID = n.NurseID";

                if (!string.IsNullOrEmpty(nurseID))
                {
                    query += " WHERE nd.NurseID = @nid";
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (!string.IsNullOrEmpty(nurseID))
                        cmd.Parameters.AddWithValue("@nid", nurseID);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewDutySchedule.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading duty schedule: " + ex.Message);
            }
        }

        // When a nurse is selected in the list
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string nurseID = row.Cells["NurseID"].Value.ToString();
                txtNurseID.Text = nurseID;
                txtNurseName.Text = row.Cells["NurseName"].Value.ToString();

                // Load selected nurse's duty schedule
                LoadDutySchedule(nurseID);
            }
        }

        // Assign duty to selected nurse
        private void btnAssignDuty_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNurseID.Text))
            {
                MessageBox.Show("Please select a nurse.");
                return;
            }

            if (comboBoxShift.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a shift.");
                return;
            }

            try
            {
                string query = "INSERT INTO NurseDuty (NurseID, DutyDate, Shift) VALUES (@nid, @dDate, @shift)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nid", txtNurseID.Text);
                    cmd.Parameters.AddWithValue("@dDate", dateTimePickerDuty.Value.Date);
                    cmd.Parameters.AddWithValue("@shift", comboBoxShift.SelectedItem.ToString());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Duty assigned successfully!");
                    LoadDutySchedule(txtNurseID.Text); // Refresh schedule for selected nurse
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error assigning duty: " + ex.Message);
            }
        }

        // Refresh duty schedule
        private void btnRefreshSchedule_Click(object sender, EventArgs e)
        {
            LoadDutySchedule(txtNurseID.Text);
        }

        // Back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            new NurseManagement().Show();
            this.Hide();
        }
    }
}