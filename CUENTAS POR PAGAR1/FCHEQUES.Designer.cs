﻿namespace CUENTAS_POR_PAGAR1
{
    partial class FCHEQUES
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
            this.DGVFCHEQUES = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BAGREGAR = new System.Windows.Forms.Button();
            this.TNUMCHE = new System.Windows.Forms.TextBox();
            this.TNUMFACTURA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BELIMINAR = new System.Windows.Forms.Button();
            this.BMODIFICAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFCHEQUES)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVFCHEQUES
            // 
            this.DGVFCHEQUES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFCHEQUES.Location = new System.Drawing.Point(0, 0);
            this.DGVFCHEQUES.Name = "DGVFCHEQUES";
            this.DGVFCHEQUES.Size = new System.Drawing.Size(520, 450);
            this.DGVFCHEQUES.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NUMERO CHEQUE";
            // 
            // BAGREGAR
            // 
            this.BAGREGAR.Location = new System.Drawing.Point(536, 368);
            this.BAGREGAR.Name = "BAGREGAR";
            this.BAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.BAGREGAR.TabIndex = 2;
            this.BAGREGAR.Text = "AGREGAR";
            this.BAGREGAR.UseVisualStyleBackColor = true;
            this.BAGREGAR.Click += new System.EventHandler(this.BAGREGAR_Click);
            // 
            // TNUMCHE
            // 
            this.TNUMCHE.Location = new System.Drawing.Point(668, 180);
            this.TNUMCHE.Name = "TNUMCHE";
            this.TNUMCHE.Size = new System.Drawing.Size(100, 20);
            this.TNUMCHE.TabIndex = 3;
            this.TNUMCHE.TextChanged += new System.EventHandler(this.TNUMCHE_TextChanged);
            this.TNUMCHE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNUMCHE_KeyPress);
            // 
            // TNUMFACTURA
            // 
            this.TNUMFACTURA.Location = new System.Drawing.Point(668, 233);
            this.TNUMFACTURA.Name = "TNUMFACTURA";
            this.TNUMFACTURA.Size = new System.Drawing.Size(100, 20);
            this.TNUMFACTURA.TabIndex = 5;
            this.TNUMFACTURA.TextChanged += new System.EventHandler(this.TNUMFACTURA_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NUMERO FACTURA";
            // 
            // BELIMINAR
            // 
            this.BELIMINAR.Location = new System.Drawing.Point(714, 368);
            this.BELIMINAR.Name = "BELIMINAR";
            this.BELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.BELIMINAR.TabIndex = 6;
            this.BELIMINAR.Text = "ELIMINAR";
            this.BELIMINAR.UseVisualStyleBackColor = true;
            this.BELIMINAR.Click += new System.EventHandler(this.BELIMINAR_Click);
            // 
            // BMODIFICAR
            // 
            this.BMODIFICAR.Location = new System.Drawing.Point(617, 368);
            this.BMODIFICAR.Name = "BMODIFICAR";
            this.BMODIFICAR.Size = new System.Drawing.Size(91, 23);
            this.BMODIFICAR.TabIndex = 7;
            this.BMODIFICAR.Text = "MODIFICAR";
            this.BMODIFICAR.UseVisualStyleBackColor = true;
            this.BMODIFICAR.Click += new System.EventHandler(this.BMODIFICAR_Click);
            // 
            // FCHEQUES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.BMODIFICAR);
            this.Controls.Add(this.BELIMINAR);
            this.Controls.Add(this.TNUMFACTURA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TNUMCHE);
            this.Controls.Add(this.BAGREGAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVFCHEQUES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCHEQUES";
            this.Text = "FCHEQUES";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FCHEQUES_FormClosed);
            this.Load += new System.EventHandler(this.FCHEQUES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFCHEQUES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVFCHEQUES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BAGREGAR;
        private System.Windows.Forms.TextBox TNUMCHE;
        private System.Windows.Forms.TextBox TNUMFACTURA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BELIMINAR;
        private System.Windows.Forms.Button BMODIFICAR;
    }
}