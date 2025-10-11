using Hospital_Management_System;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class AddAppointments : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public AddAppointments()
        {
            InitializeComponent();
            LoadPatients();
            LoadDoctors();
            LoadDoctorList(); // Load Doctor List DataGridView
        }

        // Load all Patient IDs into comboBox1
        private void LoadPatients()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT PatientID FROM Patient", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PatientIDComboBox.Items.Add(dr["PatientID"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message);
            }
        }

        // Load all Doctor IDs into DoctorIDComboBox
        private void LoadDoctors()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DoctorID FROM Doctor", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DoctorIDComboBox.Items.Add(dr["DoctorID"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message);
            }
        }

        // Load Doctor List DataGridView (DoctorID & DoctorName only)
        private void LoadDoctorList()
        {
            try
            {
                con.Open();
                string query = "SELECT DoctorID, DoctorName,Department FROM Doctor";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DoctorListDataGridView.DataSource = dt;

                DoctorListDataGridView.ReadOnly = true;
                DoctorListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DoctorListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctor list: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AppointmentsManagement().Show();
            this.Hide();
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            if (PatientIDComboBox.SelectedIndex == -1 || DoctorIDComboBox.SelectedIndex == -1 || AvailableSlotComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Patient, Doctor and Slot.");
                return;
            }

            if (string.IsNullOrWhiteSpace(ContactTextBox.Text))
            {
                MessageBox.Show("Patient contact is missing.");
                return;
            }

            try
            {
                con.Open();

                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Appointment WHERE DoctorID=@DoctorID AND AppointmentDate=@AppointmentDate AND AppointmentSlot=@AppointmentSlot", con);
                checkCmd.Parameters.AddWithValue("@DoctorID", DoctorIDComboBox.SelectedItem.ToString());
                checkCmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDatePicker.Value.Date);
                checkCmd.Parameters.AddWithValue("@AppointmentSlot", AvailableSlotComboBox.SelectedItem.ToString());

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("This slot is already booked. Please select another slot.");
                    con.Close();
                    return;
                }

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Appointment (PatientID, DoctorID, PatientContact, AppointmentDate, AppointmentSlot) " +
                    "VALUES (@PatientID, @DoctorID, @PatientContact, @AppointmentDate, @AppointmentSlot)", con);

                cmd.Parameters.AddWithValue("@PatientID", PatientIDComboBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DoctorID", DoctorIDComboBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PatientContact", ContactTextBox.Text);
                cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDatePicker.Value.Date);
                cmd.Parameters.AddWithValue("@AppointmentSlot", AvailableSlotComboBox.SelectedItem.ToString());
                cmd.ExecuteNonQuery();

                SqlCommand recordCmd = new SqlCommand(
                    "INSERT INTO MedicalRecords (PatientID, DoctorID, Diagnosis, Date) " +
                    "VALUES (@PatientID, @DoctorID, @Diagnosis, @Date)", con);
                recordCmd.Parameters.AddWithValue("@PatientID", PatientIDComboBox.SelectedItem.ToString());
                recordCmd.Parameters.AddWithValue("@DoctorID", DoctorIDComboBox.SelectedItem.ToString());
                recordCmd.Parameters.AddWithValue("@Diagnosis", DiagnosisTextBox.Text);
                recordCmd.Parameters.AddWithValue("@Date", AppointmentDatePicker.Value.Date);
                recordCmd.ExecuteNonQuery();

                MessageBox.Show("Appointment booked successfully!");
                new AppointmentsManagement().Show();
                this.Hide();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error booking appointment: " + ex.Message);
            }
        }

        // 🔹 When PatientID is selected → load PatientName & Contact
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(PatientIDComboBox.Text))
                    return;

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT PatientName, PatientContact FROM Patient WHERE PatientID=@PatientID", con);
                cmd.Parameters.AddWithValue("@PatientID", PatientIDComboBox.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    PatientNameTextBox.Text = dr["PatientName"].ToString();
                    ContactTextBox.Text = dr["PatientContact"].ToString();
                }
                else
                {
                    PatientNameTextBox.Clear();
                    ContactTextBox.Clear();
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patient details: " + ex.Message);
            }
        }

        // 🔹 When DoctorID is selected → load DoctorName, Department & Available Slots
        private void DoctorIDComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DoctorName, Department, AvailableSlot FROM Doctor WHERE DoctorID=@DoctorID", con);
                cmd.Parameters.AddWithValue("@DoctorID", DoctorIDComboBox.SelectedItem.ToString());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DocNameTextBox.Text = dr["DoctorName"].ToString();
                    DepartmentTextBox.Text = dr["Department"].ToString();

                    AvailableSlotComboBox.Items.Clear();
                    string[] slots = dr["AvailableSlot"].ToString().Split(',');
                    foreach (string slot in slots)
                        AvailableSlotComboBox.Items.Add(slot.Trim());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctor details: " + ex.Message);
            }
        }

        private void DocNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AppointmentsManagement().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddAppointments_Load(object sender, EventArgs e)
        {
            string query="select DoctorID,DoctorName,Department from Doctor";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            DoctorListDataGridView.DataSource = dt;

            DoctorListDataGridView.Columns["DoctorID"].HeaderText = "Doctor ID";

            DoctorListDataGridView.Columns["DoctorName"].HeaderText = "Full Name";

            DoctorListDataGridView.Columns["Department"].HeaderText = "Department";

        }
    }
}
