using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace CrystalReports_UAM
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        



        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crOpenItems1 = new CrystalReports_UAM.crOpenItems();
            this.labReport = new System.Windows.Forms.Label();
            this.cmbReports = new System.Windows.Forms.ComboBox();
            this.crCashReport1 = new CrystalReports_UAM.crCashReport();
            this.labCashReportDate = new System.Windows.Forms.Label();
            this.dtpCashReportDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-2, 48);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.crOpenItems1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1925, 959);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // labReport
            // 
            this.labReport.AutoSize = true;
            this.labReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labReport.Location = new System.Drawing.Point(40, 13);
            this.labReport.Name = "labReport";
            this.labReport.Size = new System.Drawing.Size(51, 17);
            this.labReport.TabIndex = 1;
            this.labReport.Text = "Raport";
            // 
            // cmbReports
            // 
            this.cmbReports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReports.FormattingEnabled = true;
            this.cmbReports.Location = new System.Drawing.Point(109, 9);
            this.cmbReports.Name = "cmbReports";
            this.cmbReports.Size = new System.Drawing.Size(121, 21);
            this.cmbReports.TabIndex = 2;
            this.cmbReports.SelectedIndexChanged += new System.EventHandler(this.cmbReports_SelectedIndexChanged);
            // 
            // labCashReportDate
            // 
            this.labCashReportDate.AutoSize = true;
            this.labCashReportDate.Location = new System.Drawing.Point(334, 15);
            this.labCashReportDate.Name = "labCashReportDate";
            this.labCashReportDate.Size = new System.Drawing.Size(118, 13);
            this.labCashReportDate.TabIndex = 3;
            this.labCashReportDate.Text = "Data raportu kasowego";
            // 
            // dtpCashReportDate
            // 
            this.dtpCashReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCashReportDate.Location = new System.Drawing.Point(458, 10);
            this.dtpCashReportDate.Name = "dtpCashReportDate";
            this.dtpCashReportDate.Size = new System.Drawing.Size(102, 20);
            this.dtpCashReportDate.TabIndex = 4;
            this.dtpCashReportDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 961);
            this.Controls.Add(this.dtpCashReportDate);
            this.Controls.Add(this.labCashReportDate);
            this.Controls.Add(this.cmbReports);
            this.Controls.Add(this.labReport);
            this.Controls.Add(this.crystalReportViewer1);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "Form1";
            this.Text = "Raporty Crystal Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private crOpenItems crOpenItems1;
        private System.Windows.Forms.Label labReport;
        private System.Windows.Forms.ComboBox cmbReports;
        private crCashReport crCashReport1;
        private System.Windows.Forms.Label labCashReportDate;
        private System.Windows.Forms.DateTimePicker dtpCashReportDate;
    }
}

