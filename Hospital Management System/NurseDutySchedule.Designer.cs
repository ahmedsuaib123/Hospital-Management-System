namespace Hospital_Management_System
{
    partial class NurseDutySchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                // Remove one of the duplicate declarations of 'components'.
                // The following line should be removed from the bottom of the file:

                // private System.ComponentModel.IContainer components = null;

                // The field 'components' is already declared at the top of the class.
                // Only one declaration is needed to avoid ambiguity.
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAssignDuty = new System.Windows.Forms.TabPage();
            this.lblNurseID = new System.Windows.Forms.Label();
            this.txtNurseID = new System.Windows.Forms.TextBox();
            this.lblNurseName = new System.Windows.Forms.Label();
            this.txtNurseName = new System.Windows.Forms.TextBox();
            this.lblDutyDate = new System.Windows.Forms.Label();
            this.dateTimePickerDuty = new System.Windows.Forms.DateTimePicker();
            this.lblShift = new System.Windows.Forms.Label();
            this.comboBoxShift = new System.Windows.Forms.ComboBox();
            this.btnAssignDuty = new System.Windows.Forms.Button();
            this.tabPageDutySchedule = new System.Windows.Forms.TabPage();
            this.dataGridViewDutySchedule = new System.Windows.Forms.DataGridView();
            this.btnRefreshSchedule = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageAssignDuty.SuspendLayout();
            this.tabPageDutySchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDutySchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(200, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(98, 23);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Nurse List";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(20, 403);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAssignDuty);
            this.tabControl1.Controls.Add(this.tabPageDutySchedule);
            this.tabControl1.Location = new System.Drawing.Point(490, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 300);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageAssignDuty
            // 
            this.tabPageAssignDuty.Controls.Add(this.lblNurseID);
            this.tabPageAssignDuty.Controls.Add(this.txtNurseID);
            this.tabPageAssignDuty.Controls.Add(this.lblNurseName);
            this.tabPageAssignDuty.Controls.Add(this.txtNurseName);
            this.tabPageAssignDuty.Controls.Add(this.lblDutyDate);
            this.tabPageAssignDuty.Controls.Add(this.dateTimePickerDuty);
            this.tabPageAssignDuty.Controls.Add(this.lblShift);
            this.tabPageAssignDuty.Controls.Add(this.comboBoxShift);
            this.tabPageAssignDuty.Controls.Add(this.btnAssignDuty);
            this.tabPageAssignDuty.Location = new System.Drawing.Point(4, 22);
            this.tabPageAssignDuty.Name = "tabPageAssignDuty";
            this.tabPageAssignDuty.Size = new System.Drawing.Size(292, 274);
            this.tabPageAssignDuty.TabIndex = 0;
            this.tabPageAssignDuty.Text = "Assign Duty";
            // 
            // lblNurseID
            // 
            this.lblNurseID.Location = new System.Drawing.Point(10, 20);
            this.lblNurseID.Name = "lblNurseID";
            this.lblNurseID.Size = new System.Drawing.Size(80, 20);
            this.lblNurseID.TabIndex = 0;
            this.lblNurseID.Text = "Nurse ID:";
            // 
            // txtNurseID
            // 
            this.txtNurseID.Location = new System.Drawing.Point(100, 20);
            this.txtNurseID.Name = "txtNurseID";
            this.txtNurseID.ReadOnly = true;
            this.txtNurseID.Size = new System.Drawing.Size(150, 20);
            this.txtNurseID.TabIndex = 1;
            // 
            // lblNurseName
            // 
            this.lblNurseName.Location = new System.Drawing.Point(10, 60);
            this.lblNurseName.Name = "lblNurseName";
            this.lblNurseName.Size = new System.Drawing.Size(80, 20);
            this.lblNurseName.TabIndex = 2;
            this.lblNurseName.Text = "Nurse Name:";
            // 
            // txtNurseName
            // 
            this.txtNurseName.Location = new System.Drawing.Point(100, 60);
            this.txtNurseName.Name = "txtNurseName";
            this.txtNurseName.ReadOnly = true;
            this.txtNurseName.Size = new System.Drawing.Size(150, 20);
            this.txtNurseName.TabIndex = 3;
            // 
            // lblDutyDate
            // 
            this.lblDutyDate.Location = new System.Drawing.Point(10, 100);
            this.lblDutyDate.Name = "lblDutyDate";
            this.lblDutyDate.Size = new System.Drawing.Size(80, 20);
            this.lblDutyDate.TabIndex = 4;
            this.lblDutyDate.Text = "Duty Date:";
            // 
            // dateTimePickerDuty
            // 
            this.dateTimePickerDuty.Location = new System.Drawing.Point(100, 100);
            this.dateTimePickerDuty.Name = "dateTimePickerDuty";
            this.dateTimePickerDuty.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerDuty.TabIndex = 5;
            // 
            // lblShift
            // 
            this.lblShift.Location = new System.Drawing.Point(10, 140);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(80, 20);
            this.lblShift.TabIndex = 6;
            this.lblShift.Text = "Shift:";
            // 
            // comboBoxShift
            // 
            this.comboBoxShift.Items.AddRange(new object[] {
            "Morning",
            "Evening",
            "Night"});
            this.comboBoxShift.Location = new System.Drawing.Point(100, 140);
            this.comboBoxShift.Name = "comboBoxShift";
            this.comboBoxShift.Size = new System.Drawing.Size(150, 21);
            this.comboBoxShift.TabIndex = 7;
            // 
            // btnAssignDuty
            // 
            this.btnAssignDuty.Location = new System.Drawing.Point(100, 180);
            this.btnAssignDuty.Name = "btnAssignDuty";
            this.btnAssignDuty.Size = new System.Drawing.Size(100, 30);
            this.btnAssignDuty.TabIndex = 8;
            this.btnAssignDuty.Text = "Assign Duty";
            this.btnAssignDuty.Click += new System.EventHandler(this.btnAssignDuty_Click);
            // 
            // tabPageDutySchedule
            // 
            this.tabPageDutySchedule.Controls.Add(this.dataGridViewDutySchedule);
            this.tabPageDutySchedule.Controls.Add(this.btnRefreshSchedule);
            this.tabPageDutySchedule.Location = new System.Drawing.Point(4, 22);
            this.tabPageDutySchedule.Name = "tabPageDutySchedule";
            this.tabPageDutySchedule.Size = new System.Drawing.Size(292, 274);
            this.tabPageDutySchedule.TabIndex = 1;
            this.tabPageDutySchedule.Text = "Duty Schedule";
            // 
            // dataGridViewDutySchedule
            // 
            this.dataGridViewDutySchedule.Location = new System.Drawing.Point(10, 20);
            this.dataGridViewDutySchedule.Name = "dataGridViewDutySchedule";
            this.dataGridViewDutySchedule.ReadOnly = true;
            this.dataGridViewDutySchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDutySchedule.Size = new System.Drawing.Size(260, 200);
            this.dataGridViewDutySchedule.TabIndex = 0;
            // 
            // btnRefreshSchedule
            // 
            this.btnRefreshSchedule.Location = new System.Drawing.Point(10, 230);
            this.btnRefreshSchedule.Name = "btnRefreshSchedule";
            this.btnRefreshSchedule.Size = new System.Drawing.Size(100, 30);
            this.btnRefreshSchedule.TabIndex = 1;
            this.btnRefreshSchedule.Text = "Refresh";
            this.btnRefreshSchedule.Click += new System.EventHandler(this.btnRefreshSchedule_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(20, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(450, 300);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // NurseDutySchedule
            // 
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "NurseDutySchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nurse Duty Schedule";
            this.Load += new System.EventHandler(this.NurseDutySchedule_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAssignDuty.ResumeLayout(false);
            this.tabPageAssignDuty.PerformLayout();
            this.tabPageDutySchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDutySchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAssignDuty;
        private System.Windows.Forms.TabPage tabPageDutySchedule;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNurseID;
        private System.Windows.Forms.TextBox txtNurseName;
        private System.Windows.Forms.Label lblNurseID;
        private System.Windows.Forms.Label lblNurseName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDuty;
        private System.Windows.Forms.Label lblDutyDate;
        private System.Windows.Forms.ComboBox comboBoxShift;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Button btnAssignDuty;
        private System.Windows.Forms.DataGridView dataGridViewDutySchedule;
        private System.Windows.Forms.Button btnRefreshSchedule;
    }
}