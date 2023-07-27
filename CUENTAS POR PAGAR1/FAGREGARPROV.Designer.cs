namespace CUENTAS_POR_PAGAR1
{
    partial class FAGREGARPROV
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
            this.BAGREGAR = new System.Windows.Forms.Button();
            this.TCODIGO = new System.Windows.Forms.TextBox();
            this.TNOMBRES = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TAPELLIDOS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TDIRECCION = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TCIUDAD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TTELEFONO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BAGREGAR
            // 
            this.BAGREGAR.Location = new System.Drawing.Point(149, 352);
            this.BAGREGAR.Name = "BAGREGAR";
            this.BAGREGAR.Size = new System.Drawing.Size(113, 37);
            this.BAGREGAR.TabIndex = 1;
            this.BAGREGAR.Text = "AGREGAR";
            this.BAGREGAR.UseVisualStyleBackColor = true;
            this.BAGREGAR.Click += new System.EventHandler(this.BAGREGAR_Click);
            // 
            // TCODIGO
            // 
            this.TCODIGO.Location = new System.Drawing.Point(181, 77);
            this.TCODIGO.MaxLength = 7;
            this.TCODIGO.Name = "TCODIGO";
            this.TCODIGO.Size = new System.Drawing.Size(100, 20);
            this.TCODIGO.TabIndex = 2;
            // 
            // TNOMBRES
            // 
            this.TNOMBRES.Location = new System.Drawing.Point(181, 119);
            this.TNOMBRES.MaxLength = 25;
            this.TNOMBRES.Name = "TNOMBRES";
            this.TNOMBRES.Size = new System.Drawing.Size(100, 20);
            this.TNOMBRES.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRES";
            // 
            // TAPELLIDOS
            // 
            this.TAPELLIDOS.Location = new System.Drawing.Point(181, 159);
            this.TAPELLIDOS.MaxLength = 25;
            this.TAPELLIDOS.Name = "TAPELLIDOS";
            this.TAPELLIDOS.Size = new System.Drawing.Size(100, 20);
            this.TAPELLIDOS.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "APELLIDOS";
            // 
            // TDIRECCION
            // 
            this.TDIRECCION.Location = new System.Drawing.Point(181, 201);
            this.TDIRECCION.MaxLength = 35;
            this.TDIRECCION.Name = "TDIRECCION";
            this.TDIRECCION.Size = new System.Drawing.Size(100, 20);
            this.TDIRECCION.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DIRECCION";
            // 
            // TCIUDAD
            // 
            this.TCIUDAD.Location = new System.Drawing.Point(181, 240);
            this.TCIUDAD.MaxLength = 25;
            this.TCIUDAD.Name = "TCIUDAD";
            this.TCIUDAD.Size = new System.Drawing.Size(100, 20);
            this.TCIUDAD.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CIUDAD";
            // 
            // TTELEFONO
            // 
            this.TTELEFONO.Location = new System.Drawing.Point(181, 281);
            this.TTELEFONO.MaxLength = 13;
            this.TTELEFONO.Name = "TTELEFONO";
            this.TTELEFONO.Size = new System.Drawing.Size(100, 20);
            this.TTELEFONO.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "TELEFONO";
            // 
            // FAGREGARPROV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.TTELEFONO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TCIUDAD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TDIRECCION);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TAPELLIDOS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TNOMBRES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TCODIGO);
            this.Controls.Add(this.BAGREGAR);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAGREGARPROV";
            this.Text = "FAGREGARPROV";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FAGREGARPROV_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BAGREGAR;
        private System.Windows.Forms.TextBox TCODIGO;
        private System.Windows.Forms.TextBox TNOMBRES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TAPELLIDOS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TDIRECCION;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TCIUDAD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TTELEFONO;
        private System.Windows.Forms.Label label6;
    }
}