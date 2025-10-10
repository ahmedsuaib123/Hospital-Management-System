namespace Hospital_Management_System
{
    partial class CheckAccountStatus
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
            this.AccountStatusDataGridView = new System.Windows.Forms.DataGridView();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.RoleTextBox = new System.Windows.Forms.TextBox();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusCombobox = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccountStatusDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(204, 22);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(137, 23);
            this.TitleLabel.TabIndex = 21;
            this.TitleLabel.Text = "Account Status";
            // 
            // AccountStatusDataGridView
            // 
            this.AccountStatusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountStatusDataGridView.Location = new System.Drawing.Point(46, 79);
            this.AccountStatusDataGridView.Name = "AccountStatusDataGridView";
            this.AccountStatusDataGridView.Size = new System.Drawing.Size(485, 284);
            this.AccountStatusDataGridView.TabIndex = 22;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(636, 174);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.ReadOnly = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(143, 20);
            this.UsernameTextBox.TabIndex = 24;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.UsernameLabel.Location = new System.Drawing.Point(551, 177);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(69, 17);
            this.UsernameLabel.TabIndex = 23;
            this.UsernameLabel.Text = "Username";
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.Location = new System.Drawing.Point(636, 218);
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.ReadOnly = true;
            this.RoleTextBox.Size = new System.Drawing.Size(143, 20);
            this.RoleTextBox.TabIndex = 26;
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.RoleLabel.Location = new System.Drawing.Point(585, 221);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(35, 17);
            this.RoleLabel.TabIndex = 25;
            this.RoleLabel.Text = "Role";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.StatusLabel.Location = new System.Drawing.Point(576, 272);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(44, 17);
            this.StatusLabel.TabIndex = 27;
            this.StatusLabel.Text = "Status";
            // 
            // StatusCombobox
            // 
            this.StatusCombobox.FormattingEnabled = true;
            this.StatusCombobox.Items.AddRange(new object[] {
            "0",
            "1"});
            this.StatusCombobox.Location = new System.Drawing.Point(636, 271);
            this.StatusCombobox.Name = "StatusCombobox";
            this.StatusCombobox.Size = new System.Drawing.Size(65, 21);
            this.StatusCombobox.TabIndex = 28;
            // 
            // UpdateButton
            // 
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.UpdateButton.Location = new System.Drawing.Point(636, 389);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(87, 33);
            this.UpdateButton.TabIndex = 29;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.BackButton.Location = new System.Drawing.Point(46, 389);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(87, 33);
            this.BackButton.TabIndex = 30;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // CheckAccountStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.StatusCombobox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.RoleTextBox);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.AccountStatusDataGridView);
            this.Controls.Add(this.TitleLabel);
            this.Name = "CheckAccountStatus";
            this.Text = "Hospital Management System";
            this.Load += new System.EventHandler(this.CheckAccountStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountStatusDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.DataGridView AccountStatusDataGridView;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox RoleTextBox;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox StatusCombobox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button BackButton;
    }
}