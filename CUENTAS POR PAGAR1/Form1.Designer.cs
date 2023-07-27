namespace CUENTAS_POR_PAGAR1
{
    partial class FINICIO
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TUSUARIO = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.DAGVUSUARIOS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TCLAVE = new System.Windows.Forms.TextBox();
            this.BENTRADA = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DAGVUSUARIOS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TUSUARIO
            // 
            this.TUSUARIO.BackColor = System.Drawing.Color.SlateBlue;
            this.TUSUARIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TUSUARIO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUSUARIO.ForeColor = System.Drawing.SystemColors.Window;
            this.TUSUARIO.Location = new System.Drawing.Point(16, 10);
            this.TUSUARIO.Name = "TUSUARIO";
            this.TUSUARIO.Size = new System.Drawing.Size(142, 14);
            this.TUSUARIO.TabIndex = 0;
            this.TUSUARIO.TextChanged += new System.EventHandler(this.TUSUARIO_TextChanged);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.BackColor = System.Drawing.Color.Transparent;
            this.a.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.SystemColors.Window;
            this.a.Location = new System.Drawing.Point(295, 79);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(66, 16);
            this.a.TabIndex = 1;
            this.a.Text = "USUARIO";
            // 
            // DAGVUSUARIOS
            // 
            this.DAGVUSUARIOS.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.DAGVUSUARIOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DAGVUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DAGVUSUARIOS.Location = new System.Drawing.Point(12, 79);
            this.DAGVUSUARIOS.Name = "DAGVUSUARIOS";
            this.DAGVUSUARIOS.Size = new System.Drawing.Size(153, 189);
            this.DAGVUSUARIOS.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(265, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONTRASEÑA";
            // 
            // TCLAVE
            // 
            this.TCLAVE.BackColor = System.Drawing.Color.SlateBlue;
            this.TCLAVE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TCLAVE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCLAVE.ForeColor = System.Drawing.SystemColors.Window;
            this.TCLAVE.Location = new System.Drawing.Point(16, 9);
            this.TCLAVE.Name = "TCLAVE";
            this.TCLAVE.PasswordChar = '●';
            this.TCLAVE.Size = new System.Drawing.Size(164, 14);
            this.TCLAVE.TabIndex = 3;
            this.TCLAVE.TextChanged += new System.EventHandler(this.TCLAVE_TextChanged);
            // 
            // BENTRADA
            // 
            this.BENTRADA.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BENTRADA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BENTRADA.FlatAppearance.BorderSize = 0;
            this.BENTRADA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BENTRADA.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BENTRADA.ForeColor = System.Drawing.SystemColors.Window;
            this.BENTRADA.Location = new System.Drawing.Point(322, 235);
            this.BENTRADA.Name = "BENTRADA";
            this.BENTRADA.Size = new System.Drawing.Size(242, 39);
            this.BENTRADA.TabIndex = 5;
            this.BENTRADA.Text = "ACCEDER";
            this.BENTRADA.UseVisualStyleBackColor = false;
            this.BENTRADA.Click += new System.EventHandler(this.BENTRADA_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.TCLAVE);
            this.panel1.Location = new System.Drawing.Point(367, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 35);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.TUSUARIO);
            this.panel2.Location = new System.Drawing.Point(367, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 35);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(-1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(617, 24);
            this.panel3.TabIndex = 8;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::CUENTAS_POR_PAGAR1.Properties.Resources.menos__1_;
            this.pictureBox3.Location = new System.Drawing.Point(531, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::CUENTAS_POR_PAGAR1.Properties.Resources.cruz;
            this.pictureBox2.Location = new System.Drawing.Point(583, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CUENTAS_POR_PAGAR1.Properties.Resources.circulo__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-240, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 293);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FINICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(614, 313);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BENTRADA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DAGVUSUARIOS);
            this.Controls.Add(this.a);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FINICIO";
            this.Load += new System.EventHandler(this.FINICIO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DAGVUSUARIOS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TUSUARIO;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.DataGridView DAGVUSUARIOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TCLAVE;
        private System.Windows.Forms.Button BENTRADA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

