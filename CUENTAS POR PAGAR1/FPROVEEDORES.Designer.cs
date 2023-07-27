namespace CUENTAS_POR_PAGAR1
{
    partial class FPROVEEDORES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPROVEEDORES));
            this.DGVPROVEEDORES = new System.Windows.Forms.DataGridView();
            this.BAGREGAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TCODIGO = new System.Windows.Forms.TextBox();
            this.BMODIFICAR = new System.Windows.Forms.Button();
            this.BELIMINAR = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.DGVPROVEEDORES)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPROVEEDORES
            // 
            this.DGVPROVEEDORES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPROVEEDORES.Location = new System.Drawing.Point(23, 133);
            this.DGVPROVEEDORES.Name = "DGVPROVEEDORES";
            this.DGVPROVEEDORES.Size = new System.Drawing.Size(448, 276);
            this.DGVPROVEEDORES.TabIndex = 0;
            // 
            // BAGREGAR
            // 
            this.BAGREGAR.Location = new System.Drawing.Point(42, 73);
            this.BAGREGAR.Name = "BAGREGAR";
            this.BAGREGAR.Size = new System.Drawing.Size(82, 32);
            this.BAGREGAR.TabIndex = 1;
            this.BAGREGAR.Text = "AGREGAR";
            this.BAGREGAR.UseVisualStyleBackColor = true;
            this.BAGREGAR.Click += new System.EventHandler(this.BAGREGAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CODIGO";
            // 
            // TCODIGO
            // 
            this.TCODIGO.Location = new System.Drawing.Point(599, 153);
            this.TCODIGO.Name = "TCODIGO";
            this.TCODIGO.Size = new System.Drawing.Size(100, 20);
            this.TCODIGO.TabIndex = 3;
            this.TCODIGO.TextChanged += new System.EventHandler(this.TCODIGO_TextChanged);
            this.TCODIGO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCODIGO_KeyPress);
            // 
            // BMODIFICAR
            // 
            this.BMODIFICAR.Location = new System.Drawing.Point(204, 73);
            this.BMODIFICAR.Name = "BMODIFICAR";
            this.BMODIFICAR.Size = new System.Drawing.Size(82, 32);
            this.BMODIFICAR.TabIndex = 4;
            this.BMODIFICAR.Text = "MODIFICAR";
            this.BMODIFICAR.UseVisualStyleBackColor = true;
            this.BMODIFICAR.Click += new System.EventHandler(this.BMODIFICAR_Click);
            // 
            // BELIMINAR
            // 
            this.BELIMINAR.Location = new System.Drawing.Point(380, 73);
            this.BELIMINAR.Name = "BELIMINAR";
            this.BELIMINAR.Size = new System.Drawing.Size(82, 32);
            this.BELIMINAR.TabIndex = 5;
            this.BELIMINAR.Text = "ELIMINAR";
            this.BELIMINAR.UseVisualStyleBackColor = true;
            this.BELIMINAR.Click += new System.EventHandler(this.BELIMINAR_Click);
            // 
            // TNOMBRES
            // 
            this.TNOMBRES.Location = new System.Drawing.Point(599, 190);
            this.TNOMBRES.Name = "TNOMBRES";
            this.TNOMBRES.Size = new System.Drawing.Size(100, 20);
            this.TNOMBRES.TabIndex = 7;
            this.TNOMBRES.TextChanged += new System.EventHandler(this.TNOMBRES_TextChanged);
            this.TNOMBRES.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNOMBRES_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOMBRES";
            // 
            // TAPELLIDOS
            // 
            this.TAPELLIDOS.Location = new System.Drawing.Point(599, 227);
            this.TAPELLIDOS.Name = "TAPELLIDOS";
            this.TAPELLIDOS.Size = new System.Drawing.Size(100, 20);
            this.TAPELLIDOS.TabIndex = 9;
            this.TAPELLIDOS.TextChanged += new System.EventHandler(this.TAPELLIDOS_TextChanged);
            this.TAPELLIDOS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TAPELLIDOS_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "APELLIDOS";
            // 
            // TDIRECCION
            // 
            this.TDIRECCION.Location = new System.Drawing.Point(599, 269);
            this.TDIRECCION.Name = "TDIRECCION";
            this.TDIRECCION.Size = new System.Drawing.Size(100, 20);
            this.TDIRECCION.TabIndex = 11;
            this.TDIRECCION.TextChanged += new System.EventHandler(this.TDIRECCION_TextChanged);
            this.TDIRECCION.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDIRECCION_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "DIRECCION";
            // 
            // TCIUDAD
            // 
            this.TCIUDAD.Location = new System.Drawing.Point(599, 308);
            this.TCIUDAD.Name = "TCIUDAD";
            this.TCIUDAD.Size = new System.Drawing.Size(100, 20);
            this.TCIUDAD.TabIndex = 13;
            this.TCIUDAD.TextChanged += new System.EventHandler(this.TCIUDAD_TextChanged);
            this.TCIUDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCIUDAD_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "CIUDAD";
            // 
            // TTELEFONO
            // 
            this.TTELEFONO.Location = new System.Drawing.Point(599, 350);
            this.TTELEFONO.MaxLength = 13;
            this.TTELEFONO.Name = "TTELEFONO";
            this.TTELEFONO.Size = new System.Drawing.Size(100, 20);
            this.TTELEFONO.TabIndex = 0;
            this.TTELEFONO.TextChanged += new System.EventHandler(this.TTELEFONO_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "TELEFONO";
            // 
            // FPROVEEDORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
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
            this.Controls.Add(this.BELIMINAR);
            this.Controls.Add(this.BMODIFICAR);
            this.Controls.Add(this.TCODIGO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BAGREGAR);
            this.Controls.Add(this.DGVPROVEEDORES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FPROVEEDORES";
            this.Text = resources.GetString("$this.Text");
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FPROVEEDORES_FormClosed);
            this.Load += new System.EventHandler(this.FPROVEEDORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPROVEEDORES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPROVEEDORES;
        private System.Windows.Forms.Button BAGREGAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TCODIGO;
        private System.Windows.Forms.Button BMODIFICAR;
        private System.Windows.Forms.Button BELIMINAR;
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