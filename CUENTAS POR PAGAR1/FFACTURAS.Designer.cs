namespace CUENTAS_POR_PAGAR1
{
    partial class FFACTURAS
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
            this.DGVFACTURAS = new System.Windows.Forms.DataGridView();
            this.BELIMINAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TNUMFACT = new System.Windows.Forms.TextBox();
            this.TCODIGO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BMODIFICAR = new System.Windows.Forms.Button();
            this.BAGREGAR = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFACTURAS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVFACTURAS
            // 
            this.DGVFACTURAS.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.DGVFACTURAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFACTURAS.Location = new System.Drawing.Point(0, 0);
            this.DGVFACTURAS.Name = "DGVFACTURAS";
            this.DGVFACTURAS.Size = new System.Drawing.Size(421, 423);
            this.DGVFACTURAS.TabIndex = 0;
            // 
            // BELIMINAR
            // 
            this.BELIMINAR.BackColor = System.Drawing.Color.SlateBlue;
            this.BELIMINAR.FlatAppearance.BorderSize = 0;
            this.BELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BELIMINAR.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BELIMINAR.ForeColor = System.Drawing.SystemColors.Window;
            this.BELIMINAR.Location = new System.Drawing.Point(695, 340);
            this.BELIMINAR.Name = "BELIMINAR";
            this.BELIMINAR.Size = new System.Drawing.Size(91, 33);
            this.BELIMINAR.TabIndex = 1;
            this.BELIMINAR.Text = "ELIMINAR";
            this.BELIMINAR.UseVisualStyleBackColor = false;
            this.BELIMINAR.Click += new System.EventHandler(this.BELIMINAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(434, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "NUMERO DE FACTURA";
            // 
            // TNUMFACT
            // 
            this.TNUMFACT.BackColor = System.Drawing.Color.SlateBlue;
            this.TNUMFACT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TNUMFACT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNUMFACT.ForeColor = System.Drawing.SystemColors.Window;
            this.TNUMFACT.Location = new System.Drawing.Point(11, 9);
            this.TNUMFACT.Name = "TNUMFACT";
            this.TNUMFACT.Size = new System.Drawing.Size(131, 14);
            this.TNUMFACT.TabIndex = 3;
            this.TNUMFACT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TCODIGO
            // 
            this.TCODIGO.BackColor = System.Drawing.Color.SlateBlue;
            this.TCODIGO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TCODIGO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCODIGO.ForeColor = System.Drawing.SystemColors.Window;
            this.TCODIGO.Location = new System.Drawing.Point(11, 9);
            this.TCODIGO.Name = "TCODIGO";
            this.TCODIGO.Size = new System.Drawing.Size(131, 14);
            this.TCODIGO.TabIndex = 5;
            this.TCODIGO.TextChanged += new System.EventHandler(this.TCODIGO_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(463, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "CODIGO CLIENTE";
            // 
            // BMODIFICAR
            // 
            this.BMODIFICAR.BackColor = System.Drawing.Color.SlateBlue;
            this.BMODIFICAR.FlatAppearance.BorderSize = 0;
            this.BMODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMODIFICAR.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMODIFICAR.ForeColor = System.Drawing.SystemColors.Window;
            this.BMODIFICAR.Location = new System.Drawing.Point(565, 340);
            this.BMODIFICAR.Name = "BMODIFICAR";
            this.BMODIFICAR.Size = new System.Drawing.Size(91, 33);
            this.BMODIFICAR.TabIndex = 6;
            this.BMODIFICAR.Text = "MODIFICAR";
            this.BMODIFICAR.UseVisualStyleBackColor = false;
            this.BMODIFICAR.Click += new System.EventHandler(this.BMODIFICAR_Click);
            // 
            // BAGREGAR
            // 
            this.BAGREGAR.BackColor = System.Drawing.Color.SlateBlue;
            this.BAGREGAR.FlatAppearance.BorderSize = 0;
            this.BAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAGREGAR.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAGREGAR.ForeColor = System.Drawing.SystemColors.Window;
            this.BAGREGAR.Location = new System.Drawing.Point(437, 340);
            this.BAGREGAR.Name = "BAGREGAR";
            this.BAGREGAR.Size = new System.Drawing.Size(91, 33);
            this.BAGREGAR.TabIndex = 0;
            this.BAGREGAR.Text = "AGREGAR";
            this.BAGREGAR.UseVisualStyleBackColor = false;
            this.BAGREGAR.Click += new System.EventHandler(this.BAGREGAR_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.TNUMFACT);
            this.panel1.Location = new System.Drawing.Point(614, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 27);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.TCODIGO);
            this.panel2.Location = new System.Drawing.Point(614, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 27);
            this.panel2.TabIndex = 8;
            // 
            // FFACTURAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.BAGREGAR);
            this.Controls.Add(this.BMODIFICAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BELIMINAR);
            this.Controls.Add(this.DGVFACTURAS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FFACTURAS";
            this.Text = "FFACTURAS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FFACTURAS_FormClosed);
            this.Load += new System.EventHandler(this.FFACTURAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFACTURAS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVFACTURAS;
        private System.Windows.Forms.Button BELIMINAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TNUMFACT;
        private System.Windows.Forms.TextBox TCODIGO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BMODIFICAR;
        private System.Windows.Forms.Button BAGREGAR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}