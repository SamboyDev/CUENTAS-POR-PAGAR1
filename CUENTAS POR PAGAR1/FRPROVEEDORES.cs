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
    public partial class FRPROVEEDORES : Form
    {
        public FRPROVEEDORES()
        {
            InitializeComponent();
        }

        private void FRPROVEEDORES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sCXSAMBOYDataSet.PROVEEDORESSAMBOY' Puede moverla o quitarla según sea necesario.
            this.pROVEEDORESSAMBOYTableAdapter.Fill(this.sCXSAMBOYDataSet.PROVEEDORESSAMBOY);

            this.reportViewer1.RefreshReport();
        }
    }
}
