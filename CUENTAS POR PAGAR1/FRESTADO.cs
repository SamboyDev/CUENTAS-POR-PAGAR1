﻿using CUENTAS_POR_PAGAR1.SCXSAMBOYDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUENTAS_POR_PAGAR1
{
    public partial class FRESTADO : Form
    {
        public FRESTADO()
        {
            InitializeComponent();
        }

        private void FRESTADO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sCXSAMBOYDataSet.ESTADODECUENTAS' Puede moverla o quitarla según sea necesario.
            this.eSTADODECUENTASTableAdapter.Fill(this.sCXSAMBOYDataSet.ESTADODECUENTAS);
            this.reportViewer1.RefreshReport();
        }
    }
}
