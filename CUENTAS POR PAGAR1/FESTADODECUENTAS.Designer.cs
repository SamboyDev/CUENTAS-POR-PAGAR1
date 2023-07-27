namespace CUENTAS_POR_PAGAR1
{
    partial class FESTADODECUENTAS
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
            this.DGVESTADOCUENTAS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TPORCODIGO = new System.Windows.Forms.TextBox();
            this.BVERTODOS = new System.Windows.Forms.Button();
            this.TPORNUMFACT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVESTADOCUENTAS)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVESTADOCUENTAS
            // 
            this.DGVESTADOCUENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVESTADOCUENTAS.Location = new System.Drawing.Point(-1, 118);
            this.DGVESTADOCUENTAS.Name = "DGVESTADOCUENTAS";
            this.DGVESTADOCUENTAS.Size = new System.Drawing.Size(801, 306);
            this.DGVESTADOCUENTAS.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CODIGO DEL PROVEEDOR";
            // 
            // TPORCODIGO
            // 
            this.TPORCODIGO.Location = new System.Drawing.Point(195, 54);
            this.TPORCODIGO.Name = "TPORCODIGO";
            this.TPORCODIGO.Size = new System.Drawing.Size(100, 20);
            this.TPORCODIGO.TabIndex = 2;
            this.TPORCODIGO.TextChanged += new System.EventHandler(this.TPORCODIGO_TextChanged);
            // 
            // BVERTODOS
            // 
            this.BVERTODOS.Location = new System.Drawing.Point(671, 49);
            this.BVERTODOS.Name = "BVERTODOS";
            this.BVERTODOS.Size = new System.Drawing.Size(90, 27);
            this.BVERTODOS.TabIndex = 3;
            this.BVERTODOS.Text = "VER TODOS";
            this.BVERTODOS.UseVisualStyleBackColor = true;
            this.BVERTODOS.Click += new System.EventHandler(this.BVERTODOS_Click);
            // 
            // TPORNUMFACT
            // 
            this.TPORNUMFACT.Location = new System.Drawing.Point(477, 53);
            this.TPORNUMFACT.Name = "TPORNUMFACT";
            this.TPORNUMFACT.Size = new System.Drawing.Size(100, 20);
            this.TPORNUMFACT.TabIndex = 5;
            this.TPORNUMFACT.TextChanged += new System.EventHandler(this.TPORNUMFACT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NUMERO DE FACTURA";
            // 
            // FESTADODECUENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.TPORNUMFACT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BVERTODOS);
            this.Controls.Add(this.TPORCODIGO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVESTADOCUENTAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FESTADODECUENTAS";
            this.Text = "FESTADODECUENTAS";
            this.Load += new System.EventHandler(this.FESTADODECUENTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVESTADOCUENTAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVESTADOCUENTAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TPORCODIGO;
        private System.Windows.Forms.Button BVERTODOS;
        private System.Windows.Forms.TextBox TPORNUMFACT;
        private System.Windows.Forms.Label label2;
    }
}