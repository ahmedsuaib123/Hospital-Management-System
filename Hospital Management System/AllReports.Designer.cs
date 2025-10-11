namespace Hospital_Management_System
{
    partial class AllReports
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView ReportDataGridView;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.ReportDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportDataGridView
            // 
            this.ReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ReportDataGridView.Name = "ReportDataGridView";
            this.ReportDataGridView.ReadOnly = true;
            this.ReportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReportDataGridView.Size = new System.Drawing.Size(776, 426);
            this.ReportDataGridView.TabIndex = 3;
            // 
            // AllReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportDataGridView);
            this.Name = "AllReports";
            this.Text = "All Reports";
            this.Load += new System.EventHandler(this.AllReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGridView)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
