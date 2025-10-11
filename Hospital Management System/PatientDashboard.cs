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
    public partial class PatientDashboard : Form
    {

        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        private bool isProfilePanelExpanded = false;
        private int targetWidth = 220; // Desired width of the panel when expanded
        private int animationStep = 20; // Step size for each timer tick

        public PatientDashboard()
        {
            InitializeComponent();
            ProfilePanel.Width = 0; // Start with the panel collapsed
            ProfilePanel.Left = this.ClientSize.Width; // Position it off-screen to the right

            timer.Tick += timer_Tick;
            ProfilePanelExtender.Click += ProfilePanelExtender_Click;

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            
        }

        private void DateLabel_Click(object sender, EventArgs e)
        {
            //DateLabel.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }

        private void PatientDashboard_Load(object sender, EventArgs e)
        {
            Name1Label.Text = Login.fullName;
            Contact1Label.Text = Login.contact;
            Age1Label.Text = Login.age != null ? Login.age.ToString() : "N/A";
            Gender1Label.Text = Login.gender;
            BloodGroup1Label.Text = Login.bloodGroup;

            DateLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt");
            Timer dateTimer = new Timer { Interval = 1000 };
            dateTimer.Tick += (s, ev) => DateLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt");
            dateTimer.Start();
        }

        private void ProfilePanelExtender_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isProfilePanelExpanded)
            {
                ProfilePanel.Width -= animationStep;
                ProfilePanel.Left += animationStep;
                if (ProfilePanel.Width <= 0)
                {
                    ProfilePanel.Width = 0;
                    ProfilePanel.Left = this.ClientSize.Width;
                    isProfilePanelExpanded = false;
                    timer.Stop();
                }
            }
            else
            {
                ProfilePanel.Width += animationStep;
                ProfilePanel.Left -= animationStep;
                if (ProfilePanel.Width >= targetWidth)
                {
                    ProfilePanel.Width = targetWidth;
                    ProfilePanel.Left = this.ClientSize.Width - targetWidth;
                    isProfilePanelExpanded = true;
                    timer.Stop();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to Logout?", "Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
        }

        private void BookAppointmentButton_Click(object sender, EventArgs e)
        {
            new BookAppointment().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new ViewAppointments().Show();
            this.Hide();
        }
    }
}
