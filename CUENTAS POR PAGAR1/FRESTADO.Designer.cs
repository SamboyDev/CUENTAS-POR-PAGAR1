namespace CUENTAS_POR_PAGAR1
{
    partial class FRESTADO
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sCXSAMBOYDataSet = new CUENTAS_POR_PAGAR1.SCXSAMBOYDataSet();
            this.sCXSAMBOYDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTADODECUENTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTADODECUENTASTableAdapter = new CUENTAS_POR_PAGAR1.SCXSAMBOYDataSetTableAdapters.ESTADODECUENTASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sCXSAMBOYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCXSAMBOYDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADODECUENTASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ESTADODECUENTAS";
            reportDataSource1.Value = this.eSTADODECUENTASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CUENTAS_POR_PAGAR1.FRESTADO.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 424);
            this.reportViewer1.TabIndex = 0;
            // 
            // sCXSAMBOYDataSet
            // 
            this.sCXSAMBOYDataSet.DataSetName = "SCXSAMBOYDataSet";
            this.sCXSAMBOYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCXSAMBOYDataSetBindingSource
            // 
            this.sCXSAMBOYDataSetBindingSource.DataSource = this.sCXSAMBOYDataSet;
            this.sCXSAMBOYDataSetBindingSource.Position = 0;
            // 
            // eSTADODECUENTASBindingSource
            // 
            this.eSTADODECUENTASBindingSource.DataMember = "ESTADODECUENTAS";
            this.eSTADODECUENTASBindingSource.DataSource = this.sCXSAMBOYDataSetBindingSource;
            // 
            // eSTADODECUENTASTableAdapter
            // 
            this.eSTADODECUENTASTableAdapter.ClearBeforeFill = true;
            // 
            // FRESTADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRESTADO";
            this.Text = "FRESTADO";
            this.Load += new System.EventHandler(this.FRESTADO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sCXSAMBOYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCXSAMBOYDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADODECUENTASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sCXSAMBOYDataSetBindingSource;
        private SCXSAMBOYDataSet sCXSAMBOYDataSet;
        private System.Windows.Forms.BindingSource eSTADODECUENTASBindingSource;
        private SCXSAMBOYDataSetTableAdapters.ESTADODECUENTASTableAdapter eSTADODECUENTASTableAdapter;
    }
}