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
    public partial class Login : Form
    {
        public static string username;
        public static string adminID;
        public static string patientID;
        public static string doctorID;
        public static string nurseID;
        public static string fullName;
        public static string adminEmail;
        public static string age;
        public static string gender;
        public static string bloodGroup;
        public static string contact;
        public static string role;
        public static string department;
        public static string qualification;
        public static string availableSlot;

        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");
        internal static int nurseId;

        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
           string query = "select * from Login where Username='" + UsernameTextBox.Text + "' and Password='" + PasswordTextBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0][4].ToString() == "1")
                {
                    Login.username = dt.Rows[0]["Username"].ToString();
                    string role = dt.Rows[0]["Role"].ToString();

                    if (role == "Doctor")
                    {
                        SqlDataAdapter da = new SqlDataAdapter(
                            "SELECT DoctorID, DoctorName, DoctorContact, DoctorAge, Gender, BloodGroup, AvailableSlot " +
                            "FROM Doctor WHERE DoctorUsername='" + username + "'", con);
                        DataTable dtt = new DataTable();
                        da.Fill(dtt);
                        if (dtt.Rows.Count > 0)
                        {
                            doctorID = Convert.ToInt32(dtt.Rows[0]["DoctorID"]).ToString();  
                            fullName = dtt.Rows[0]["DoctorName"].ToString();
                            contact = dtt.Rows[0]["DoctorContact"].ToString();
                            age = Convert.ToInt32(dtt.Rows[0]["DoctorAge"]).ToString();
                            gender = dtt.Rows[0]["Gender"].ToString();
                            bloodGroup = dtt.Rows[0]["BloodGroup"].ToString();
                            availableSlot = dtt.Rows[0]["AvailableSlot"].ToString();
                        }
                    }
                    else if (role == "Patient")
                    {
                        SqlDataAdapter da = new SqlDataAdapter(
                            "SELECT PatientID, PatientName, PatientContact FROM Patient WHERE PatientUsername='" + username + "'", con);
                        DataTable dtt = new DataTable();
                        da.Fill(dtt);
                        if (dtt.Rows.Count > 0)
                        {
                            patientID = Convert.ToInt32(dtt.Rows[0]["PatientID"]).ToString();   
                            fullName = dtt.Rows[0]["PatientName"].ToString();
                            contact = dtt.Rows[0]["PatientContact"].ToString();  
                        }
                    }
                    else if (role == "Nurse")
                    {
                        SqlDataAdapter da = new SqlDataAdapter("SELECT NurseID, NurseName FROM Nurse WHERE NurseUsername='" + username + "'", con);
                        DataTable dtt = new DataTable();
                        da.Fill(dtt);
                        if (dtt.Rows.Count > 0)
                        {
                            nurseID = Convert.ToInt32(dtt.Rows[0]["NurseID"]).ToString();   
                            fullName = dtt.Rows[0]["NurseName"].ToString();
                        }
                    }
                    else
                    {
                        fullName = username;
                    }

                    if (role == "Admin")
                    {
                        new AdminDashboard().Show();
                        this.Hide();
                    }
                    else if (role == "Patient")
                    {
                        new PatientDashboard().Show();
                        this.Hide();
                    }
                    else if (role == "Doctor")
                    {
                        new DoctorDashboard().Show();
                        this.Hide();
                    }
                    else if (role == "Nurse")
                    {
                        new NurseDashboard().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Unknown Role! Contact admin.");
                    }
                }
                else
                {
                    MessageBox.Show("Account is disabled. Contact with admin");
                }
            }
            else
            {
                MessageBox.Show("Wrong Credentials!! Try Again.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ForgetPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ForgetPassword().Show();
            this.Hide();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            new Signup().Show();
            this.Hide();
        }
    }

}
