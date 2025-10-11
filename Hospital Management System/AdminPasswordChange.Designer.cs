namespace Hospital_Management_System
{
    partial class AdminPasswordChange
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
            this.AdminTitleLabel = new System.Windows.Forms.Label();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.CurrentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.CurrentPassowrdLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminTitleLabel
            // 
            this.AdminTitleLabel.AutoSize = true;
            this.AdminTitleLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminTitleLabel.Location = new System.Drawing.Point(305, 60);
            this.AdminTitleLabel.Name = "AdminTitleLabel";
            this.AdminTitleLabel.Size = new System.Drawing.Size(144, 23);
            this.AdminTitleLabel.TabIndex = 21;
            this.AdminTitleLabel.Text = "Reset Password";
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordCheckBox.ForeColor = System.Drawing.Color.Black;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(563, 278);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(102, 17);
            this.ShowPasswordCheckBox.TabIndex = 32;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = false;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(265, 276);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(246, 20);
            this.ConfirmPasswordTextBox.TabIndex = 31;
            this.ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(115, 279);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(118, 17);
            this.ConfirmPasswordLabel.TabIndex = 30;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Location = new System.Drawing.Point(265, 208);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(246, 20);
            this.NewPasswordTextBox.TabIndex = 29;
            this.NewPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.NewPasswordLabel.Location = new System.Drawing.Point(134, 211);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(99, 17);
            this.NewPasswordLabel.TabIndex = 28;
            this.NewPasswordLabel.Text = "New Password";
            // 
            // CurrentPasswordTextBox
            // 
            this.CurrentPasswordTextBox.Location = new System.Drawing.Point(265, 155);
            this.CurrentPasswordTextBox.Name = "CurrentPasswordTextBox";
            this.CurrentPasswordTextBox.Size = new System.Drawing.Size(246, 20);
            this.CurrentPasswordTextBox.TabIndex = 34;
            this.CurrentPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // CurrentPassowrdLabel
            // 
            this.CurrentPassowrdLabel.AutoSize = true;
            this.CurrentPassowrdLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CurrentPassowrdLabel.Location = new System.Drawing.Point(118, 155);
            this.CurrentPassowrdLabel.Name = "CurrentPassowrdLabel";
            this.CurrentPassowrdLabel.Size = new System.Drawing.Size(115, 17);
            this.CurrentPassowrdLabel.TabIndex = 33;
            this.CurrentPassowrdLabel.Text = "Current Password";
            // 
            // ResetButton
            // 
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.ResetButton.Location = new System.Drawing.Point(578, 348);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(87, 33);
            this.ResetButton.TabIndex = 35;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.CancelButton.Location = new System.Drawing.Point(118, 348);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(87, 33);
            this.CancelButton.TabIndex = 36;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AdminPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CurrentPasswordTextBox);
            this.Controls.Add(this.CurrentPassowrdLabel);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.AdminTitleLabel);
            this.Name = "AdminPasswordChange";
            this.Text = "AdminPasswordChange";
            this.Load += new System.EventHandler(this.AdminPasswordChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminTitleLabel;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.TextBox CurrentPasswordTextBox;
        private System.Windows.Forms.Label CurrentPassowrdLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CancelButton;
    }
}