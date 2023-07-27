namespace CUENTAS_POR_PAGAR1
{
    partial class FRPROVEEDORES
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
            this.sCXSAMBOYDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCXSAMBOYDataSet = new CUENTAS_POR_PAGAR1.SCXSAMBOYDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pROVEEDORESSAMBOYTableAdapter = new CUENTAS_POR_PAGAR1.SCXSAMBOYDataSetTableAdapters.PROVEEDORESSAMBOYTableAdapter();
            this.pROVEEDORESSAMBOYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sCXSAMBOYDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCXSAMBOYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEEDORESSAMBOYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sCXSAMBOYDataSetBindingSource
            // 
            this.sCXSAMBOYDataSetBindingSource.DataSource = this.sCXSAMBOYDataSet;
            this.sCXSAMBOYDataSetBindingSource.Position = 0;
            // 
            // sCXSAMBOYDataSet
            // 
            this.sCXSAMBOYDataSet.DataSetName = "SCXSAMBOYDataSet";
            this.sCXSAMBOYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PROVEEDORESSAMBOY";
            reportDataSource1.Value = this.pROVEEDORESSAMBOYBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CUENTAS_POR_PAGAR1.FRPROVEEDORES.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 424);
            this.reportViewer1.TabIndex = 0;
            // 
            // pROVEEDORESSAMBOYTableAdapter
            // 
            this.pROVEEDORESSAMBOYTableAdapter.ClearBeforeFill = true;
            // 
            // pROVEEDORESSAMBOYBindingSource
            // 
            this.pROVEEDORESSAMBOYBindingSource.DataMember = "PROVEEDORESSAMBOY";
            this.pROVEEDORESSAMBOYBindingSource.DataSource = this.sCXSAMBOYDataSetBindingSource;
            // 
            // FRPROVEEDORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRPROVEEDORES";
            this.Text = "FRPROVEEDORES";
            this.Load += new System.EventHandler(this.FRPROVEEDORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sCXSAMBOYDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCXSAMBOYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEEDORESSAMBOYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sCXSAMBOYDataSetBindingSource;
        private SCXSAMBOYDataSet sCXSAMBOYDataSet;
        private SCXSAMBOYDataSetTableAdapters.PROVEEDORESSAMBOYTableAdapter pROVEEDORESSAMBOYTableAdapter;
        private System.Windows.Forms.BindingSource pROVEEDORESSAMBOYBindingSource;
    }
}