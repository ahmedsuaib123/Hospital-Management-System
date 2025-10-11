using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class CheckAccountStatus : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HOP36BN\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public CheckAccountStatus()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string select_query = "SELECT Username, Role, Status FROM Login";
                SqlDataAdapter da = new SqlDataAdapter(select_query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.ReadOnly = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // Handles both CellContentClick and CellClick (wired from Designer)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // if header clicked, ignore
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            textBoxUsername.Text = row.Cells["Username"].Value?.ToString() ?? "";
            textBoxRole.Text = row.Cells["Role"].Value?.ToString() ?? "";

            // get status as string (works for int/bit/varchar)
            string statusVal = row.Cells["Status"].Value?.ToString() ?? "";

            // ensure combo contains the value; if yes select it, otherwise clear selection
            if (comboBoxStatus.Items.Contains(statusVal))
                comboBoxStatus.SelectedItem = statusVal;
            else
                comboBoxStatus.SelectedIndex = -1;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                MessageBox.Show("Please select a user first!");
                return;
            }

            if (comboBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status");
                return;
            }

            // parse selected status to integer
            if (!int.TryParse(comboBoxStatus.SelectedItem.ToString(), out int statusInt))
            {
                MessageBox.Show("Invalid status");
                return;
            }

            try
            {
                con.Open();
                string updateQuery = "UPDATE Login SET Status = @status WHERE Username = @username";
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.Add("@status", SqlDbType.Int).Value = statusInt;
                    cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Account status updated successfully!");
                    else
                        MessageBox.Show("Update failed: username not found.");
                }

                // Refresh grid
                button1_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void CheckAccountStatus_Load(object sender, EventArgs e)
        {
            // populate combo with 0 and 1
            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.Add("0");
            comboBoxStatus.Items.Add("1");
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
