namespace CUENTAS_POR_PAGAR1
{
    partial class FMODIFICARFACT
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
            this.label1 = new System.Windows.Forms.Label();
            this.BMODIFICAR = new System.Windows.Forms.Button();
            this.TNUMFACT = new System.Windows.Forms.TextBox();
            this.TCODIGO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TFECHAFACT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TVALFACT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TFECHAVENC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO FACTURA";
            // 
            // BMODIFICAR
            // 
            this.BMODIFICAR.Location = new System.Drawing.Point(173, 348);
            this.BMODIFICAR.Name = "BMODIFICAR";
            this.BMODIFICAR.Size = new System.Drawing.Size(92, 36);
            this.BMODIFICAR.TabIndex = 1;
            this.BMODIFICAR.Text = "MODIFICAR";
            this.BMODIFICAR.UseVisualStyleBackColor = true;
            this.BMODIFICAR.Click += new System.EventHandler(this.BMODIFICAR_Click);
            // 
            // TNUMFACT
            // 
            this.TNUMFACT.Location = new System.Drawing.Point(217, 99);
            this.TNUMFACT.Name = "TNUMFACT";
            this.TNUMFACT.Size = new System.Drawing.Size(173, 20);
            this.TNUMFACT.TabIndex = 2;
            // 
            // TCODIGO
            // 
            this.TCODIGO.Location = new System.Drawing.Point(217, 141);
            this.TCODIGO.Name = "TCODIGO";
            this.TCODIGO.Size = new System.Drawing.Size(173, 20);
            this.TCODIGO.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CODIGO CLIENTE";
            // 
            // TFECHAFACT
            // 
            this.TFECHAFACT.Location = new System.Drawing.Point(217, 221);
            this.TFECHAFACT.Name = "TFECHAFACT";
            this.TFECHAFACT.Size = new System.Drawing.Size(173, 20);
            this.TFECHAFACT.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "FECHA FACTURA";
            // 
            // TVALFACT
            // 
            this.TVALFACT.Location = new System.Drawing.Point(217, 179);
            this.TVALFACT.Name = "TVALFACT";
            this.TVALFACT.Size = new System.Drawing.Size(173, 20);
            this.TVALFACT.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "VALOR FACTURA";
            // 
            // TFECHAVENC
            // 
            this.TFECHAVENC.Location = new System.Drawing.Point(217, 262);
            this.TFECHAVENC.Name = "TFECHAVENC";
            this.TFECHAVENC.Size = new System.Drawing.Size(173, 20);
            this.TFECHAVENC.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "FECHA VENCIMIENTO";
            // 
            // FMODIFICARFACT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 416);
            this.Controls.Add(this.TFECHAVENC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TFECHAFACT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TVALFACT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TCODIGO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TNUMFACT);
            this.Controls.Add(this.BMODIFICAR);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMODIFICARFACT";
            this.Text = "FMODIFICARFACT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FMODIFICARFACT_FormClosed);
            this.Load += new System.EventHandler(this.FMODIFICARFACT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BMODIFICAR;
        private System.Windows.Forms.TextBox TNUMFACT;
        private System.Windows.Forms.TextBox TCODIGO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TFECHAFACT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TVALFACT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TFECHAVENC;
        private System.Windows.Forms.Label label6;
    }
}