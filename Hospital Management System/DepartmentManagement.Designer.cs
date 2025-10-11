namespace Hospital_Management_System
{
    partial class DepartmentManagement
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
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DepartmentDataGridView = new System.Windows.Forms.DataGridView();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(157, 69);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(193, 20);
            this.SearchTextBox.TabIndex = 48;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.SearchLabel.Location = new System.Drawing.Point(78, 69);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(58, 20);
            this.SearchLabel.TabIndex = 47;
            this.SearchLabel.Text = "Search";
            // 
            // BackButton
            // 
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.BackButton.Location = new System.Drawing.Point(638, 391);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(87, 33);
            this.BackButton.TabIndex = 46;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.DeleteButton.Location = new System.Drawing.Point(355, 391);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(87, 33);
            this.DeleteButton.TabIndex = 44;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.AddButton.Location = new System.Drawing.Point(76, 391);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(87, 33);
            this.AddButton.TabIndex = 43;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DepartmentDataGridView
            // 
            this.DepartmentDataGridView.AllowUserToAddRows = false;
            this.DepartmentDataGridView.AllowUserToDeleteRows = false;
            this.DepartmentDataGridView.AllowUserToResizeColumns = false;
            this.DepartmentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentDataGridView.Location = new System.Drawing.Point(78, 102);
            this.DepartmentDataGridView.Name = "DepartmentDataGridView";
            this.DepartmentDataGridView.ReadOnly = true;
            this.DepartmentDataGridView.Size = new System.Drawing.Size(647, 258);
            this.DepartmentDataGridView.StandardTab = true;
            this.DepartmentDataGridView.TabIndex = 42;
            this.DepartmentDataGridView.VirtualMode = true;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(351, 26);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(119, 23);
            this.TitleLabel.TabIndex = 41;
            this.TitleLabel.Text = "Departments";
            // 
            // DepartmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DepartmentDataGridView);
            this.Controls.Add(this.TitleLabel);
            this.Name = "DepartmentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentManagement";
            this.Load += new System.EventHandler(this.DepartmentManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView DepartmentDataGridView;
        private System.Windows.Forms.Label TitleLabel;
    }
}