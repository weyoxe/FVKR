
namespace FVKR
{
    partial class ReportPatients
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TVKRDataSet4 = new FVKR.TVKRDataSet4();
            this.ReceptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReceptionTableAdapter = new FVKR.TVKRDataSet4TableAdapters.ReceptionTableAdapter();
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeTableAdapter = new FVKR.TVKRDataSet4TableAdapters.EmployeeTableAdapter();
            this.TVKRDataSet1 = new FVKR.TVKRDataSet1();
            this.PatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PatientTableAdapter = new FVKR.TVKRDataSet1TableAdapters.PatientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TVKRDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TVKRDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReceptionBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.EmployeeBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.PatientBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FVKR.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // TVKRDataSet4
            // 
            this.TVKRDataSet4.DataSetName = "TVKRDataSet4";
            this.TVKRDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReceptionBindingSource
            // 
            this.ReceptionBindingSource.DataMember = "Reception";
            this.ReceptionBindingSource.DataSource = this.TVKRDataSet4;
            // 
            // ReceptionTableAdapter
            // 
            this.ReceptionTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeBindingSource
            // 
            this.EmployeeBindingSource.DataMember = "Employee";
            this.EmployeeBindingSource.DataSource = this.TVKRDataSet4;
            // 
            // EmployeeTableAdapter
            // 
            this.EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // TVKRDataSet1
            // 
            this.TVKRDataSet1.DataSetName = "TVKRDataSet1";
            this.TVKRDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PatientBindingSource
            // 
            this.PatientBindingSource.DataMember = "Patient";
            this.PatientBindingSource.DataSource = this.TVKRDataSet1;
            // 
            // PatientTableAdapter
            // 
            this.PatientTableAdapter.ClearBeforeFill = true;
            // 
            // ReportPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportPatients";
            this.Text = "ReportPatients";
            this.Load += new System.EventHandler(this.ReportPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TVKRDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TVKRDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReceptionBindingSource;
        private TVKRDataSet4 TVKRDataSet4;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private System.Windows.Forms.BindingSource PatientBindingSource;
        private TVKRDataSet1 TVKRDataSet1;
        private TVKRDataSet4TableAdapters.ReceptionTableAdapter ReceptionTableAdapter;
        private TVKRDataSet4TableAdapters.EmployeeTableAdapter EmployeeTableAdapter;
        private TVKRDataSet1TableAdapters.PatientTableAdapter PatientTableAdapter;
    }
}