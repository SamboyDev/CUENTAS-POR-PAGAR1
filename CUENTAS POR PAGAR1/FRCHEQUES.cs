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
    public partial class FRCHEQUES : Form
    {
        public FRCHEQUES()
        {
            InitializeComponent();
        }

        private void FRCHEQUES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sCXSAMBOYDataSet.CHEQUESSAMBOY' Puede moverla o quitarla según sea necesario.
            this.cHEQUESSAMBOYTableAdapter.Fill(this.sCXSAMBOYDataSet.CHEQUESSAMBOY);

            this.reportViewer1.RefreshReport();
        }
    }
}
