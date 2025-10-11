using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class BookAppointment : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;");
        private int PatientID; // Stores logged-in patient's ID

        public BookAppointment()
        {
            InitializeComponent();
            //PatientID = Login.patientID;
            LoadDoctorList(); 
        }

        private void BookAppointment_Load(object sender, EventArgs e)
        {
            DocNameTextBox.ReadOnly = true;
            DepartmentTextBox.ReadOnly = true;
            LoadDoctors();
        }

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

        private void DoctorIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void BookButton_Click(object sender, EventArgs e)
        {
            if (DoctorIDComboBox.SelectedIndex == -1 || AvailableSlotComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Doctor and a Slot.");
                return;
            }

            // ** Check for null PatientContact **
            if (string.IsNullOrEmpty(Login.contact))
            {
                MessageBox.Show("Patient contact is missing. Please update your contact information.");
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

                cmd.Parameters.AddWithValue("@PatientID", PatientID);
                cmd.Parameters.AddWithValue("@DoctorID", DoctorIDComboBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PatientContact", Login.contact); // ✅ now never null
                cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDatePicker.Value.Date);
                cmd.Parameters.AddWithValue("@AppointmentSlot", AvailableSlotComboBox.SelectedItem.ToString());
                //cmd.Parameters.AddWithValue("@Status", 1); // Pending status

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Appointment booked successfully!");
                    new PatientDashboard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Booking failed!");
                }
                    

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error booking appointment: " + ex.Message);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new PatientDashboard().Show();
            this.Hide();
        }

        private void DocNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadDoctorList()
        {
            
                con.Open();
                string query = "SELECT DoctorID, DoctorName, Department FROM Doctor";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.ReadOnly = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                con.Close();
            
            
        }
    }
}
