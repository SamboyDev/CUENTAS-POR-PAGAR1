namespace CUENTAS_POR_PAGAR1
{
    partial class FMODIFICARCHEQ
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
            this.TNUMCHEQ = new System.Windows.Forms.TextBox();
            this.BMODIFICAR = new System.Windows.Forms.Button();
            this.TNUMFACT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TVALCHEQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TFECHACHEQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NÚMERO CHEQUE";
            // 
            // TNUMCHEQ
            // 
            this.TNUMCHEQ.Location = new System.Drawing.Point(223, 116);
            this.TNUMCHEQ.Name = "TNUMCHEQ";
            this.TNUMCHEQ.Size = new System.Drawing.Size(100, 20);
            this.TNUMCHEQ.TabIndex = 1;
            this.TNUMCHEQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNUMCHEQ_KeyPress);
            // 
            // BMODIFICAR
            // 
            this.BMODIFICAR.Location = new System.Drawing.Point(169, 355);
            this.BMODIFICAR.Name = "BMODIFICAR";
            this.BMODIFICAR.Size = new System.Drawing.Size(99, 34);
            this.BMODIFICAR.TabIndex = 2;
            this.BMODIFICAR.Text = "MODIFICAR";
            this.BMODIFICAR.UseVisualStyleBackColor = true;
            this.BMODIFICAR.Click += new System.EventHandler(this.BMODIFICAR_Click);
            // 
            // TNUMFACT
            // 
            this.TNUMFACT.Location = new System.Drawing.Point(223, 162);
            this.TNUMFACT.Name = "TNUMFACT";
            this.TNUMFACT.Size = new System.Drawing.Size(100, 20);
            this.TNUMFACT.TabIndex = 4;
            this.TNUMFACT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNUMFACT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NÚMERO FACTURA";
            // 
            // TVALCHEQ
            // 
            this.TVALCHEQ.Location = new System.Drawing.Point(223, 206);
            this.TVALCHEQ.Name = "TVALCHEQ";
            this.TVALCHEQ.Size = new System.Drawing.Size(100, 20);
            this.TVALCHEQ.TabIndex = 6;
            this.TVALCHEQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TVALCHEQ_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "VALOR CHEQUE";
            // 
            // TFECHACHEQ
            // 
            this.TFECHACHEQ.Location = new System.Drawing.Point(223, 248);
            this.TFECHACHEQ.Name = "TFECHACHEQ";
            this.TFECHACHEQ.Size = new System.Drawing.Size(100, 20);
            this.TFECHACHEQ.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "FECHA CHEQUE";
            // 
            // FMODIFICARCHEQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 414);
            this.Controls.Add(this.TFECHACHEQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TVALCHEQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TNUMFACT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BMODIFICAR);
            this.Controls.Add(this.TNUMCHEQ);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMODIFICARCHEQ";
            this.Text = "FMODIFICARCHEQ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FMODIFICARCHEQ_FormClosed);
            this.Load += new System.EventHandler(this.FMODIFICARCHEQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TNUMCHEQ;
        private System.Windows.Forms.Button BMODIFICAR;
        private System.Windows.Forms.TextBox TNUMFACT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TVALCHEQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TFECHACHEQ;
        private System.Windows.Forms.Label label4;
    }
}